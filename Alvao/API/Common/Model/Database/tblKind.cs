using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Definitions of the objects properties.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKind.html"/>
[Table("dbo.tblKind")]
public class tblKind {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKind.KindCode.html#fields"/>
    public enum KindCode {
        AccountIsDisabled = 144,
        Address = 8,
        AlvaoAgentDeviceId = 177,
        AzureSqlDatabase = 174,
        AzureSqlServer = 173,
        AzureStorageAccount = 175,
        BiosSN = 87,
        Building = 35,
        Category = 101,
        CdReadSpeed = 79,
        CdWriteSpeed = 81,
        Center = 121,
        Centre = 57,
        ChassisType = 98,
        City = 109,
        CloudName = 136,
        Codepage = 25,
        Color = 131,
        Company = 112,
        ComputerKind = 78,
        ComputerSetName = 1,
        ConnectionSpeed = 127,
        ContactPerson = 47,
        ContractNumber = 160,
        ContractStatus = 165,
        Country = 111,
        CountryCode = 26,
        DataRecordingMedium = 123,
        DataService = 126,
        DateOfNextServiceInspection = 43,
        DefaultIncidentService = 142,
        DefaultIncidentSla = 141,
        Department = 39,
        DhcpServer = 64,
        Diagonal = 77,
        Division = 90,
        Domain = 63,
        DvdReadSpeed = 80,
        DvdWriteSpeed = 82,
        Email = 46,
        Ethernet100Mbit = 84,
        Ethernet10Mbit = 83,
        EvidentaryNo = 102,
        Facility = 76,
        Fax = 45,
        FileSystem = 27,
        FreeSpace = 51,
        Freeware = 56,
        Frequency = 18,
        GraphicCard = 155,
        HDQuantity = 149,
        HiddenProperties = 159,
        HomePhone = 116,
        HorizontalResolution = 21,
        HostName = 3,
        IPAddress = 62,
        IPAddresses = 154,
        IPPhone = 118,
        Imei = 122,
        InstalledMaps = 128,
        Interface = 68,
        IntuneDeviceId = 166,
        IntuneLastCheckIn = 168,
        InventaryNo = 11,
        IpxAddress = 66,
        Irq = 67,
        JamfDeviceId = 182,
        JamfLastCheckIn = 183,
        JobTitle = 108,
        KeyFor = 130,
        LandeskId = 105,
        LansweeperDeviceId = 184,
        LansweeperLastCheckIn = 185,
        LansweeperSiteId = 186,
        LastFoundAssetCheck = 103,
        LastImportedFromAD = 146,
        LastLoggedUser = 139,
        LicensePlateNumber = 132,
        LogicalDevice = 28,
        LoginName = 54,
        MacAddress = 61,
        MacAddresses = 153,
        Manufacturer = 16,
        MaxSize = 95,
        MaximumFrequency = 29,
        MaximumHorizontalResolution = 85,
        MaximumVerticalResolution = 86,
        MemoryCardType = 129,
        MobilePhone = 107,
        Model = 96,
        ModemInterface = 125,
        MonitorType = 120,
        MonitoringMode = 143,
        Name = 0,
        NetworkBranchName = 4,
        Note = 6,
        NoteForAdministratorAssetCheck = 180,
        NotifyOfTheEndOfValidityInAdvanceInDays = 164,
        NumberOfCores = 156,
        NumberOfLicenses = 34,
        NumberOfLogicalProcessors = 140,
        Office = 75,
        OperatingSystem = 152,
        Order = 157,
        OrganizationCode = 9,
        OrganizationName = 48,
        PCDescription = 42,
        POBox = 113,
        PackingSlipNo = 13,
        Pager = 117,
        PartOfDomain = 99,
        Password = 53,
        PaymentPeriodInMonths = 161,
        PersonResponsibleForSoftware = 138,
        PersonalNumber = 74,
        Phone = 44,
        PhoneNumber = 124,
        PictureHeight = 32,
        PictureWidth = 31,
        Place = 7,
        Port = 14,
        Price = 49,
        Procesor = 150,
        ProcesorQuantity = 151,
        ProcessorId = 104,
        PurchaseDate = 40,
        Quantity = 100,
        RamCapacity = 147,
        RamSlots = 93,
        RamUsedSlots = 94,
        ReasonForNotBeingFoundAssetCheck = 179,
        RefreshMax = 19,
        RefreshMinimum = 20,
        ResourceGroup = 172,
        Resp = 145,
        Room = 37,
        ScreenResolution = 119,
        Section = 91,
        Segment = 58,
        SerialNo = 12,
        ServerFarmName = 135,
        SiteName = 2,
        Size = 50,
        SnmpLastScan = 171,
        SnmpScan = 170,
        StateOrProvince = 114,
        StatusAssetCheck = 178,
        Storey = 36,
        Street = 110,
        SubnetName = 60,
        Subsidiary = 92,
        Supplier = 38,
        Tariff = 134,
        TechnicalInspectionValidUntil = 133,
        TonerLevel = 169,
        TotalHDCapacity = 148,
        Type = 17,
        TypeDesignation = 10,
        Unioin = 88,
        Unit = 59,
        User = 5,
        UserGroups = 158,
        UserUpn = 167,
        VMHostName = 137,
        ValidFrom = 162,
        ValidTo = 163,
        Version = 23,
        VerticalResolution = 22,
        VideoMode = 30,
        VideoRam = 55,
        WakeUpType = 97,
        Warranty = 41,
        WarrantyUntil = 106,
        Website = 52,
        Workplace = 89,
        Workstation = 176,
        ZabbixDeviceId = 187,
        ZabbixLastCheckIn = 188,
        ZipCode = 115,
        __order = 33,
    }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKind.KindFlags.html#fields"/>
    [Flags]
    public enum KindFlags {
        [Obsolete("It&#39;s no longer in use.")]
        Classified = 1,
        [Obsolete("It&#39;s no longer in use.")]
        Hidden = 4,
        ImplicitValue = 2,
        NoInherit = 32,
        [Obsolete("It&#39;s no longer in use.")]
        Password = 128,
        [Obsolete("It&#39;s no longer in use.")]
        PropViewTabPosition = 64,
        SelectOnly = 8192,
        [Obsolete("It&#39;s no longer in use.")]
        Unique = 4096,
        [Obsolete("It&#39;s no longer in use.")]
        WMI_Classified = 8,
        [Obsolete("It&#39;s no longer in use.")]
        WMI_Key = 16,
        [Obsolete("It&#39;s no longer in use.")]
        WMI_LoginName = 256,
        [Obsolete("It&#39;s no longer in use.")]
        WMI_Measure = 2048,
        [Obsolete("It&#39;s no longer in use.")]
        WMI_REG = 512,
        [Obsolete("It&#39;s no longer in use.")]
        WMI_Scanner = 1024,
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
    //[Ignore] // ! TODO: Investigate where this come from
    public string DataType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKind.html#Alvao_API_Common_Model_Database_tblKind_IsSystem"/>
    //[Ignore] // ! TODO: Investigate where this come from
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
