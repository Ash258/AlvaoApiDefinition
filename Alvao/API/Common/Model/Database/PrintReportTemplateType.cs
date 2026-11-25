using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplateType.html"/>
[Table("dbo.PrintReportTemplateType")]
public class PrintReportTemplateType {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplateType.html#Alvao_API_Common_Model_Database_PrintReportTemplateType_Name"/>
    public virtual string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplateType.html#Alvao_API_Common_Model_Database_PrintReportTemplateType_id"/>
    [ExplicitKey]
    public virtual int id { get; set; }
}
