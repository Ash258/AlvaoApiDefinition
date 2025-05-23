using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Definitions of the objects properties.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblKind.htm"/>
[TableAttribute("dbo.tblKind")]
public class tblKind {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblKind_KindCode.htm"/>
    public enum KindCode {
        Name = 0,
        HostName = 3,
        User = 5,
        Place = 7,
        Address = 8,
        TypeDesignation = 10,
        InventaryNo = 11,
        SerialNo = 12,
        PackingSlipNo = 13,
        Port = 14,
        Manufacturer = 16,
        Type = 17,
        Frequency = 18,
        RefreshMax = 19,
        Version = 23,
        Supplier = 38,
        Department = 39,
        PurchaseDate = 40,
        Warranty = 41,
        PCDescription = 42,
        Phone = 44,
        Fax = 45,
        UserEmail = 46,
        OrganizationName = 48,
        Size = 50,
        LoginName = 54,
        VideoRam = 55,
        Centre = 57,
        MacAddress = 61,
        IPAddress = 62,
        Domain = 63,
        Interface = 68,
        UserPersonalId = 74,
        ComputerKind = 78,
        BiosSN = 87,
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
        ProcessorId = 104,
        LandeskId = 105,
        WarrantyUntil = 106,
        MobilePhone = 107,
        JobTitle = 108,
        City = 109,
        Street = 110,
        Country = 111,
        Company = 112,
        StateOrProvince = 114,
        ZipCode = 115,
        HomePhone = 116,
        Pager = 117,
        VMHostName = 137,
        LastLoggedUser = 139,
        NumberOfLogicalProcessors = 140,
        AccountIsDisabled = 144,
        Resp = 145,
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
    }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblKind_KindFlags.htm"/>
    [FlagsAttribute]
    public enum KindFlags {
        Classified = 1,
        ImplicitValue = 2,
        Hidden = 4,
        WMI_Classified = 8,
        WMI_Key = 16,
        NoInherit = 32,
        PropViewTabPosition = 64,
        Password = 128,
        WMI_LoginName = 256,
        WMI_REG = 512,
        WMI_Scanner = 1_024,
        WMI_Measure = 2_048,
        Unique = 4_096,
        SelectOnly = 8_192,
    }
    /// <summary>1 = global property for a class of objects. "0" indicates the property is considered local for each class of objects (printers, computers etc.). An automatic list of values is then put together from the values of this property for the given object class,</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblKind_bolGlobalScope.htm"/>
    public virtual bool bolGlobalScope { get; set; }
    /// <summary>1 = property value must be unique</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblKind_bolUnique.htm"/>
    public virtual bool bolUnique { get; set; }
    /// <summary>1 = property value can only be selected from the list of values</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblKind_bSelectOnly.htm"/>
    public virtual bool bSelectOnly { get; set; }
    /// <summary>1 = Delete value when copying properties</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblKind_CleanValueByCopying.htm"/>
    public virtual bool CleanValueByCopying { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblKind_DataType.htm"/>
    public string DataType { get; set; }
    /// <summary>bit field:0x20 = property not inheritable</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblKind_intFlags.htm"/>
    public virtual int? intFlags { get; set; }
    /// <summary>The unique number determines the property (integrated ones are numbered), user properties do not have this number</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblKind_intKindCode.htm"/>
    public virtual int? intKindCode { get; set; }
    /// <summary>primary key</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblKind_intKindId.htm"/>
    [KeyAttribute]
    public virtual int intKindId { get; set; }
    /// <summary>The sequence for table filtering can be set</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblKind_intOrder.htm"/>
    public virtual int? intOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblKind_IsSystem.htm"/>
    public bool IsSystem { get; set; }
    /// <summary>Property data type ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblKind_KindDataTypeId.htm"/>
    public virtual int KindDataTypeId { get; set; }
    /// <summary>icon - tblIcon</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblKind_lintIconId.htm"/>
    public virtual int? lintIconId { get; set; }
    /// <summary>This attribute contains the tblKind.intKindId definition of the property, from which the list of values shall be used (tblKindValue)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblKind_lintValueKindId.htm"/>
    public virtual int? lintValueKindId { get; set; }
    /// <summary>1 = the property is mandatory in objects of all kinds that use it. In this case, there is no record for it in the RequiredClassKind table.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblKind_RequiredForAllClasses.htm"/>
    public virtual bool RequiredForAllClasses { get; set; }
    /// <summary>property name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblKind_txtName.htm"/>
    public virtual string txtName { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblKind__ctor.htm"/>
    public tblKind() { }
}
