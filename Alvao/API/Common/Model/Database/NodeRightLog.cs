using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Logging of changes in permissions of users in Asset Management.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_NodeRightLog.htm"/>
[TableAttribute("dbo.NodeRightLog")]
public class NodeRightLog
{
    /// <summary>Object kind name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NodeRightLog_Class.htm"/>
    public virtual string Class { get; set; }
    /// <summary>Object kind name - the previous value.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NodeRightLog_ClassOld.htm"/>
    public virtual string ClassOld { get; set; }
    /// <summary>Permission to create any objects.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NodeRightLog_Create.htm"/>
    public virtual bool? Create { get; set; }
    /// <summary>Permission to create any objects - the previous value.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NodeRightLog_CreateOld.htm"/>
    public virtual bool? CreateOld { get; set; }
    /// <summary>Permission to delete.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NodeRightLog_Delete.htm"/>
    public virtual bool? Delete { get; set; }
    /// <summary>Permission to delete - the previous value.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NodeRightLog_DeleteOld.htm"/>
    public virtual bool? DeleteOld { get; set; }
    /// <summary>Group name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NodeRightLog_Group.htm"/>
    public virtual string Group { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NodeRightLog_Id.htm"/>
    [KeyAttribute]
    public virtual int Id { get; set; }
    /// <summary>Logged-in user name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NodeRightLog_ModifiedBy.htm"/>
    public virtual string ModifiedBy { get; set; }
    /// <summary>Permission to move.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NodeRightLog_Move.htm"/>
    public virtual bool? Move { get; set; }
    /// <summary>Permission to move - the previous value.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NodeRightLog_MoveOld.htm"/>
    public virtual bool? MoveOld { get; set; }
    /// <summary>Object name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NodeRightLog_Object.htm"/>
    public virtual string Object { get; set; }
    /// <summary>Object name - the previous value.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NodeRightLog_ObjectOld.htm"/>
    public virtual string ObjectOld { get; set; }
    /// <summary>Permission to read.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NodeRightLog_Read.htm"/>
    public virtual bool? Read { get; set; }
    /// <summary>Permission to read - the previous value.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NodeRightLog_ReadOld.htm"/>
    public virtual bool? ReadOld { get; set; }
    /// <summary>Check box including of child objects.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NodeRightLog_Recursive.htm"/>
    public virtual bool Recursive { get; set; }
    /// <summary>Check box including of child objects - the previous value.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NodeRightLog_RecursiveOld.htm"/>
    public virtual bool? RecursiveOld { get; set; }
    /// <summary>Date and time of the change execution.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NodeRightLog_TimeStamp.htm"/>
    public virtual DateTime TimeStamp { get; set; }
    /// <summary>User name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NodeRightLog_User.htm"/>
    public virtual string User { get; set; }
    /// <summary>Permission to edit.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NodeRightLog_Write.htm"/>
    public virtual bool? Write { get; set; }
    /// <summary>Permission to edit - the previous value.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NodeRightLog_WriteOld.htm"/>
    public virtual bool? WriteOld { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_NodeRightLog__ctor.htm"/>
    public NodeRightLog() { }
}
