using AutoMapper.Configuration.Annotations;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Definitions of the objects properties.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKind.html"/>
[Table("dbo.tblKind")]
public class tblKind {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKind.KindCode.html#fields"/>
    public enum KindCode {
        Name = 0,
        ComputerSetName = 1,
        SiteName = 2,
        HostName = 3,
        NetworkBranchName = 4,
        User = 5,
        Note = 6,
        Place = 7,
        Address = 8,
        OrganizationCode = 9,
        TypeDesignation = 10,
        InventaryNo = 11,
        SerialNo = 12,
        PackingSlipNo = 13,
        Port = 14,
        Manufacturer = 16,
        Type = 17,
        Frequency = 18,
        RefreshMax = 19,
        RefreshMinimum = 20,
        HorizontalResolution = 21,
        VerticalResolution = 22,
        Version = 23,
        Codepage = 25,
        CountryCode = 26,
        FileSystem = 27,
        LogicalDevice = 28,
        MaximumFrequency = 29,
        VideoMode = 30,
        PictureWidth = 31,
        PictureHeight = 32,
        __order = 33,
        NumberOfLicenses = 34,
        Building = 35,
        Storey = 36,
        Room = 37,
        Supplier = 38,
        Department = 39,
        PurchaseDate = 40,
        Warranty = 41,
        PCDescription = 42,
        DateOfNextServiceInspection = 43,
        Phone = 44,
        Fax = 45,
        Email = 46,
        ContactPerson = 47,
        OrganizationName = 48,
        Price = 49,
        Size = 50,
        FreeSpace = 51,
        Website = 52,
        Password = 53,
        LoginName = 54,
        VideoRam = 55,
        Freeware = 56,
        Centre = 57,
        Segment = 58,
        Unit = 59,
        SubnetName = 60,
        MacAddress = 61,
        IPAddress = 62,
        Domain = 63,
        DhcpServer = 64,
        IpxAddress = 66,
        Irq = 67,
        Interface = 68,
        PersonalNumber = 74,
        Office = 75,
        Facility = 76,
        Diagonal = 77,
        ComputerKind = 78,
        CdReadSpeed = 79,
        DvdReadSpeed = 80,
        CdWriteSpeed = 81,
        DvdWriteSpeed = 82,
        Ethernet10Mbit = 83,
        Ethernet100Mbit = 84,
        MaximumHorizontalResolution = 85,
        MaximumVerticalResolution = 86,
        BiosSN = 87,
        Unioin = 88,
        Workplace = 89,
        Division = 90,
        Section = 91,
        Subsidiary = 92,
        RamSlots = 93,
        RamUsedSlots = 94,
        MaxSize = 95,
        Model = 96,
        WakeUpType = 97,
        ChassisType = 98,
        PartOfDomain = 99,
        Quantity = 100,
        Category = 101,
        EvidentaryNo = 102,
        LastFoundAssetCheck = 103,
        ProcessorId = 104,
        LandeskId = 105,
        WarrantyUntil = 106,
        MobilePhone = 107,
        JobTitle = 108,
        City = 109,
        Street = 110,
        Country = 111,
        Company = 112,
        POBox = 113,
        StateOrProvince = 114,
        ZipCode = 115,
        HomePhone = 116,
        Pager = 117,
        IPPhone = 118,
        ScreenResolution = 119,
        MonitorType = 120,
        Center = 121,
        Imei = 122,
        DataRecordingMedium = 123,
        PhoneNumber = 124,
        ModemInterface = 125,
        DataService = 126,
        ConnectionSpeed = 127,
        InstalledMaps = 128,
        MemoryCardType = 129,
        KeyFor = 130,
        Color = 131,
        LicensePlateNumber = 132,
        TechnicalInspectionValidUntil = 133,
        Tariff = 134,
        ServerFarmName = 135,
        CloudName = 136,
        VMHostName = 137,
        PersonResponsibleForSoftware = 138,
        LastLoggedUser = 139,
        NumberOfLogicalProcessors = 140,
        DefaultIncidentSla = 141,
        DefaultIncidentService = 142,
        MonitoringMode = 143,
        AccountIsDisabled = 144,
        Resp = 145,
        LastImportedFromAD = 146,
        RamCapacity = 147,
        TotalHDCapacity = 148,
        HDQuantity = 149,
        Procesor = 150,
        ProcesorQuantity = 151,
        OperatingSystem = 152,
        MacAddresses = 153,
        IPAddresses = 154,
        GraphicCard = 155,
        NumberOfCores = 156,
        Order = 157,
        UserGroups = 158,
        HiddenProperties = 159,
        ContractNumber = 160,
        PaymentPeriodInMonths = 161,
        ValidFrom = 162,
        ValidTo = 163,
        NotifyOfTheEndOfValidityInAdvanceInDays = 164,
        ContractStatus = 165,
        IntuneDeviceId = 166,
        UserUpn = 167,
        IntuneLastCheckIn = 168,
        TonerLevel = 169,
        SnmpScan = 170,
        SnmpLastScan = 171,
        ResourceGroup = 172,
        AzureSqlServer = 173,
        AzureSqlDatabase = 174,
        AzureStorageAccount = 175,
        Workstation = 176,
        AlvaoAgentDeviceId = 177,
        StatusAssetCheck = 178,
        ReasonForNotBeingFoundAssetCheck = 179,
        NoteForAdministratorAssetCheck = 180,
        JamfDeviceId = 182,
        JamfLastCheckIn = 183,
        LansweeperDeviceId = 184,
        LansweeperLastCheckIn = 185,
        LansweeperSiteId = 186,
        ZabbixDeviceId = 187,
        ZabbixLastCheckIn = 188,
        MsSccmDeviceId = 189,
    }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKind.KindFlags.html#fields"/>
    [Flags]
    public enum KindFlags {
        [Obsolete("It's no longer in use.")]
        Classified = 1,
        ImplicitValue = 2,
        [Obsolete("It's no longer in use.")]
        Hidden = 4,
        [Obsolete("It's no longer in use.")]
        WMI_Classified = 8,
        [Obsolete("It's no longer in use.")]
        WMI_Key = 16,
        NoInherit = 32,
        [Obsolete("It's no longer in use.")]
        PropViewTabPosition = 64,
        [Obsolete("It's no longer in use.")]
        Password = 128,
        [Obsolete("It's no longer in use.")]
        WMI_LoginName = 256,
        [Obsolete("It's no longer in use.")]
        WMI_REG = 512,
        [Obsolete("It's no longer in use.")]
        WMI_Scanner = 1024,
        [Obsolete("It's no longer in use.")]
        WMI_Measure = 2048,
        [Obsolete("It's no longer in use.")]
        Unique = 4096,
        SelectOnly = 8192,
    }

    /// <summary>Property categories</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKind.html#Alvao_API_Common_Model_Database_tblKind_Category"/>
    public virtual string Category { get; set; }
    /// <summary>1 = Delete value when copying properties</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKind.html#Alvao_API_Common_Model_Database_tblKind_CleanValueByCopying"/>
    public virtual bool CleanValueByCopying { get; set; }
    /// <summary>NodeCust table column name that stores the property value. NULL = the object property is not used in any object class and has no representation in the NodeCust table.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKind.html#Alvao_API_Common_Model_Database_tblKind_ColumnName"/>
    public virtual string ColumnName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKind.html#Alvao_API_Common_Model_Database_tblKind_DataType"/>
    [Ignore]
    public string DataType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKind.html#Alvao_API_Common_Model_Database_tblKind_IsSystem"/>
    [Ignore]
    public bool IsSystem { get; set; }
    /// <summary>Property data type ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKind.html#Alvao_API_Common_Model_Database_tblKind_KindDataTypeId"/>
    public virtual int KindDataTypeId { get; set; }
    /// <summary>Precision of the decimal part of the number.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKind.html#Alvao_API_Common_Model_Database_tblKind_Precision"/>
    public virtual int? Precision { get; set; }
    /// <summary>1 = the property is mandatory in objects of all kinds that use it. In this case, there is no record for it in the RequiredClassKind table.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKind.html#Alvao_API_Common_Model_Database_tblKind_RequiredForAllClasses"/>
    public virtual bool RequiredForAllClasses { get; set; }
    /// <summary>1 = property value can only be selected from the list of values</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKind.html#Alvao_API_Common_Model_Database_tblKind_bSelectOnly"/>
    public virtual bool bSelectOnly { get; set; }
    /// <summary>1 = global property for a class of objects. &quot;0&quot; indicates the property is considered local for each class of objects (printers, computers etc.). An automatic list of values is then put together from the values of this property for the given object class,</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKind.html#Alvao_API_Common_Model_Database_tblKind_bolGlobalScope"/>
    public virtual bool bolGlobalScope { get; set; }
    /// <summary>1 = property value must be unique</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKind.html#Alvao_API_Common_Model_Database_tblKind_bolUnique"/>
    public virtual bool bolUnique { get; set; }
    /// <summary>bit field: 0x20 = property not inheritable</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKind.html#Alvao_API_Common_Model_Database_tblKind_intFlags"/>
    public virtual int? intFlags { get; set; }
    /// <summary>The unique number determines the property (integrated ones are numbered), user properties do not have this number</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKind.html#Alvao_API_Common_Model_Database_tblKind_intKindCode"/>
    public virtual int? intKindCode { get; set; }
    /// <summary>primary key</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKind.html#Alvao_API_Common_Model_Database_tblKind_intKindId"/>
    [Key]
    public virtual int intKindId { get; set; }
    /// <summary>The sequence for table filtering can be set</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKind.html#Alvao_API_Common_Model_Database_tblKind_intOrder"/>
    public virtual int? intOrder { get; set; }
    /// <summary>This attribute contains the tblKind.intKindId definition of the property, from which the list of values shall be used (tblKindValue)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKind.html#Alvao_API_Common_Model_Database_tblKind_lintValueKindId"/>
    public virtual int? lintValueKindId { get; set; }
    /// <summary>property name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKind.html#Alvao_API_Common_Model_Database_tblKind_txtName"/>
    public virtual string txtName { get; set; }
}
