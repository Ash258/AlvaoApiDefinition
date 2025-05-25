using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detail of the HW detection - BIOS.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html"/>
[Table("dbo.vWbemObject_BIOS")]
public class vWbemObject_BIOS {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_AdapterRAM"/>
    public virtual double? AdapterRAM { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_AdapterType"/>
    public virtual string AdapterType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_AttachedTo"/>
    public virtual string AttachedTo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_Availability"/>
    public virtual int? Availability { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_BankLabel"/>
    public virtual string BankLabel { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_BaseBoard"/>
    public virtual string BaseBoard { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_CSDVersion"/>
    public virtual string CSDVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_Capacity"/>
    public virtual long? Capacity { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_Caption"/>
    public virtual string Caption { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_ChassisTypes"/>
    public virtual int? ChassisTypes { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_Compressed"/>
    public virtual bool? Compressed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_CurrentClockSpeed"/>
    public virtual int? CurrentClockSpeed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_CurrentRefreshRate"/>
    public virtual int? CurrentRefreshRate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_DHCPEnabled"/>
    public virtual bool? DHCPEnabled { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_DNSServerSearchOrder"/>
    public virtual string DNSServerSearchOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_DataWidth"/>
    public virtual int? DataWidth { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_Description"/>
    public virtual string Description { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_DeviceID"/>
    public virtual string DeviceID { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_DeviceLocator"/>
    public virtual string DeviceLocator { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_DeviceType"/>
    public virtual string DeviceType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_Drive"/>
    public virtual string Drive { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_DriveType"/>
    public virtual int? DriveType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_EDIDVersion"/>
    public virtual string EDIDVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_FileSystem"/>
    public virtual string FileSystem { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_FormFactor"/>
    public virtual int? FormFactor { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_FreeSpace"/>
    public virtual double? FreeSpace { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_IPAddress"/>
    public virtual string IPAddress { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_IPEnabled"/>
    public virtual bool? IPEnabled { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_IPSubnet"/>
    public virtual string IPSubnet { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_IRQNumber"/>
    public virtual int? IRQNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_InfraredSupported"/>
    public virtual bool? InfraredSupported { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_InstallDate"/>
    public virtual DateTime? InstallDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_InterfaceType"/>
    public virtual string InterfaceType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_MACAddress"/>
    public virtual string MACAddress { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_ManufactureDate"/>
    public virtual DateTime? ManufactureDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_Manufacturer"/>
    public virtual string Manufacturer { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_MaxCapacity"/>
    public virtual int? MaxCapacity { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_MaxClockSpeed"/>
    public virtual int? MaxClockSpeed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_MaxRefreshRate"/>
    public virtual int? MaxRefreshRate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_MediaType"/>
    public virtual string MediaType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_MemoryDevices"/>
    public virtual int? MemoryDevices { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_MemoryType"/>
    public virtual int? MemoryType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_MinRefreshRate"/>
    public virtual int? MinRefreshRate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_Model"/>
    public virtual string Model { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_MonitorManufacturer"/>
    public virtual string MonitorManufacturer { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_Monochrome"/>
    public virtual bool? Monochrome { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_NetConnectionID"/>
    public virtual string NetConnectionID { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_OSLanguage"/>
    public virtual int? OSLanguage { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_Organization"/>
    public virtual string Organization { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_PNPDeviceID"/>
    public virtual string PNPDeviceID { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_PartOfDomain"/>
    public virtual bool? PartOfDomain { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_PortName"/>
    public virtual string PortName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_ProcessorId"/>
    public virtual string ProcessorId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_Prop_Domain"/>
    public virtual string Prop_Domain { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_Prop_Name"/>
    public virtual string Prop_Name { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_Prop_Product"/>
    public virtual string Prop_Product { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_Prop_Size"/>
    public virtual double? Prop_Size { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_RegisteredUser"/>
    public virtual string RegisteredUser { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_SMBIOSBIOSVersion"/>
    public virtual string SMBIOSBIOSVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_ScreenHeight"/>
    public virtual int? ScreenHeight { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_ScreenWidth"/>
    public virtual int? ScreenWidth { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_SerialNumber"/>
    public virtual string SerialNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_Service"/>
    public virtual string Service { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_ServiceName"/>
    public virtual string ServiceName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_SocketDesignation"/>
    public virtual string SocketDesignation { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_Speed"/>
    public virtual string Speed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_StatusInfo"/>
    public virtual int? StatusInfo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_SystemDirectory"/>
    public virtual string SystemDirectory { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_SystemType"/>
    public virtual string SystemType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_TotalPhysicalMemory"/>
    public virtual long? TotalPhysicalMemory { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_TypeDetail"/>
    public virtual int? TypeDetail { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_UPSPort"/>
    public virtual string UPSPort { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_UserName"/>
    public virtual string UserName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_Version"/>
    public virtual string Version { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_VideoModeDescription"/>
    public virtual string VideoModeDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_VolumeSerialNumber"/>
    public virtual string VolumeSerialNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_WakeUpType"/>
    public virtual int? WakeUpType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS___CLASS"/>
    public virtual string __CLASS { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_bolVirtualObject"/>
    public virtual bool bolVirtualObject { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_intWbemObjectId"/>
    public virtual int intWbemObjectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_lintDetectId"/>
    public virtual int lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_txtChassisTypesDesc"/>
    public virtual string txtChassisTypesDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_txtFormFactorDesc"/>
    public virtual string txtFormFactorDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_txtMemoryTypeDesc"/>
    public virtual string txtMemoryTypeDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_txtStatusInfoDesc"/>
    public virtual string txtStatusInfoDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_txtTypeDetailDesc"/>
    public virtual string txtTypeDetailDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject_BIOS.html#Alvao_API_Common_Model_Database_vWbemObject_BIOS_txtWakeUpTypeDesc"/>
    public virtual string txtWakeUpTypeDesc { get; set; }
}
