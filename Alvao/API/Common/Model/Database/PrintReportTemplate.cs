using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Templates for print reports</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html"/>
[Table("dbo.PrintReportTemplate")]
public class PrintReportTemplate {
    /// <summary>Asset code type ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_AssetCodeTypeId"/>
    public virtual byte? AssetCodeTypeId { get; set; }
    /// <summary>Barcode source property kind ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_BarcodeSourcePropKindId"/>
    public virtual int? BarcodeSourcePropKindId { get; set; }
    /// <summary>Description of template</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_Description"/>
    public virtual string Description { get; set; }
    /// <summary>Page height in mm</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_HeightMm"/>
    public virtual int? HeightMm { get; set; }
    /// <summary>Date and time of last change</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_LastModified"/>
    public virtual DateTime LastModified { get; set; }
    /// <summary>User ID of the person who performed the latest change (tPerson.iPersonId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_LastModifiedByPersonId"/>
    public virtual int LastModifiedByPersonId { get; set; }
    /// <summary>Page margin bottom in mm</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_MarginBottomMm"/>
    public virtual int? MarginBottomMm { get; set; }
    /// <summary>Page margin left in mm</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_MarginLeftMm"/>
    public virtual int? MarginLeftMm { get; set; }
    /// <summary>Page margin right in mm</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_MarginRightMm"/>
    public virtual int? MarginRightMm { get; set; }
    /// <summary>Page margin top in mm</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_MarginTopMm"/>
    public virtual int? MarginTopMm { get; set; }
    /// <summary>Template name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_Name"/>
    public virtual string Name { get; set; }
    /// <summary>Page orientation. NULL, 0 = portrait, 1 = landscape</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_PageOrientation"/>
    public virtual bool? PageOrientation { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_PrintReportTemplateTypeId"/>
    public virtual int? PrintReportTemplateTypeId { get; set; }
    /// <summary>Print page &quot;X from Y&quot; information in the footer of each page</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_ShowPageNumbers"/>
    public virtual bool? ShowPageNumbers { get; set; }
    /// <summary>Page width in mm</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_WidthMm"/>
    public virtual int? WidthMm { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_id"/>
    [Key]
    public virtual int id { get; set; }
}
