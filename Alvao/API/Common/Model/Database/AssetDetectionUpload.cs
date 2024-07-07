using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Information on files received from autonomous Agents.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_AssetDetectionUpload.htm"/>
[TableAttribute("dbo.AssetDetectionUpload")]
public class AssetDetectionUpload
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_AssetDetectionUpload_ComputerNodeId.htm"/>
    public virtual int ComputerNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_AssetDetectionUpload_DetectionKind.htm"/>
    public virtual int DetectionKind { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_AssetDetectionUpload_Id.htm"/>
    [ExplicitKeyAttribute]
    public virtual Guid Id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_AssetDetectionUpload_TempFileName.htm"/>
    public virtual string TempFileName { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_AssetDetectionUpload__ctor.htm"/>
    public AssetDetectionUpload() { }
}
