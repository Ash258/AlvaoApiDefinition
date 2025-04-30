using HtmlAgilityPack;
using Microsoft.Extensions.Logging;
using Microsoft.Graph.Models;

namespace AlvaoScrapper;

public class AlvaoNamespace2
{
    public ILogger Logger;

    public string Name { get; set; }
    public string FullUrl { get; set; }
    public string LocalHtmlFile { get; set; }
    public HtmlDocument HtmlDocument { get; set; }
    public AlvaoClass2[]? Classes { get; set; }

    public Dictionary<string, DotnetEnum[]> Enums { get; set; }

    public AlvaoNamespace2(string namespaceName)
    {
        using var loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddFilter("AlvaoScrapper", (LogLevel)int.Parse(Environment.GetEnvironmentVariable("Logging__LogLevel__AlvaoScrapper") ?? "4"));
            builder.AddSimpleConsole(options =>
            {
                options.IncludeScopes = true;
                options.SingleLine = true;
            });
        });
        Logger = loggerFactory.CreateLogger<AlvaoNamespace2>();

        Name = namespaceName;
        FullUrl = $"{Helpers.BASE_HTML_URL}/{namespaceName}.html";
        LocalHtmlFile = $"{Helpers.LOCAL_HTML_FOLDER}/{FullUrl.Split("/").Last()}";
        HtmlDocument = Helpers.LoadDocument(FullUrl, LocalHtmlFile);

        Enums = [];

        Helpers.AssertDirectory(Name.Replace(".", "/"));
    }

    internal void Process()
    {
        Logger.LogInformation("Processing {} namespace", Name);

        AssertDocumentIsNamespace();

        // h3 contains the main groups (classes, interfaces, ...)
        Logger.LogDebug("Searching for h3 element");
        var h3Headers = HtmlDocument.DocumentNode.SelectNodes("//h3");
        if (h3Headers == null)
        {
            Logger.LogError("Cannot find h3 element on page");
            return;
        }

        Logger.LogInformation("Found {} headers {{{}}}", h3Headers.Count, Name);

        // Take first group from the h3 elements, as we take only following siblings of first h3
        var currentMemberType = SanitizeMemberType(h3Headers[0].InnerText.Trim());
        var relevantElements = HtmlDocument.DocumentNode.SelectNodes("//h3/following-sibling::*");
        Logger.LogInformation("Processing namespace group [{}] {{{}}}", currentMemberType, Name);

        List<MemberProperties> membersToProcess = [];
        foreach (var el in relevantElements)
        {
            // Other group occoured
            if (el.Name.Equals("h3"))
            {
                var n = SanitizeMemberType(el.InnerText.Trim());
                Logger.LogInformation("Namespace group changed from {} to [{}] {{{}}}", currentMemberType, n, Name);
                currentMemberType = n;
                continue;
            }

            var aNode = el.SelectSingleNode(".//dt/a");
            MemberProperties member = new()
            {
                Type = currentMemberType,
                Name = aNode.InnerText.Trim(),
                Url = aNode.GetAttributeValue("href", "none"),
            };

            Logger.LogInformation("Found {} '{}' {{{}}}", currentMemberType, member.Name, Name);
            membersToProcess.Add(member);
        }

        // Enums needs to be preprocessed
        foreach (var member in membersToProcess.Where(x => x.Type.Equals("Enum")))
        {
            System.Console.WriteLine("Processing enum: " + member.Name);
            AlvaoClass2 clazz = new(member.Name, member.Url, member.Type, this, null);

            try
            {
                clazz.Process();
            }
            catch (Exception e)
            {
                Logger.LogError("Cannot process enum ({}) [{}] {{{}}}", e.Message, member.Name, Name);
                continue;
            }

            if (!member.Name.Contains('.'))
            {
                Logger.LogCritical("Enum does not containe parent class name [{}] {{{}}}", member.Name, Name);
                continue;
            }

            if (clazz.SpecialEnumClass == null)
            {
                Logger.LogCritical("Enum was not parsed correctly [{}] {{{}}}", member.Name, Name);
                continue;
            }

            var parent = member.Name.Split(".")[0];
            if (Enums.TryGetValue(parent, out DotnetEnum[]? value))
            {
                value.AddLast(clazz.SpecialEnumClass);
            }
            else
            {
                Enums.Add(parent, [clazz.SpecialEnumClass]);
            }
        }

        foreach (var member in membersToProcess.Where(x => !x.Type.Equals("Enum")))
        {
            var validClasss = new string[] {
                // "AadSetting",
                "LogOperation",
                // "HtmlTextModel",
                // "CustomTables",
            };
            if (!validClasss.Contains(member.Name)) continue; // ! TODO: Drop

            var enums = Enums.GetValueOrDefault(member.Name, []);
            AlvaoClass2 clazz = new(member.Name, member.Url, member.Type, this, enums);
            try
            {
                clazz.Process();
            }
            catch (Exception e)
            {
                Logger.LogError("Cannot process class ({}) [{}] {{{}}}", e.Message, member.Name, Name);
                continue;
            }

            MonkeyPatch2.AssertGenerationOK(clazz);
        }
    }

    private void AssertDocumentIsNamespace()
    {

        Logger.LogDebug("Verifying HTML document is namespace");
        var h1 = HtmlDocument.DocumentNode.SelectSingleNode("//article/h1");
        if (h1 == null)
        {
            Logger.LogError("Page does not have h1");
            throw new Exception("Page does not have h1");
        }

        if (!h1.GetAttributeValue("id", "none").Equals(Name.Replace(".", "_")) || !h1.InnerText.Trim().Equals($"Namespace {Name}"))
        {
            Logger.LogError("Page contains different namespace");
            throw new Exception("Page contains different namespace");
        }
    }

    internal static string SanitizeMemberType(string type)
    {
        return type switch
        {
            "Classes" => "Class",
            "Interfaces" => "Interface",
            "Enums" => "Enum",
            _ => "Class",
        };
    }

    #region DTOs
    internal record MemberProperties()
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
    #endregion DTOs
}
