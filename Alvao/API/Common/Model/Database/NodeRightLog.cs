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
    public virtual string Class { get; set; }
    /// <summary>Object kind name - the previous value.</summary>
    public virtual string ClassOld { get; set; }
    /// <summary>Permission to create any objects.</summary>
    public virtual bool? Create { get; set; }
    /// <summary>Permission to create any objects - the previous value.</summary>
    public virtual bool? CreateOld { get; set; }
    /// <summary>Permission to delete.</summary>
    public virtual bool? Delete { get; set; }
    /// <summary>Permission to delete - the previous value.</summary>
    public virtual bool? DeleteOld { get; set; }
    /// <summary>Group name.</summary>
    public virtual string Group { get; set; }
    /// <summary>Record ID.</summary>
    [KeyAttribute]
    public virtual int Id { get; set; }
    /// <summary>Logged-in user name.</summary>
    public virtual string ModifiedBy { get; set; }
    /// <summary>Permission to move.</summary>
    public virtual bool? Move { get; set; }
    /// <summary>Permission to move - the previous value.</summary>
    public virtual bool? MoveOld { get; set; }
    /// <summary>Object name.</summary>
    public virtual string Object { get; set; }
    /// <summary>Object name - the previous value.</summary>
    public virtual string ObjectOld { get; set; }
    /// <summary>Permission to read.</summary>
    public virtual bool? Read { get; set; }
    /// <summary>Permission to read - the previous value.</summary>
    public virtual bool? ReadOld { get; set; }
    /// <summary>Check box including of child objects.</summary>
    public virtual bool Recursive { get; set; }
    /// <summary>Check box including of child objects - the previous value.</summary>
    public virtual bool? RecursiveOld { get; set; }
    /// <summary>Date and time of the change execution.</summary>
    public virtual DateTime TimeStamp { get; set; }
    /// <summary>User name.</summary>
    public virtual string User { get; set; }
    /// <summary>Permission to edit.</summary>
    public virtual bool? Write { get; set; }
    /// <summary>Permission to edit - the previous value.</summary>
    public virtual bool? WriteOld { get; set; }

    public NodeRightLog() { }
}
