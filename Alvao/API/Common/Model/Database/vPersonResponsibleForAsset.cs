using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Users responsible for assets.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPersonResponsibleForAsset.html"/>
[Table("dbo.vPersonResponsibleForAsset")]
public class vPersonResponsibleForAsset {
    /// <summary>Asset ID (tblNode.intNodeId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPersonResponsibleForAsset.html#Alvao_API_Common_Model_Database_vPersonResponsibleForAsset_NodeId"/>
    public virtual int NodeId { get; set; }

    /// <summary>User ID (tblNode.intNodeId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPersonResponsibleForAsset.html#Alvao_API_Common_Model_Database_vPersonResponsibleForAsset_PersonResponsibleForAsset"/>
    public virtual int? PersonResponsibleForAsset { get; set; }

}
