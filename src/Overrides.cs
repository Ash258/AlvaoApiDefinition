using System.Text;
using Microsoft.Extensions.Logging;
using static AlvaoScrapper.Helpers;

namespace AlvaoScrapper;

public static class Overrides {
    private const string CAUTION = "!!!CAUTION: This class is not documented. It was generated as empty, to make the project compilable";

    // Output path of type: Alvao.API.AI.Model.Foo => Alvao/API/AI/Model/Foo.cs
    public static string CsFilePath(string ns, string name) => $"{ns.Replace(".", "/")}/{name}.cs";

    // Empty classes for undocumented Alvao types referenced from documented pages
    public static void GenerateStubs(ILogger logger) {
        foreach (var stub in State.Stubs.Values.OrderBy(s => s.FullName)) {
            var path = CsFilePath(stub.Namespace, stub.Name);
            if (File.Exists(Path.Combine(Patches.OVERRIDES_FOLDER, path))) {
                logger.LogInformation("Stub {} is hand written in overrides", stub.FullName);
                continue;
            }

            logger.LogInformation("Generating stub for undocumented type {}", stub.FullName);
            var sb = new StringBuilder();
            sb.AppendLine($"namespace {stub.Namespace};");
            sb.AppendLine();
            GenerateSummary(CAUTION, 0, [], sb);
            sb.AppendLine($"public class {stub.Name} {{ }}");

            AssertDirectory(Path.GetDirectoryName(path)!);
            File.WriteAllText(path, sb.ToString());
        }
    }

    // Copy hand written files (overrides/Alvao/**/*.cs) over generated output
    public static void CopyHandWritten(ILogger logger) {
        if (!Directory.Exists(Patches.OVERRIDES_FOLDER)) return;

        foreach (var file in Directory.EnumerateFiles(Patches.OVERRIDES_FOLDER, "*.cs", SearchOption.AllDirectories)) {
            var target = Path.GetRelativePath(Patches.OVERRIDES_FOLDER, file);
            logger.LogInformation("Copying hand written {}", target);

            AssertDirectory(Path.GetDirectoryName(target)!);
            File.Copy(file, target, true);
        }
    }
}
