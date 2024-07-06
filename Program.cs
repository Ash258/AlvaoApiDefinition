using AlvaoScapper;

string[] alvaoNamespace = {
    "Alvao.API.AI",
    "Alvao.API.AI.Model",
    "Alvao.API.AI.Utils",
    "Alvao.API.AM",
    "Alvao.API.AM.Exceptions",
    "Alvao.API.AM.Model",
    "Alvao.API.Common",
    "Alvao.API.Common.Exceptions",
    "Alvao.API.Common.Model",
    "Alvao.API.Common.Model.Database",
    "Alvao.API.SD",
    "Alvao.API.SD.Exceptions",
    "Alvao.API.SD.Model",
    "Alvao.Context",
    "Alvao.Context.DB"
};


string[] filter = [];
int toTake = alvaoNamespace.Length;
if (args.Length > 0)
{
    if (args.Contains("ignore")) Helpers.IGNORE_CACHE = true;

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

Console.WriteLine($"Processed {State.Namespaces.Count} namespaces and {State.Classes.Count} classes");
