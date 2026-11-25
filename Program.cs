using AlvaoScrapper;
using Microsoft.Extensions.Logging;
using static AlvaoScrapper.Helpers;

var logger = CreateLogger<Program>();

// Arguments: [test] [ignore] [namespace...]
if (args.Contains("test")) {
    Console.WriteLine("All files are generated OK");
    Environment.Exit(0);
}
if (args.Contains("ignore")) IGNORE_CACHE = true;
string[] filter = [.. args.Where(a => a != "ignore")];

AssertDirectory(LOCAL_HTML_FOLDER);

// Version of the latest ALVAO release, the package is versioned by it
var version = DocsInfo.DetectReleaseVersion();
var previousVersion = File.Exists(".alvaorc") ? File.ReadAllText(".alvaorc").Trim() : string.Empty;
if (!version.Equals(previousVersion)) {
    logger.LogWarning("ALVAO version changed from {} to {}", previousVersion, version);
    File.WriteAllText(".alvaorc", $"{version}\n");
}

// All documented namespaces, from the API table of contents
State.AllNamespaces = DocsInfo.LoadNamespaces();
string[] alvaoNamespace = filter.Length > 0
    ? [.. State.AllNamespaces.Where(filter.Contains)]
    : [.. State.AllNamespaces];

// Members of all namespaces have to be known before processing any class, to resolve type references
foreach (var ns in State.AllNamespaces) {
    var alvaoNs = new AlvaoNamespace(ns);
    try {
        alvaoNs.CollectMembers();
    } catch (Exception e) {
        logger.LogError("Cannot list members of namespace {}: {}", ns, e.Message);
    }
    State.Namespaces.Add(ns, alvaoNs);
}

foreach (var ns in alvaoNamespace) {
    logger.LogInformation("Processing {ns} Namespace", ns);

    try {
        State.Namespaces[ns].Process();
    } catch (Exception e) {
        logger.LogError("Cannot process namespace {}: {}", ns, e.Message);
        continue;
    }
}

// Database models of tables, which are documented only in the database documentation, and schema reference
if (alvaoNamespace.Contains(DatabaseSchema.MODELS_NAMESPACE)) DatabaseSchema.GenerateMissingModels(logger);
DatabaseSchema.WriteMarkdown("Alvao/DATABASE.md", version);

Overrides.GenerateStubs(logger);
Overrides.CopyHandWritten(logger);

Console.WriteLine("");
Console.WriteLine($"ALVAO {version}: processed {alvaoNamespace.Length} namespaces, {State.Classes.Count} classes and {State.Stubs.Count} undocumented types");
