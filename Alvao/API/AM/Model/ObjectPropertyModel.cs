namespace Alvao.API.AM.Model;

public class ObjectPropertyModel
{
    public int GlobalScope { get; set; }
    public int Id { get; set; }
    public bool IsInheritable { get; set; }
    public int KindId { get; set; }
    public string Name { get; set; }
    public int NameOrder { get; set; }
    public string Value { get; set; }
}
