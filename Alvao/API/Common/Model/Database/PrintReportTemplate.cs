using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Templates for print reports</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html"/>
[Table("dbo.PrintReportTemplate")]
public class PrintReportTemplate {
    /// <summary>Description of template</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_Description"/>
    public virtual string Description { get; set; }
    /// <summary>Date and time of last change</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_LastModified"/>
    public virtual DateTime LastModified { get; set; }
    /// <summary>User ID of the person who performed the latest change (tPerson.iPersonId).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_LastModifiedByPersonId"/>
    public virtual int LastModifiedByPersonId { get; set; }
    /// <summary>Template name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_Name"/>
    public virtual string Name { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_id"/>
    [Key]
    public virtual int id { get; set; }
}
