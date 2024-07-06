namespace Alvao.API.AI.Model;

public class TicketRelatedObject
{
    public string BeginNodeName { get; set; }
    public string BeginNodePath { get; set; }
    public string BeginRelation { get; set; }
    public string EndNodeName { get; set; }
    public string EndNodePath { get; set; }
    public string EndRelation { get; set; }
    public int NodeId { get; set; }
    public string NodeName { get; set; }
    public string NodePath { get; set; }
    public string NodeType { get; set; }
    public string TicketId { get; set; }

    public TicketRelatedObject() { }
}
