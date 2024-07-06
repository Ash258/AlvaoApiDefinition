using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Sending unrecognized records, request for adding product to the standard software products library.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tSwLibAddUnknown.htm"/>
[TableAttribute("dbo.tSwLibAddUnknown")]
public class tSwLibAddUnknown
{
    public virtual bool bInform { get; set; }
    public virtual DateTime dCreated { get; set; }
    public virtual DateTime? dNextTry { get; set; }
    public virtual int? iNewProductUID { get; set; }
    public virtual int? iRequestUID { get; set; }
    [KeyAttribute]
    public virtual int iSwLibAddUnknownId { get; set; }
    public virtual int liCreatedPersonId { get; set; }
    public virtual int? liProductId { get; set; }
    public virtual string mEntries { get; set; }
    public virtual byte[] oAttachment { get; set; }
    public virtual string sAttachmentName { get; set; }
    public virtual string sCollector { get; set; }
    public virtual string sEmail { get; set; }

    public tSwLibAddUnknown() { }
}
