using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Information on files received from autonomous Agents.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_AssetDetectionUpload.htm"/>
[TableAttribute("dbo.AssetDetectionUpload")]
public class AssetDetectionUpload
{
    public virtual int ComputerNodeId { get; set; }
    public virtual int DetectionKind { get; set; }
    [ExplicitKeyAttribute]
    public virtual Guid Id { get; set; }
    public virtual string TempFileName { get; set; }

    public AssetDetectionUpload() { }
}
