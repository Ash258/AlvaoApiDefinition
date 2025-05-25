using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detail of the HW detection - all.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html"/>
[Table("dbo.vWbemObject")]
public class vWbemObject {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_AdapterRAM"/>
    public virtual double? AdapterRAM { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_AdapterType"/>
    public virtual string AdapterType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_AttachedTo"/>
    public virtual string AttachedTo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_Availability"/>
    public virtual int? Availability { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_BankLabel"/>
    public virtual string BankLabel { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_BaseBoard"/>
    public virtual string BaseBoard { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_CSDVersion"/>
    public virtual string CSDVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_Capacity"/>
    public virtual long? Capacity { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_Caption"/>
    public virtual string Caption { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_ChassisTypes"/>
    public virtual int? ChassisTypes { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_Compressed"/>
    public virtual bool? Compressed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_CurrentClockSpeed"/>
    public virtual int? CurrentClockSpeed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_CurrentRefreshRate"/>
    public virtual int? CurrentRefreshRate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_DHCPEnabled"/>
    public virtual bool? DHCPEnabled { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_DNSServerSearchOrder"/>
    public virtual string DNSServerSearchOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_DataWidth"/>
    public virtual int? DataWidth { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_Description"/>
    public virtual string Description { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_DeviceID"/>
    public virtual string DeviceID { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_DeviceLocator"/>
    public virtual string DeviceLocator { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_DeviceType"/>
    public virtual string DeviceType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_Drive"/>
    public virtual string Drive { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_DriveType"/>
    public virtual int? DriveType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_EDIDVersion"/>
    public virtual string EDIDVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_FileSystem"/>
    public virtual string FileSystem { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_FormFactor"/>
    public virtual int? FormFactor { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_FreeSpace"/>
    public virtual double? FreeSpace { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_IPAddress"/>
    public virtual string IPAddress { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_IPEnabled"/>
    public virtual bool? IPEnabled { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_IPSubnet"/>
    public virtual string IPSubnet { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_IRQNumber"/>
    public virtual int? IRQNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_InfraredSupported"/>
    public virtual bool? InfraredSupported { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_InstallDate"/>
    public virtual DateTime? InstallDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_InterfaceType"/>
    public virtual string InterfaceType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_MACAddress"/>
    public virtual string MACAddress { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_ManufactureDate"/>
    public virtual DateTime? ManufactureDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_Manufacturer"/>
    public virtual string Manufacturer { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_MaxCapacity"/>
    public virtual int? MaxCapacity { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_MaxClockSpeed"/>
    public virtual int? MaxClockSpeed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_MaxRefreshRate"/>
    public virtual int? MaxRefreshRate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_MediaType"/>
    public virtual string MediaType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_MemoryDevices"/>
    public virtual int? MemoryDevices { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_MemoryType"/>
    public virtual int? MemoryType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_MinRefreshRate"/>
    public virtual int? MinRefreshRate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_Model"/>
    public virtual string Model { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_MonitorManufacturer"/>
    public virtual string MonitorManufacturer { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_Monochrome"/>
    public virtual bool? Monochrome { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_NetConnectionID"/>
    public virtual string NetConnectionID { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_OSLanguage"/>
    public virtual int? OSLanguage { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_Organization"/>
    public virtual string Organization { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_PNPDeviceID"/>
    public virtual string PNPDeviceID { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_PartOfDomain"/>
    public virtual bool? PartOfDomain { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_PortName"/>
    public virtual string PortName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_ProcessorId"/>
    public virtual string ProcessorId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_Prop_Domain"/>
    public virtual string Prop_Domain { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_Prop_Name"/>
    public virtual string Prop_Name { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_Prop_Product"/>
    public virtual string Prop_Product { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_Prop_Size"/>
    public virtual double? Prop_Size { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_RegisteredUser"/>
    public virtual string RegisteredUser { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_SMBIOSBIOSVersion"/>
    public virtual string SMBIOSBIOSVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_ScreenHeight"/>
    public virtual int? ScreenHeight { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_ScreenWidth"/>
    public virtual int? ScreenWidth { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_SerialNumber"/>
    public virtual string SerialNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_Service"/>
    public virtual string Service { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_ServiceName"/>
    public virtual string ServiceName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_SocketDesignation"/>
    public virtual string SocketDesignation { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_Speed"/>
    public virtual string Speed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_StatusInfo"/>
    public virtual int? StatusInfo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_SystemDirectory"/>
    public virtual string SystemDirectory { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_SystemType"/>
    public virtual string SystemType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_TotalPhysicalMemory"/>
    public virtual long? TotalPhysicalMemory { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_TypeDetail"/>
    public virtual int? TypeDetail { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_UPSPort"/>
    public virtual string UPSPort { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_UserName"/>
    public virtual string UserName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_Version"/>
    public virtual string Version { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_VideoModeDescription"/>
    public virtual string VideoModeDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_VolumeSerialNumber"/>
    public virtual string VolumeSerialNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_WakeUpType"/>
    public virtual int? WakeUpType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject___CLASS"/>
    public virtual string __CLASS { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_bolVirtualObject"/>
    public virtual bool bolVirtualObject { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_intWbemObjectId"/>
    public virtual int intWbemObjectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_lintDetectId"/>
    public virtual int lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_lintWbemObjectId1"/>
    public virtual int lintWbemObjectId1 { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_lintWbemObjectId2"/>
    public virtual int lintWbemObjectId2 { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_txtChassisTypesDesc"/>
    public virtual string txtChassisTypesDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_txtFormFactorDesc"/>
    public virtual string txtFormFactorDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_txtMemoryTypeDesc"/>
    public virtual string txtMemoryTypeDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_txtStatusInfoDesc"/>
    public virtual string txtStatusInfoDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_txtTypeDetailDesc"/>
    public virtual string txtTypeDetailDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vWbemObject.html#Alvao_API_Common_Model_Database_vWbemObject_txtWakeUpTypeDesc"/>
    public virtual string txtWakeUpTypeDesc { get; set; }
}
