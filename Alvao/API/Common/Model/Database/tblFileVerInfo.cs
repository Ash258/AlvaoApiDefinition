using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Information on detected files - versions.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblFileVerInfo.htm"/>
[TableAttribute("dbo.tblFileVerInfo")]
public class tblFileVerInfo
{
    public virtual int? intFileDateLS { get; set; }
    public virtual int? intFileDateMS { get; set; }
    public virtual int? intFileFlags { get; set; }
    public virtual int? intFileFlagsMask { get; set; }
    public virtual int? intFileOS { get; set; }
    public virtual int? intFileSubtype { get; set; }
    public virtual int? intFileType { get; set; }
    public virtual int? intFileVersionLS { get; set; }
    public virtual int? intFileVersionMS { get; set; }
    public virtual int? intProductVersionLS { get; set; }
    public virtual int? intProductVersionMS { get; set; }
    [ExplicitKeyAttribute]
    public virtual int lintFileId { get; set; }

    public tblFileVerInfo() { }
}
