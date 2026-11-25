using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Templates for print reports</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html"/>
[Table("dbo.PrintReportTemplate")]
public class PrintReportTemplate {
    /// <summary>Asset code type ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_AssetCodeTypeId"/>
    /// <remarks>
    /// Column <c>AssetCodeTypeId</c>: tinyint, null. References <see cref="PrintTemplateAssetCodeType"/>.
    /// </remarks>
    public virtual byte? AssetCodeTypeId { get; set; }
    /// <summary>Barcode source property kind ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_BarcodeSourcePropKindId"/>
    /// <remarks>Column <c>BarcodeSourcePropKindId</c>: int, null. References <see cref="tblKind"/>.</remarks>
    public virtual int? BarcodeSourcePropKindId { get; set; }
    /// <summary>Description of template</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_Description"/>
    /// <remarks>Column <c>Description</c>: nvarchar(max), null.</remarks>
    public virtual string Description { get; set; }
    /// <summary>Page height in mm</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_HeightMm"/>
    /// <remarks>Column <c>HeightMm</c>: int, null.</remarks>
    public virtual int? HeightMm { get; set; }
    /// <summary>Date and time of last change</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_LastModified"/>
    /// <remarks>Column <c>LastModified</c>: datetime, not null.</remarks>
    public virtual DateTime LastModified { get; set; }
    /// <summary>User ID of the person who performed the latest change (tPerson.iPersonId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_LastModifiedByPersonId"/>
    /// <remarks>Column <c>LastModifiedByPersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int LastModifiedByPersonId { get; set; }
    /// <summary>Page margin bottom in mm</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_MarginBottomMm"/>
    /// <remarks>Column <c>MarginBottomMm</c>: int, null.</remarks>
    public virtual int? MarginBottomMm { get; set; }
    /// <summary>Page margin left in mm</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_MarginLeftMm"/>
    /// <remarks>Column <c>MarginLeftMm</c>: int, null.</remarks>
    public virtual int? MarginLeftMm { get; set; }
    /// <summary>Page margin right in mm</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_MarginRightMm"/>
    /// <remarks>Column <c>MarginRightMm</c>: int, null.</remarks>
    public virtual int? MarginRightMm { get; set; }
    /// <summary>Page margin top in mm</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_MarginTopMm"/>
    /// <remarks>Column <c>MarginTopMm</c>: int, null.</remarks>
    public virtual int? MarginTopMm { get; set; }
    /// <summary>Template name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(255), not null.</remarks>
    public virtual string Name { get; set; }
    /// <summary>Page orientation. NULL, 0 = portrait, 1 = landscape</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_PageOrientation"/>
    /// <remarks>Column <c>PageOrientation</c>: bit, null.</remarks>
    public virtual bool? PageOrientation { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_PrintReportTemplateTypeId"/>
    /// <remarks>
    /// Column <c>PrintReportTemplateTypeId</c>: int, null. References <see cref="PrintReportTemplateType"/>.
    /// </remarks>
    public virtual int? PrintReportTemplateTypeId { get; set; }
    /// <summary>Print page &quot;X from Y&quot; information in the footer of each page</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_ShowPageNumbers"/>
    /// <remarks>Column <c>ShowPageNumbers</c>: bit, null.</remarks>
    public virtual bool? ShowPageNumbers { get; set; }
    /// <summary>Page width in mm</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_WidthMm"/>
    /// <remarks>Column <c>WidthMm</c>: int, null.</remarks>
    public virtual int? WidthMm { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintReportTemplate.html#Alvao_API_Common_Model_Database_PrintReportTemplate_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
