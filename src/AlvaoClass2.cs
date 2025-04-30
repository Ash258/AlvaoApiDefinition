using System.Text;
using HtmlAgilityPack;
using Microsoft.Extensions.Logging;
using static AlvaoScrapper.Helpers2;

namespace AlvaoScrapper;

public class AlvaoClass2
{
    public ILogger Logger;

    public string Type { get; set; }
    public string? FullUrl { get; set; }
    public string LocalHtmlFile { get; set; }
    public string FinalCsFile { get; set; }
    public List<ScopeBoundary> Boundaries { get; set; }

    public AlvaoNamespace2 Namespace { get; set; }
    public string NamespaceName { get; set; }
    public string Name { get; set; }
    public string Summary { get; set; }
    public HtmlDocument HtmlDocument { get; set; }
    public List<string> Usings { get; set; }
    public string Definition { get; set; } = "";
    public List<DotnetConstructor> Constructors { get; set; }
    public DotnetEnum? SpecialEnumClass { get; set; }
    public List<DotnetEnum> Enums { get; set; }
    public List<DotnetProperty> Properties { get; set; }
    public List<DotnetField> Fields { get; set; }
    public List<string> Events { get; set; }
    public List<DotnetMethod> Methods { get; set; }

    public bool IsEnum { get; set; }

    public AlvaoClass2(string name, string href, string memberType, AlvaoNamespace2 ns, DotnetEnum[]? enums)
    {
        Logger = CreateLogger<AlvaoClass2>();

        Name = name;
        Type = memberType;
        IsEnum = String.Equals(Type, "Enum");
        FullUrl = $"{Helpers.BASE_HTML_URL}/{href.Split("/").Last()}";
        Namespace = ns;
        NamespaceName = ns.Name;
        LocalHtmlFile = $"{Helpers.LOCAL_HTML_FOLDER}/{FullUrl.Split("/").Last()}";
        HtmlDocument = Helpers.LoadDocument(FullUrl, LocalHtmlFile);
        FinalCsFile = $"{NamespaceName.Replace(".", "/")}/{Name}.cs";

        Summary = Helpers2.GetSummary(HtmlDocument);
        SpecialEnumClass = null;
        Boundaries = [];
        Usings = [];
        Fields = [];
        Properties = [];
        Enums = [];
        Methods = [];
        Events = [];
        Constructors = [];

        if (enums != null && enums.Length > 0)
        {
            Enums.AddRange(enums);
        }
    }

    #region Helper functions
    private int ExtractHeading1Index(HtmlNodeCollection elements)
    {
        var h1Index = elements.FindIndex(e => e.Name.Equals("h1"));
        if (h1Index == -1)
        {
            Logger.LogError("Page does not specify h1 element [{}] {{{}}}", Name, NamespaceName);
            throw new Exception($"Page does not specify h1 element {Name} {NamespaceName}");
        }

        return h1Index;
    }

    private List<int> ExtractH2Indexes(HtmlNodeCollection elements)
    {
        // Constructors, Properties, Fields, Events, Methods are h2
        Logger.LogInformation("Finding class member groups [{}] {{{}}}", Name, NamespaceName);
        var h2Indexes = elements
            .Select((f, i) => new { f, i })
            .Where(x => x.f.Name == "h2")
            .Select(x => x.i).ToList();

        if (h2Indexes.Count == 0)
        {
            Logger.LogInformation("Class does not expose any members [{}] {{{}}}", Name, NamespaceName);
        }

        Logger.LogDebug("There are {} h2 elements [{}] {{{}}}", h2Indexes.Count, Name, NamespaceName);

        return h2Indexes;
    }

    private static string SanitizeClassName(HtmlNode element)
    {
        return TrimInnerText(element)
                .Replace("Class ", "")
                .Replace("Interface ", "")
                .Replace("Enum ", "")
                .Trim();
    }

    private void AssertCorrectClassPage(string className)
    {
        Logger.LogDebug("Asserting class [{}] {{{}}}", Name, NamespaceName);
        if (className.Equals(Name)) return;

        Logger.LogError("Page specify different class: {} [{}] {{{}}}", className, Name, NamespaceName);
        throw new Exception($"Page specify different class: {className} {Name} {NamespaceName}");
    }

    private void AssertClassBoundaries(HtmlNodeCollection elements)
    {
        foreach (var b in Boundaries.OrderBy(x => x.start))
        {
            Logger.LogDebug("{}", b.DebugFormat(elements[b.end].Name));

            if (!elements[b.start].Name.Equals(b.name.Split(" ")[0]))
            {
                Logger.LogError("Wrong last element of scope {} [{}] {{{}}}", b.name.Split(" ")[0], Name, NamespaceName);
            }
        }
        if (Boundaries[0].end == Boundaries[^1].end) return;

        Logger.LogError("Page boundaries are incorrect [{}] {{{}}}", Name, NamespaceName);
        throw new Exception($"Page boundaries are incorrect: {Name} {NamespaceName}");
    }

    private Dictionary<string, List<HtmlNode>> SplitElementsIntoClassGroups(HtmlNodeCollection elements, int h1IndexStart, int h1IndexEnd, List<int> h2Indexes)
    {
        Logger.LogDebug("Processing class groups [{}] {{{}}}", Name, NamespaceName);
        var groupName = "Class";
        // Class specific items are saved into group "Class"
        Dictionary<string, List<HtmlNode>> classGroups = [];
        var isEmpty = h2Indexes.Count == 0;
        if (isEmpty) h2Indexes = [h1IndexStart];

        for (int i = 0; i < h2Indexes.Count; i++)
        {
            Logger.LogDebug("Processing class group {} [{}] {{{}}}", i, Name, NamespaceName);
            int h2IndexStart = h2Indexes[i];
            int h2IndexEnd = i == h2Indexes.Count - 1
                ? h1IndexEnd // Completely last sibling element
                : h2Indexes[i + 1] - 1; // Element before next h2

            // Collect h1 scoped elements when processing first h2 element (first h1 index to first h2 index - 1)
            if (i == 0)
            {
                var skip = isEmpty
                    ? h1IndexEnd - h1IndexStart
                    : h2IndexStart - h1IndexStart + 1;

                Logger.LogDebug("Processing class related elements [{}] {{{}}}", Name, NamespaceName);
                classGroups.Add(groupName, [.. elements.Skip(h1IndexStart).Take(skip)]);
                if (isEmpty) break;
            }

            groupName = TrimInnerText(elements[h2IndexStart]);

            Logger.LogDebug("Adding class group {} [{}] {{{}}}", groupName, Name, NamespaceName);
            // Add self and all elements before next h2
            classGroups.Add(groupName, [.. elements.Skip(h2IndexStart).Take(h2IndexEnd - h2IndexStart + 1)]);

            // Boundaries contains all elements between self and next element (including self and exclude next same level element)
            Boundaries.Add(new ScopeBoundary(
                "h2 - " + elements[h2IndexStart].InnerText.Trim(),
                h2IndexStart,
                h2IndexEnd
            ));
        }

        Logger.LogInformation("Found {} class members [{}] {{{}}}", classGroups.Count, Name, NamespaceName);

        return classGroups;
    }

    private static (List<int>, int) FindIndexesOfElement(List<HtmlNode> elements, string element)
    {
        var indexes = elements
            .Select((f, i) => new { f, i })
            .Where(x => x.f.Name == element)
            .Select(x => x.i).ToList();
        var lastIndex = elements.Count;

        return (indexes, lastIndex);
    }

    private (string, string, string) ExtractMemberInformation(List<HtmlNode> elements, string memberType)
    {
        var _name = ReplaceEndLinesWithSpace(TrimInnerText(elements[0]));
        var _sum = string.Empty;
        var _def = string.Empty;

        // Summary handling
        try
        {
            if (!new[] { "markdown", "summary" }.All(elements[1].GetClasses().Contains))
            {
                Logger.LogWarning("{} member {} does not have valid markdown summary [{}] {{{}}}", memberType, _name, Name, NamespaceName);
            }
            _sum = ReplaceEndLinesWithSpace(TrimInnerText(elements[1].SelectSingleNode(".//p")));
        }
        catch
        {
            Logger.LogWarning("{} member {} does not specify summary [{}] {{{}}}", memberType, _name, Name, NamespaceName);
        }
        // Definition extraction
        try
        {
            if (!elements[3].GetClasses().Contains("codewrapper"))
            {
                Logger.LogWarning("{} member {} does not have valid definition element [{}] {{{}}}", memberType, _name, Name, NamespaceName);
            }
            _def = SanitizeXmlToString(TrimInnerText(elements[3].SelectSingleNode(".//pre/code")));
        }
        catch
        {
            Logger.LogWarning("{} member {} definition extraction failed [{}] {{{}}}", memberType, _name, Name, NamespaceName);
        }

        return (_name, _sum, _def);
    }
    #endregion Helper functions








    /* ! TODO: Reimplement and reorganize*/
    internal void RestructuralizeClassDocument()
    {
        Logger.LogInformation("Processing the class document [{}] {{{}}}", Name, NamespaceName);
        // Get all elements in main article container
        var elements = HtmlDocument.DocumentNode.SelectNodes("//article/*");
        Logger.LogDebug("There are {} total elements [{}] {{{}}}", elements.Count, Name, NamespaceName);

        // First element should be h1
        var h1IndexStart = ExtractHeading1Index(elements);
        var h1IndexEnd = elements.Count - 1;
        var className = SanitizeClassName(elements[h1IndexStart]);

        AssertCorrectClassPage(className);

        elements[h1IndexEnd].SetAttributeValue("isLastElement", "true");
        Boundaries = [new ScopeBoundary("h1", h1IndexStart, h1IndexEnd)];

        List<int> h2Indexes = ExtractH2Indexes(elements);

        Dictionary<string, List<HtmlNode>> classGroups = SplitElementsIntoClassGroups(elements, h1IndexStart, h1IndexEnd, h2Indexes);

        AssertClassBoundaries(elements);

        foreach (var gr in classGroups)
        {
            Logger.LogDebug("Class member {} with {} elements [{}] {{{}}}", gr.Key, gr.Value.Count, Name, NamespaceName);

            switch (gr.Key)
            {
                case "Properties":
                    ProcessPropertiesOrFields(gr.Value, "Property");
                    break;
                case "Fields":
                    if (IsEnum)
                    {
                        ProcessEnumFields(gr.Value);
                        break;
                    }
                    ProcessPropertiesOrFields(gr.Value, "Field");
                    break;
                case "Constructors":
                    ProcessConstructors(gr.Value);
                    break;
                case "Methods":
                    ProcessMethods(gr.Value);
                    break;
                case "Class":
                    // ? TODO: Do not rely on hardcoded indexes
                    Summary = TrimInnerText(classGroups.GetValueOrDefault("Class", [])[2]);
                    Definition = TrimInnerText(classGroups.GetValueOrDefault("Class", [])[4]);
                    break;
                default:
                    Logger.LogWarning("!!!!!!!!!!!!!!!!!!!Skipping class group {} with {} elements [{}] {{{}}}", gr.Key, gr.Value.Count, Name, NamespaceName);
                    break;
            }
        }
    }

    private void ProcessEnumFields(List<HtmlNode> elements)
    {
        Logger.LogDebug("Processing enum fields[{}] {{{}}}", Name, NamespaceName);
        (List<int> h2Indexes, int lastIndex) = FindIndexesOfElement(elements, "h2");

        // Print warning if there are other fields, to adjust the implementation if such enum exists
        if (h2Indexes.Count > 1)
        {
            Logger.LogWarning("Enum has other members [{}] {{{}}}", Name, NamespaceName);
            return;
        }

        var dl = elements.Skip(1).Take(1).ToList();

        // Currently we can assume, that the there will be next element with dt
        Logger.LogDebug("Processing enum field parameters [{}] {{{}}}", Name, NamespaceName);// This has to be dl
        var enumFields = dl[0].SelectNodes(".//dt/code").Select(x => x.InnerText).ToList();

        Logger.LogDebug("Enum has {} fields [{}] {{{}}}", enumFields.Count, Name, NamespaceName);// This has to be dl
        SpecialEnumClass = new DotnetEnum()
        {
            Name = Name,
            Summary = Summary,
            Definition = Definition,
            Fields = enumFields
        };
    }

    private void ProcessPropertiesOrFields(List<HtmlNode> elements, string type)
    {
        var isField = String.Equals("Field", type);
        var typePlural = isField
            ? "Fields"
            : "Properties";

        Logger.LogDebug("Processing class {} [{}] {{{}}}", typePlural.ToLower(), Name, NamespaceName);
        (List<int> h3Indexes, int lastIndex) = FindIndexesOfElement(elements, "h3");

        for (var i = 0; i < h3Indexes.Count; ++i)
        {
            var end = i == h3Indexes.Count - 1
                ? lastIndex
                : h3Indexes[i + 1];

            Logger.LogDebug("{} spans from {} to {} [{}] {{{}}}", type, h3Indexes[i], end, Name, NamespaceName);
            var propertyElements = elements[h3Indexes[i]..end];

            (var _name, var _sum, var _def) = ExtractMemberInformation(propertyElements, type);

            if (isField)
            {
                Fields.Add(
                    new DotnetField()
                    {
                        Name = _name,
                        Summary = _sum,
                        Definition = _def,
                    }
                );
            }
            else
            {
                Properties.Add(
                    new DotnetProperty()
                    {
                        Name = _name,
                        Summary = _sum,
                        Definition = _def,
                    }
                );
            }
        }
    }

    private void ProcessConstructors(List<HtmlNode> elements)
    {
        Logger.LogInformation("Processing class constructors [{}] {{{}}}", Name, NamespaceName);
        (List<int> h3Indexes, int lastIndex) = FindIndexesOfElement(elements, "h3");

        Logger.LogInformation("Found {} constructors [{}] {{{}}}", h3Indexes.Count, Name, NamespaceName);

        for (var i = 0; i < h3Indexes.Count; ++i)
        {
            var end = i == h3Indexes.Count - 1
                ? lastIndex // Take last element in the whole group
                : h3Indexes[i + 1] - 1; // Take next // ! TODO: Realy - 1???

            Logger.LogDebug("Constructor spans from {} to {} [{}] {{{}}}", h3Indexes[i], end, Name, NamespaceName);
            var currentElements = elements[h3Indexes[i]..end];

            (var _name, var _sum, var _def) = ExtractMemberInformation(currentElements, "Constructor");
            (var h4Indexes, var lastH4element) = FindIndexesOfElement(currentElements, "h4");

            Logger.LogDebug("Found {} constructor nested properties [{}] {{{}}}", h4Indexes.Count, Name, NamespaceName);

            List<string> examples = [];
            List<(string, string)> parameters = [];
            for (var h4i = 0; h4i < h4Indexes.Count; ++h4i)
            {
                var h4end = h4i == h4Indexes.Count - 1
                    ? lastH4element // Take last element of the current elements in h3 group
                    : h4Indexes[h4i + 1];

                var groupName = currentElements[h4Indexes[h4i]].InnerText.Trim();
                Logger.LogDebug("Constructor group {} spans from {} to {} [{}] {{{}}}", groupName, h3Indexes[i], end, Name, NamespaceName);
                var h4CurrentElements = currentElements[h4Indexes[h4i]..h4end];

                switch (groupName)
                {
                    case "Parameters":
                        Logger.LogDebug("Processing constructor parameters [{}] {{{}}}", Name, NamespaceName);// This has to be dl
                        var parameterDefs = h4CurrentElements[1].SelectNodes(".//dt/code").Select(x => x.InnerText).ToList();
                        var parameterSums = h4CurrentElements[1].SelectNodes(".//dd/p").Select(x => x.InnerText).ToList();
                        if (parameterDefs.Count != parameterSums.Count)
                        {
                            Logger.LogError("Mismatch between method parameter names and description [{}] {{{}}}", Name, NamespaceName);
                            break;
                        }
                        for (var paramIndex = 0; paramIndex < parameterDefs.Count; ++paramIndex)
                        {
                            var _parameterName = parameterDefs[paramIndex].Trim();
                            Logger.LogDebug("Adding method parameter {} [{}] {{{}}}", _parameterName, Name, NamespaceName);
                            parameters.Add((_parameterName, Helpers.ReplaceEndLinesWithSpace(parameterSums[paramIndex].Trim())));
                        }
                        break;
                    case "Examples":
                        // ! TODO: Implement
                        // ? TODO: Investigate if there are more examples somewhere
                        // Logger.LogDebug("Processing constructor examples [{}] {{{}}}", Name, NamespaceName);
                        // Console.WriteLine(h4CurrentElements[1].Name);
                        // examples.Add(h4CurrentElements[1].Name);
                        // examples.Add(h4CurrentElements[1].SelectSingleNode(".//code").InnerText.Trim());
                        break;
                    default:
                        break;
                }
            }
            Constructors.Add(
                new DotnetConstructor()
                {
                    Name = _name,
                    Summary = _sum,
                    Definition = _def,
                    Parameters = parameters,
                    Examples = examples,
                }
            );
        }
    }

    private void ProcessMethods(List<HtmlNode> elements)
    {
        Logger.LogDebug("Processing class methods [{}] {{{}}}", Name, NamespaceName);
        (var h3Indexes, var h3LastIndex) = FindIndexesOfElement(elements, "h3");

        Logger.LogDebug("Found {} methods [{}] {{{}}}", h3Indexes.Count, Name, NamespaceName);

        for (var i = 0; i < h3Indexes.Count; ++i)
        {
            var end = i == h3Indexes.Count - 1
                ? h3LastIndex
                : h3Indexes[i + 1];

            Logger.LogDebug("Method spans from {} to {} [{}] {{{}}}", h3Indexes[i], end, Name, NamespaceName);
            var methodElements = elements[h3Indexes[i]..end];

            (var _name, var _sum, var _def) = ExtractMemberInformation(methodElements, "Method");
            (var h4Indexes, var h4LastIndex) = FindIndexesOfElement(methodElements, "h4");

            Logger.LogDebug("Found {} method nested properties [{}] {{{}}}", h4Indexes.Count, Name, NamespaceName);

            List<string> returns = [];
            List<string> exceptions = [];
            List<(string, string)> parameters = [];

            for (var methodPropIndex = 0; methodPropIndex < h4Indexes.Count; ++methodPropIndex)
            {
                var h4end = methodPropIndex == h4Indexes.Count - 1
                    ? h4LastIndex
                    : h4Indexes[methodPropIndex + 1];

                var h4CurrentElements = methodElements[h4Indexes[methodPropIndex]..h4end];

                var methodGroupName = TrimInnerText(h4CurrentElements[0]);
                Logger.LogInformation("Processing group {} of {} method [{}] {{{}}}", methodGroupName, _name, Name, NamespaceName);

                switch (methodGroupName)
                {
                    case "Parameters":
                        Logger.LogDebug("Processing method parameters [{}] {{{}}}", Name, NamespaceName);
                        // This has to be dl
                        var parameterDefs = h4CurrentElements[1].SelectNodes(".//dt/code").Select(x => x.InnerText).ToList();
                        var parameterSums = h4CurrentElements[1].SelectNodes(".//dd/p").Select(x => x.InnerText).ToList();
                        if (parameterDefs.Count != parameterSums.Count)
                        {
                            Logger.LogError("Mismatch between method parameter names and description [{}] {{{}}}", Name, NamespaceName);
                            break;
                        }
                        for (var paramIndex = 0; paramIndex < parameterDefs.Count; ++paramIndex)
                        {
                            var _parameterName = parameterDefs[paramIndex].Trim();
                            Logger.LogDebug("Adding method parameter {} [{}] {{{}}}", _parameterName, Name, NamespaceName);
                            parameters.Add((_parameterName, Helpers.ReplaceEndLinesWithSpace(parameterSums[paramIndex].Trim())));
                        }
                        break;
                    //     case "Examples":
                    //         // ! TODO: Implement
                    //         // ? TODO: Investigate if there are more examples somewhere
                    //         // Logger.LogDebug("Processing constructor examples [{}] {{{}}}", Name, NamespaceName);
                    //         // Console.WriteLine(h4CurrentElements[1].Name);
                    //         // examples.Add(h4CurrentElements[1].Name);
                    //         // examples.Add(h4CurrentElements[1].SelectSingleNode(".//code").InnerText.Trim());
                    //         break;
                    case "Returns":
                        // Simple void, no need to handle returns, definition is enough
                        // ? TODO: Investigate if there are some returns described
                        Logger.LogWarning("Skipping Returns of method {} [{}] {{{}}}", _name, Name, NamespaceName);
                        break;
                    default:
                        Logger.LogWarning("Skipping group {} of method {} [{}] {{{}}}", methodGroupName, _name, Name, NamespaceName);
                        break;
                }
            }
            Methods.Add(
                new DotnetMethod()
                {
                    Name = _name,
                    Summary = _sum,
                    Definition = _def,
                    Parameters = parameters,
                    Returns = "", // ! TODO: Implement
                }
            );
        }
    }

    internal void Process()
    {
        RestructuralizeClassDocument();
        if (IsEnum) return;
        ProduceFinalCsFile();
    }

    private void AssertDocumentIsClass()
    {
        Logger.LogDebug("Verifying HTML document is class");
        var h1 = HtmlDocument.DocumentNode.SelectSingleNode("//article/h1");
        if (h1 == null)
        {
            Logger.LogError("");
            throw new Exception("Page does not have h1");
        }

        var fqdnId = NamespaceName.Replace(".", "_");
        fqdnId = fqdnId + "_" + Name.Replace(".", "_");
        var actual = h1.InnerText.Trim();
        var expected = $"{Type} {Name}";
        if (!h1.GetAttributeValue("id", "none").Equals(fqdnId) || !actual.Equals(expected))
        {
            Logger.LogError("Page contains different class: Expected {}, Actual: {}", expected, actual);
            throw new Exception($"Page contains different class: Expected {expected}, Actual: {actual}");
        }
    }

    private void ProcessDefinition()
    {
        Logger.LogInformation("Processing definitition of class {name} {{{ns}}}", Name, NamespaceName);
        var _def = Helpers2.ExtractObjectDefinition(HtmlDocument);
        if (_def == null) return;

        Definition = _def;
    }

    public void ProduceFinalCsFile()
    {
        Logger.LogInformation("Constructing final dotnet cs file for class [{}] {{{}}}", Name, NamespaceName);
        var sb = new StringBuilder();

        // First process usings
        if (Usings.Count != 0)
        {
            Logger.LogInformation("Adding usings for class [{}] {{{}}}", Name, NamespaceName);
            Usings.Distinct().Order().ToList().ForEach(el => sb.AppendLine($"using {el};"));
            sb.AppendLine("");
        }

        // Set namespace
        sb.AppendLine($"namespace {NamespaceName};");
        sb.AppendLine("");

        // Set class specific docs
        if (!Summary.Equals("")) sb.AppendLine($"/// <summary>{Summary}</summary>");
        if (!FullUrl.IsNullOrEmpty()) sb.AppendLine($"/// <see href=\"{FullUrl}\"/>");
        sb.AppendLine(Definition);
        sb.AppendLine("{");
        bool indentNext = false;
        {
            Enums.ForEach(el => sb.AppendLine(el.Produce()));
            indentNext = Enums.Count > 0;

            if (indentNext && Fields.Count > 0) sb.AppendLine("");
            Fields.ForEach(el => sb.AppendLine(el.Produce()));
            indentNext = Fields.Count > 0;

            if (indentNext && Properties.Count > 0) sb.AppendLine("");
            Properties.ForEach(el => sb.AppendLine(el.Produce()));
            indentNext = Properties.Count > 0;

            // if (indentNext && Events.Count > 0) sb.AppendLine("");
            // Events.ForEach(el => sb.AppendLine($"{Helpers.PrefixEachLineSpaces(el)};"));
            // indentNext = Events.Count > 0;

            if (indentNext && Constructors.Count > 0) sb.AppendLine("");
            Constructors.ForEach(el => sb.AppendLine(el.Produce()));
            indentNext = Constructors.Count > 0;

            if (indentNext && Methods.Count > 0) sb.AppendLine("");
            Methods.ForEach(el => sb.AppendLine(el.Produce()));
        }

        sb.AppendLine("}"); // End class

        Logger.LogDebug("Writing cs file [{}] {{{}}}", Name, NamespaceName);
        File.WriteAllText(FinalCsFile, sb.ToString());
        Logger.LogInformation("Final cs file written {} [{}] {{{}}}", FinalCsFile, Name, NamespaceName);
        State.Classes.Add(Name, this);
    }

    #region DTOs
    // Start should include the element itself (h1, h2)
    // End should not include the next element (except h1)
    // End index of last element should equal the end index of h1
    // This should look like:
    // h1, 0, 99
    // h2, 10, 49
    // h3, 20, 29
    // h3, 30, 39
    // h3, 40, 39
    // h2, 50, 99
    public record ScopeBoundary(
        string name,
        int start,
        int end
    )
    {
        internal string? DebugFormat(string lastElementName)
        {
            return $"ScopeBoundary {{ name = {name}, start = {start}, end = {end}, lastElement = {lastElementName} }}";
        }
    }
    #endregion DTOs
}
