using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detail of the HW detection - Hard disks.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html"/>
[Table("dbo.vWbemObjectPhysicalMedia")]
public class vWbemObjectPhysicalMedia {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_AdapterRAM"/>
    public virtual double? AdapterRAM { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_AdapterType"/>
    public virtual string AdapterType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_AttachedTo"/>
    public virtual string AttachedTo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Availability"/>
    public virtual int? Availability { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_BankLabel"/>
    public virtual string BankLabel { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_BaseBoard"/>
    public virtual string BaseBoard { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_CSDVersion"/>
    public virtual string CSDVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Capacity"/>
    public virtual long? Capacity { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Caption"/>
    public virtual string Caption { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_ChassisTypes"/>
    public virtual int? ChassisTypes { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Compressed"/>
    public virtual bool? Compressed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_CurrentClockSpeed"/>
    public virtual int? CurrentClockSpeed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_CurrentRefreshRate"/>
    public virtual int? CurrentRefreshRate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_DHCPEnabled"/>
    public virtual bool? DHCPEnabled { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_DNSServerSearchOrder"/>
    public virtual string DNSServerSearchOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_DataWidth"/>
    public virtual int? DataWidth { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Description"/>
    public virtual string Description { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_DeviceID"/>
    public virtual string DeviceID { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_DeviceLocator"/>
    public virtual string DeviceLocator { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_DeviceType"/>
    public virtual string DeviceType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Drive"/>
    public virtual string Drive { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_DriveType"/>
    public virtual int? DriveType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_EDIDVersion"/>
    public virtual string EDIDVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_FileSystem"/>
    public virtual string FileSystem { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_FormFactor"/>
    public virtual int? FormFactor { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_FreeSpace"/>
    public virtual double? FreeSpace { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_IPAddress"/>
    public virtual string IPAddress { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_IPEnabled"/>
    public virtual bool? IPEnabled { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_IPSubnet"/>
    public virtual string IPSubnet { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_IRQNumber"/>
    public virtual int? IRQNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_InfraredSupported"/>
    public virtual bool? InfraredSupported { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_InstallDate"/>
    public virtual DateTime? InstallDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_InterfaceType"/>
    public virtual string InterfaceType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_MACAddress"/>
    public virtual string MACAddress { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_ManufactureDate"/>
    public virtual DateTime? ManufactureDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Manufacturer"/>
    public virtual string Manufacturer { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_MaxCapacity"/>
    public virtual int? MaxCapacity { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_MaxClockSpeed"/>
    public virtual int? MaxClockSpeed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_MaxRefreshRate"/>
    public virtual int? MaxRefreshRate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_MediaType"/>
    public virtual string MediaType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_MemoryDevices"/>
    public virtual int? MemoryDevices { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_MemoryType"/>
    public virtual int? MemoryType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_MinRefreshRate"/>
    public virtual int? MinRefreshRate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Model"/>
    public virtual string Model { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_MonitorManufacturer"/>
    public virtual string MonitorManufacturer { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Monochrome"/>
    public virtual bool? Monochrome { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_NetConnectionID"/>
    public virtual string NetConnectionID { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_OSLanguage"/>
    public virtual int? OSLanguage { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Organization"/>
    public virtual string Organization { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_PNPDeviceID"/>
    public virtual string PNPDeviceID { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_PartOfDomain"/>
    public virtual bool? PartOfDomain { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_PortName"/>
    public virtual string PortName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_ProcessorId"/>
    public virtual string ProcessorId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Prop_Domain"/>
    public virtual string Prop_Domain { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Prop_Name"/>
    public virtual string Prop_Name { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Prop_Product"/>
    public virtual string Prop_Product { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Prop_Size"/>
    public virtual double? Prop_Size { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_RegisteredUser"/>
    public virtual string RegisteredUser { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_SMBIOSBIOSVersion"/>
    public virtual string SMBIOSBIOSVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_ScreenHeight"/>
    public virtual int? ScreenHeight { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_ScreenWidth"/>
    public virtual int? ScreenWidth { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_SerialNumber"/>
    public virtual string SerialNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Service"/>
    public virtual string Service { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_ServiceName"/>
    public virtual string ServiceName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_SocketDesignation"/>
    public virtual string SocketDesignation { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Speed"/>
    public virtual string Speed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_StatusInfo"/>
    public virtual int? StatusInfo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_SystemDirectory"/>
    public virtual string SystemDirectory { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_SystemType"/>
    public virtual string SystemType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_TotalPhysicalMemory"/>
    public virtual long? TotalPhysicalMemory { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_TypeDetail"/>
    public virtual int? TypeDetail { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_UPSPort"/>
    public virtual string UPSPort { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_UserName"/>
    public virtual string UserName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Version"/>
    public virtual string Version { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_VideoModeDescription"/>
    public virtual string VideoModeDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_VolumeSerialNumber"/>
    public virtual string VolumeSerialNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_WakeUpType"/>
    public virtual int? WakeUpType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia___CLASS"/>
    public virtual string __CLASS { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_bolVirtualObject"/>
    public virtual bool bolVirtualObject { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_intWbemObjectId"/>
    public virtual int intWbemObjectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_lintDetectId"/>
    public virtual int lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_lintWbemObjectId1"/>
    public virtual int lintWbemObjectId1 { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_lintWbemObjectId2"/>
    public virtual int lintWbemObjectId2 { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_txtChassisTypesDesc"/>
    public virtual string txtChassisTypesDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_txtFormFactorDesc"/>
    public virtual string txtFormFactorDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_txtMemoryTypeDesc"/>
    public virtual string txtMemoryTypeDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_txtStatusInfoDesc"/>
    public virtual string txtStatusInfoDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_txtTypeDetailDesc"/>
    public virtual string txtTypeDetailDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObjectPhysicalMedia.html#Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_txtWakeUpTypeDesc"/>
    public virtual string txtWakeUpTypeDesc { get; set; }
}
