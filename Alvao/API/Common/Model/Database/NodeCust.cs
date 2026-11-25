using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Object property values<br/><br/>!!!CAUTION: This class is not part of the API documentation. It was generated from
/// the database documentation
/// </summary>
/// <see href="https://doc.alvao.com/en/26/admin-guide/customization/alvao-database/tables/#U_dbo.NodeCust"/>
[Table("dbo.NodeCust")]
public class NodeCust {
    /// <summary>ID of object (tblNode.intNodeId)</summary>
    /// <remarks>Column <c>NodeId</c>: int, not null. References <see cref="tblNode"/>.</remarks>
    public virtual int NodeId { get; set; }
    /// <summary>System column with sparse column set information.</summary>
    /// <remarks>Column <c>ColumnSet</c>: xml, null.</remarks>
    public virtual string ColumnSet { get; set; }
    /// <remarks>Column <c>Name</c>: nvarchar(255), null.</remarks>
    public virtual string Name { get; set; }
    /// <remarks>Column <c>ComputerSetName</c>: nvarchar(255), null.</remarks>
    public virtual string ComputerSetName { get; set; }
    /// <remarks>Column <c>Hostname</c>: nvarchar(255), null.</remarks>
    public virtual string Hostname { get; set; }
    /// <remarks>Column <c>NetworkBranchName</c>: nvarchar(255), null.</remarks>
    public virtual string NetworkBranchName { get; set; }
    /// <remarks>Column <c>User</c>: nvarchar(255), null.</remarks>
    public virtual string User { get; set; }
    /// <remarks>Column <c>Note</c>: nvarchar(255), null.</remarks>
    public virtual string Note { get; set; }
    /// <remarks>Column <c>Location</c>: nvarchar(255), null.</remarks>
    public virtual string Location { get; set; }
    /// <remarks>Column <c>Address</c>: nvarchar(255), null.</remarks>
    public virtual string Address { get; set; }
    /// <remarks>Column <c>OrganizationCode</c>: nvarchar(255), null.</remarks>
    public virtual string OrganizationCode { get; set; }
    /// <remarks>Column <c>TypeDesignation</c>: nvarchar(255), null.</remarks>
    public virtual string TypeDesignation { get; set; }
    /// <remarks>Column <c>InventoryNumber</c>: nvarchar(255), null.</remarks>
    public virtual string InventoryNumber { get; set; }
    /// <remarks>Column <c>SerialNumber</c>: nvarchar(255), null.</remarks>
    public virtual string SerialNumber { get; set; }
    /// <remarks>Column <c>PackingSlipNumber</c>: nvarchar(255), null.</remarks>
    public virtual string PackingSlipNumber { get; set; }
    /// <remarks>Column <c>Port</c>: nvarchar(255), null.</remarks>
    public virtual string Port { get; set; }
    /// <remarks>Column <c>Manufacturer</c>: nvarchar(255), null.</remarks>
    public virtual string Manufacturer { get; set; }
    /// <remarks>Column <c>Type</c>: nvarchar(255), null.</remarks>
    public virtual string Type { get; set; }
    /// <remarks>Column <c>Frequency</c>: nvarchar(255), null.</remarks>
    public virtual string Frequency { get; set; }
    /// <remarks>Column <c>RefreshMaximum</c>: nvarchar(255), null.</remarks>
    public virtual string RefreshMaximum { get; set; }
    /// <remarks>Column <c>RefreshMinimum</c>: nvarchar(255), null.</remarks>
    public virtual string RefreshMinimum { get; set; }
    /// <remarks>Column <c>HorizontalResolution</c>: nvarchar(255), null.</remarks>
    public virtual string HorizontalResolution { get; set; }
    /// <remarks>Column <c>VerticalResolution</c>: nvarchar(255), null.</remarks>
    public virtual string VerticalResolution { get; set; }
    /// <remarks>Column <c>Version</c>: nvarchar(255), null.</remarks>
    public virtual string Version { get; set; }
    /// <remarks>Column <c>Codepage</c>: nvarchar(255), null.</remarks>
    public virtual string Codepage { get; set; }
    /// <remarks>Column <c>CountryCode</c>: nvarchar(255), null.</remarks>
    public virtual string CountryCode { get; set; }
    /// <remarks>Column <c>FileSystem</c>: nvarchar(255), null.</remarks>
    public virtual string FileSystem { get; set; }
    /// <remarks>Column <c>LogicalDevice</c>: nvarchar(255), null.</remarks>
    public virtual string LogicalDevice { get; set; }
    /// <remarks>Column <c>PictureWidth</c>: nvarchar(255), null.</remarks>
    public virtual string PictureWidth { get; set; }
    /// <remarks>Column <c>PictureHeight</c>: nvarchar(255), null.</remarks>
    public virtual string PictureHeight { get; set; }
    /// <remarks>Column <c>__order</c>: nvarchar(255), null.</remarks>
    public virtual string __order { get; set; }
    /// <remarks>Column <c>NumberOfLicenses</c>: nvarchar(255), null.</remarks>
    public virtual string NumberOfLicenses { get; set; }
    /// <remarks>Column <c>Building</c>: nvarchar(255), null.</remarks>
    public virtual string Building { get; set; }
    /// <remarks>Column <c>Floor</c>: nvarchar(255), null.</remarks>
    public virtual string Floor { get; set; }
    /// <remarks>Column <c>Room</c>: nvarchar(255), null.</remarks>
    public virtual string Room { get; set; }
    /// <remarks>Column <c>Vendor</c>: nvarchar(255), null.</remarks>
    public virtual string Vendor { get; set; }
    /// <remarks>Column <c>Department</c>: nvarchar(255), null.</remarks>
    public virtual string Department { get; set; }
    /// <remarks>Column <c>PurchaseDate</c>: date, null.</remarks>
    public virtual DateTime? PurchaseDate { get; set; }
    /// <remarks>Column <c>Warranty</c>: nvarchar(255), null.</remarks>
    public virtual string Warranty { get; set; }
    /// <remarks>Column <c>Description</c>: nvarchar(255), null.</remarks>
    public virtual string Description { get; set; }
    /// <remarks>Column <c>DateOfNextServiceInspection</c>: date, null.</remarks>
    public virtual DateTime? DateOfNextServiceInspection { get; set; }
    /// <remarks>Column <c>Phone</c>: nvarchar(255), null.</remarks>
    public virtual string Phone { get; set; }
    /// <remarks>Column <c>Fax</c>: nvarchar(255), null.</remarks>
    public virtual string Fax { get; set; }
    /// <remarks>Column <c>Email</c>: nvarchar(255), null.</remarks>
    public virtual string Email { get; set; }
    /// <remarks>Column <c>ContactPerson</c>: nvarchar(255), null.</remarks>
    public virtual string ContactPerson { get; set; }
    /// <remarks>Column <c>OrganizationName</c>: nvarchar(255), null.</remarks>
    public virtual string OrganizationName { get; set; }
    /// <remarks>Column <c>Price</c>: nvarchar(255), null.</remarks>
    public virtual string Price { get; set; }
    /// <remarks>Column <c>Size</c>: nvarchar(255), null.</remarks>
    public virtual string Size { get; set; }
    /// <remarks>Column <c>Website</c>: nvarchar(255), null.</remarks>
    public virtual string Website { get; set; }
    /// <remarks>Column <c>Password</c>: nvarchar(255), null.</remarks>
    public virtual string Password { get; set; }
    /// <remarks>Column <c>UserName</c>: nvarchar(255), null.</remarks>
    public virtual string UserName { get; set; }
    /// <remarks>Column <c>CostCenter</c>: nvarchar(255), null.</remarks>
    public virtual string CostCenter { get; set; }
    /// <remarks>Column <c>Segment</c>: nvarchar(255), null.</remarks>
    public virtual string Segment { get; set; }
    /// <remarks>Column <c>Unit</c>: nvarchar(255), null.</remarks>
    public virtual string Unit { get; set; }
    /// <remarks>Column <c>SubnetName</c>: nvarchar(255), null.</remarks>
    public virtual string SubnetName { get; set; }
    /// <remarks>Column <c>MacAddress</c>: nvarchar(255), null.</remarks>
    public virtual string MacAddress { get; set; }
    /// <remarks>Column <c>IpAddress</c>: nvarchar(255), null.</remarks>
    public virtual string IpAddress { get; set; }
    /// <remarks>Column <c>DnsDomain</c>: nvarchar(255), null.</remarks>
    public virtual string DnsDomain { get; set; }
    /// <remarks>Column <c>DhcpServer</c>: nvarchar(255), null.</remarks>
    public virtual string DhcpServer { get; set; }
    /// <remarks>Column <c>IpxAddress</c>: nvarchar(255), null.</remarks>
    public virtual string IpxAddress { get; set; }
    /// <remarks>Column <c>Irq</c>: nvarchar(255), null.</remarks>
    public virtual string Irq { get; set; }
    /// <remarks>Column <c>DiskInterface</c>: nvarchar(255), null.</remarks>
    public virtual string DiskInterface { get; set; }
    /// <remarks>Column <c>PersonalNumber</c>: nvarchar(255), null.</remarks>
    public virtual string PersonalNumber { get; set; }
    /// <remarks>Column <c>Office</c>: nvarchar(255), null.</remarks>
    public virtual string Office { get; set; }
    /// <remarks>Column <c>Facility</c>: nvarchar(255), null.</remarks>
    public virtual string Facility { get; set; }
    /// <remarks>Column <c>Diagonal</c>: nvarchar(255), null.</remarks>
    public virtual string Diagonal { get; set; }
    /// <remarks>Column <c>ComputerKind</c>: nvarchar(255), null.</remarks>
    public virtual string ComputerKind { get; set; }
    /// <remarks>Column <c>BiosSerialNumber</c>: nvarchar(255), null.</remarks>
    public virtual string BiosSerialNumber { get; set; }
    /// <remarks>Column <c>Subdivision</c>: nvarchar(255), null.</remarks>
    public virtual string Subdivision { get; set; }
    /// <remarks>Column <c>Site</c>: nvarchar(255), null.</remarks>
    public virtual string Site { get; set; }
    /// <remarks>Column <c>Division</c>: nvarchar(255), null.</remarks>
    public virtual string Division { get; set; }
    /// <remarks>Column <c>Section</c>: nvarchar(255), null.</remarks>
    public virtual string Section { get; set; }
    /// <remarks>Column <c>Subsidiary</c>: nvarchar(255), null.</remarks>
    public virtual string Subsidiary { get; set; }
    /// <remarks>Column <c>Sockets</c>: nvarchar(255), null.</remarks>
    public virtual string Sockets { get; set; }
    /// <remarks>Column <c>Model</c>: nvarchar(255), null.</remarks>
    public virtual string Model { get; set; }
    /// <remarks>Column <c>CaseKind</c>: nvarchar(255), null.</remarks>
    public virtual string CaseKind { get; set; }
    /// <remarks>Column <c>PartOfTheDomain</c>: nvarchar(255), null.</remarks>
    public virtual string PartOfTheDomain { get; set; }
    /// <remarks>Column <c>Quantity</c>: nvarchar(255), null.</remarks>
    public virtual string Quantity { get; set; }
    /// <remarks>Column <c>AssetCategory</c>: nvarchar(255), null.</remarks>
    public virtual string AssetCategory { get; set; }
    /// <remarks>Column <c>AssetNumber</c>: nvarchar(255), null.</remarks>
    public virtual string AssetNumber { get; set; }
    /// <remarks>Column <c>AssetCheckDate</c>: date, null.</remarks>
    public virtual DateTime? AssetCheckDate { get; set; }
    /// <remarks>Column <c>WarrantyExpiration</c>: date, null.</remarks>
    public virtual DateTime? WarrantyExpiration { get; set; }
    /// <remarks>Column <c>MobilePhone</c>: nvarchar(255), null.</remarks>
    public virtual string MobilePhone { get; set; }
    /// <remarks>Column <c>Position</c>: nvarchar(255), null.</remarks>
    public virtual string Position { get; set; }
    /// <remarks>Column <c>City</c>: nvarchar(255), null.</remarks>
    public virtual string City { get; set; }
    /// <remarks>Column <c>Street</c>: nvarchar(255), null.</remarks>
    public virtual string Street { get; set; }
    /// <remarks>Column <c>Country</c>: nvarchar(255), null.</remarks>
    public virtual string Country { get; set; }
    /// <remarks>Column <c>Company</c>: nvarchar(255), null.</remarks>
    public virtual string Company { get; set; }
    /// <remarks>Column <c>PoBox</c>: nvarchar(255), null.</remarks>
    public virtual string PoBox { get; set; }
    /// <remarks>Column <c>StateOrProvince</c>: nvarchar(255), null.</remarks>
    public virtual string StateOrProvince { get; set; }
    /// <remarks>Column <c>ZipCode</c>: nvarchar(255), null.</remarks>
    public virtual string ZipCode { get; set; }
    /// <remarks>Column <c>HomePhone</c>: nvarchar(255), null.</remarks>
    public virtual string HomePhone { get; set; }
    /// <remarks>Column <c>Pager</c>: nvarchar(255), null.</remarks>
    public virtual string Pager { get; set; }
    /// <remarks>Column <c>IpPhone</c>: nvarchar(255), null.</remarks>
    public virtual string IpPhone { get; set; }
    /// <remarks>Column <c>ScreenResolution</c>: nvarchar(255), null.</remarks>
    public virtual string ScreenResolution { get; set; }
    /// <remarks>Column <c>MonitorType</c>: nvarchar(255), null.</remarks>
    public virtual string MonitorType { get; set; }
    /// <remarks>Column <c>Imei</c>: nvarchar(255), null.</remarks>
    public virtual string Imei { get; set; }
    /// <remarks>Column <c>DataRecordingMedium</c>: nvarchar(255), null.</remarks>
    public virtual string DataRecordingMedium { get; set; }
    /// <remarks>Column <c>PhoneNumber</c>: nvarchar(255), null.</remarks>
    public virtual string PhoneNumber { get; set; }
    /// <remarks>Column <c>ModemInterface</c>: nvarchar(255), null.</remarks>
    public virtual string ModemInterface { get; set; }
    /// <remarks>Column <c>DataService</c>: nvarchar(255), null.</remarks>
    public virtual string DataService { get; set; }
    /// <remarks>Column <c>MemoryCardType</c>: nvarchar(255), null.</remarks>
    public virtual string MemoryCardType { get; set; }
    /// <remarks>Column <c>KeyFor</c>: nvarchar(255), null.</remarks>
    public virtual string KeyFor { get; set; }
    /// <remarks>Column <c>Color</c>: nvarchar(255), null.</remarks>
    public virtual string Color { get; set; }
    /// <remarks>Column <c>LicensePlateNumber</c>: nvarchar(255), null.</remarks>
    public virtual string LicensePlateNumber { get; set; }
    /// <remarks>Column <c>TechnicalInspectionValidUntil</c>: date, null.</remarks>
    public virtual DateTime? TechnicalInspectionValidUntil { get; set; }
    /// <remarks>Column <c>Tariff</c>: nvarchar(255), null.</remarks>
    public virtual string Tariff { get; set; }
    /// <remarks>Column <c>ServerFarmName</c>: nvarchar(255), null.</remarks>
    public virtual string ServerFarmName { get; set; }
    /// <remarks>Column <c>CloudName</c>: nvarchar(255), null.</remarks>
    public virtual string CloudName { get; set; }
    /// <remarks>Column <c>HostComputer</c>: nvarchar(255), null.</remarks>
    public virtual string HostComputer { get; set; }
    /// <remarks>Column <c>LastLoggedOnUser</c>: nvarchar(255), null.</remarks>
    public virtual string LastLoggedOnUser { get; set; }
    /// <remarks>Column <c>PersonResponsibleForSoftware</c>: nvarchar(255), null.</remarks>
    public virtual string PersonResponsibleForSoftware { get; set; }
    /// <remarks>Column <c>NumberOfLogicalCpuCores</c>: nvarchar(255), null.</remarks>
    public virtual string NumberOfLogicalCpuCores { get; set; }
    /// <remarks>Column <c>DefaultIncidentSla</c>: nvarchar(255), null.</remarks>
    public virtual string DefaultIncidentSla { get; set; }
    /// <remarks>Column <c>DefaultIncidentService</c>: nvarchar(255), null.</remarks>
    public virtual string DefaultIncidentService { get; set; }
    /// <remarks>Column <c>MonitoringMode</c>: nvarchar(255), null.</remarks>
    public virtual string MonitoringMode { get; set; }
    /// <remarks>Column <c>AccountIsDisabled</c>: nvarchar(255), null.</remarks>
    public virtual string AccountIsDisabled { get; set; }
    /// <remarks>Column <c>PersonResponsibleForAsset</c>: int, null.</remarks>
    public virtual int? PersonResponsibleForAsset { get; set; }
    /// <remarks>Column <c>LastImportedFromAd</c>: date, null.</remarks>
    public virtual DateTime? LastImportedFromAd { get; set; }
    /// <remarks>Column <c>RamSizeGb</c>: float, null.</remarks>
    public virtual double? RamSizeGb { get; set; }
    /// <remarks>Column <c>TotalStorageCapacityGb</c>: float, null.</remarks>
    public virtual double? TotalStorageCapacityGb { get; set; }
    /// <remarks>Column <c>NumberOfHardDrives</c>: float, null.</remarks>
    public virtual double? NumberOfHardDrives { get; set; }
    /// <remarks>Column <c>Cpu</c>: nvarchar(255), null.</remarks>
    public virtual string Cpu { get; set; }
    /// <remarks>Column <c>NumberOfProcessors</c>: float, null.</remarks>
    public virtual double? NumberOfProcessors { get; set; }
    /// <remarks>Column <c>OperatingSystem</c>: nvarchar(255), null.</remarks>
    public virtual string OperatingSystem { get; set; }
    /// <remarks>Column <c>MacAddresses</c>: nvarchar(255), null.</remarks>
    public virtual string MacAddresses { get; set; }
    /// <remarks>Column <c>IpAddresses</c>: nvarchar(255), null.</remarks>
    public virtual string IpAddresses { get; set; }
    /// <remarks>Column <c>GraphicCard</c>: nvarchar(255), null.</remarks>
    public virtual string GraphicCard { get; set; }
    /// <remarks>Column <c>NumberOfPhysicalCpuCores</c>: nvarchar(255), null.</remarks>
    public virtual string NumberOfPhysicalCpuCores { get; set; }
    /// <remarks>Column <c>Order</c>: nvarchar(255), null.</remarks>
    public virtual string Order { get; set; }
    /// <remarks>Column <c>UserGroups</c>: nvarchar(255), null.</remarks>
    public virtual string UserGroups { get; set; }
    /// <remarks>Column <c>HiddenProperties</c>: nvarchar(255), null.</remarks>
    public virtual string HiddenProperties { get; set; }
    /// <remarks>Column <c>ContractNumber</c>: nvarchar(255), null.</remarks>
    public virtual string ContractNumber { get; set; }
    /// <remarks>Column <c>PaymentPeriodMonths</c>: float, null.</remarks>
    public virtual double? PaymentPeriodMonths { get; set; }
    /// <remarks>Column <c>ValidFrom</c>: date, null.</remarks>
    public virtual DateTime? ValidFrom { get; set; }
    /// <remarks>Column <c>ValidTo</c>: date, null.</remarks>
    public virtual DateTime? ValidTo { get; set; }
    /// <remarks>Column <c>NotifyOfTheEndOfValidityInAdvanceDays</c>: float, null.</remarks>
    public virtual double? NotifyOfTheEndOfValidityInAdvanceDays { get; set; }
    /// <remarks>Column <c>ContractStatus</c>: nvarchar(255), null.</remarks>
    public virtual string ContractStatus { get; set; }
    /// <remarks>Column <c>IntuneDeviceId</c>: nvarchar(255), null.</remarks>
    public virtual string IntuneDeviceId { get; set; }
    /// <remarks>Column <c>UserUpn</c>: nvarchar(255), null.</remarks>
    public virtual string UserUpn { get; set; }
    /// <remarks>Column <c>IntuneLastCheckIn</c>: nvarchar(255), null.</remarks>
    public virtual string IntuneLastCheckIn { get; set; }
    /// <remarks>Column <c>TonerLevel</c>: nvarchar(255), null.</remarks>
    public virtual string TonerLevel { get; set; }
    /// <remarks>Column <c>SnmpScan</c>: nvarchar(255), null.</remarks>
    public virtual string SnmpScan { get; set; }
    /// <remarks>Column <c>SnmpLastScan</c>: nvarchar(255), null.</remarks>
    public virtual string SnmpLastScan { get; set; }
    /// <remarks>Column <c>ResourceGroup</c>: nvarchar(255), null.</remarks>
    public virtual string ResourceGroup { get; set; }
    /// <remarks>Column <c>AzureSqlServer</c>: nvarchar(255), null.</remarks>
    public virtual string AzureSqlServer { get; set; }
    /// <remarks>Column <c>AzureSqlDatabase</c>: nvarchar(255), null.</remarks>
    public virtual string AzureSqlDatabase { get; set; }
    /// <remarks>Column <c>AzureStorageAccount</c>: nvarchar(255), null.</remarks>
    public virtual string AzureStorageAccount { get; set; }
    /// <remarks>Column <c>Workstation</c>: nvarchar(255), null.</remarks>
    public virtual string Workstation { get; set; }
    /// <remarks>Column <c>AlvaoAgentDeviceId</c>: nvarchar(255), null.</remarks>
    public virtual string AlvaoAgentDeviceId { get; set; }
    /// <remarks>Column <c>StatusAssetCheck</c>: nvarchar(255), null.</remarks>
    public virtual string StatusAssetCheck { get; set; }
    /// <remarks>Column <c>ReasonForNotBeingFoundAssetCheck</c>: nvarchar(255), null.</remarks>
    public virtual string ReasonForNotBeingFoundAssetCheck { get; set; }
    /// <remarks>Column <c>NoteForAdministratorAssetCheck</c>: nvarchar(255), null.</remarks>
    public virtual string NoteForAdministratorAssetCheck { get; set; }
    /// <remarks>Column <c>AdGuid</c>: nvarchar(255), null.</remarks>
    public virtual string AdGuid { get; set; }
    /// <remarks>Column <c>JamfDeviceId</c>: nvarchar(255), null.</remarks>
    public virtual string JamfDeviceId { get; set; }
    /// <remarks>Column <c>JamfLastCheckIn</c>: nvarchar(255), null.</remarks>
    public virtual string JamfLastCheckIn { get; set; }
    /// <remarks>Column <c>LansweeperDeviceId</c>: nvarchar(255), null.</remarks>
    public virtual string LansweeperDeviceId { get; set; }
    /// <remarks>Column <c>LansweeperLastCheckIn</c>: nvarchar(255), null.</remarks>
    public virtual string LansweeperLastCheckIn { get; set; }
    /// <remarks>Column <c>LansweeperSiteId</c>: nvarchar(255), null.</remarks>
    public virtual string LansweeperSiteId { get; set; }
    /// <remarks>Column <c>ZabbixDeviceId</c>: nvarchar(255), null.</remarks>
    public virtual string ZabbixDeviceId { get; set; }
    /// <remarks>Column <c>ZabbixLastCheckIn</c>: nvarchar(255), null.</remarks>
    public virtual string ZabbixLastCheckIn { get; set; }
    /// <remarks>Column <c>MsSccmDeviceId</c>: nvarchar(255), null.</remarks>
    public virtual string MsSccmDeviceId { get; set; }
    /// <remarks>Column <c>AlvaoAgentLastCheckIn</c>: nvarchar(255), null.</remarks>
    public virtual string AlvaoAgentLastCheckIn { get; set; }
    /// <remarks>Column <c>StatusAssetAssignment</c>: nvarchar(255), null.</remarks>
    public virtual string StatusAssetAssignment { get; set; }
    /// <remarks>Column <c>CommentForRecipientAssetAssignment</c>: nvarchar(255), null.</remarks>
    public virtual string CommentForRecipientAssetAssignment { get; set; }
    /// <remarks>Column <c>SupportServices</c>: nvarchar(255), null.</remarks>
    public virtual string SupportServices { get; set; }
    /// <remarks>Column <c>Availability</c>: nvarchar(255), null.</remarks>
    public virtual string Availability { get; set; }
    /// <remarks>Column <c>Confidentiality</c>: nvarchar(255), null.</remarks>
    public virtual string Confidentiality { get; set; }
    /// <remarks>Column <c>Integrity</c>: nvarchar(255), null.</remarks>
    public virtual string Integrity { get; set; }
    /// <remarks>Column <c>TotalAssetValue</c>: float, null.</remarks>
    public virtual double? TotalAssetValue { get; set; }
    /// <remarks>Column <c>RiskLevel</c>: nvarchar(255), null.</remarks>
    public virtual string RiskLevel { get; set; }
    /// <remarks>Column <c>AssetCyberSecurityCategory</c>: nvarchar(255), null.</remarks>
    public virtual string AssetCyberSecurityCategory { get; set; }
    /// <remarks>Column <c>Ownership</c>: nvarchar(255), null.</remarks>
    public virtual string Ownership { get; set; }
    /// <remarks>Column <c>MonitorComputerLastScan</c>: nvarchar(255), null.</remarks>
    public virtual string MonitorComputerLastScan { get; set; }
    /// <remarks>Column <c>LastScanDate</c>: date, null.</remarks>
    public virtual DateTime? LastScanDate { get; set; }
    /// <remarks>Column <c>CiscoMerakiDeviceId</c>: nvarchar(255), null.</remarks>
    public virtual string CiscoMerakiDeviceId { get; set; }
    /// <remarks>Column <c>CiscoMerakiLastCheckIn</c>: nvarchar(255), null.</remarks>
    public virtual string CiscoMerakiLastCheckIn { get; set; }
    /// <remarks>Column <c>SplashtopDeviceId</c>: nvarchar(255), null.</remarks>
    public virtual string SplashtopDeviceId { get; set; }
    /// <remarks>Column <c>TeamViewerGuid</c>: nvarchar(255), null.</remarks>
    public virtual string TeamViewerGuid { get; set; }
    /// <remarks>Column <c>TeamViewerDeviceId</c>: nvarchar(255), null.</remarks>
    public virtual string TeamViewerDeviceId { get; set; }
    /// <remarks>Column <c>TeamViewerLastCheckIn</c>: nvarchar(255), null.</remarks>
    public virtual string TeamViewerLastCheckIn { get; set; }
    /// <remarks>Column <c>AdDomain</c>: nvarchar(255), null.</remarks>
    public virtual string AdDomain { get; set; }
}
