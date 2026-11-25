namespace AlvaoScrapper;

public static class State {
    public static Dictionary<string, AlvaoNamespace> Namespaces = [];

    public static Dictionary<string, AlvaoClass> Classes = [];

    // All documented Alvao namespaces (used to split xref page names into namespace + type)
    public static List<string> AllNamespaces = [];

    // Short (top-level) type name => namespaces, where type with such name exists.
    // Filled with documented Alvao types before any class is processed and extended with every resolved reference.
    public static Dictionary<string, HashSet<string>> KnownTypes = [];

    // Undocumented Alvao types referenced from documented pages: full name => (namespace, name)
    public static Dictionary<string, TypeRef> Stubs = [];

    public static void RegisterType(string ns, string name) {
        if (!KnownTypes.TryGetValue(name, out var set)) {
            set = [];
            KnownTypes[name] = set;
        }
        set.Add(ns);
    }

    public static bool IsKnownType(string ns, string name) =>
        KnownTypes.TryGetValue(name, out var set) && set.Contains(ns);

    public static bool IsDocumentedType(string ns, string name) =>
        Namespaces.TryGetValue(ns, out var alvaoNs) && alvaoNs.MemberNames.Contains(name);
}
