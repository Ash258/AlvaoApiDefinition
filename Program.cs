using AlvaoScapper;

string[] alvaoNamespace = {
    "Alvao.API.AI",
    "Alvao.API.AI.Model",
    "Alvao.API.AI.Utils",
    "Alvao.API.AM",
    "Alvao.API.AM.Exceptions",
    "Alvao.API.AM.Model",
    "Alvao.API.AM.Model.Detection",
    "Alvao.API.AM.Model.Detection.Software",
    "Alvao.API.AM.Model.SwLibrary",
    "Alvao.API.Common",
    "Alvao.API.Common.Exceptions",
    "Alvao.API.Common.Model",
    "Alvao.API.Common.Model.CustomApps",
    "Alvao.API.Common.Model.CustomApps.Requests",
    "Alvao.API.Common.Model.Database",
    "Alvao.API.Common.Model.Translations",
    "Alvao.API.SD",
    "Alvao.API.SD.Exceptions",
    "Alvao.API.SD.Model",
    "Alvao.Context",
    "Alvao.Context.DB",
};

string[] filter = [];
int toTake = alvaoNamespace.Length;
if (args.Length > 0)
{
    if (args.Contains("test"))
    {
        Console.WriteLine("All files are generated OK");
        Environment.Exit(0);
    }

    if (args.Contains("ignore")) Helpers.IGNORE_CACHE = true;

    var _l = Helpers.IGNORE_CACHE ? args.Length - 1 : args.Length;

    filter = [.. args.TakeLast(_l)];
    if (filter.Length > 0) alvaoNamespace = alvaoNamespace.Where(ns => filter.Contains(ns)).ToArray();
}

MonkeyPatch.MonkeyPatchNotAvailableNamespaces();

foreach (var ns in alvaoNamespace)
{
    Console.WriteLine($"Processing {ns} Namespace");

    AlvaoNamespace alvaoNs = new AlvaoNamespace($"{Helpers.BASE_HTML_URL}/N_{ns.Replace(".", "_")}.htm", ns);
    State.Namespaces.Add(ns, alvaoNs);
    alvaoNs.Process();
}

var latest = State.Versions.Distinct().OrderDescending().ToArray();
Console.WriteLine("");
Console.WriteLine($"Unique versions: {latest.Length} ({string.Join(", ", latest)})");
File.WriteAllText(".version", latest.First());

Console.WriteLine("");
Console.WriteLine($"Processed {State.Namespaces.Count} namespaces and {State.Classes.Count} classes");
