using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Sending unrecognized records, request for adding product to the standard software product library.
/// </summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html"/>
[Table("dbo.tSwLibAddUnknown")]
public class tSwLibAddUnknown {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html#Alvao_API_Common_Model_Database_tSwLibAddUnknown_Comments"/>
    /// <remarks>Column <c>Comments</c>: nvarchar(max), null.</remarks>
    public virtual string Comments { get; set; }
    /// <summary>1 = reported software issue, 0 = unkown software</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html#Alvao_API_Common_Model_Database_tSwLibAddUnknown_IsSwScanIssue"/>
    /// <remarks>Column <c>IsSwScanIssue</c>: bit, not null.</remarks>
    public virtual bool IsSwScanIssue { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html#Alvao_API_Common_Model_Database_tSwLibAddUnknown_bInform"/>
    /// <remarks>Column <c>bInform</c>: bit, not null.</remarks>
    public virtual bool bInform { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html#Alvao_API_Common_Model_Database_tSwLibAddUnknown_dCreated"/>
    /// <remarks>Column <c>dCreated</c>: datetime, not null.</remarks>
    public virtual DateTime dCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html#Alvao_API_Common_Model_Database_tSwLibAddUnknown_dNextTry"/>
    /// <remarks>Column <c>dNextTry</c>: datetime, null.</remarks>
    public virtual DateTime? dNextTry { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html#Alvao_API_Common_Model_Database_tSwLibAddUnknown_iNewProductUID"/>
    /// <remarks>Column <c>iNewProductUID</c>: int, null.</remarks>
    public virtual int? iNewProductUID { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html#Alvao_API_Common_Model_Database_tSwLibAddUnknown_iRequestUID"/>
    /// <remarks>Column <c>iRequestUID</c>: int, null.</remarks>
    public virtual int? iRequestUID { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html#Alvao_API_Common_Model_Database_tSwLibAddUnknown_iSwLibAddUnknownId"/>
    /// <remarks>Column <c>iSwLibAddUnknownId</c>: int, not null.</remarks>
    [Key]
    public virtual int iSwLibAddUnknownId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html#Alvao_API_Common_Model_Database_tSwLibAddUnknown_liCreatedPersonId"/>
    /// <remarks>Column <c>liCreatedPersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int liCreatedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html#Alvao_API_Common_Model_Database_tSwLibAddUnknown_liProductId"/>
    /// <remarks>Column <c>liProductId</c>: int, null. References <see cref="tblProduct"/>.</remarks>
    public virtual int? liProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html#Alvao_API_Common_Model_Database_tSwLibAddUnknown_oAttachment"/>
    /// <remarks>Column <c>oAttachment</c>: image, null.</remarks>
    public virtual byte[] oAttachment { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html#Alvao_API_Common_Model_Database_tSwLibAddUnknown_sAttachmentName"/>
    /// <remarks>Column <c>sAttachmentName</c>: nvarchar(255), null.</remarks>
    public virtual string sAttachmentName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwLibAddUnknown.html#Alvao_API_Common_Model_Database_tSwLibAddUnknown_sEmail"/>
    /// <remarks>Column <c>sEmail</c>: nvarchar(255), null.</remarks>
    public virtual string sEmail { get; set; }
}
