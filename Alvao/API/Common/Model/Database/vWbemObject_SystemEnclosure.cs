using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detail of the HW detection - Computer rack.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html"/>
[Table("dbo.vWbemObject_SystemEnclosure")]
public class vWbemObject_SystemEnclosure {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_AdapterRAM"/>
    public virtual double? AdapterRAM { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_AdapterType"/>
    public virtual string AdapterType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_AttachedTo"/>
    public virtual string AttachedTo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Availability"/>
    public virtual int? Availability { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_BankLabel"/>
    public virtual string BankLabel { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_BaseBoard"/>
    public virtual string BaseBoard { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_CSDVersion"/>
    public virtual string CSDVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Capacity"/>
    public virtual long? Capacity { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Caption"/>
    public virtual string Caption { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_ChassisTypes"/>
    public virtual int? ChassisTypes { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Compressed"/>
    public virtual bool? Compressed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_CurrentClockSpeed"/>
    public virtual int? CurrentClockSpeed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_CurrentRefreshRate"/>
    public virtual int? CurrentRefreshRate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_DHCPEnabled"/>
    public virtual bool? DHCPEnabled { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_DNSServerSearchOrder"/>
    public virtual string DNSServerSearchOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_DataWidth"/>
    public virtual int? DataWidth { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Description"/>
    public virtual string Description { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_DeviceID"/>
    public virtual string DeviceID { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_DeviceLocator"/>
    public virtual string DeviceLocator { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_DeviceType"/>
    public virtual string DeviceType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Drive"/>
    public virtual string Drive { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_DriveType"/>
    public virtual int? DriveType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_EDIDVersion"/>
    public virtual string EDIDVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_FileSystem"/>
    public virtual string FileSystem { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_FormFactor"/>
    public virtual int? FormFactor { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_FreeSpace"/>
    public virtual double? FreeSpace { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_IPAddress"/>
    public virtual string IPAddress { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_IPEnabled"/>
    public virtual bool? IPEnabled { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_IPSubnet"/>
    public virtual string IPSubnet { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_IRQNumber"/>
    public virtual int? IRQNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_InfraredSupported"/>
    public virtual bool? InfraredSupported { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_InstallDate"/>
    public virtual DateTime? InstallDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_InterfaceType"/>
    public virtual string InterfaceType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_MACAddress"/>
    public virtual string MACAddress { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_ManufactureDate"/>
    public virtual DateTime? ManufactureDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Manufacturer"/>
    public virtual string Manufacturer { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_MaxCapacity"/>
    public virtual int? MaxCapacity { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_MaxClockSpeed"/>
    public virtual int? MaxClockSpeed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_MaxRefreshRate"/>
    public virtual int? MaxRefreshRate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_MediaType"/>
    public virtual string MediaType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_MemoryDevices"/>
    public virtual int? MemoryDevices { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_MemoryType"/>
    public virtual int? MemoryType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_MinRefreshRate"/>
    public virtual int? MinRefreshRate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Model"/>
    public virtual string Model { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_MonitorManufacturer"/>
    public virtual string MonitorManufacturer { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Monochrome"/>
    public virtual bool? Monochrome { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_NetConnectionID"/>
    public virtual string NetConnectionID { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_OSLanguage"/>
    public virtual int? OSLanguage { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Organization"/>
    public virtual string Organization { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_PNPDeviceID"/>
    public virtual string PNPDeviceID { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_PartOfDomain"/>
    public virtual bool? PartOfDomain { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_PortName"/>
    public virtual string PortName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_ProcessorId"/>
    public virtual string ProcessorId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Prop_Domain"/>
    public virtual string Prop_Domain { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Prop_Name"/>
    public virtual string Prop_Name { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Prop_Product"/>
    public virtual string Prop_Product { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Prop_Size"/>
    public virtual double? Prop_Size { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_RegisteredUser"/>
    public virtual string RegisteredUser { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_SMBIOSBIOSVersion"/>
    public virtual string SMBIOSBIOSVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_ScreenHeight"/>
    public virtual int? ScreenHeight { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_ScreenWidth"/>
    public virtual int? ScreenWidth { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_SerialNumber"/>
    public virtual string SerialNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Service"/>
    public virtual string Service { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_ServiceName"/>
    public virtual string ServiceName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_SocketDesignation"/>
    public virtual string SocketDesignation { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Speed"/>
    public virtual string Speed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_StatusInfo"/>
    public virtual int? StatusInfo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_SystemDirectory"/>
    public virtual string SystemDirectory { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_SystemType"/>
    public virtual string SystemType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_TotalPhysicalMemory"/>
    public virtual long? TotalPhysicalMemory { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_TypeDetail"/>
    public virtual int? TypeDetail { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_UPSPort"/>
    public virtual string UPSPort { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_UserName"/>
    public virtual string UserName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Version"/>
    public virtual string Version { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_VideoModeDescription"/>
    public virtual string VideoModeDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_VolumeSerialNumber"/>
    public virtual string VolumeSerialNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_WakeUpType"/>
    public virtual int? WakeUpType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure___CLASS"/>
    public virtual string __CLASS { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_bolVirtualObject"/>
    public virtual bool bolVirtualObject { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_intWbemObjectId"/>
    public virtual int intWbemObjectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_lintDetectId"/>
    public virtual int lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_txtChassisTypesDesc"/>
    public virtual string txtChassisTypesDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_txtFormFactorDesc"/>
    public virtual string txtFormFactorDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_txtMemoryTypeDesc"/>
    public virtual string txtMemoryTypeDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_txtStatusInfoDesc"/>
    public virtual string txtStatusInfoDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_txtTypeDetailDesc"/>
    public virtual string txtTypeDetailDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_SystemEnclosure.html#Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_txtWakeUpTypeDesc"/>
    public virtual string txtWakeUpTypeDesc { get; set; }
}
