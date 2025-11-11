using HtmlAgilityPack;
using Microsoft.Extensions.Logging;
using static AlvaoScrapper.Helpers;

namespace AlvaoScrapper;

public class AlvaoNamespace {
    public ILogger Logger;

    public string Name { get; set; }
    public string FullUrl { get; set; }
    public string LocalHtmlFile { get; set; }
    public HtmlDocument HtmlDocument { get; set; }
    public AlvaoClass[]? Classes { get; set; }

    public Dictionary<string, DotnetEnum[]> Enums { get; set; }

    public AlvaoNamespace(string namespaceName) {
        Logger = CreateLogger<AlvaoNamespace>();

        Name = namespaceName;
        FullUrl = $"{BASE_HTML_URL}/{Name}.html";
        LocalHtmlFile = $"{LOCAL_HTML_FOLDER}/{FullUrl.Split("/").Last()}";
        HtmlDocument = LoadDocument(FullUrl, LocalHtmlFile);
        Enums = [];

        AssertDirectory(Name.Replace(".", "/"));
    }

    internal void Process() {
        Logger.LogInformation("Processing {} namespace", Name);

        if (Name.Equals("Alvao.Apps.API")) return;

        AssertDocumentIsNamespace();

        // h3 contains the main groups (classes, interfaces, ...)
        Logger.LogDebug("Searching for group (h3) element {{{}}}", Name);
        var h3Headers = HtmlDocument.DocumentNode.SelectNodes("//h3");
        if (h3Headers == null) {
            Logger.LogError("Cannot find any groups on page {{{}}}", Name);
            return;
        }

        Logger.LogInformation("Found {} headers {{{}}}", h3Headers.Count, Name);

        // Take first group from the h3 elements, as we take only following siblings of first h3
        var currentMemberType = SanitizeMemberType(TrimInnerText(h3Headers[0]));
        var relevantElements = HtmlDocument.DocumentNode.SelectNodes("//h3/following-sibling::*");
        List<MemberProperties> membersToProcess = [];

        Logger.LogInformation("Processing namespace group [{}] {{{}}}", currentMemberType, Name);

        foreach (var el in relevantElements) {
            // Other group occoured
            if (el.Name.Equals("h3")) {
                var n = SanitizeMemberType(TrimInnerText(el));
                Logger.LogInformation("Namespace group changed from {} to [{}] {{{}}}", currentMemberType, n, Name);
                currentMemberType = n;
                continue;
            }

            var aNode = el.SelectSingleNode(".//dt/a");
            var member = new MemberProperties() {
                Type = currentMemberType,
                Name = aNode.InnerText.Trim(),
                Url = aNode.GetAttributeValue("href", "none"),
            };

            Logger.LogInformation("Found {} '{}' {{{}}}", currentMemberType, member.Name, Name);
            membersToProcess.Add(member);
        }

        // Enums needs to be preprocessed
        Logger.LogDebug("Going to process enums {{{}}}", Name);
        foreach (var member in membersToProcess.Where(x => x.Type.Equals("Enum"))) {
            Logger.LogInformation("Processing enum {} {{{}}}", member.Name, Name);

            var clazz = new AlvaoClass(member.Name, member.Url, member.Type, this, null);

            try {
                clazz.Process();
            } catch (Exception e) {
                Logger.LogError("Cannot process enum ({}) [{}] {{{}}}", e.Message, member.Name, Name);
                continue;
            }

            var parent = member.Name.Contains('.')
                ? member.Name.Split(".")[0]
                : string.Empty;

            if (clazz.SpecialEnumClass == null) {
                Logger.LogCritical("Enum was not parsed correctly [{}] {{{}}}", member.Name, Name);
                continue;
            }

            if (string.IsNullOrEmpty(parent)) {
                Logger.LogDebug("Producing standalone cs enum file [{}] {{{}}}", member.Name, Name);
                clazz.ProduceFinalCsFile(true);
                continue;
            }

            var value = Enums.GetValueOrDefault(parent, []);
            if (value.Length != 0) {
                Logger.LogDebug("Adding enum '{}' to existing parent class {} [{}] {{{}}}", clazz.SpecialEnumClass.Name, parent, member.Name, Name);
                Enums[parent] = [.. value.Concat([clazz.SpecialEnumClass])];
            } else {
                Logger.LogDebug("Creating new parent class '{}' for enum '{}' [{}] {{{}}}", parent, clazz.SpecialEnumClass.Name, member.Name, Name);
                Enums.Add(parent, [clazz.SpecialEnumClass]);
            }
        }

        foreach (var member in membersToProcess.Where(x => !x.Type.Equals("Enum"))) {
            var enums = Enums.GetValueOrDefault(member.Name, []);
            var clazz = new AlvaoClass(member.Name, member.Url, member.Type, this, enums);

            try {
                clazz.Process();
            } catch (Exception e) {
                Logger.LogError("Cannot process class ({}) [{}] {{{}}}", e.Message, member.Name, Name);
                continue;
            }
        }
    }

    private void AssertDocumentIsNamespace() {
        Logger.LogDebug("Verifying HTML document is namespace {{{}}}", Name);
        var h1 = HtmlDocument.DocumentNode.SelectSingleNode("//article/h1");
        if (h1 == null) {
            Logger.LogError("Page does not have h1 {{{}}}", Name);
            throw new Exception($"Page does not have h1 {Name}");
        }

        if (!h1.GetAttributeValue("id", "none").Equals(Name.Replace(".", "_")) || !h1.InnerText.Trim().Equals($"Namespace {Name}")) {
            Logger.LogError("Page contains different namespace {{{}}}", Name);
            throw new Exception($"Page contains different namespace {Name}");
        }
    }

    internal static string SanitizeMemberType(string type) {
        return type switch {
            "Classes" => "Class",
            "Interfaces" => "Interface",
            "Enums" => "Enum",
            "Structs" => "Struct",
            _ => "Class",
        };
    }

    #region DTOs
    internal record MemberProperties() {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
    #endregion DTOs
}
