using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Logging of changes in permissions of users in Asset Management.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html"/>
[Table("dbo.NodeRightLog")]
public class NodeRightLog {
    /// <summary>Object type name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_Class"/>
    public virtual string Class { get; set; }
    /// <summary>Object type name - the previous value.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_ClassOld"/>
    public virtual string ClassOld { get; set; }
    /// <summary>Permission to create any objects.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_Create"/>
    public virtual bool? Create { get; set; }
    /// <summary>Permission to create any objects - the previous value.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_CreateOld"/>
    public virtual bool? CreateOld { get; set; }
    /// <summary>Permission to delete.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_Delete"/>
    public virtual bool? Delete { get; set; }
    /// <summary>Permission to delete - the previous value.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_DeleteOld"/>
    public virtual bool? DeleteOld { get; set; }
    /// <summary>Group name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_Group"/>
    public virtual string Group { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_Id"/>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Logged-in user name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_ModifiedBy"/>
    public virtual string ModifiedBy { get; set; }
    /// <summary>Permission to move.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_Move"/>
    public virtual bool? Move { get; set; }
    /// <summary>Permission to move - the previous value.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_MoveOld"/>
    public virtual bool? MoveOld { get; set; }
    /// <summary>Object name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_Object"/>
    public virtual string Object { get; set; }
    /// <summary>Object name - the previous value.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_ObjectOld"/>
    public virtual string ObjectOld { get; set; }
    /// <summary>Permission to read.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_Read"/>
    public virtual bool? Read { get; set; }
    /// <summary>Permission to read - the previous value.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_ReadOld"/>
    public virtual bool? ReadOld { get; set; }
    /// <summary>Check box including of child objects.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_Recursive"/>
    public virtual bool Recursive { get; set; }
    /// <summary>Check box including of child objects - the previous value.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_RecursiveOld"/>
    public virtual bool? RecursiveOld { get; set; }
    /// <summary>Date and time of the change execution.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_TimeStamp"/>
    public virtual DateTime TimeStamp { get; set; }
    /// <summary>User name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_User"/>
    public virtual string User { get; set; }
    /// <summary>Permission to edit.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_Write"/>
    public virtual bool? Write { get; set; }
    /// <summary>Permission to edit - the previous value.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRightLog.html#Alvao_API_Common_Model_Database_NodeRightLog_WriteOld"/>
    public virtual bool? WriteOld { get; set; }
}
