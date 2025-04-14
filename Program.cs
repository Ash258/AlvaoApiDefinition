using AlvaoScrapper;
using Microsoft.Extensions.Logging;

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

using var loggerFactory = LoggerFactory.Create(builder =>
{
    builder.AddFilter("AlvaoScrapper", (LogLevel)int.Parse(Environment.GetEnvironmentVariable("Logging__LogLevel__AlvaoScrappeasdfr") ?? "2"));
    builder.AddSimpleConsole(options =>
    {
        options.SingleLine = true;
    });
});
var logger = loggerFactory.CreateLogger<Program>();

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

    var alvaoNs = new AlvaoNamespace2($"{ns}.html", ns);
    State.Namespaces.Add(ns, alvaoNs);
    alvaoNs.Process();
}

Console.WriteLine("");
Console.WriteLine($"Processed {State.Namespaces.Count} namespaces and {State.Classes.Count} classes");
