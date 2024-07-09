namespace Alvao.API.Common.Model.CustomApps;

public class EntityTabShowResult
{
    public bool Show { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }

    public EntityTabShowResult(bool show, string name, string url)
    {
        Show = show;
        Name = name;
        Url = url;
    }
}
