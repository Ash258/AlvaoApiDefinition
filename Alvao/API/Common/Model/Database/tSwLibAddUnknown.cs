using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Sending unrecognized records, request for adding product to the standard software product library.
/// </summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html"/>
[Table("dbo.tSwLibAddUnknown")]
public class tSwLibAddUnknown {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html#Alvao_API_Common_Model_Database_tSwLibAddUnknown_Comments"/>
    public virtual string Comments { get; set; }
    /// <summary>1 = reported software issue, 0 = unkown software</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html#Alvao_API_Common_Model_Database_tSwLibAddUnknown_IsSwScanIssue"/>
    public virtual bool IsSwScanIssue { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html#Alvao_API_Common_Model_Database_tSwLibAddUnknown_bInform"/>
    public virtual bool bInform { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html#Alvao_API_Common_Model_Database_tSwLibAddUnknown_dCreated"/>
    public virtual DateTime dCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html#Alvao_API_Common_Model_Database_tSwLibAddUnknown_dNextTry"/>
    public virtual DateTime? dNextTry { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html#Alvao_API_Common_Model_Database_tSwLibAddUnknown_iNewProductUID"/>
    public virtual int? iNewProductUID { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html#Alvao_API_Common_Model_Database_tSwLibAddUnknown_iRequestUID"/>
    public virtual int? iRequestUID { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html#Alvao_API_Common_Model_Database_tSwLibAddUnknown_iSwLibAddUnknownId"/>
    [Key]
    public virtual int iSwLibAddUnknownId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html#Alvao_API_Common_Model_Database_tSwLibAddUnknown_liCreatedPersonId"/>
    public virtual int liCreatedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html#Alvao_API_Common_Model_Database_tSwLibAddUnknown_liProductId"/>
    public virtual int? liProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html#Alvao_API_Common_Model_Database_tSwLibAddUnknown_oAttachment"/>
    public virtual byte[] oAttachment { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html#Alvao_API_Common_Model_Database_tSwLibAddUnknown_sAttachmentName"/>
    public virtual string sAttachmentName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html#Alvao_API_Common_Model_Database_tSwLibAddUnknown_sEmail"/>
    public virtual string sEmail { get; set; }
}
