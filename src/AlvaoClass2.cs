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
    public List<string> Enums { get; set; }
    public List<DotnetProperty> Properties { get; set; }
    public List<DotnetField> Fields { get; set; }
    public List<string> Events { get; set; }
    public List<DotnetMethod> Methods { get; set; }

    public AlvaoClass2(string name, string href, string memberType, AlvaoNamespace2 ns)
    {
        using var loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddFilter("AlvaoScrapper", (LogLevel)int.Parse(Environment.GetEnvironmentVariable("Logging__LogLevel__AlvaoScrapper") ?? "2"));
            builder.AddSimpleConsole(options =>
            {
                options.IncludeScopes = true;
                options.SingleLine = true;
            });
        });
        Logger = loggerFactory.CreateLogger<AlvaoClass2>();

        Name = name;
        Type = memberType;
        FullUrl = $"{Helpers.BASE_HTML_URL}/{href.Split("/").Last()}";
        Namespace = ns;
        NamespaceName = ns.Name;
        LocalHtmlFile = $"{Helpers.LOCAL_HTML_FOLDER}/{FullUrl.Split("/").Last()}";
        HtmlDocument = Helpers.LoadDocument(FullUrl, LocalHtmlFile);
        FinalCsFile = $"{NamespaceName.Replace(".", "/")}/{Name}.cs";

        Summary = Helpers2.GetSummary(HtmlDocument);
        Boundaries = [];
        Usings = [];
        Fields = [];
        Properties = [];
        Enums = [];
        Methods = [];
        Events = [];
        Constructors = [];
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
            // ? TODO: is this error? Change to warning and return
            Logger.LogError("Class does not expose any members [{}] {{{}}}", Name, NamespaceName);
            throw new Exception($"Class does not expose any members {Name} {NamespaceName}");
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

    private void AssertClassBoundaries(HtmlNodeCollection elements, List<ScopeBoundary> boundaries)
    {
        foreach (var b in boundaries.OrderBy(x => x.start))
        {
            Logger.LogDebug("{}", b.DebugFormat(elements[b.end].Name));

            if (!elements[b.start].Name.Equals(b.name.Split(" ")[0]))
            {
                Logger.LogError("Wrong last element of scope {} [{}] {{{}}}", b.name.Split(" ")[0], Name, NamespaceName);
            }
        }
        if (boundaries[0].end == boundaries[^1].end) return;

        Logger.LogError("Page boundaries are incorrect [{}] {{{}}}", Name, NamespaceName);
        throw new Exception($"Page boundaries are incorrect: {Name} {NamespaceName}");
    }

    private Dictionary<string, List<HtmlNode>> SplitElementsIntoClassGroups(HtmlNodeCollection elements, int h1IndexStart, int h1IndexEnd, List<int> h2Indexes)
    {
        Logger.LogDebug("Processing class groups [{}] {{{}}}", Name, NamespaceName);
        var groupName = "Class";
        // Class specific items are saved into group "Class"
        Dictionary<string, List<HtmlNode>> classGroups = [];

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
                Logger.LogDebug("Processing class related elements [{}] {{{}}}", Name, NamespaceName);
                classGroups.Add(groupName, [.. elements.Skip(h1IndexStart).Take(h2IndexStart - h1IndexStart + 1)]);
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
        List<ScopeBoundary> boundaries = [new ScopeBoundary("h1", h1IndexStart, h1IndexEnd)];

        List<int> h2Indexes = ExtractH2Indexes(elements);

        // First pass is h1 (class specific items), until first h2
        Dictionary<string, List<HtmlNode>> classGroups = SplitElementsIntoClassGroups(elements, h1IndexStart, h1IndexEnd, h2Indexes);

        AssertClassBoundaries(elements, boundaries);

        foreach (var gr in classGroups)
        {
            Logger.LogDebug("Class member {} with {} elements [{}] {{{}}}", gr.Key, gr.Value.Count, Name, NamespaceName);

            switch (gr.Key)
            {
                // case "Properties":
                //     Properties = _ProcessProperties(gr.Value);
                //     break;
                // case "Fields":
                //     Fields = _ProcessFields(gr.Value);
                //     break;
                case "Constructors":
                    ProcessConstructors(gr.Value);
                    break;
                // case "Methods":
                //     Methods = _ProcessMethods(gr.Value);
                //     break;
                default:
                    Logger.LogWarning("!!!!!!!!!!!!!!!!!!!Skipping class group {} with {} elements [{}] {{{}}}", gr.Key, gr.Value.Count, Name, NamespaceName);
                    break;
            }
        }

        // ! TODO: Do not rely on hardcoded indexes
        Summary = TrimInnerText(classGroups.GetValueOrDefault("Class", [])[2]);
        Definition = TrimInnerText(classGroups.GetValueOrDefault("Class", [])[4]);

        ProduceFinalCsFile();

        Environment.Exit(100);
        return;



        // !!!!!! TODO: DROP
        // // var memberGroupIndex = elements.FindIndex(e => e.Name.Equals("h2"));
        // if (memberGroupIndex == -1)
        // {
        //     Logger.LogWarning("Class {} does not have any members {{{}}}", Name, NamespaceName);
        //     return;
        // }

        // var classRelatedElements = elements.Take(memberGroupIndex);
        // var previousGroupEndIndex = memberGroupIndex;
        // var groups = new Dictionary<string, List<HtmlNode>>();
        // var groupName = elements[memberGroupIndex].InnerText.Trim();
        // var groupElements = elements.Skip(classRelatedElements.Count()).ToList();
        // groups.Add(groupName, groupElements);
        // // Logger.LogWarning("{}", groupName);
        // // foreach (var e in groupElements)
        // // {
        // // }
        // // Break rest of the elements into groups by h2 elements (Constructors, Properties, Fields, Events, Methods)
        // while (memberGroupIndex != -1)
        // {
        //     // First is always the group itself
        //     previousGroupEndIndex = memberGroupIndex;
        //     memberGroupIndex = elements.Skip(1).ToList().FindIndex(e => e.Name.Equals("h2"));
        //     Console.WriteLine(memberGroupIndex);
        //     continue;
        //     if (memberGroupIndex == -1)
        //     {
        //         // There are no other groups
        //         Logger.LogError("No other groups. -1 index");
        //     }

        //     groups.Add(elements[memberGroupIndex].InnerText.Trim(), elements.Skip(previousGroupEndIndex).Take(memberGroupIndex).ToList());
        // }
        // // Logger.LogError("{} [{}] {{{}}}", memberGroupIndex.ToString(), Name, NamespaceName);
        // // Logger.LogError("{} {}", h1Index, memberGroupIndex);
        // // Environment.Exit(20);

        // foreach (var gr in groups.Keys)
        // {
        //     Console.WriteLine(gr);
        //     foreach (var el in groups.GetValueOrDefault(gr, []))
        //     {
        //         Console.WriteLine("    " + el.Name);
        //     }
        // }

        // foreach (var el in classRelatedElements)
        // {
        //     Console.WriteLine(el.Name);
        // }
    }

    // TODO: merge propeties and fields
    // ! TODO: Void
    private List<DotnetProperty> _ProcessProperties(List<HtmlNode> elements)
    {
        List<DotnetProperty> properties = [];
        Logger.LogDebug("Processing class properties [{}] {{{}}}", Name, NamespaceName);
        var h3Indexes = elements
                .Select((f, i) => new { f, i })
                .Where(x => x.f.Name == "h3")
                .Select(x => x.i).ToList();
        var lastIndex = elements.Count - 1;

        for (var i = 0; i < h3Indexes.Count; ++i)
        {
            var end = i == h3Indexes.Count - 1
                ? lastIndex
                : h3Indexes[i + 1];
            var currentElements = elements[h3Indexes[i]..end];
            var divs = currentElements.Where(x => x.Name.Equals("div")).ToList();
            if (divs.Count == 3)
            {
                var _name = currentElements[0].InnerText.Trim();
                var sum = string.Empty;
                try
                {
                    sum = divs[0].SelectSingleNode(".//p").InnerText.Trim();
                }
                catch
                {
                    Logger.LogDebug("Property {} does not specify summary [{}] {{{}}}", _name, Name, NamespaceName);
                }
                properties.Add(
                    new DotnetProperty()
                    {
                        Name = _name,
                        Summary = sum,
                        Definition = Helpers2.SanitizeXmlToString(divs[^1].SelectSingleNode(".//pre/code").InnerText.Trim()),
                    }
                );
            }
            else
            {
                Logger.LogError("Property does not have all divs");
            }
        }

        return properties;
    }

    // ! TODO: Void
    private List<DotnetField> _ProcessFields(List<HtmlNode> elements)
    {
        List<DotnetField> fields = [];
        Logger.LogDebug("Processing class fields [{}] {{{}}}", Name, NamespaceName);
        var h3Indexes = elements
                .Select((f, i) => new { f, i })
                .Where(x => x.f.Name == "h3")
                .Select(x => x.i).ToList();
        var lastIndex = elements.Count - 1;

        Logger.LogDebug("Found {} Fields [{}] {{{}}}", h3Indexes.Count, Name, NamespaceName);

        for (var i = 0; i < h3Indexes.Count; ++i)
        {
            var end = i == h3Indexes.Count - 1
                ? lastIndex
                : h3Indexes[i + 1];
            var currentElements = elements[h3Indexes[i]..end];
            var divs = currentElements.Where(x => x.Name.Equals("div")).ToList();
            if (divs.Count == 3)
            {
                var _name = currentElements[0].InnerText.Trim();
                var sum = string.Empty;
                try
                {
                    sum = divs[0].SelectSingleNode(".//p").InnerText.Trim();
                }
                catch
                {
                    Logger.LogDebug("Field {} does not specify summary [{}] {{{}}}", _name, Name, NamespaceName);
                }
                fields.Add(
                    new DotnetField()
                    {
                        Name = _name,
                        Summary = sum,
                        Definition = Helpers2.SanitizeXmlToString(divs[^1].SelectSingleNode(".//pre/code").InnerText.Trim()),
                    }
                );
            }
            else
            {
                Logger.LogError("Property does not have all divs");
            }
        }

        return fields;
    }

    // ! TODO: Void
    private void ProcessConstructors(List<HtmlNode> elements)
    {
        Logger.LogInformation("Processing class constructors [{}] {{{}}}", Name, NamespaceName);
        var h3Indexes = elements
                .Select((f, i) => new { f, i })
                .Where(x => x.f.Name == "h3")
                .Select(x => x.i).ToList();
        var lastIndex = elements.Count;

        Logger.LogInformation("Found {} constructors [{}] {{{}}}", h3Indexes.Count, Name, NamespaceName);

        var _name = string.Empty;
        var _sum = string.Empty;
        var _def = string.Empty;
        for (var i = 0; i < h3Indexes.Count; ++i)
        {
            var end = i == h3Indexes.Count - 1
                ? lastIndex // Take last element in the whole group
                : h3Indexes[i + 1] - 1; // Take next // ! TODO: Realy - 1???

            Logger.LogDebug("Constructor spans from {} to {} [{}] {{{}}}", h3Indexes[i], end, Name, NamespaceName);
            var currentElements = elements[h3Indexes[i]..end];

            // First element is h3, that include name
            // Take it hardcoded for now
            _name = currentElements[0].InnerText.Trim();
            try
            {
                _sum = currentElements[1].SelectSingleNode(".//p").InnerText.Trim();
            }
            catch
            {
                Logger.LogWarning("Constructor {} does not specify summary [{}] {{{}}}", _name, Name, NamespaceName);
            }
            try
            {
                _def = Helpers2.SanitizeXmlToString(currentElements[3].SelectSingleNode(".//pre/code").InnerText.Trim());

            }
            catch
            {
                Logger.LogWarning("Cannot process definition of constructor {} [{}] {{{}}}", _name, Name, NamespaceName);
            }

            var h4Indexes = currentElements
                .Select((f, i) => new { f, i })
                .Where(x => x.f.Name == "h4")
                .Select(x => x.i).ToList();

            Logger.LogDebug("Found {} constructor nested properties [{}] {{{}}}", h4Indexes.Count, Name, NamespaceName);

            List<string> examples = [];
            List<(string, string)> parameters = [];
            for (var h4i = 0; h4i < h4Indexes.Count; ++h4i)
            {
                var h4end = h4i == h4Indexes.Count - 1
                    ? currentElements.Count // Take last element of the current elements in h3 group
                    : h4Indexes[h4i + 1];

                var groupName = currentElements[h4Indexes[h4i]].InnerText.Trim();
                Logger.LogDebug("Constructor group {} spans from {} to {} [{}] {{{}}}", groupName, h3Indexes[i], end, Name, NamespaceName);
                var h4CurrentElements = currentElements[h4Indexes[h4i]..h4end];

                switch (groupName)
                {
                    case "Parameters":
                        Logger.LogDebug("Processing constructor parameters [{}] {{{}}}", Name, NamespaceName);
                        // This has to be dl
                        var constrParams = h4CurrentElements[1].SelectNodes(".//dt/code").Select(x => x.InnerText).ToList();
                        var constrParamsDesc = h4CurrentElements[1].SelectNodes(".//dd/p").Select(x => x.InnerText).ToList();
                        if (constrParams.Count != constrParamsDesc.Count)
                        {
                            Logger.LogError("Mismatch between constructor parameter names and description [{}] {{{}}}", Name, NamespaceName);
                            break;
                        }
                        for (var _cpi = 0; _cpi < constrParams.Count; ++_cpi)
                        {
                            var _parameterName = constrParams[_cpi].Trim();
                            Logger.LogDebug("Adding constructor parameter {} [{}] {{{}}}", _parameterName, Name, NamespaceName);
                            parameters.Add((_parameterName, constrParamsDesc[_cpi].Trim()));
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

    // ! TODO: Void
    private List<DotnetMethod> _ProcessMethods(List<HtmlNode> elements)
    {
        List<DotnetMethod> methods = [];

        for (int i = 0; i < elements.Count; i++)
        {
            HtmlNode? el = elements[i];
            Console.WriteLine("[" + i + "] " + el.Name + "(" + el.InnerText.Trim().PadRight(200).Substring(0, 20).Trim() + ")");
        }

        Logger.LogDebug("Processing class methods [{}] {{{}}}", Name, NamespaceName);
        var h3Indexes = elements
                .Select((f, i) => new { f, i })
                .Where(x => x.f.Name == "h3")
                .Select(x => x.i).ToList();

        //  3   6   8
        //  3,6
        //  6,8
        //  8, elements.count


        var lastIndex = elements.Count;
        // var lastIndex = elements.Count - 1;

        Logger.LogDebug("Found {} methods [{}] {{{}}}", h3Indexes.Count, Name, NamespaceName);

        // 2 -> 8
        // 9 -> 14
        // Environment.Exit(20);
        // return methods;
        var _name = string.Empty;
        var sum = string.Empty;
        for (var i = 0; i < h3Indexes.Count; ++i)
        {
            var end = i == h3Indexes.Count - 1
                ? lastIndex
                : h3Indexes[i + 1];
            Console.WriteLine(">>>>" + i + ",,,," + h3Indexes[i] + " -> " + end + "   ");
            var currentElements = elements[h3Indexes[i]..end];
            var divs = currentElements.Where(x => x.Name.Equals("div")).ToList();
            if (divs.Count == 3)
            {
                _name = currentElements[0].InnerText.Trim();
                // Logger.LogDebug("Processing method {} [{}] {{{}}}", _name, Name, NamespaceName);
                try
                {
                    sum = divs[0].SelectSingleNode(".//p").InnerText.Trim();
                }
                catch
                {
                    Logger.LogDebug("Method {} does not specify summary [{}] {{{}}}", _name, Name, NamespaceName);
                }
            }
            else
            {
                Logger.LogError("Method does not have all divs");
            }

            // parameter, return, exception
            var h4Indexes = currentElements
                    .Select((f, i) => new { f, i })
                    .Where(x => x.f.Name == "h4")
                    .Select(x => x.i).ToList();

            Logger.LogDebug("Found {} method nested properties [{}] {{{}}}", h4Indexes.Count, Name, NamespaceName);

            List<string> returns = [];
            List<(string, string)> parameters = [];

            for (var j = 0; j < h4Indexes.Count; ++j)
            {

                Console.WriteLine(j);
                Console.WriteLine(j + 1);
                Console.WriteLine(h4Indexes.Count - 1);
                Console.WriteLine(j == h4Indexes.Count - 1);
                Console.WriteLine(end);
                Console.WriteLine("C: " + currentElements.Count);
                Console.WriteLine(h4Indexes[j + 1]);
                var h4end = j == h4Indexes.Count - 1
                    ? end
                    : h4Indexes[j + 1];
                Console.WriteLine(end + ":::: " + currentElements.Count);
                // Console.WriteLine(h4Indexes[j] + ":::: " + h4end);
                var h4CurrentElements = currentElements[h4Indexes[j]..h4end];

                Logger.LogDebug("h4 elements count {} [{}] {{{}}}", h4CurrentElements.Count, Name, NamespaceName);

                Console.WriteLine("ANO");
                Console.WriteLine(h4Indexes[j]);
                Console.WriteLine();
                continue;
                switch (h4CurrentElements[0].InnerText.Trim())
                {
                    case "Parameters":
                        Logger.LogDebug("Processing constructor parameters [{}] {{{}}}", Name, NamespaceName);
                        // THis has to be dl
                        var constrParams = h4CurrentElements[1].SelectNodes(".//dt/code").Select(x => x.InnerText).ToList();
                        var constrParamsDesc = h4CurrentElements[1].SelectNodes(".//dd/p").Select(x => x.InnerText).ToList();
                        if (constrParams.Count != constrParamsDesc.Count)
                        {
                            Logger.LogError("Mismatch between constructor paramter names and description [{}] {{{}}}", Name, NamespaceName);
                            break;
                        }
                        for (var _ci = 0; _ci < constrParams.Count; ++_ci)
                        {
                            Logger.LogDebug("Adding constructor parameter {} [{}] {{{}}}", constrParams[_ci], Name, NamespaceName);
                            parameters.Add((constrParams[_ci], constrParamsDesc[_ci]));
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
            Environment.Exit(40);
            methods.Add(
                new DotnetMethod()
                {
                    Name = _name,
                    Summary = sum,
                    Definition = Helpers2.SanitizeXmlToString(divs[^1].SelectSingleNode(".//pre/code").InnerText.Trim()),
                    Parameters = parameters,
                    Returns = "", // ! TODO: Implement
                }
            );
        }

        return methods;
    }

    internal void Process()
    {
        RestructuralizeClassDocument();
        return;
        Logger.LogInformation("Processing {} class {{{}}}", Name, NamespaceName);
        AssertDocumentIsClass();

        ProcessDefinition();
        ProcessProperties();
        ProcessConstructors();
        ProcessMethods();

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

    private void ProcessProperties()
    {
        Logger.LogInformation("Processing properties of class {name} {{{ns}}}", Name, NamespaceName);
        var elements = HtmlDocument.DocumentNode.SelectNodes("//h2[@id='properties' and @class='section']/following-sibling::*");
        if (elements == null)
        {
            Logger.LogInformation("Class does not define properties [{}] {{{}}}", Name, NamespaceName);
            return;
        }

        var breakLoop = false;
        var member = new DotnetProperty
        {
            Name = string.Empty,
        };

        // ? TODO: Try to filter only h3, divs between two h2
        foreach (var element in elements)
        {
            switch (element.Name)
            {
                // ! TODO: Handle summary
                case "h3":
                    // Actual property name
                    Logger.LogInformation("Changing current property from '{}' to '{}' {{{}}}", member.Name, element.InnerText.Trim(), NamespaceName);

                    member.Reset();
                    member.Name = element.InnerText.Trim();
                    break;
                case "div":
                    // Actual property summary / definition
                    var divClass = element.GetAttributeValue("class", "none");
                    // Summary handling
                    if (divClass.Equals("markdown level1 summary"))
                    {
                        try
                        {
                            member.Summary = element.SelectSingleNode(".//p").InnerText.Trim();
                        }
                        catch
                        {
                            // There is no paragraph under div
                        }
                        break;
                    }

                    // Definition handling
                    if (!divClass.Equals("codewrapper")) break;

                    member.Definition = element.SelectSingleNode(".//pre/code").InnerText.Trim();
                    if (member.Name.IsNullOrEmpty()) break;

                    // ??? TODO: Why Properties.Add(property) does not work?
                    Properties.Add(new DotnetProperty()
                    {
                        Name = member.Name,
                        Summary = member.Summary,
                        Definition = Helpers2.SanitizeXmlToString(member.Definition),
                    });
                    member.Reset();
                    break;
                case "h2":
                    // This means there is change in the member type (properties, fields)
                    breakLoop = true;
                    break;
                case "a":
                    // In some cases there is link element. Skip it
                    break;
            }
            if (breakLoop) break;
        }
    }

    private void ProcessConstructors()
    {
        Logger.LogInformation("Processing constructors of class {name} {{{ns}}}", Name, NamespaceName);
        var elements = HtmlDocument.DocumentNode.SelectNodes("//h2[@id='constructors' and @class='section']/following-sibling::*");
        if (elements == null)
        {
            Logger.LogInformation("Class does not define constructors [{}] {{{}}}", Name, NamespaceName);
            return;
        }

        /*
        <h3> - Constructor name
        <div> - Summary
        <div> - Definition
        <h4> - Parameters
        <dl> - Parameter X
        <dl> - Parameter X
        */
        var breakLoop = false;
        var member = new DotnetConstructor()
        {
            Name = string.Empty,
        };

        // ! TODOOO: Rework to something more contextual
        // ! TODO: handle examples
        foreach (var element in elements)
        {
            switch (element.Name)
            {
                case "h3":
                    // Actual Constructor name
                    Logger.LogInformation("Changing current constructor from '{}' to '{}' {{{}}}", member.Name, element.InnerText.Trim(), NamespaceName);

                    member.Reset();
                    member.Name = element.InnerText.Trim();
                    break;
                case "div":
                    // Actual constructor summary / definition
                    var divClass = element.GetAttributeValue("class", "none");
                    // Summary handling
                    if (divClass.Equals("markdown level1 summary"))
                    {
                        Logger.LogInformation("Processing constructor summary {{{}}}", NamespaceName);
                        try
                        {
                            member.Summary = element.SelectSingleNode(".//p").InnerText.Trim();
                        }
                        catch
                        {
                            // There is no paragraph under div
                        }
                        break;
                    }

                    // Definition handling
                    if (!divClass.Equals("codewrapper")) break;
                    Logger.LogInformation("Processing constructor definition {{{}}}", NamespaceName);

                    member.Definition = element.SelectSingleNode(".//pre/code").InnerText.Trim();
                    if (member.Name.IsNullOrEmpty()) break;
                    break;
                case "dl":
                    // Actual constructor parameter
                    // ! TODO: This needs to support multiple element
                    Logger.LogInformation("Processing constructor parameter {{{}}}", NamespaceName);
                    var name = element.SelectSingleNode(".//dt/code").InnerText.Trim();
                    var sum = element.SelectSingleNode(".//dd/p").InnerText.Trim();
                    member.Parameters.Add(
                        (name, sum)
                    );

                    // There is no other parameter defined, saved the constructor
                    if (!element.NextSibling.Name.Equals("dl"))
                    {

                        // ? TODO: Investigate better approach to elimate hardcoding of such types
                        if (member.Definition.Contains(" StreamingContext ")) Usings.Add("System.Runtime.Serialization");
                        if (member.Definition.Contains(" SerializationInfo ")) Usings.Add("System.Runtime.Serialization");

                        Constructors.Add(new DotnetConstructor()
                        {
                            Name = member.Name,
                            Summary = member.Summary,
                            Definition = Helpers2.SanitizeXmlToString(member.Definition),
                            Parameters = member.Parameters,
                        });
                        member.Reset();
                    }
                    break;
                case "h4":
                    // Skip header with parameters
                    break;
                case "h2":
                    // Skip other group of members
                    breakLoop = true;
                    break;
                case "a":
                    break;
            }

            if (breakLoop) break;
        }
    }

    private void ProcessMethods()
    {
        Logger.LogInformation("Processing methods of class {name} {{{ns}}}", Name, NamespaceName);
        var elements = HtmlDocument.DocumentNode.SelectNodes("//h2[@id='methods' and @class='section']/following-sibling::*");
        if (elements == null)
        {
            Logger.LogInformation("Class does not define methods [{}] {{{}}}", Name, NamespaceName);
            return;
        }

        var breakLoop = false;
        var member = new DotnetMethod
        {
            Name = string.Empty,
        };

        /*
        <h3> - Method name
        <div> - Summary
        <div> - Definition
        <h4> - Parameters
        <dl> - Actual paramters
        <h4> - Returns
        <dl> - Return value
        */
        // ! TODOOO: Rework to something more contextual
        foreach (var element in elements)
        {
            switch (element.Name)
            {
                case "h3":
                    // Actual method name
                    Logger.LogInformation("Changing current method from '{}' to '{}' {{{}}}", member.Name, element.InnerText.Trim(), NamespaceName);

                    member.Reset();
                    member.Name = element.InnerText.Trim();
                    break;
                case "div":
                    // Actual method summary / definition
                    var divClass = element.GetAttributeValue("class", "none");
                    // // Summary handling
                    if (divClass.Equals("markdown level1 summary"))
                    {
                        Logger.LogInformation("Processing method summary {{{}}}", NamespaceName);
                        try
                        {
                            member.Summary = element.SelectSingleNode(".//p").InnerText.Trim();
                        }
                        catch
                        {
                            // There is no paragraph under div
                        }
                        break;
                    }

                    // Definition handling
                    if (!divClass.Equals("codewrapper")) break;
                    Logger.LogInformation("Processing method definition {{{}}}", NamespaceName);

                    member.Definition = element.SelectSingleNode(".//pre/code").InnerText.Trim();
                    if (member.Name.IsNullOrEmpty()) break;
                    break;
                case "dl":
                    // Actual method parameter/return
                    // Class of dl is "parameters"
                    if (!element.GetAttributeValue("class", "none").Trim().Equals("parameters"))
                    {
                        Logger.LogInformation("Class of element is not 'parameters'");
                        break;
                    }

                    // Previous element has to be h4 with either "Parameters" or "Returns"
                    Logger.LogError(element.SelectNodes(".//dt/code").Count.ToString());
                    if (!element.PreviousSibling.Name.Equals("h4"))
                    {
                        Logger.LogInformation("Previous element is not h4");
                        break;
                    }
                    Logger.LogWarning(element.PreviousSibling.InnerText.Trim());
                    var previousId = element.PreviousSibling.GetAttributeValue("id", "none").Trim();
                    if (previousId.StartsWith("parameter"))
                    {
                        Logger.LogInformation("Processing method parameters {{{}}}", NamespaceName);
                    }
                    else if (previousId.StartsWith("returns"))
                    {
                        Logger.LogInformation("Processing method return values {{{}}}", NamespaceName);
                    }

                    break;
                    var names = element.SelectNodes(".//dt/code");
                    var summaries = element.SelectNodes(".//dd/p");
                    if (names.Count != summaries.Count)
                    {
                        Logger.LogError("Cannot process method {} parameters (incorrect name,summary count) {{{}}}", member.Name, NamespaceName);
                        break;
                    }
                    for (var i = 0; i < names.Count; ++i)
                    {
                        member.Parameters.Add((names[i].InnerText.Trim(), summaries[i].InnerText.Trim()));
                    }

                    // ? TODO: Could there be a method without parameters and return?
                    // There is no other parameter defined, saved the method
                    // Method could end with returns or with parameters (in case of void)
                    // Save when:
                    //  There is no next sibling (Nothing to do - either last return or parameter)
                    //  Next sibling element is h3 (Next method)
                    if (!element.NextSibling.Name.Equals("dl"))
                    {
                        Logger.LogWarning("Saving {}", member.Name);
                        //     Constructors.Add(new DotnetConstructor()
                        //     {
                        //         Name = member.Name,
                        //         Summary = member.Summary,
                        //         Definition = Helpers2.SanitizeXmlToString(member.Definition),
                        //         Parameters = member.Parameters,
                        //     });
                        //     member.Reset();
                    }
                    break;
                case "h4":
                    // Skip header with parameters
                    break;
                case "h2":
                    // Skip other group of members
                    breakLoop = true;
                    break;
                case "a":
                    break;
            }

            if (breakLoop) break;
        }

        //     bool emailQueueProcessed = false;

        //     foreach (var e in elements)
        //     {
        //         var _name = Helpers.ExtractObjectName(e);

        // // TODO: Drop
        // if (emailQueueProcessed) continue;
        // if (Helpers.IsClass(this, "Alvao.API.Common", "Email") && _name.Contains("Queue")) emailQueueProcessed = true;
        // if (MonkeyPatch.IsInvalidMethod(NamespaceName, Name, _name)) continue;

        //         var _definition = Helpers.ExtractObjectDefinition(_document);
        //         if (_definition == null) continue;
        //         if (_definition.Contains("ObsoleteAttribute")) continue;

        //         var _params = _document.DocumentNode.SelectSingleNode("//*[@id=\"IDBSection\"]/dl");
        //         if (_params != null)
        //         {
        //             _sb.AppendLine($"///");
        //             var _dts = _document.DocumentNode.SelectNodes("//*[@id=\"IDBSection\"]/dl/dt");
        //             var _dds = _document.DocumentNode.SelectNodes("//*[@id=\"IDBSection\"]/dl/dd");

        //             for (int i = 0; i < _dts.Count; i++)
        //             {
        //                 var _var = _dts[i].SelectSingleNode(".//span")?.InnerText.Trim().Replace("&lt;", "<").Replace("&gt;", ">").Replace("&nbsp;", " ");
        //                 var _description = _dds[i]?.InnerText.Trim().Replace("&lt;", "<").Replace("&gt;", ">").Replace("&nbsp;", " ");
        //                 if (_description == null) continue;

        //                 _description = Helpers.ReplaceEndLinesWithSpace(_description);
        //                 _sb.AppendLine($"/// <param name=\"{_var}\">{_description}</param>");
        //             }
        //         }

        //         _definition = Helpers.SanitizeXmlToString(_definition);

        //         // TODO: Drop
        //         _definition = MonkeyPatch.Methods(this, _name, _definition);

        //         _sb.AppendLine($"{_definition}{Helpers.GenerateMethodBody(Type)}");
        //         Methods.Add(_sb.ToString());
        //     }
    }

    public void ProduceFinalCsFile()
    {
        Logger.LogInformation("Constructing final dotnet cl file for class [{}] {{{}}}", Name, NamespaceName);
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
        {
            Logger.LogInformation("Constructing properties for class [{}] {{{}}}", Name, NamespaceName);
            Properties.ForEach(el => sb.AppendLine(el.Produce()));
            Fields.ForEach(el => sb.AppendLine(el.Produce()));
            // Events.ForEach(el => sb.AppendLine($"{Helpers.PrefixEachLineSpaces(el)};"));

            if ((Enums.Count > 0 || Properties.Count > 0 || Fields.Count > 0 || Events.Count > 0) && Constructors.Count > 0) sb.AppendLine("");
            Logger.LogInformation("Constructing constructors for class [{}] {{{}}}", Name, NamespaceName);
            Constructors.ForEach(el => sb.AppendLine(el.Produce()));

            Methods.ForEach(el => sb.AppendLine(el.Produce()));
        }

        sb.AppendLine("}"); // End class

        Logger.LogDebug("Writing cs file [{}] {{{}}}", Name, NamespaceName);
        File.WriteAllText(FinalCsFile, sb.ToString());
        Logger.LogDebug("Final cs file written {} [{}] {{{}}}", FinalCsFile, Name, NamespaceName);
        State.Classes.Add(Name, this);
    }

    // public AlvaoClass(bool manual, string namespaceName, string name, string summary)
    // {
    //     using var loggerFactory = LoggerFactory.Create(builder =>
    //     {
    //         builder.AddFilter("AlvaoScrapper", LogLevel.Debug);
    //         builder.AddConsole();
    //     });
    //     Logger = loggerFactory.CreateLogger<AlvaoClass>();

    //     Name = name.Replace(" Class", "").Replace(" Interface", "").Trim();
    //     Type = name.EndsWith("Interface") ? ClassType.INTERFACE : ClassType.CLASS;
    //     NamespaceName = namespaceName;
    //     FinalCsFile = $"{namespaceName.Replace(".", "/")}/{Name}.cs";

    //     Summary = summary;
    //     Version = "";
    //     Usings = [];
    //     Fields = [];
    //     Properties = [];
    //     Enums = [];
    //     Methods = [];
    //     Events = [];

    //     Constructors = [];
    //     LocalHtmlFile = "";
    //     HtmlDocument = null;
    // }

    // public void Process()
    // {
    //     Logger.LogInformation("Processing member '{}' ({}) [{}]", Name, Type, NamespaceName);

    //     // TODO: Drop
    //     // ! TODO: Check if needed
    //     if (MonkeyPatch.IsInvalidClass(NamespaceName, Name)) return;

    //     Logger.LogInformation("Processing definitition of class {name} [{ns}]", Name, NamespaceName);
    //     var _def = Helpers.ExtractObjectDefinition(HtmlDocument);
    //     if (_def == null) return;

    //     Definition = _def;
    //     ProcessProperties();
    //     // ProcessFields();
    //     // ProcessEvents();
    //     ProcessConstructors();
    //     // ProcessMethods();

    //     // TODO: Drop
    //     // MonkeyPatch.Using(this);

    //     State.Classes.Add($"{NamespaceName}.{Name}", this);
    //     ProduceFinalCsFile();
    // }

    // private static StringBuilder ProcessDocumentationComments(string link, HtmlDocument document, out bool skip)
    // {
    //     skip = false;
    //     var _summary = Helpers.GetSummary(document);
    //     if (_summary.Contains("Obsolete") || _summary.Contains("obsolete")) skip = true;
    //     var _sb = new StringBuilder();
    //     if (!_summary.Equals("")) _sb.AppendLine(_summary);
    //     _sb.AppendLine(Helpers.GenerateSeeDoc(link));

    //     return _sb;
    // }

    // public void ProcessFields()
    // {
    //     return;
    //     var fields = HtmlDocument.DocumentNode.SelectNodes("//table[@id=\"FieldList\"]/tr/td[2]/a");
    //     if (fields == null) return;

    //     foreach (var f in fields)
    //     {
    //         var fieldName = Helpers.ExtractObjectName(f);
    //         Console.WriteLine($"    Processing {fieldName} Field");

    //         var fieldHtmlBaseFileName = f.GetAttributeValue("href", "").Split("/").Last();
    //         var fieldLink = $"{Helpers.BASE_HTML_URL}/{fieldHtmlBaseFileName}";
    //         var fieldLocalHtml = $"{Helpers.LOCAL_HTML_FOLDER}/{fieldHtmlBaseFileName}";
    //         if (Helpers.IsInvalidAlvaoUrl(fieldLink)) continue;

    //         var fieldDocument = Helpers.LoadDocument(fieldLink, fieldLocalHtml);
    //         var _sb = ProcessDocumentationComments(fieldLink, fieldDocument, out bool obsolete);
    //         if (obsolete) continue;

    //         var fieldDef = Helpers.ExtractObjectDefinition(fieldDocument);
    //         if (fieldDef == null) continue;
    //         fieldDef = Helpers.SanitizeXmlToString(fieldDef);

    //         // TODO: Drop
    //         if (fieldName.Equals("EmailFormat")) fieldDef = fieldDef.Replace("\"]", "\"\"]");
    //         if (new[] { "EmailFormat", "EmailPattern" }.Contains(fieldName)) fieldDef = fieldDef.Replace("= \"", "= @\"");

    //         _sb.AppendLine(fieldDef);
    //         Fields.Add(_sb.ToString());
    //     }
    // }

    // private void ProcessEvents()
    // {
    //     var elements = HtmlDocument.DocumentNode.SelectNodes("//table[@id=\"EventList\"]/tr/td[2]/a");
    //     if (elements == null) return;

    //     foreach (var e in elements)
    //     {
    //         var _name = Helpers.ExtractObjectName(e);
    //         Console.WriteLine($"    Processing {_name} Method");

    //         var _htmlBaseFileName = e.GetAttributeValue("href", "").Split("/").Last();
    //         var _link = $"{Helpers.BASE_HTML_URL}/{_htmlBaseFileName}";
    //         var _localHtml = $"{Helpers.LOCAL_HTML_FOLDER}/{_htmlBaseFileName}";
    //         if (Helpers.IsInvalidAlvaoUrl(_link)) continue;

    //         var _document = Helpers.LoadDocument(_link, _localHtml);
    //         var _sb = ProcessDocumentationComments(_link, _document, out bool obsolete);
    //         if (obsolete) continue;

    //         var _definition = Helpers.ExtractObjectDefinition(_document);
    //         if (_definition == null) continue;

    //         _sb.AppendLine(Helpers.SanitizeXmlToString(_definition));
    //         Events.Add(_sb.ToString());
    //     }
    // }

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
