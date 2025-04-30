using AlvaoScrapper;
using Microsoft.Extensions.Logging;
using static AlvaoScrapper.Helpers2;

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

var logger = CreateLogger<Program>();

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
    if (filter.Length > 0) alvaoNamespace = [.. alvaoNamespace.Where(ns => filter.Contains(ns))];
}

// MonkeyPatch.MonkeyPatchNotAvailableNAlvao.API.Common.Modelamespaces();

foreach (var ns in alvaoNamespace)
{
    logger.LogInformation("Processing {ns} Namespace", ns);
    logger.LogDebug("Processing {ns} Namespace", ns);

    var alvaoNs = new AlvaoNamespace2(ns);
    State.Namespaces.Add(ns, alvaoNs);
    try
    {
        alvaoNs.Process();
    }
    catch (Exception e)
    {
        logger.LogError("Cannot process namespace {}: {}", e.Message, ns);
        continue;
    }
}

Console.WriteLine("");
Console.WriteLine($"Processed {State.Namespaces.Count} namespaces and {State.Classes.Count} classes");
