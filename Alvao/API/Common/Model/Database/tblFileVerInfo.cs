using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Information on detected files - versions.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblFileVerInfo.htm"/>
[TableAttribute("dbo.tblFileVerInfo")]
public class tblFileVerInfo {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileVerInfo_intFileDateLS.htm"/>
    public virtual int? intFileDateLS { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileVerInfo_intFileDateMS.htm"/>
    public virtual int? intFileDateMS { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileVerInfo_intFileFlags.htm"/>
    public virtual int? intFileFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileVerInfo_intFileFlagsMask.htm"/>
    public virtual int? intFileFlagsMask { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileVerInfo_intFileOS.htm"/>
    public virtual int? intFileOS { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileVerInfo_intFileSubtype.htm"/>
    public virtual int? intFileSubtype { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileVerInfo_intFileType.htm"/>
    public virtual int? intFileType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileVerInfo_intFileVersionLS.htm"/>
    public virtual int? intFileVersionLS { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileVerInfo_intFileVersionMS.htm"/>
    public virtual int? intFileVersionMS { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileVerInfo_intProductVersionLS.htm"/>
    public virtual int? intProductVersionLS { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileVerInfo_intProductVersionMS.htm"/>
    public virtual int? intProductVersionMS { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileVerInfo_lintFileId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int lintFileId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblFileVerInfo__ctor.htm"/>
    public tblFileVerInfo() { }
}
