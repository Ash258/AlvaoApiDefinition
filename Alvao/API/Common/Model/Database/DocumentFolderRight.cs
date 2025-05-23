using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Permissions of users and groups for documents stored in a certain document folder</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_DocumentFolderRight.htm"/>
[TableAttribute("dbo.DocumentFolderRight")]
public class DocumentFolderRight
{
    /// <summary>1 = deletion permission for documents</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DocumentFolderRight_CanDelete.htm"/>
    public virtual bool? CanDelete { get; set; }
    /// <summary>1 = editing permission for documents</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DocumentFolderRight_CanModify.htm"/>
    public virtual bool? CanModify { get; set; }
    /// <summary>1 = read permission for documents</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DocumentFolderRight_CanRead.htm"/>
    public virtual bool? CanRead { get; set; }
    /// <summary>Document folder (DocumentFolder.id)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DocumentFolderRight_DocumentFolderId.htm"/>
    public virtual int DocumentFolderId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DocumentFolderRight_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>User (tPerson.iPersonId); Just one of the PersonId and RoleId must have a value filled in.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DocumentFolderRight_PersonId.htm"/>
    public virtual int? PersonId { get; set; }
    /// <summary>User group (tRole.iRoleId)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DocumentFolderRight_RoleId.htm"/>
    public virtual int? RoleId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_DocumentFolderRight__ctor.htm"/>
    public DocumentFolderRight() { }
}
