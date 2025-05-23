using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Sending unrecognized records, request for adding product to the standard software products library.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tSwLibAddUnknown.htm"/>
[TableAttribute("dbo.tSwLibAddUnknown")]
public class tSwLibAddUnknown
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSwLibAddUnknown_bInform.htm"/>
    public virtual bool bInform { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSwLibAddUnknown_dCreated.htm"/>
    public virtual DateTime dCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSwLibAddUnknown_dNextTry.htm"/>
    public virtual DateTime? dNextTry { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSwLibAddUnknown_iNewProductUID.htm"/>
    public virtual int? iNewProductUID { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSwLibAddUnknown_iRequestUID.htm"/>
    public virtual int? iRequestUID { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSwLibAddUnknown_iSwLibAddUnknownId.htm"/>
    [KeyAttribute]
    public virtual int iSwLibAddUnknownId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSwLibAddUnknown_liCreatedPersonId.htm"/>
    public virtual int liCreatedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSwLibAddUnknown_liProductId.htm"/>
    public virtual int? liProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSwLibAddUnknown_mEntries.htm"/>
    public virtual string mEntries { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSwLibAddUnknown_oAttachment.htm"/>
    public virtual byte[] oAttachment { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSwLibAddUnknown_sAttachmentName.htm"/>
    public virtual string sAttachmentName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSwLibAddUnknown_sCollector.htm"/>
    public virtual string sCollector { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSwLibAddUnknown_sEmail.htm"/>
    public virtual string sEmail { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tSwLibAddUnknown__ctor.htm"/>
    public tSwLibAddUnknown() { }
}
