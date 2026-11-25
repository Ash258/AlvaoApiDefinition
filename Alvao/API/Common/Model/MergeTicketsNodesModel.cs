namespace Alvao.API.Common.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.MergeTicketsNodesModel.html"/>
public class MergeTicketsNodesModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.MergeTicketsNodesModel.html#Alvao_API_Common_Model_MergeTicketsNodesModel_deletedNodeIds"/>
    public IEnumerable<int> deletedNodeIds { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.MergeTicketsNodesModel.html#Alvao_API_Common_Model_MergeTicketsNodesModel_updatedNodeIds"/>
    public IEnumerable<int> updatedNodeIds { get; set; }
}
