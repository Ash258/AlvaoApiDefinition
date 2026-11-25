using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>HW detected in the computers.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html"/>
[Table("dbo.tblWbemObject")]
public class tblWbemObject : ICloneable {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Active"/>
    /// <remarks>Column <c>Active</c>: bit, null.</remarks>
    public virtual bool? Active { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_AdapterRAM"/>
    /// <remarks>Column <c>AdapterRAM</c>: float, null.</remarks>
    public virtual double? AdapterRAM { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_AdapterType"/>
    /// <remarks>Column <c>AdapterType</c>: nvarchar(255), null.</remarks>
    public virtual string AdapterType { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_AlvaoVirtualMachineHostname"/>
    /// <remarks>Column <c>AlvaoVirtualMachineHostname</c>: nvarchar(128), null.</remarks>
    public virtual string AlvaoVirtualMachineHostname { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_AttachedTo"/>
    /// <remarks>Column <c>AttachedTo</c>: nvarchar(255), null.</remarks>
    public virtual string AttachedTo { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Availability"/>
    /// <remarks>Column <c>Availability</c>: int, null.</remarks>
    public virtual int? Availability { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_BankLabel"/>
    /// <remarks>Column <c>BankLabel</c>: nvarchar(255), null.</remarks>
    public virtual string BankLabel { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_BaseBoard"/>
    /// <remarks>Column <c>BaseBoard</c>: nvarchar(255), null.</remarks>
    public virtual string BaseBoard { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_CSDVersion"/>
    /// <remarks>Column <c>CSDVersion</c>: nvarchar(255), null.</remarks>
    public virtual string CSDVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Capacity"/>
    /// <remarks>Column <c>Capacity</c>: bigint, null.</remarks>
    public virtual long? Capacity { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Caption"/>
    /// <remarks>Column <c>Caption</c>: nvarchar(255), null.</remarks>
    public virtual string Caption { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_ChassisTypes"/>
    /// <remarks>Column <c>ChassisTypes</c>: int, null.</remarks>
    public virtual int? ChassisTypes { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Compressed"/>
    /// <remarks>Column <c>Compressed</c>: bit, null.</remarks>
    public virtual bool? Compressed { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_CurrentClockSpeed"/>
    /// <remarks>Column <c>CurrentClockSpeed</c>: int, null.</remarks>
    public virtual int? CurrentClockSpeed { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_CurrentRefreshRate"/>
    /// <remarks>Column <c>CurrentRefreshRate</c>: int, null.</remarks>
    public virtual int? CurrentRefreshRate { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_DHCPEnabled"/>
    /// <remarks>Column <c>DHCPEnabled</c>: bit, null.</remarks>
    public virtual bool? DHCPEnabled { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_DNSServerSearchOrder"/>
    /// <remarks>Column <c>DNSServerSearchOrder</c>: nvarchar(255), null.</remarks>
    public virtual string DNSServerSearchOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_DataWidth"/>
    /// <remarks>Column <c>DataWidth</c>: int, null.</remarks>
    public virtual int? DataWidth { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Description"/>
    /// <remarks>Column <c>Description</c>: nvarchar(255), null.</remarks>
    public virtual string Description { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_DeviceID"/>
    /// <remarks>Column <c>DeviceID</c>: nvarchar(255), null.</remarks>
    public virtual string DeviceID { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_DeviceLocator"/>
    /// <remarks>Column <c>DeviceLocator</c>: nvarchar(255), null.</remarks>
    public virtual string DeviceLocator { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_DeviceType"/>
    /// <remarks>Column <c>DeviceType</c>: nvarchar(255), null.</remarks>
    public virtual string DeviceType { get; set; }
    /// <summary>DNS domain of the computer.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_DnsDomain"/>
    /// <remarks>Column <c>DnsDomain</c>: nvarchar(255), null.</remarks>
    public virtual string DnsDomain { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Drive"/>
    /// <remarks>Column <c>Drive</c>: nvarchar(255), null.</remarks>
    public virtual string Drive { get; set; }
    /// <summary>Drive letter.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_DriveLetter"/>
    /// <remarks>Column <c>DriveLetter</c>: nvarchar(16), null.</remarks>
    public virtual string DriveLetter { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_DriveType"/>
    /// <remarks>Column <c>DriveType</c>: int, null.</remarks>
    public virtual int? DriveType { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_EDIDVersion"/>
    /// <remarks>Column <c>EDIDVersion</c>: nvarchar(255), null.</remarks>
    public virtual string EDIDVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_FileSystem"/>
    /// <remarks>Column <c>FileSystem</c>: nvarchar(255), null.</remarks>
    public virtual string FileSystem { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_FormFactor"/>
    /// <remarks>Column <c>FormFactor</c>: int, null.</remarks>
    public virtual int? FormFactor { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_FreeSpace"/>
    /// <remarks>Column <c>FreeSpace</c>: float, null.</remarks>
    public virtual double? FreeSpace { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_IPAddress"/>
    /// <remarks>Column <c>IPAddress</c>: nvarchar(255), null.</remarks>
    public virtual string IPAddress { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_IPEnabled"/>
    /// <remarks>Column <c>IPEnabled</c>: bit, null.</remarks>
    public virtual bool? IPEnabled { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_IPSubnet"/>
    /// <remarks>Column <c>IPSubnet</c>: nvarchar(255), null.</remarks>
    public virtual string IPSubnet { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_IRQNumber"/>
    /// <remarks>Column <c>IRQNumber</c>: int, null.</remarks>
    public virtual int? IRQNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_InfraredSupported"/>
    /// <remarks>Column <c>InfraredSupported</c>: bit, null.</remarks>
    public virtual bool? InfraredSupported { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_InstallDate"/>
    /// <remarks>Column <c>InstallDate</c>: datetime, null.</remarks>
    public virtual DateTime? InstallDate { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_InterfaceType"/>
    /// <remarks>Column <c>InterfaceType</c>: nvarchar(255), null.</remarks>
    public virtual string InterfaceType { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_IsActivated"/>
    /// <remarks>Column <c>IsActivated</c>: bit, null.</remarks>
    public virtual bool? IsActivated { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_IsEnabled"/>
    /// <remarks>Column <c>IsEnabled</c>: bit, null.</remarks>
    public virtual bool? IsEnabled { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_IsOwned"/>
    /// <remarks>Column <c>IsOwned</c>: bit, null.</remarks>
    public virtual bool? IsOwned { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_MACAddress"/>
    /// <remarks>Column <c>MACAddress</c>: nvarchar(255), null.</remarks>
    public virtual string MACAddress { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_ManufactureDate"/>
    /// <remarks>Column <c>ManufactureDate</c>: datetime, null.</remarks>
    public virtual DateTime? ManufactureDate { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Manufacturer"/>
    /// <remarks>Column <c>Manufacturer</c>: nvarchar(255), null.</remarks>
    public virtual string Manufacturer { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_ManufacturerVersion"/>
    /// <remarks>Column <c>ManufacturerVersion</c>: nvarchar(128), null.</remarks>
    public virtual string ManufacturerVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_ManufacturerVersionFull20"/>
    /// <remarks>Column <c>ManufacturerVersionFull20</c>: nvarchar(128), null.</remarks>
    public virtual string ManufacturerVersionFull20 { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_ManufacturerVersionInfo"/>
    /// <remarks>Column <c>ManufacturerVersionInfo</c>: nvarchar(128), null.</remarks>
    public virtual string ManufacturerVersionInfo { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_MaxCapacity"/>
    /// <remarks>Column <c>MaxCapacity</c>: int, null.</remarks>
    public virtual int? MaxCapacity { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_MaxClockSpeed"/>
    /// <remarks>Column <c>MaxClockSpeed</c>: int, null.</remarks>
    public virtual int? MaxClockSpeed { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_MaxHorizontalImageSize"/>
    /// <remarks>Column <c>MaxHorizontalImageSize</c>: int, null.</remarks>
    public virtual int? MaxHorizontalImageSize { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_MaxRefreshRate"/>
    /// <remarks>Column <c>MaxRefreshRate</c>: int, null.</remarks>
    public virtual int? MaxRefreshRate { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_MaxVerticalImageSize"/>
    /// <remarks>Column <c>MaxVerticalImageSize</c>: int, null.</remarks>
    public virtual int? MaxVerticalImageSize { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_MediaType"/>
    /// <remarks>Column <c>MediaType</c>: nvarchar(255), null.</remarks>
    public virtual string MediaType { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_MemoryDevices"/>
    /// <remarks>Column <c>MemoryDevices</c>: int, null.</remarks>
    public virtual int? MemoryDevices { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_MemoryType"/>
    /// <remarks>Column <c>MemoryType</c>: int, null.</remarks>
    public virtual int? MemoryType { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_MinRefreshRate"/>
    /// <remarks>Column <c>MinRefreshRate</c>: int, null.</remarks>
    public virtual int? MinRefreshRate { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Model"/>
    /// <remarks>Column <c>Model</c>: nvarchar(255), null.</remarks>
    public virtual string Model { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_MonitorManufacturer"/>
    /// <remarks>Column <c>MonitorManufacturer</c>: nvarchar(255), null.</remarks>
    public virtual string MonitorManufacturer { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Monochrome"/>
    /// <remarks>Column <c>Monochrome</c>: bit, null.</remarks>
    public virtual bool? Monochrome { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_NetConnectionID"/>
    /// <remarks>Column <c>NetConnectionID</c>: nvarchar(255), null.</remarks>
    public virtual string NetConnectionID { get; set; }
    /// <summary>Number of physical CPU cores.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_NumberOfCores"/>
    /// <remarks>Column <c>NumberOfCores</c>: int, null.</remarks>
    public virtual int? NumberOfCores { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_NumberOfLogicalProcessors"/>
    /// <remarks>Column <c>NumberOfLogicalProcessors</c>: int, null.</remarks>
    public virtual int? NumberOfLogicalProcessors { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_OSLanguage"/>
    /// <remarks>Column <c>OSLanguage</c>: int, null.</remarks>
    public virtual int? OSLanguage { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Organization"/>
    /// <remarks>Column <c>Organization</c>: nvarchar(255), null.</remarks>
    public virtual string Organization { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_PNPDeviceID"/>
    /// <remarks>Column <c>PNPDeviceID</c>: nvarchar(255), null.</remarks>
    public virtual string PNPDeviceID { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_PartOfDomain"/>
    /// <remarks>Column <c>PartOfDomain</c>: bit, null.</remarks>
    public virtual bool? PartOfDomain { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_PhysicalPresenceVersionInfo"/>
    /// <remarks>Column <c>PhysicalPresenceVersionInfo</c>: nvarchar(128), null.</remarks>
    public virtual string PhysicalPresenceVersionInfo { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_PortName"/>
    /// <remarks>Column <c>PortName</c>: nvarchar(255), null.</remarks>
    public virtual string PortName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_ProcessorId"/>
    /// <remarks>Column <c>ProcessorId</c>: nvarchar(255), null.</remarks>
    public virtual string ProcessorId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Prop_Domain"/>
    /// <remarks>Column <c>Prop_Domain</c>: nvarchar(255), null.</remarks>
    public virtual string Prop_Domain { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Prop_Name"/>
    /// <remarks>Column <c>Prop_Name</c>: nvarchar(255), null.</remarks>
    public virtual string Prop_Name { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Prop_Product"/>
    /// <remarks>Column <c>Prop_Product</c>: nvarchar(255), null.</remarks>
    public virtual string Prop_Product { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Prop_Size"/>
    /// <remarks>Column <c>Prop_Size</c>: float, null.</remarks>
    public virtual double? Prop_Size { get; set; }
    /// <summary>The status of drive section encryption by the BitLocker tool. 0 = off, 1 = on, 2 = unknown.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_ProtectionStatus"/>
    /// <remarks>Column <c>ProtectionStatus</c>: int, null.</remarks>
    public virtual int? ProtectionStatus { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_RegisteredUser"/>
    /// <remarks>Column <c>RegisteredUser</c>: nvarchar(255), null.</remarks>
    public virtual string RegisteredUser { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_SMBIOSBIOSVersion"/>
    /// <remarks>Column <c>SMBIOSBIOSVersion</c>: nvarchar(255), null.</remarks>
    public virtual string SMBIOSBIOSVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_ScreenHeight"/>
    /// <remarks>Column <c>ScreenHeight</c>: int, null.</remarks>
    public virtual int? ScreenHeight { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_ScreenWidth"/>
    /// <remarks>Column <c>ScreenWidth</c>: int, null.</remarks>
    public virtual int? ScreenWidth { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_SerialNumber"/>
    /// <remarks>Column <c>SerialNumber</c>: nvarchar(255), null.</remarks>
    public virtual string SerialNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Service"/>
    /// <remarks>Column <c>Service</c>: nvarchar(255), null.</remarks>
    public virtual string Service { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_ServiceName"/>
    /// <remarks>Column <c>ServiceName</c>: nvarchar(255), null.</remarks>
    public virtual string ServiceName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_SocketDesignation"/>
    /// <remarks>Column <c>SocketDesignation</c>: nvarchar(255), null.</remarks>
    public virtual string SocketDesignation { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_SpecVersion"/>
    /// <remarks>Column <c>SpecVersion</c>: nvarchar(128), null.</remarks>
    public virtual string SpecVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Speed"/>
    /// <remarks>Column <c>Speed</c>: nvarchar(255), null.</remarks>
    public virtual string Speed { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_StatusInfo"/>
    /// <remarks>Column <c>StatusInfo</c>: int, null.</remarks>
    public virtual int? StatusInfo { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_SystemDirectory"/>
    /// <remarks>Column <c>SystemDirectory</c>: nvarchar(255), null.</remarks>
    public virtual string SystemDirectory { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_SystemType"/>
    /// <remarks>Column <c>SystemType</c>: nvarchar(255), null.</remarks>
    public virtual string SystemType { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_TotalPhysicalMemory"/>
    /// <remarks>Column <c>TotalPhysicalMemory</c>: bigint, null.</remarks>
    public virtual long? TotalPhysicalMemory { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_TypeDetail"/>
    /// <remarks>Column <c>TypeDetail</c>: int, null.</remarks>
    public virtual int? TypeDetail { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_UPSPort"/>
    /// <remarks>Column <c>UPSPort</c>: nvarchar(255), null.</remarks>
    public virtual string UPSPort { get; set; }
    /// <summary>Unique identifier for the hardware object.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_UniqueId"/>
    /// <remarks>Column <c>UniqueId</c>: nvarchar(255), null.</remarks>
    public virtual string UniqueId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_UserName"/>
    /// <remarks>Column <c>UserName</c>: nvarchar(255), null.</remarks>
    public virtual string UserName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Version"/>
    /// <remarks>Column <c>Version</c>: nvarchar(255), null.</remarks>
    public virtual string Version { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_VideoModeDescription"/>
    /// <remarks>Column <c>VideoModeDescription</c>: nvarchar(255), null.</remarks>
    public virtual string VideoModeDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_VolumeSerialNumber"/>
    /// <remarks>Column <c>VolumeSerialNumber</c>: nvarchar(255), null.</remarks>
    public virtual string VolumeSerialNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_WakeUpType"/>
    /// <remarks>Column <c>WakeUpType</c>: int, null.</remarks>
    public virtual int? WakeUpType { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject___CLASS"/>
    /// <remarks>Column <c>__CLASS</c>: nvarchar(255), null.</remarks>
    public virtual string __CLASS { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_bolVirtualObject"/>
    /// <remarks>Column <c>bolVirtualObject</c>: bit, not null.</remarks>
    public virtual bool bolVirtualObject { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_intWbemObjectId"/>
    /// <remarks>Column <c>intWbemObjectId</c>: bigint, not null.</remarks>
    [Key]
    public virtual long intWbemObjectId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_lintDetectId"/>
    /// <remarks>Column <c>lintDetectId</c>: int, not null. References <see cref="tblDetect"/>.</remarks>
    public virtual int lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_txtChassisTypesDesc"/>
    /// <remarks>Column <c>txtChassisTypesDesc</c>: nvarchar(255), null.</remarks>
    public virtual string txtChassisTypesDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_txtFormFactorDesc"/>
    /// <remarks>Column <c>txtFormFactorDesc</c>: nvarchar(255), null.</remarks>
    public virtual string txtFormFactorDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_txtMemoryTypeDesc"/>
    /// <remarks>Column <c>txtMemoryTypeDesc</c>: nvarchar(255), null.</remarks>
    public virtual string txtMemoryTypeDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_txtStatusInfoDesc"/>
    /// <remarks>Column <c>txtStatusInfoDesc</c>: nvarchar(255), null.</remarks>
    public virtual string txtStatusInfoDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_txtTypeDetailDesc"/>
    /// <remarks>Column <c>txtTypeDetailDesc</c>: nvarchar(255), null.</remarks>
    public virtual string txtTypeDetailDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_txtWakeUpTypeDesc"/>
    /// <remarks>Column <c>txtWakeUpTypeDesc</c>: nvarchar(255), null.</remarks>
    public virtual string txtWakeUpTypeDesc { get; set; }

    /// <summary>Creates a new object that is a copy of the current instance.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Clone"/>
    /// <returns>A new object that is a copy of this instance.</returns>
    public object Clone() { throw new NotImplementedException(); }
}
