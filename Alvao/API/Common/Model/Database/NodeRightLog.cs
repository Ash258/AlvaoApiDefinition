using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Logging of changes in permissions of users in Asset Management.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html"/>
[Table("dbo.NodeRightLog")]
public class NodeRightLog {
    /// <summary>Object type name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_Class"/>
    /// <remarks>Column <c>Class</c>: nvarchar(255), null.</remarks>
    public virtual string Class { get; set; }
    /// <summary>Object type name - the previous value.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_ClassOld"/>
    /// <remarks>Column <c>ClassOld</c>: nvarchar(255), null.</remarks>
    public virtual string ClassOld { get; set; }
    /// <summary>Permission to create any objects.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_Create"/>
    /// <remarks>Column <c>Create</c>: bit, null.</remarks>
    public virtual bool? Create { get; set; }
    /// <summary>Permission to create any objects - the previous value.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_CreateOld"/>
    /// <remarks>Column <c>CreateOld</c>: bit, null.</remarks>
    public virtual bool? CreateOld { get; set; }
    /// <summary>Permission to delete.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_Delete"/>
    /// <remarks>Column <c>Delete</c>: bit, null.</remarks>
    public virtual bool? Delete { get; set; }
    /// <summary>Permission to delete - the previous value.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_DeleteOld"/>
    /// <remarks>Column <c>DeleteOld</c>: bit, null.</remarks>
    public virtual bool? DeleteOld { get; set; }
    /// <summary>Group name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_Group"/>
    /// <remarks>Column <c>Group</c>: nvarchar(255), null.</remarks>
    public virtual string Group { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Logged-in user name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_ModifiedBy"/>
    /// <remarks>Column <c>ModifiedBy</c>: nvarchar(255), not null.</remarks>
    public virtual string ModifiedBy { get; set; }
    /// <summary>Permission to move.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_Move"/>
    /// <remarks>Column <c>Move</c>: bit, null.</remarks>
    public virtual bool? Move { get; set; }
    /// <summary>Permission to move - the previous value.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_MoveOld"/>
    /// <remarks>Column <c>MoveOld</c>: bit, null.</remarks>
    public virtual bool? MoveOld { get; set; }
    /// <summary>Object name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_Object"/>
    /// <remarks>Column <c>Object</c>: nvarchar(255), null.</remarks>
    public virtual string Object { get; set; }
    /// <summary>Object name - the previous value.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_ObjectOld"/>
    /// <remarks>Column <c>ObjectOld</c>: nvarchar(255), null.</remarks>
    public virtual string ObjectOld { get; set; }
    /// <summary>Permission to read.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_Read"/>
    /// <remarks>Column <c>Read</c>: bit, null.</remarks>
    public virtual bool? Read { get; set; }
    /// <summary>Permission to read - the previous value.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_ReadOld"/>
    /// <remarks>Column <c>ReadOld</c>: bit, null.</remarks>
    public virtual bool? ReadOld { get; set; }
    /// <summary>Check box including of child objects.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_Recursive"/>
    /// <remarks>Column <c>Recursive</c>: bit, not null.</remarks>
    public virtual bool Recursive { get; set; }
    /// <summary>Check box including of child objects - the previous value.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_RecursiveOld"/>
    /// <remarks>Column <c>RecursiveOld</c>: bit, null.</remarks>
    public virtual bool? RecursiveOld { get; set; }
    /// <summary>Date and time of the change execution.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_TimeStamp"/>
    /// <remarks>Column <c>TimeStamp</c>: datetime, not null.</remarks>
    public virtual DateTime TimeStamp { get; set; }
    /// <summary>User name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_User"/>
    /// <remarks>Column <c>User</c>: nvarchar(255), null.</remarks>
    public virtual string User { get; set; }
    /// <summary>Permission to edit.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_Write"/>
    /// <remarks>Column <c>Write</c>: bit, null.</remarks>
    public virtual bool? Write { get; set; }
    /// <summary>Permission to edit - the previous value.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_WriteOld"/>
    /// <remarks>Column <c>WriteOld</c>: bit, null.</remarks>
    public virtual bool? WriteOld { get; set; }
}
