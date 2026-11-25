using System.Net;
using System.Text.Json;
using System.Text.RegularExpressions;
using static AlvaoScrapper.Helpers;

namespace AlvaoScrapper;

// Information about the documentation itself: list of namespaces and released ALVAO version.
// Both are cached in the html folder next to the pages, so cached runs stay consistent with cached pages.
public static partial class DocsInfo {
    private static readonly HttpClient Http = new();

    private static string DocsRoot => $"https://doc.alvao.com/en/{ALVAO_VERSION}";

    // All namespaces from the API table of contents
    public static List<string> LoadNamespaces() {
        var json = Cached("toc.json", () => Download($"{BASE_HTML_URL}/toc.json"));

        using var doc = JsonDocument.Parse(json);
        return [.. doc.RootElement.GetProperty("items").EnumerateArray()
            .Where(i => i.TryGetProperty("type", out var t) && t.GetString() == "Namespace")
            .Select(i => i.GetProperty("name").GetString()!)];
    }

    // Version of the latest release from release notes: "version 26.4" => 26.4.0, "version 26.4 Patch" => 26.4.1
    public static string DetectReleaseVersion() {
        return Cached("release-version.txt", () => {
            // Every release notes page links all other releases in its sidebar (N = release, Np = patch)
            var index = Download($"{DocsRoot}/admin-guide/whats-new/1/");
            var releases = ReleaseLinkRegex().Matches(index)
                .Select(m => (Number: int.Parse(m.Groups[1].Value), Patch: m.Groups[2].Value == "p"))
                .ToList();
            if (releases.Count == 0) throw new Exception("Cannot find any release notes");

            var latest = releases.MaxBy(r => (r.Number, r.Patch ? 1 : 0));
            var page = Download($"{DocsRoot}/admin-guide/whats-new/{latest.Number}{(latest.Patch ? "p" : "")}/");
            var m = ReleaseTitleRegex().Match(page);
            if (!m.Success) throw new Exception($"Cannot find version in release notes {latest.Number}");

            return $"{m.Groups[1].Value}.{(m.Groups[2].Success ? 1 : 0)}";
        }).Trim();
    }

    private static string Cached(string fileName, Func<string> fetch) {
        var local = Path.Combine(LOCAL_HTML_FOLDER, fileName);
        if (!IGNORE_CACHE && File.Exists(local)) return File.ReadAllText(local);

        var content = fetch();
        AssertDirectory(LOCAL_HTML_FOLDER);
        File.WriteAllText(local, content);

        return content;
    }

    private static string Download(string url) {
        for (var attempt = 1; ; attempt++) {
            using var response = Http.GetAsync(url).GetAwaiter().GetResult();
            if (response.StatusCode == HttpStatusCode.OK) return response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            if (attempt >= DOWNLOAD_ATTEMPTS) throw new Exception($"Cannot download {url}: HTTP {(int)response.StatusCode}");

            Thread.Sleep(TimeSpan.FromSeconds(5 * attempt));
        }
    }

    [GeneratedRegex(@"/admin-guide/whats-new/(\d+)(p?)(?=[/""'\s>])")]
    private static partial Regex ReleaseLinkRegex();

    [GeneratedRegex(@"<title[^>]*>[^<]*\(version (\d+\.\d+)( Patch)?\)")]
    private static partial Regex ReleaseTitleRegex();
}
