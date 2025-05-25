using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Permissions of users and groups for documents stored in a certain document folder</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DocumentFolderRight.html"/>
[Table("dbo.DocumentFolderRight")]
public class DocumentFolderRight {
    /// <summary>1 = deletion permission for documents</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DocumentFolderRight.html#Alvao_API_Common_Model_Database_DocumentFolderRight_CanDelete"/>
    public virtual bool? CanDelete { get; set; }
    /// <summary>1 = editing permission for documents</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DocumentFolderRight.html#Alvao_API_Common_Model_Database_DocumentFolderRight_CanModify"/>
    public virtual bool? CanModify { get; set; }
    /// <summary>1 = read permission for documents</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DocumentFolderRight.html#Alvao_API_Common_Model_Database_DocumentFolderRight_CanRead"/>
    public virtual bool? CanRead { get; set; }
    /// <summary>Document folder (DocumentFolder.id)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DocumentFolderRight.html#Alvao_API_Common_Model_Database_DocumentFolderRight_DocumentFolderId"/>
    public virtual int DocumentFolderId { get; set; }
    /// <summary>User (tPerson.iPersonId); Just one of the PersonId and RoleId must have a value filled in.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DocumentFolderRight.html#Alvao_API_Common_Model_Database_DocumentFolderRight_PersonId"/>
    public virtual int? PersonId { get; set; }
    /// <summary>User group (tRole.iRoleId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DocumentFolderRight.html#Alvao_API_Common_Model_Database_DocumentFolderRight_RoleId"/>
    public virtual int? RoleId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DocumentFolderRight.html#Alvao_API_Common_Model_Database_DocumentFolderRight_id"/>
    [Key]
    public virtual int id { get; set; }
}
