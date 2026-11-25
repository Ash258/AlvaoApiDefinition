using System.Text.Json;

namespace AlvaoScrapper;

// Things, which cannot be derived from the documentation pages. Loaded from overrides/patches.json.
// Hand written classes live as plain .cs files in overrides/ and are copied over the generated output.
public class Patches {
    public const string OVERRIDES_FOLDER = "overrides";

    // Add using, when any definition of the class contains given text (attributes are never linked in docs)
    public List<DefinitionUsing> DefinitionUsings { get; set; } = [];

    // Namespace of types, which are not linked in documentation and cannot be resolved from data-uid
    public Dictionary<string, string> TypeNamespaces { get; set; } = [];

    // Members to generate, when class implements interface and documentation does not list the member
    public Dictionary<string, List<string>> InterfaceMembers { get; set; } = [];

    // Plain text replacements in definitions of specific class (docfx quirks)
    public List<Fixup> Fixups { get; set; } = [];

    public record DefinitionUsing(string Contains, string Using);

    public record Fixup(string Class, string Find, string Replace);

    private static Patches? _instance;

    public static Patches Instance => _instance ??= Load();

    private static Patches Load() {
        var path = Path.Combine(OVERRIDES_FOLDER, "patches.json");
        if (!File.Exists(path)) return new Patches();

        return JsonSerializer.Deserialize<Patches>(File.ReadAllText(path), new JsonSerializerOptions {
            PropertyNameCaseInsensitive = true,
            ReadCommentHandling = JsonCommentHandling.Skip,
            AllowTrailingCommas = true,
        }) ?? new Patches();
    }
}
