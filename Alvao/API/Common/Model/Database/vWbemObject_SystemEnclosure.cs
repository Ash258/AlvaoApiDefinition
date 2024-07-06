using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Detail of the HW detection - Computer rack.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure.htm"/>
[TableAttribute("dbo.vWbemObject_SystemEnclosure")]
public class vWbemObject_SystemEnclosure
{
    public virtual string __CLASS { get; set; }
    public virtual double? AdapterRAM { get; set; }
    public virtual string AdapterType { get; set; }
    public virtual string AttachedTo { get; set; }
    public virtual int? Availability { get; set; }
    public virtual string BankLabel { get; set; }
    public virtual string BaseBoard { get; set; }
    public virtual bool bolVirtualObject { get; set; }
    public virtual long? Capacity { get; set; }
    public virtual string Caption { get; set; }
    public virtual bool? Compressed { get; set; }
    public virtual string CSDVersion { get; set; }
    public virtual int? CurrentClockSpeed { get; set; }
    public virtual int? CurrentRefreshRate { get; set; }
    public virtual int? DataWidth { get; set; }
    public virtual string Description { get; set; }
    public virtual string DeviceID { get; set; }
    public virtual string DeviceLocator { get; set; }
    public virtual string DeviceType { get; set; }
    public virtual bool? DHCPEnabled { get; set; }
    public virtual string DNSServerSearchOrder { get; set; }
    public virtual string Drive { get; set; }
    public virtual int? DriveType { get; set; }
    public virtual string EDIDVersion { get; set; }
    public virtual string FileSystem { get; set; }
    public virtual int? FormFactor { get; set; }
    public virtual double? FreeSpace { get; set; }
    public virtual int? ChassisTypes { get; set; }
    public virtual bool? InfraredSupported { get; set; }
    public virtual DateTime? InstallDate { get; set; }
    public virtual string InterfaceType { get; set; }
    public virtual int intWbemObjectId { get; set; }
    public virtual string IPAddress { get; set; }
    public virtual bool? IPEnabled { get; set; }
    public virtual string IPSubnet { get; set; }
    public virtual int? IRQNumber { get; set; }
    public virtual int lintDetectId { get; set; }
    public virtual string MACAddress { get; set; }
    public virtual DateTime? ManufactureDate { get; set; }
    public virtual string Manufacturer { get; set; }
    public virtual int? MaxCapacity { get; set; }
    public virtual int? MaxClockSpeed { get; set; }
    public virtual int? MaxRefreshRate { get; set; }
    public virtual string MediaType { get; set; }
    public virtual int? MemoryDevices { get; set; }
    public virtual int? MemoryType { get; set; }
    public virtual int? MinRefreshRate { get; set; }
    public virtual string Model { get; set; }
    public virtual string MonitorManufacturer { get; set; }
    public virtual bool? Monochrome { get; set; }
    public virtual string NetConnectionID { get; set; }
    public virtual string Organization { get; set; }
    public virtual int? OSLanguage { get; set; }
    public virtual bool? PartOfDomain { get; set; }
    public virtual string PNPDeviceID { get; set; }
    public virtual string PortName { get; set; }
    public virtual string ProcessorId { get; set; }
    public virtual string Prop_Domain { get; set; }
    public virtual string Prop_Name { get; set; }
    public virtual string Prop_Product { get; set; }
    public virtual double? Prop_Size { get; set; }
    public virtual string RegisteredUser { get; set; }
    public virtual int? ScreenHeight { get; set; }
    public virtual int? ScreenWidth { get; set; }
    public virtual string SerialNumber { get; set; }
    public virtual string Service { get; set; }
    public virtual string ServiceName { get; set; }
    public virtual string SMBIOSBIOSVersion { get; set; }
    public virtual string SocketDesignation { get; set; }
    public virtual string Speed { get; set; }
    public virtual int? StatusInfo { get; set; }
    public virtual string SystemDirectory { get; set; }
    public virtual string SystemType { get; set; }
    public virtual long? TotalPhysicalMemory { get; set; }
    public virtual string txtFormFactorDesc { get; set; }
    public virtual string txtChassisTypesDesc { get; set; }
    public virtual string txtMemoryTypeDesc { get; set; }
    public virtual string txtStatusInfoDesc { get; set; }
    public virtual string txtTypeDetailDesc { get; set; }
    public virtual string txtWakeUpTypeDesc { get; set; }
    public virtual int? TypeDetail { get; set; }
    public virtual string UPSPort { get; set; }
    public virtual string UserName { get; set; }
    public virtual string Version { get; set; }
    public virtual string VideoModeDescription { get; set; }
    public virtual string VolumeSerialNumber { get; set; }
    public virtual int? WakeUpType { get; set; }

    public vWbemObject_SystemEnclosure() { }
}
