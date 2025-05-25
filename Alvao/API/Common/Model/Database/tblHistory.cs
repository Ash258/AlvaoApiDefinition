using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Log - history of objects in the tree - move, deletion, insertion, etc.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.html"/>
[Table("dbo.tblHistory")]
public class tblHistory {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.HistoryFlags.html#fields"/>
    public enum HistoryFlags {
        InsertNew = 1024,
        MoveDest = 256,
        MoveSrc = 512,
        MoveTo = 768,
        ToNew = 1280,
    }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.html#Alvao_API_Common_Model_Database_tblHistory_RemovedByPersonId"/>
    public virtual int? RemovedByPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.html#Alvao_API_Common_Model_Database_tblHistory_RemovedDate"/>
    public virtual DateTime? RemovedDate { get; set; }
    /// <summary>date and time</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.html#Alvao_API_Common_Model_Database_tblHistory_dteDateTime"/>
    public virtual DateTime? dteDateTime { get; set; }
    /// <summary>bit array: 1 = moved here &quot;X&quot; 2 = moved from here &quot;X&quot; 3 = moved to &quot;X&quot; 4 = new &quot;X&quot; inserted here 5 = created in &quot;X&quot; 6 = moved here &quot;X&quot; (scanner) 7 = moved from here &quot;X&quot; (scanner) 8 = moved from &quot;Y&quot; to &quot;X&quot; (scanner) 9 = new &quot;X&quot; inserted here (scanner) 10 = created in &quot;X&quot; (scanner)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.html#Alvao_API_Common_Model_Database_tblHistory_intFlags"/>
    public virtual int? intFlags { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.html#Alvao_API_Common_Model_Database_tblHistory_intHistoryId"/>
    [Key]
    public virtual int intHistoryId { get; set; }
    /// <summary>Author of recorded operation - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.html#Alvao_API_Common_Model_Database_tblHistory_liPersonId"/>
    public virtual int liPersonId { get; set; }
    /// <summary>detection - tblDetect; Null is possible, provided the operation was executed manually without a link to the detection</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.html#Alvao_API_Common_Model_Database_tblHistory_lintDetectId"/>
    public virtual int? lintDetectId { get; set; }
    /// <summary>object - tblNode; always different from null</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.html#Alvao_API_Common_Model_Database_tblHistory_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <summary>object Y - tblNodeId; This attribute can be NULL, if object Y was removed from the database</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.html#Alvao_API_Common_Model_Database_tblHistory_lintOp2NodeId"/>
    public virtual int? lintOp2NodeId { get; set; }
    /// <summary>object X - tblNodeId; This attribute can be NULL, if object X was removed from the database</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.html#Alvao_API_Common_Model_Database_tblHistory_lintOpNodeId"/>
    public virtual int? lintOpNodeId { get; set; }
    /// <summary>name of object Y including full path</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.html#Alvao_API_Common_Model_Database_tblHistory_txtOp2NodeName"/>
    public virtual string txtOp2NodeName { get; set; }
    /// <summary>name of object X including full path</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblHistory.html#Alvao_API_Common_Model_Database_tblHistory_txtOpNodeName"/>
    public virtual string txtOpNodeName { get; set; }
}
