using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Permissions of users and groups for documents stored in a certain document folder
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_DocumentFolderRight.htm"/>
[TableAttribute("dbo.DocumentFolderRight")]
public class DocumentFolderRight
{
    /// <summary>1 = deletion permission for documents</summary>
    public virtual bool? CanDelete { get; set; }
    /// <summary>1 = editing permission for documents</summary>
    public virtual bool? CanModify { get; set; }
    /// <summary>1 = read permission for documents</summary>
    public virtual bool? CanRead { get; set; }
    /// <summary>Document folder (DocumentFolder.id)</summary>
    public virtual int DocumentFolderId { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>User (tPerson.iPersonId); Just one of the PersonId and RoleId must have a value filled in.</summary>
    public virtual int? PersonId { get; set; }
    /// <summary>User group (tRole.iRoleId)</summary>
    public virtual int? RoleId { get; set; }

    public DocumentFolderRight() { }
}
