using AlvaoScapper;

string[] alvaoNamespace = {
    "Alvao.API.AI.Model",
    "Alvao.API.AI.Utils",
    "Alvao.API.AI",
    "Alvao.API.Common.Exceptions",
    "Alvao.API.Common.Model.Database",
    "Alvao.API.Common.Model",
    "Alvao.API.Common",
    "Alvao.API.AM.Exceptions",
    "Alvao.API.AM.Model",
    "Alvao.API.AM",
    "Alvao.API.SD.Model",
    "Alvao.API.SD.Exceptions",
    "Alvao.API.SD",
    "Alvao.Context.DB",
    "Alvao.Context",
};


string[] filter = [];
int toTake = alvaoNamespace.Length;
if (args.Length > 0)
{
    if (args.Contains("ignore")) Helpers.IGNORE_CACHE = true;
    if (args.Contains("test"))
    {
        Console.WriteLine("All files are generated OK");
        Environment.Exit(0);
    }

    var _l = Helpers.IGNORE_CACHE ? args.Length - 1 : args.Length;

    filter = args.TakeLast(_l).ToArray();
    alvaoNamespace = alvaoNamespace.Where(ns => filter.Contains(ns)).ToArray();
}

foreach (var ns in alvaoNamespace)
{
    Console.WriteLine($"Processing {ns} Namespace");
    var namespaceUrl = $"{Helpers.BASE_HTML_URL}/N_{ns.Replace(".", "_")}.htm";
    var baseNamespaceFileName = namespaceUrl.Split("/").Last();

    AlvaoNamespace alvaoNs = new AlvaoNamespace(
        namespaceUrl,
        $"{Helpers.LOCAL_HTML_FOLDER}/{baseNamespaceFileName}",
        ns,
        ns
    );

    State.Namespaces.Add(ns, alvaoNs);

    alvaoNs.Process();
}

var latest = State.Versions.Distinct().OrderDescending().ToArray();
Console.WriteLine($"Unique versions: {latest.Length} ({string.Join(", ", latest)})");
File.WriteAllText(".version", latest.First());

Console.WriteLine("");
Console.WriteLine($"Processed {State.Namespaces.Count} namespaces and {State.Classes.Count} classes");
