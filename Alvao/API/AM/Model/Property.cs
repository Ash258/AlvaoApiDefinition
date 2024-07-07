using Newtonsoft.Json;

namespace Alvao.API.AM.Model;

public class Property
{
    [JsonIgnoreAttribute]
    public bool CanModify { get; set; }
    [JsonIgnoreAttribute]
    public int ClassId { get; set; }
    [JsonIgnoreAttribute]
    public string DbName { get; }
    [JsonIgnoreAttribute]
    public bool HasGlobalScope { get; set; }
    [JsonIgnoreAttribute]
    public bool IsDetected { get; set; }
    [JsonIgnoreAttribute]
    public bool IsFromAd { get; set; }
    [JsonIgnoreAttribute]
    public bool IsUnique { get; set; }
    [JsonIgnoreAttribute]
    public Kind.KindCode KindCode { get; set; }
    [JsonIgnoreAttribute]
    public Kind.DataType KindDataType { get; set; }
    [JsonIgnoreAttribute]
    public int KindId { get; set; }
    [JsonIgnoreAttribute]
    public string LikeValue { get; }
    public string Name { get; set; }
    public int? NameOrder { get; set; }
    [JsonIgnoreAttribute]
    public int ObjectId { get; set; }
    [JsonIgnoreAttribute]
    public int? ParentNodeId { get; set; }
    public int PropertyId { get; set; }
    [JsonIgnoreAttribute]
    public string SampleString { get; set; }
    [JsonIgnoreAttribute]
    public int SequenceId { get; set; }
    public string Value { get; set; }
    [JsonIgnoreAttribute]
    public bool ValueIsSelectionOnly { get; set; }
    [JsonIgnoreAttribute]
    public int? ValueKindId { get; set; }

    public Property() { }
    public Property(
        int propertyId,
        int sequenceId
    )
    { }
    public Property(
        string name,
        string value
    )
    { }

    public bool IsInherited() { throw new System.NotImplementedException(); }

    public bool IsQueryProperty() { throw new System.NotImplementedException(); }

    public bool IsSystemProperty() { throw new System.NotImplementedException(); }

    public bool Validate() { throw new System.NotImplementedException(); }
}
