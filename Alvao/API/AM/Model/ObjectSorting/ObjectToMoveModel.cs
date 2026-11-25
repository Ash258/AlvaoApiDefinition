namespace Alvao.API.AM.Model.ObjectSorting;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ObjectSorting.ObjectToMoveModel.html"/>
public class ObjectToMoveModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ObjectSorting.ObjectToMoveModel.html#Alvao_API_AM_Model_ObjectSorting_ObjectToMoveModel_IsAlreadyInTarget"/>
    public bool IsAlreadyInTarget { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ObjectSorting.ObjectToMoveModel.html#Alvao_API_AM_Model_ObjectSorting_ObjectToMoveModel_NodeId"/>
    public int NodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ObjectSorting.ObjectToMoveModel.html#Alvao_API_AM_Model_ObjectSorting_ObjectToMoveModel_RuleId"/>
    public int RuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ObjectSorting.ObjectToMoveModel.html#Alvao_API_AM_Model_ObjectSorting_ObjectToMoveModel_TargetId"/>
    public int TargetId { get; set; }
}
