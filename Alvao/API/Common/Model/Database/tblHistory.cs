using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Log - history of objects in the tree - move, deletion, insertion, etc.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblHistory.htm"/>
[TableAttribute("dbo.tblHistory")]
public class tblHistory
{
    /// <summary>date and time</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblHistory_dteDateTime.htm"/>
    public virtual DateTime? dteDateTime { get; set; }
    /// <summary>bit array:1 = moved here "X"2 = moved from here "X"3 = moved to "X"4 = new "X" inserted here5 = created in "X"6 = moved here "X" (scanner)7 = moved from here "X" (scanner)8 = moved from "Y" to "X" (scanner)9 = new "X" inserted here (scanner)10 = created in "X" (scanner)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblHistory_intFlags.htm"/>
    public virtual int? intFlags { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblHistory_intHistoryId.htm"/>
    [KeyAttribute]
    public virtual int intHistoryId { get; set; }
    /// <summary>detection - tblDetect; Null is possible, provided the operation was executed manually without a link to the detection</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblHistory_lintDetectId.htm"/>
    public virtual int? lintDetectId { get; set; }
    /// <summary>object - tblNode; always different from null</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblHistory_lintNodeId.htm"/>
    public virtual int lintNodeId { get; set; }
    /// <summary>object Y - tblNodeId; This attribute can be NULL, if object Y was removed from the database</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblHistory_lintOp2NodeId.htm"/>
    public virtual int? lintOp2NodeId { get; set; }
    /// <summary>object X - tblNodeId; This attribute can be NULL, if object X was removed from the database</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblHistory_lintOpNodeId.htm"/>
    public virtual int? lintOpNodeId { get; set; }
    /// <summary>Author of recorded operation - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblHistory_liPersonId.htm"/>
    public virtual int liPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblHistory_RemovedByPersonId.htm"/>
    public virtual int? RemovedByPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblHistory_RemovedDate.htm"/>
    public virtual DateTime? RemovedDate { get; set; }
    /// <summary>name of object Y including full path</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblHistory_txtOp2NodeName.htm"/>
    public virtual string txtOp2NodeName { get; set; }
    /// <summary>name of object X including full path</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblHistory_txtOpNodeName.htm"/>
    public virtual string txtOpNodeName { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblHistory__ctor.htm"/>
    public tblHistory() { }
}
