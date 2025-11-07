using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>HW detected in the computers.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html"/>
[Table("dbo.tblWbemObject")]
public class tblWbemObject : ICloneable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Active"/>
    public virtual bool? Active { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_AdapterRAM"/>
    public virtual double? AdapterRAM { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_AdapterType"/>
    public virtual string AdapterType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_AlvaoVirtualMachineHostname"/>
    public virtual string AlvaoVirtualMachineHostname { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_AttachedTo"/>
    public virtual string AttachedTo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Availability"/>
    public virtual int? Availability { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_BankLabel"/>
    public virtual string BankLabel { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_BaseBoard"/>
    public virtual string BaseBoard { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_CSDVersion"/>
    public virtual string CSDVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Capacity"/>
    public virtual long? Capacity { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Caption"/>
    public virtual string Caption { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_ChassisTypes"/>
    public virtual int? ChassisTypes { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Compressed"/>
    public virtual bool? Compressed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_CurrentClockSpeed"/>
    public virtual int? CurrentClockSpeed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_CurrentRefreshRate"/>
    public virtual int? CurrentRefreshRate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_DHCPEnabled"/>
    public virtual bool? DHCPEnabled { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_DNSServerSearchOrder"/>
    public virtual string DNSServerSearchOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_DataWidth"/>
    public virtual int? DataWidth { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Description"/>
    public virtual string Description { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_DeviceID"/>
    public virtual string DeviceID { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_DeviceLocator"/>
    public virtual string DeviceLocator { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_DeviceType"/>
    public virtual string DeviceType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Drive"/>
    public virtual string Drive { get; set; }
    /// <summary>Drive letter.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_DriveLetter"/>
    public virtual string DriveLetter { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_DriveType"/>
    public virtual int? DriveType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_EDIDVersion"/>
    public virtual string EDIDVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_FileSystem"/>
    public virtual string FileSystem { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_FormFactor"/>
    public virtual int? FormFactor { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_FreeSpace"/>
    public virtual double? FreeSpace { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_IPAddress"/>
    public virtual string IPAddress { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_IPEnabled"/>
    public virtual bool? IPEnabled { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_IPSubnet"/>
    public virtual string IPSubnet { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_IRQNumber"/>
    public virtual int? IRQNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_InfraredSupported"/>
    public virtual bool? InfraredSupported { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_InstallDate"/>
    public virtual DateTime? InstallDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_InterfaceType"/>
    public virtual string InterfaceType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_IsActivated"/>
    public virtual bool? IsActivated { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_IsEnabled"/>
    public virtual bool? IsEnabled { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_IsOwned"/>
    public virtual bool? IsOwned { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_MACAddress"/>
    public virtual string MACAddress { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_ManufactureDate"/>
    public virtual DateTime? ManufactureDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Manufacturer"/>
    public virtual string Manufacturer { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_ManufacturerVersion"/>
    public virtual string ManufacturerVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_ManufacturerVersionFull20"/>
    public virtual string ManufacturerVersionFull20 { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_ManufacturerVersionInfo"/>
    public virtual string ManufacturerVersionInfo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_MaxCapacity"/>
    public virtual int? MaxCapacity { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_MaxClockSpeed"/>
    public virtual int? MaxClockSpeed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_MaxHorizontalImageSize"/>
    public virtual int? MaxHorizontalImageSize { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_MaxRefreshRate"/>
    public virtual int? MaxRefreshRate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_MaxVerticalImageSize"/>
    public virtual int? MaxVerticalImageSize { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_MediaType"/>
    public virtual string MediaType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_MemoryDevices"/>
    public virtual int? MemoryDevices { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_MemoryType"/>
    public virtual int? MemoryType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_MinRefreshRate"/>
    public virtual int? MinRefreshRate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Model"/>
    public virtual string Model { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_MonitorManufacturer"/>
    public virtual string MonitorManufacturer { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Monochrome"/>
    public virtual bool? Monochrome { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_NetConnectionID"/>
    public virtual string NetConnectionID { get; set; }
    /// <summary>Number of physical CPU cores.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_NumberOfCores"/>
    public virtual int? NumberOfCores { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_NumberOfLogicalProcessors"/>
    public virtual int? NumberOfLogicalProcessors { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_OSLanguage"/>
    public virtual int? OSLanguage { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Organization"/>
    public virtual string Organization { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_PNPDeviceID"/>
    public virtual string PNPDeviceID { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_PartOfDomain"/>
    public virtual bool? PartOfDomain { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_PhysicalPresenceVersionInfo"/>
    public virtual string PhysicalPresenceVersionInfo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_PortName"/>
    public virtual string PortName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_ProcessorId"/>
    public virtual string ProcessorId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Prop_Domain"/>
    public virtual string Prop_Domain { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Prop_Name"/>
    public virtual string Prop_Name { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Prop_Product"/>
    public virtual string Prop_Product { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Prop_Size"/>
    public virtual double? Prop_Size { get; set; }
    /// <summary>The status of drive section encryption by the BitLocker tool. 0 = off, 1 = on, 2 = unknown.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_ProtectionStatus"/>
    public virtual int? ProtectionStatus { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_RegisteredUser"/>
    public virtual string RegisteredUser { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_SMBIOSBIOSVersion"/>
    public virtual string SMBIOSBIOSVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_ScreenHeight"/>
    public virtual int? ScreenHeight { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_ScreenWidth"/>
    public virtual int? ScreenWidth { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_SerialNumber"/>
    public virtual string SerialNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Service"/>
    public virtual string Service { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_ServiceName"/>
    public virtual string ServiceName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_SocketDesignation"/>
    public virtual string SocketDesignation { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_SpecVersion"/>
    public virtual string SpecVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Speed"/>
    public virtual string Speed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_StatusInfo"/>
    public virtual int? StatusInfo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_SystemDirectory"/>
    public virtual string SystemDirectory { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_SystemType"/>
    public virtual string SystemType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_TotalPhysicalMemory"/>
    public virtual long? TotalPhysicalMemory { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_TypeDetail"/>
    public virtual int? TypeDetail { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_UPSPort"/>
    public virtual string UPSPort { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_UserName"/>
    public virtual string UserName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Version"/>
    public virtual string Version { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_VideoModeDescription"/>
    public virtual string VideoModeDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_VolumeSerialNumber"/>
    public virtual string VolumeSerialNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_WakeUpType"/>
    public virtual int? WakeUpType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject___CLASS"/>
    public virtual string __CLASS { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_bolVirtualObject"/>
    public virtual bool bolVirtualObject { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_intWbemObjectId"/>
    [Key]
    public virtual int intWbemObjectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_lintDetectId"/>
    public virtual int lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_txtChassisTypesDesc"/>
    public virtual string txtChassisTypesDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_txtFormFactorDesc"/>
    public virtual string txtFormFactorDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_txtMemoryTypeDesc"/>
    public virtual string txtMemoryTypeDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_txtStatusInfoDesc"/>
    public virtual string txtStatusInfoDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_txtTypeDetailDesc"/>
    public virtual string txtTypeDetailDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_txtWakeUpTypeDesc"/>
    public virtual string txtWakeUpTypeDesc { get; set; }

    /// <summary>Creates a new object that is a copy of the current instance.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObject.html#Alvao_API_Common_Model_Database_tblWbemObject_Clone"/>
    /// <returns>A new object that is a copy of this instance.</returns>
    public object Clone() { throw new NotImplementedException(); }
}
