namespace Alvao.API.AM.Model;

public class UpdateObjectPropertyModel
{
    public int Id { get; set; }
    public bool IsInheritable { get; set; }
    public int KindId { get; set; }
    public string Value { get; set; }
}
