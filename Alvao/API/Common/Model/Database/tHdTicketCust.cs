using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Ticket custom fields values.<br/><br/>!!!CAUTION: This class is not part of the API documentation. It was generated
/// from the database documentation
/// </summary>
/// <see href="https://doc.alvao.com/en/26/admin-guide/customization/alvao-database/tables/#U_dbo.tHdTicketCust"/>
[Table("dbo.tHdTicketCust")]
public class tHdTicketCust {
    /// <summary>Link to ticket to which the values belong.</summary>
    /// <remarks>Column <c>liHdTicketId</c>: int, not null. References <see cref="tHdTicket"/>.</remarks>
    public virtual int liHdTicketId { get; set; }
    /// <remarks>Column <c>ProblemCandidate</c>: bit, null.</remarks>
    public virtual bool? ProblemCandidate { get; set; }
    /// <remarks>Column <c>IncidentClosureCode</c>: int, null.</remarks>
    public virtual int? IncidentClosureCode { get; set; }
    /// <remarks>Column <c>AccessToInternalSyst</c>: bit, null.</remarks>
    public virtual bool? AccessToInternalSyst { get; set; }
    /// <remarks>Column <c>vendorSecCompliance</c>: int, null.</remarks>
    public virtual int? vendorSecCompliance { get; set; }
    /// <remarks>Column <c>vendorRiskAnalysis</c>: int, null.</remarks>
    public virtual int? vendorRiskAnalysis { get; set; }
    /// <remarks>Column <c>vendorNDA</c>: int, null.</remarks>
    public virtual int? vendorNDA { get; set; }
    /// <remarks>Column <c>changeDocUrl</c>: nvarchar(256), null.</remarks>
    public virtual string changeDocUrl { get; set; }
    /// <remarks>Column <c>NadrizenyPracovnik</c>: int, null.</remarks>
    public virtual int? NadrizenyPracovnik { get; set; }
    /// <remarks>Column <c>IssuesFound</c>: nvarchar(256), null.</remarks>
    public virtual string IssuesFound { get; set; }
    /// <remarks>Column <c>severityOfVulnerability</c>: int, null.</remarks>
    public virtual int? severityOfVulnerability { get; set; }
    /// <remarks>Column <c>Changeend</c>: datetime, null.</remarks>
    public virtual DateTime? Changeend { get; set; }
    /// <remarks>Column <c>Changestart</c>: datetime, null.</remarks>
    public virtual DateTime? Changestart { get; set; }
    /// <remarks>Column <c>RiskLevel</c>: int, null.</remarks>
    public virtual int? RiskLevel { get; set; }
    /// <remarks>Column <c>changeEndActual</c>: datetime, null.</remarks>
    public virtual DateTime? changeEndActual { get; set; }
    /// <remarks>Column <c>changeStartActual</c>: datetime, null.</remarks>
    public virtual DateTime? changeStartActual { get; set; }
    /// <remarks>Column <c>RiskDescription</c>: nvarchar(256), null.</remarks>
    public virtual string RiskDescription { get; set; }
    /// <remarks>Column <c>successfulChange</c>: bit, null.</remarks>
    public virtual bool? successfulChange { get; set; }
    /// <remarks>Column <c>overranChangeWindow</c>: bit, null.</remarks>
    public virtual bool? overranChangeWindow { get; set; }
    /// <remarks>Column <c>symptoms</c>: nvarchar(max), null.</remarks>
    public virtual string symptoms { get; set; }
    /// <remarks>Column <c>diagnosis</c>: nvarchar(max), null.</remarks>
    public virtual string diagnosis { get; set; }
    /// <remarks>Column <c>rootCause</c>: nvarchar(max), null.</remarks>
    public virtual string rootCause { get; set; }
    /// <remarks>Column <c>workaround</c>: nvarchar(max), null.</remarks>
    public virtual string workaround { get; set; }
    /// <remarks>Column <c>methodOfResolution</c>: nvarchar(max), null.</remarks>
    public virtual string methodOfResolution { get; set; }
    /// <remarks>Column <c>ProblemClosureCode</c>: int, null.</remarks>
    public virtual int? ProblemClosureCode { get; set; }
    /// <remarks>Column <c>FiveWhys</c>: nvarchar(256), null.</remarks>
    public virtual string FiveWhys { get; set; }
    /// <remarks>Column <c>UserName</c>: nvarchar(256), null.</remarks>
    public virtual string UserName { get; set; }
    /// <remarks>Column <c>UserSurname</c>: nvarchar(256), null.</remarks>
    public virtual string UserSurname { get; set; }
    /// <remarks>Column <c>TripDeparture</c>: datetime, null.</remarks>
    public virtual DateTime? TripDeparture { get; set; }
    /// <remarks>Column <c>TripReturn</c>: datetime, null.</remarks>
    public virtual DateTime? TripReturn { get; set; }
    /// <remarks>Column <c>TripPurpose</c>: nvarchar(256), null.</remarks>
    public virtual string TripPurpose { get; set; }
    /// <remarks>Column <c>TripTransport</c>: nvarchar(256), null.</remarks>
    public virtual string TripTransport { get; set; }
    /// <remarks>Column <c>Department</c>: int, null.</remarks>
    public virtual int? Department { get; set; }
    /// <remarks>Column <c>PositionName</c>: int, null.</remarks>
    public virtual int? PositionName { get; set; }
    /// <remarks>Column <c>Manager</c>: int, null.</remarks>
    public virtual int? Manager { get; set; }
    /// <remarks>Column <c>Locality</c>: int, null.</remarks>
    public virtual int? Locality { get; set; }
    /// <remarks>Column <c>FirstDay</c>: date, null.</remarks>
    public virtual DateTime? FirstDay { get; set; }
    /// <remarks>Column <c>ContractAgreementOn</c>: int, null.</remarks>
    public virtual int? ContractAgreementOn { get; set; }
    /// <remarks>Column <c>NumberOfMonths</c>: int, null.</remarks>
    public virtual int? NumberOfMonths { get; set; }
    /// <remarks>Column <c>Laptop</c>: bit, null.</remarks>
    public virtual bool? Laptop { get; set; }
    /// <remarks>Column <c>StandardDesktopKit_i</c>: bit, null.</remarks>
    public virtual bool? StandardDesktopKit_i { get; set; }
    /// <remarks>Column <c>MobilePhone</c>: bit, null.</remarks>
    public virtual bool? MobilePhone { get; set; }
    /// <remarks>Column <c>Car</c>: bit, null.</remarks>
    public virtual bool? Car { get; set; }
    /// <remarks>Column <c>OtherTraining</c>: nvarchar(256), null.</remarks>
    public virtual string OtherTraining { get; set; }
    /// <remarks>Column <c>DescribePotentialSpe</c>: nvarchar(max), null.</remarks>
    public virtual string DescribePotentialSpe { get; set; }
    /// <remarks>Column <c>ContractType</c>: int, null.</remarks>
    public virtual int? ContractType { get; set; }
    /// <remarks>Column <c>MobilePackage</c>: int, null.</remarks>
    public virtual int? MobilePackage { get; set; }
    /// <remarks>Column <c>LostOrStolen</c>: int, null.</remarks>
    public virtual int? LostOrStolen { get; set; }
    /// <remarks>Column <c>Url</c>: nvarchar(256), null.</remarks>
    public virtual string Url { get; set; }
}
