using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Documents.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vDocument.htm"/>
[TableAttribute("dbo.vDocument")]
public class vDocument
{
    public virtual DateTime CreatedDate { get; set; }
    public virtual int DocumentFolderId { get; set; }
    public virtual DateTime? dteRemoved { get; set; }
    public virtual int? GiverFlags { get; set; }
    public virtual int id { get; set; }
    public virtual string IdNumber { get; set; }
    public virtual DateTime? IssuedDate { get; set; }
    public virtual int? liCreatedPersonId { get; set; }
    public virtual int? lintDestNodeId { get; set; }
    public virtual int lintDocumentKindId { get; set; }
    public virtual int? lintResellerCompanyId { get; set; }
    public virtual int? lintSrcNodeId { get; set; }
    public virtual int? liRemovedPersonId { get; set; }
    public virtual string Name { get; set; }
    public virtual int? ReceiverFlags { get; set; }
    public virtual string sCreatedPersonName { get; set; }
    public virtual string SignComputer { get; set; }
    public virtual DateTime? SignDate { get; set; }
    public virtual string SignedBy { get; set; }
    public virtual int? SignPersonId { get; set; }
    public virtual string sRemovedPersonName { get; set; }
    public virtual bool SummaryProtocol { get; set; }
    public virtual int TransferConfirmTypeId { get; set; }
    public virtual string txtIdNumber2 { get; set; }
    public virtual int? txtLink { get; set; }
    public virtual string txtMemo { get; set; }
    public virtual string txtResellerCompany { get; set; }

    public vDocument() { }
}
