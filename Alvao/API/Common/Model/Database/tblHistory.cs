using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Log - history of objects in the tree - move, deletion, insertion, etc.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.html"/>
[Table("dbo.tblHistory")]
public class tblHistory {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.HistoryFlags.html#fields"/>
    public enum HistoryFlags {
        MoveDest = 256,
        MoveSrc = 512,
        MoveTo = 768,
        InsertNew = 1024,
        ToNew = 1280,
        MoveToAutomatically = 2816,
        MoveDestAutomatically = 3072,
        MoveSrcAutomatically = 3328,
        RelationsCopiedFrom = 3329,
        RelationsCopiedTo = 3330,
        RelationsMovedFrom = 3331,
        RelationsMovedTo = 3332,
        ReplacedBy = 3333,
        Replaced = 3334,
    }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.html#Alvao_API_Common_Model_Database_tblHistory_ObjectRuleId"/>
    public virtual int? ObjectRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.html#Alvao_API_Common_Model_Database_tblHistory_RemovedByPersonId"/>
    public virtual int? RemovedByPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.html#Alvao_API_Common_Model_Database_tblHistory_RemovedDate"/>
    public virtual DateTime? RemovedDate { get; set; }
    /// <summary>date and time</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.html#Alvao_API_Common_Model_Database_tblHistory_dteDateTime"/>
    public virtual DateTime? dteDateTime { get; set; }
    /// <summary>
    /// 1 = The child object inserted 2 = Object deleted 4 = Deleted from 8 = Inserted to 256 = Child object inserted
    /// (moved) 512 = Child object deleted (moved) 768 = Move 1024 = A new child object inserted 1280 = Inserted new to
    /// 1536 = Child object inserted (moved) 1792 = Child object deleted (moved) 2048 = Moved to 2304 = A new child
    /// object inserted 2560 = Inserted new to 2816 = Automatic move 3072 = Child object inserted (moved automatically
    /// by rule) 3328 = Child object deleted (moved automatically by rule) 3329 = Relations copied from object 3330 =
    /// Relations copied to object 3331 = Relations moved from object 3332 = Relations moved to object 3333 = Object
    /// replaced by 3334 = Object replaced something
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.html#Alvao_API_Common_Model_Database_tblHistory_intFlags"/>
    public virtual int? intFlags { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.html#Alvao_API_Common_Model_Database_tblHistory_intHistoryId"/>
    [Key]
    public virtual int intHistoryId { get; set; }
    /// <summary>Author of recorded operation - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.html#Alvao_API_Common_Model_Database_tblHistory_liPersonId"/>
    public virtual int liPersonId { get; set; }
    /// <summary>
    /// detection - tblDetect; Null is possible, provided the operation was executed manually without a link to the
    /// detection
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.html#Alvao_API_Common_Model_Database_tblHistory_lintDetectId"/>
    public virtual int? lintDetectId { get; set; }
    /// <summary>object - tblNode; always different from null</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.html#Alvao_API_Common_Model_Database_tblHistory_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <summary>object Y - tblNodeId; This attribute can be NULL, if object Y was removed from the database</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.html#Alvao_API_Common_Model_Database_tblHistory_lintOp2NodeId"/>
    public virtual int? lintOp2NodeId { get; set; }
    /// <summary>object X - tblNodeId; This attribute can be NULL, if object X was removed from the database</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.html#Alvao_API_Common_Model_Database_tblHistory_lintOpNodeId"/>
    public virtual int? lintOpNodeId { get; set; }
    /// <summary>name of object Y including full path</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.html#Alvao_API_Common_Model_Database_tblHistory_txtOp2NodeName"/>
    public virtual string txtOp2NodeName { get; set; }
    /// <summary>name of object X including full path</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.html#Alvao_API_Common_Model_Database_tblHistory_txtOpNodeName"/>
    public virtual string txtOpNodeName { get; set; }
}
