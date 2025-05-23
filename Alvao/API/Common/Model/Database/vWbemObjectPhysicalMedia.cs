using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detail of the HW detection - Hard disks.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia.htm"/>
[TableAttribute("dbo.vWbemObjectPhysicalMedia")]
public class vWbemObjectPhysicalMedia {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia___CLASS.htm"/>
    public virtual string __CLASS { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_AdapterRAM.htm"/>
    public virtual double? AdapterRAM { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_AdapterType.htm"/>
    public virtual string AdapterType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_AttachedTo.htm"/>
    public virtual string AttachedTo { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Availability.htm"/>
    public virtual int? Availability { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_BankLabel.htm"/>
    public virtual string BankLabel { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_BaseBoard.htm"/>
    public virtual string BaseBoard { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_bolVirtualObject.htm"/>
    public virtual bool bolVirtualObject { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Capacity.htm"/>
    public virtual long? Capacity { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Caption.htm"/>
    public virtual string Caption { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Compressed.htm"/>
    public virtual bool? Compressed { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_CSDVersion.htm"/>
    public virtual string CSDVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_CurrentClockSpeed.htm"/>
    public virtual int? CurrentClockSpeed { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_CurrentRefreshRate.htm"/>
    public virtual int? CurrentRefreshRate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_DataWidth.htm"/>
    public virtual int? DataWidth { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Description.htm"/>
    public virtual string Description { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_DeviceID.htm"/>
    public virtual string DeviceID { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_DeviceLocator.htm"/>
    public virtual string DeviceLocator { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_DeviceType.htm"/>
    public virtual string DeviceType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_DHCPEnabled.htm"/>
    public virtual bool? DHCPEnabled { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_DNSServerSearchOrder.htm"/>
    public virtual string DNSServerSearchOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Drive.htm"/>
    public virtual string Drive { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_DriveType.htm"/>
    public virtual int? DriveType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_EDIDVersion.htm"/>
    public virtual string EDIDVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_FileSystem.htm"/>
    public virtual string FileSystem { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_FormFactor.htm"/>
    public virtual int? FormFactor { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_FreeSpace.htm"/>
    public virtual double? FreeSpace { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_ChassisTypes.htm"/>
    public virtual int? ChassisTypes { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_InfraredSupported.htm"/>
    public virtual bool? InfraredSupported { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_InstallDate.htm"/>
    public virtual DateTime? InstallDate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_InterfaceType.htm"/>
    public virtual string InterfaceType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_intWbemObjectId.htm"/>
    public virtual int intWbemObjectId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_IPAddress.htm"/>
    public virtual string IPAddress { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_IPEnabled.htm"/>
    public virtual bool? IPEnabled { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_IPSubnet.htm"/>
    public virtual string IPSubnet { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_IRQNumber.htm"/>
    public virtual int? IRQNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_lintDetectId.htm"/>
    public virtual int lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_lintWbemObjectId1.htm"/>
    public virtual int lintWbemObjectId1 { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_lintWbemObjectId2.htm"/>
    public virtual int lintWbemObjectId2 { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_MACAddress.htm"/>
    public virtual string MACAddress { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_ManufactureDate.htm"/>
    public virtual DateTime? ManufactureDate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Manufacturer.htm"/>
    public virtual string Manufacturer { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_MaxCapacity.htm"/>
    public virtual int? MaxCapacity { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_MaxClockSpeed.htm"/>
    public virtual int? MaxClockSpeed { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_MaxRefreshRate.htm"/>
    public virtual int? MaxRefreshRate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_MediaType.htm"/>
    public virtual string MediaType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_MemoryDevices.htm"/>
    public virtual int? MemoryDevices { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_MemoryType.htm"/>
    public virtual int? MemoryType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_MinRefreshRate.htm"/>
    public virtual int? MinRefreshRate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Model.htm"/>
    public virtual string Model { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_MonitorManufacturer.htm"/>
    public virtual string MonitorManufacturer { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Monochrome.htm"/>
    public virtual bool? Monochrome { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_NetConnectionID.htm"/>
    public virtual string NetConnectionID { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Organization.htm"/>
    public virtual string Organization { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_OSLanguage.htm"/>
    public virtual int? OSLanguage { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_PartOfDomain.htm"/>
    public virtual bool? PartOfDomain { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_PNPDeviceID.htm"/>
    public virtual string PNPDeviceID { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_PortName.htm"/>
    public virtual string PortName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_ProcessorId.htm"/>
    public virtual string ProcessorId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Prop_Domain.htm"/>
    public virtual string Prop_Domain { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Prop_Name.htm"/>
    public virtual string Prop_Name { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Prop_Product.htm"/>
    public virtual string Prop_Product { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Prop_Size.htm"/>
    public virtual double? Prop_Size { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_RegisteredUser.htm"/>
    public virtual string RegisteredUser { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_ScreenHeight.htm"/>
    public virtual int? ScreenHeight { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_ScreenWidth.htm"/>
    public virtual int? ScreenWidth { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_SerialNumber.htm"/>
    public virtual string SerialNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Service.htm"/>
    public virtual string Service { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_ServiceName.htm"/>
    public virtual string ServiceName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_SMBIOSBIOSVersion.htm"/>
    public virtual string SMBIOSBIOSVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_SocketDesignation.htm"/>
    public virtual string SocketDesignation { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Speed.htm"/>
    public virtual string Speed { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_StatusInfo.htm"/>
    public virtual int? StatusInfo { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_SystemDirectory.htm"/>
    public virtual string SystemDirectory { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_SystemType.htm"/>
    public virtual string SystemType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_TotalPhysicalMemory.htm"/>
    public virtual long? TotalPhysicalMemory { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_txtFormFactorDesc.htm"/>
    public virtual string txtFormFactorDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_txtChassisTypesDesc.htm"/>
    public virtual string txtChassisTypesDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_txtMemoryTypeDesc.htm"/>
    public virtual string txtMemoryTypeDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_txtStatusInfoDesc.htm"/>
    public virtual string txtStatusInfoDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_txtTypeDetailDesc.htm"/>
    public virtual string txtTypeDetailDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_txtWakeUpTypeDesc.htm"/>
    public virtual string txtWakeUpTypeDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_TypeDetail.htm"/>
    public virtual int? TypeDetail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_UPSPort.htm"/>
    public virtual string UPSPort { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_UserName.htm"/>
    public virtual string UserName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_Version.htm"/>
    public virtual string Version { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_VideoModeDescription.htm"/>
    public virtual string VideoModeDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_VolumeSerialNumber.htm"/>
    public virtual string VolumeSerialNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia_WakeUpType.htm"/>
    public virtual int? WakeUpType { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vWbemObjectPhysicalMedia__ctor.htm"/>
    public vWbemObjectPhysicalMedia() { }
}
