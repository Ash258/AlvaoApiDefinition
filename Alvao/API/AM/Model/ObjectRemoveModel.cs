namespace Alvao.API.AM.Model;

public class ObjectRemoveModel
{
    public bool IsInTrash { get; set; }
    public bool IsResponsible { get; set; }
    public bool IsTemplate { get; set; }
    public bool IsUsedOnLicense { get; set; }
    public string Name { get; set; }
    public int ObjectId { get; set; }
}
