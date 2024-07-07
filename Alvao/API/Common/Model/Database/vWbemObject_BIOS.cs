using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Detail of the HW detection - BIOS.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vWbemObject_BIOS.htm"/>
[TableAttribute("dbo.vWbemObject_BIOS")]
public class vWbemObject_BIOS
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS___CLASS.htm"/>
    public virtual string __CLASS { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_AdapterRAM.htm"/>
    public virtual double? AdapterRAM { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_AdapterType.htm"/>
    public virtual string AdapterType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_AttachedTo.htm"/>
    public virtual string AttachedTo { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_Availability.htm"/>
    public virtual int? Availability { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_BankLabel.htm"/>
    public virtual string BankLabel { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_BaseBoard.htm"/>
    public virtual string BaseBoard { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_bolVirtualObject.htm"/>
    public virtual bool bolVirtualObject { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_Capacity.htm"/>
    public virtual long? Capacity { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_Caption.htm"/>
    public virtual string Caption { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_Compressed.htm"/>
    public virtual bool? Compressed { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_CSDVersion.htm"/>
    public virtual string CSDVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_CurrentClockSpeed.htm"/>
    public virtual int? CurrentClockSpeed { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_CurrentRefreshRate.htm"/>
    public virtual int? CurrentRefreshRate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_DataWidth.htm"/>
    public virtual int? DataWidth { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_Description.htm"/>
    public virtual string Description { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_DeviceID.htm"/>
    public virtual string DeviceID { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_DeviceLocator.htm"/>
    public virtual string DeviceLocator { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_DeviceType.htm"/>
    public virtual string DeviceType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_DHCPEnabled.htm"/>
    public virtual bool? DHCPEnabled { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_DNSServerSearchOrder.htm"/>
    public virtual string DNSServerSearchOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_Drive.htm"/>
    public virtual string Drive { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_DriveType.htm"/>
    public virtual int? DriveType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_EDIDVersion.htm"/>
    public virtual string EDIDVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_FileSystem.htm"/>
    public virtual string FileSystem { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_FormFactor.htm"/>
    public virtual int? FormFactor { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_FreeSpace.htm"/>
    public virtual double? FreeSpace { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_ChassisTypes.htm"/>
    public virtual int? ChassisTypes { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_InfraredSupported.htm"/>
    public virtual bool? InfraredSupported { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_InstallDate.htm"/>
    public virtual DateTime? InstallDate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_InterfaceType.htm"/>
    public virtual string InterfaceType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_intWbemObjectId.htm"/>
    public virtual int intWbemObjectId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_IPAddress.htm"/>
    public virtual string IPAddress { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_IPEnabled.htm"/>
    public virtual bool? IPEnabled { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_IPSubnet.htm"/>
    public virtual string IPSubnet { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_IRQNumber.htm"/>
    public virtual int? IRQNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_lintDetectId.htm"/>
    public virtual int lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_MACAddress.htm"/>
    public virtual string MACAddress { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_ManufactureDate.htm"/>
    public virtual DateTime? ManufactureDate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_Manufacturer.htm"/>
    public virtual string Manufacturer { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_MaxCapacity.htm"/>
    public virtual int? MaxCapacity { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_MaxClockSpeed.htm"/>
    public virtual int? MaxClockSpeed { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_MaxRefreshRate.htm"/>
    public virtual int? MaxRefreshRate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_MediaType.htm"/>
    public virtual string MediaType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_MemoryDevices.htm"/>
    public virtual int? MemoryDevices { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_MemoryType.htm"/>
    public virtual int? MemoryType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_MinRefreshRate.htm"/>
    public virtual int? MinRefreshRate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_Model.htm"/>
    public virtual string Model { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_MonitorManufacturer.htm"/>
    public virtual string MonitorManufacturer { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_Monochrome.htm"/>
    public virtual bool? Monochrome { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_NetConnectionID.htm"/>
    public virtual string NetConnectionID { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_Organization.htm"/>
    public virtual string Organization { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_OSLanguage.htm"/>
    public virtual int? OSLanguage { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_PartOfDomain.htm"/>
    public virtual bool? PartOfDomain { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_PNPDeviceID.htm"/>
    public virtual string PNPDeviceID { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_PortName.htm"/>
    public virtual string PortName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_ProcessorId.htm"/>
    public virtual string ProcessorId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_Prop_Domain.htm"/>
    public virtual string Prop_Domain { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_Prop_Name.htm"/>
    public virtual string Prop_Name { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_Prop_Product.htm"/>
    public virtual string Prop_Product { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_Prop_Size.htm"/>
    public virtual double? Prop_Size { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_RegisteredUser.htm"/>
    public virtual string RegisteredUser { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_ScreenHeight.htm"/>
    public virtual int? ScreenHeight { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_ScreenWidth.htm"/>
    public virtual int? ScreenWidth { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_SerialNumber.htm"/>
    public virtual string SerialNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_Service.htm"/>
    public virtual string Service { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_ServiceName.htm"/>
    public virtual string ServiceName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_SMBIOSBIOSVersion.htm"/>
    public virtual string SMBIOSBIOSVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_SocketDesignation.htm"/>
    public virtual string SocketDesignation { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_Speed.htm"/>
    public virtual string Speed { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_StatusInfo.htm"/>
    public virtual int? StatusInfo { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_SystemDirectory.htm"/>
    public virtual string SystemDirectory { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_SystemType.htm"/>
    public virtual string SystemType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_TotalPhysicalMemory.htm"/>
    public virtual long? TotalPhysicalMemory { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_txtFormFactorDesc.htm"/>
    public virtual string txtFormFactorDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_txtChassisTypesDesc.htm"/>
    public virtual string txtChassisTypesDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_txtMemoryTypeDesc.htm"/>
    public virtual string txtMemoryTypeDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_txtStatusInfoDesc.htm"/>
    public virtual string txtStatusInfoDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_txtTypeDetailDesc.htm"/>
    public virtual string txtTypeDetailDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_txtWakeUpTypeDesc.htm"/>
    public virtual string txtWakeUpTypeDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_TypeDetail.htm"/>
    public virtual int? TypeDetail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_UPSPort.htm"/>
    public virtual string UPSPort { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_UserName.htm"/>
    public virtual string UserName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_Version.htm"/>
    public virtual string Version { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_VideoModeDescription.htm"/>
    public virtual string VideoModeDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_VolumeSerialNumber.htm"/>
    public virtual string VolumeSerialNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_BIOS_WakeUpType.htm"/>
    public virtual int? WakeUpType { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vWbemObject_BIOS__ctor.htm"/>
    public vWbemObject_BIOS() { }
}
