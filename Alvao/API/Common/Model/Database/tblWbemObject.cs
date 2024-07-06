using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// HW detected in the computers.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblWbemObject.htm"/>
[TableAttribute("dbo.tblWbemObject")]
public class tblWbemObject
{
    public virtual string __CLASS { get; set; }
    public virtual bool? Active { get; set; }
    public virtual double? AdapterRAM { get; set; }
    public virtual string AdapterType { get; set; }
    public virtual string AlvaoVirtualMachineHostname { get; set; }
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
    /// <summary>Drive letter.</summary>
    public virtual string DriveLetter { get; set; }
    public virtual int? DriveType { get; set; }
    public virtual string EDIDVersion { get; set; }
    public virtual string FileSystem { get; set; }
    public virtual int? FormFactor { get; set; }
    public virtual double? FreeSpace { get; set; }
    public virtual int? ChassisTypes { get; set; }
    public virtual bool? InfraredSupported { get; set; }
    public virtual DateTime? InstallDate { get; set; }
    public virtual string InterfaceType { get; set; }
    [KeyAttribute]
    public virtual int intWbemObjectId { get; set; }
    public virtual string IPAddress { get; set; }
    public virtual bool? IPEnabled { get; set; }
    public virtual string IPSubnet { get; set; }
    public virtual int? IRQNumber { get; set; }
    public virtual bool? IsActivated { get; set; }
    public virtual bool? IsEnabled { get; set; }
    public virtual bool? IsOwned { get; set; }
    public virtual int lintDetectId { get; set; }
    public virtual string MACAddress { get; set; }
    public virtual DateTime? ManufactureDate { get; set; }
    public virtual string Manufacturer { get; set; }
    public virtual string ManufacturerVersion { get; set; }
    public virtual string ManufacturerVersionFull20 { get; set; }
    public virtual string ManufacturerVersionInfo { get; set; }
    public virtual int? MaxCapacity { get; set; }
    public virtual int? MaxClockSpeed { get; set; }
    public virtual int? MaxHorizontalImageSize { get; set; }
    public virtual int? MaxRefreshRate { get; set; }
    public virtual int? MaxVerticalImageSize { get; set; }
    public virtual string MediaType { get; set; }
    public virtual int? MemoryDevices { get; set; }
    public virtual int? MemoryType { get; set; }
    public virtual int? MinRefreshRate { get; set; }
    public virtual string Model { get; set; }
    public virtual string MonitorManufacturer { get; set; }
    public virtual bool? Monochrome { get; set; }
    public virtual string NetConnectionID { get; set; }
    /// <summary>Number of physical CPU cores.</summary>
    public virtual int? NumberOfCores { get; set; }
    public virtual int? NumberOfLogicalProcessors { get; set; }
    public virtual string Organization { get; set; }
    public virtual int? OSLanguage { get; set; }
    public virtual bool? PartOfDomain { get; set; }
    public virtual string PhysicalPresenceVersionInfo { get; set; }
    public virtual string PNPDeviceID { get; set; }
    public virtual string PortName { get; set; }
    public virtual string ProcessorId { get; set; }
    public virtual string Prop_Domain { get; set; }
    public virtual string Prop_Name { get; set; }
    public virtual string Prop_Product { get; set; }
    public virtual double? Prop_Size { get; set; }
    /// <summary>The status of drive section encryption by the BitLocker tool. 0 = off, 1 = on, 2 = unknown.</summary>
    public virtual int? ProtectionStatus { get; set; }
    public virtual string RegisteredUser { get; set; }
    public virtual int? ScreenHeight { get; set; }
    public virtual int? ScreenWidth { get; set; }
    public virtual string SerialNumber { get; set; }
    public virtual string Service { get; set; }
    public virtual string ServiceName { get; set; }
    public virtual string SMBIOSBIOSVersion { get; set; }
    public virtual string SocketDesignation { get; set; }
    public virtual string SpecVersion { get; set; }
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

    public tblWbemObject() { }
}
