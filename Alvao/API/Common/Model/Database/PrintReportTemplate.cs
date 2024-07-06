using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Templates for print reports
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_PrintReportTemplate.htm"/>
[TableAttribute("dbo.PrintReportTemplate")]
public class PrintReportTemplate
{
    /// <summary>Description of template</summary>
    public virtual string Description { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Date and time of last change</summary>
    public virtual DateTime LastModified { get; set; }
    /// <summary>User ID of the person who performed the latest change (tPerson.iPersonId).</summary>
    public virtual int LastModifiedByPersonId { get; set; }
    /// <summary>Template name</summary>
    public virtual string Name { get; set; }

    public PrintReportTemplate() { }
}
