using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Detail of the HW detection - Computer rack.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure.htm"/>
[TableAttribute("dbo.vWbemObject_SystemEnclosure")]
public class vWbemObject_SystemEnclosure
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure___CLASS.htm"/>
    public virtual string __CLASS { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_AdapterRAM.htm"/>
    public virtual double? AdapterRAM { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_AdapterType.htm"/>
    public virtual string AdapterType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_AttachedTo.htm"/>
    public virtual string AttachedTo { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Availability.htm"/>
    public virtual int? Availability { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_BankLabel.htm"/>
    public virtual string BankLabel { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_BaseBoard.htm"/>
    public virtual string BaseBoard { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_bolVirtualObject.htm"/>
    public virtual bool bolVirtualObject { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Capacity.htm"/>
    public virtual long? Capacity { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Caption.htm"/>
    public virtual string Caption { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Compressed.htm"/>
    public virtual bool? Compressed { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_CSDVersion.htm"/>
    public virtual string CSDVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_CurrentClockSpeed.htm"/>
    public virtual int? CurrentClockSpeed { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_CurrentRefreshRate.htm"/>
    public virtual int? CurrentRefreshRate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_DataWidth.htm"/>
    public virtual int? DataWidth { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Description.htm"/>
    public virtual string Description { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_DeviceID.htm"/>
    public virtual string DeviceID { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_DeviceLocator.htm"/>
    public virtual string DeviceLocator { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_DeviceType.htm"/>
    public virtual string DeviceType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_DHCPEnabled.htm"/>
    public virtual bool? DHCPEnabled { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_DNSServerSearchOrder.htm"/>
    public virtual string DNSServerSearchOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Drive.htm"/>
    public virtual string Drive { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_DriveType.htm"/>
    public virtual int? DriveType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_EDIDVersion.htm"/>
    public virtual string EDIDVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_FileSystem.htm"/>
    public virtual string FileSystem { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_FormFactor.htm"/>
    public virtual int? FormFactor { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_FreeSpace.htm"/>
    public virtual double? FreeSpace { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_ChassisTypes.htm"/>
    public virtual int? ChassisTypes { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_InfraredSupported.htm"/>
    public virtual bool? InfraredSupported { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_InstallDate.htm"/>
    public virtual DateTime? InstallDate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_InterfaceType.htm"/>
    public virtual string InterfaceType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_intWbemObjectId.htm"/>
    public virtual int intWbemObjectId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_IPAddress.htm"/>
    public virtual string IPAddress { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_IPEnabled.htm"/>
    public virtual bool? IPEnabled { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_IPSubnet.htm"/>
    public virtual string IPSubnet { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_IRQNumber.htm"/>
    public virtual int? IRQNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_lintDetectId.htm"/>
    public virtual int lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_MACAddress.htm"/>
    public virtual string MACAddress { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_ManufactureDate.htm"/>
    public virtual DateTime? ManufactureDate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Manufacturer.htm"/>
    public virtual string Manufacturer { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_MaxCapacity.htm"/>
    public virtual int? MaxCapacity { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_MaxClockSpeed.htm"/>
    public virtual int? MaxClockSpeed { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_MaxRefreshRate.htm"/>
    public virtual int? MaxRefreshRate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_MediaType.htm"/>
    public virtual string MediaType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_MemoryDevices.htm"/>
    public virtual int? MemoryDevices { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_MemoryType.htm"/>
    public virtual int? MemoryType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_MinRefreshRate.htm"/>
    public virtual int? MinRefreshRate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Model.htm"/>
    public virtual string Model { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_MonitorManufacturer.htm"/>
    public virtual string MonitorManufacturer { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Monochrome.htm"/>
    public virtual bool? Monochrome { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_NetConnectionID.htm"/>
    public virtual string NetConnectionID { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Organization.htm"/>
    public virtual string Organization { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_OSLanguage.htm"/>
    public virtual int? OSLanguage { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_PartOfDomain.htm"/>
    public virtual bool? PartOfDomain { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_PNPDeviceID.htm"/>
    public virtual string PNPDeviceID { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_PortName.htm"/>
    public virtual string PortName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_ProcessorId.htm"/>
    public virtual string ProcessorId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Prop_Domain.htm"/>
    public virtual string Prop_Domain { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Prop_Name.htm"/>
    public virtual string Prop_Name { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Prop_Product.htm"/>
    public virtual string Prop_Product { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Prop_Size.htm"/>
    public virtual double? Prop_Size { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_RegisteredUser.htm"/>
    public virtual string RegisteredUser { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_ScreenHeight.htm"/>
    public virtual int? ScreenHeight { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_ScreenWidth.htm"/>
    public virtual int? ScreenWidth { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_SerialNumber.htm"/>
    public virtual string SerialNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Service.htm"/>
    public virtual string Service { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_ServiceName.htm"/>
    public virtual string ServiceName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_SMBIOSBIOSVersion.htm"/>
    public virtual string SMBIOSBIOSVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_SocketDesignation.htm"/>
    public virtual string SocketDesignation { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Speed.htm"/>
    public virtual string Speed { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_StatusInfo.htm"/>
    public virtual int? StatusInfo { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_SystemDirectory.htm"/>
    public virtual string SystemDirectory { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_SystemType.htm"/>
    public virtual string SystemType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_TotalPhysicalMemory.htm"/>
    public virtual long? TotalPhysicalMemory { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_txtFormFactorDesc.htm"/>
    public virtual string txtFormFactorDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_txtChassisTypesDesc.htm"/>
    public virtual string txtChassisTypesDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_txtMemoryTypeDesc.htm"/>
    public virtual string txtMemoryTypeDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_txtStatusInfoDesc.htm"/>
    public virtual string txtStatusInfoDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_txtTypeDetailDesc.htm"/>
    public virtual string txtTypeDetailDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_txtWakeUpTypeDesc.htm"/>
    public virtual string txtWakeUpTypeDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_TypeDetail.htm"/>
    public virtual int? TypeDetail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_UPSPort.htm"/>
    public virtual string UPSPort { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_UserName.htm"/>
    public virtual string UserName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_Version.htm"/>
    public virtual string Version { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_VideoModeDescription.htm"/>
    public virtual string VideoModeDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_VolumeSerialNumber.htm"/>
    public virtual string VolumeSerialNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure_WakeUpType.htm"/>
    public virtual int? WakeUpType { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vWbemObject_SystemEnclosure__ctor.htm"/>
    public vWbemObject_SystemEnclosure() { }
}
