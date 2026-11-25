using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Services custom fields values.<br/><br/>!!!CAUTION: This class is not part of the API documentation. It was
/// generated from the database documentation
/// </summary>
/// <see href="https://doc.alvao.com/en/26/admin-guide/customization/alvao-database/tables/#U_dbo.tHdSectionCust"/>
[Table("dbo.tHdSectionCust")]
public class tHdSectionCust {
    /// <remarks>Column <c>liHdSectionId</c>: int, null. References <see cref="tHdSection"/>.</remarks>
    public virtual int? liHdSectionId { get; set; }
    /// <remarks>Column <c>RequestForHwCatalogPath</c>: nvarchar(max), null.</remarks>
    public virtual string RequestForHwCatalogPath { get; set; }
    /// <remarks>Column <c>RequestForHwCategories</c>: nvarchar(max), null.</remarks>
    public virtual string RequestForHwCategories { get; set; }
    /// <remarks>Column <c>RequestForHwCurrency</c>: nvarchar(256), null.</remarks>
    public virtual string RequestForHwCurrency { get; set; }
    /// <remarks>Column <c>ServiceCi</c>: int, null.</remarks>
    public virtual int? ServiceCi { get; set; }
    /// <remarks>Column <c>cause</c>: nvarchar(256), null.</remarks>
    public virtual string cause { get; set; }
    /// <remarks>Column <c>ServiceClass</c>: int, null.</remarks>
    public virtual int? ServiceClass { get; set; }
    /// <remarks>Column <c>ServiceKind</c>: nvarchar(256), null.</remarks>
    public virtual string ServiceKind { get; set; }
    /// <remarks>Column <c>ServiceNodeId</c>: int, null.</remarks>
    public virtual int? ServiceNodeId { get; set; }
    /// <remarks>Column <c>ExtAppSettings</c>: nvarchar(max), null.</remarks>
    public virtual string ExtAppSettings { get; set; }
    /// <remarks>Column <c>SectionSimilarityVector</c>: nvarchar(max), null.</remarks>
    public virtual string SectionSimilarityVector { get; set; }
    /// <remarks>Column <c>CreateSolutionProposal</c>: bit, null.</remarks>
    public virtual bool? CreateSolutionProposal { get; set; }
    /// <remarks>Column <c>MajorIncidentScore</c>: float, null.</remarks>
    public virtual double? MajorIncidentScore { get; set; }
    /// <remarks>Column <c>LastVectorTicketId</c>: int, null.</remarks>
    public virtual int? LastVectorTicketId { get; set; }
    /// <remarks>Column <c>CommunicationVector</c>: nvarchar(max), null.</remarks>
    public virtual string CommunicationVector { get; set; }
    /// <remarks>Column <c>FieldsVector</c>: nvarchar(max), null.</remarks>
    public virtual string FieldsVector { get; set; }
    /// <remarks>Column <c>ObjectsVector</c>: nvarchar(max), null.</remarks>
    public virtual string ObjectsVector { get; set; }
    /// <remarks>Column <c>ExpectedCost</c>: int, null.</remarks>
    public virtual int? ExpectedCost { get; set; }
    /// <remarks>Column <c>ExpectedRiskLevel</c>: int, null.</remarks>
    public virtual int? ExpectedRiskLevel { get; set; }
    /// <remarks>Column <c>ServiceOwner</c>: int, null.</remarks>
    public virtual int? ServiceOwner { get; set; }
}
