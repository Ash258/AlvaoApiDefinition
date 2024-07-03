using AlvaoScapper;
using Microsoft.Identity.Client;

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


int toTake = alvaoNamespace.Length;
if (args.Length > 0)
{
    if (args.Contains("ignore")) Helpers.IGNORE_CACHE = true;
    if (args.Contains("single")) toTake = 1;
}

foreach (var ns in alvaoNamespace.TakeLast(toTake))
{
    Console.WriteLine($"Processing {ns} Namespace");
    var namespaceUrl = $"{Helpers.BASE_HTML_URL}/N_{ns.Replace(".", "_")}.htm";
    var baseNamespaceFileName = namespaceUrl.Split("/").Last();

    AlvaoNamespace alvaoNs = new AlvaoNamespace(
        namespaceUrl,
        $"{Helpers.LOCAL_HTML_FOLDER}/{baseNamespaceFileName}",
        ns
    );

    var classes = alvaoNs.HtmlDocument.DocumentNode.SelectNodes("//*[@id=\"tocNav\"]/div[@class='toclevel2']");

    foreach (var cl in classes)
    {
        var classANode = cl.SelectNodes(".//a").Last();
        var classHtmlBaseFileName = classANode.GetAttributeValue("href", "").Split("/").Last();
        var classLink = $"{Helpers.BASE_HTML_URL}/{classHtmlBaseFileName}";
        var className = classANode.GetAttributeValue("title", "");

        // TODO: Support more types
        if (!className.EndsWith("Class")) continue;

        var clazz = new AlvaoClass(
            classLink,
            $"{Helpers.LOCAL_HTML_FOLDER}/{classHtmlBaseFileName}",
            ns,
            className.Replace("Class", "").Trim()
        );
        clazz.Process();
    }
}
