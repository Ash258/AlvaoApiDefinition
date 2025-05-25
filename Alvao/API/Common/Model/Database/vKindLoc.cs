using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Translations of the object properties in all languages ââused.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vKindLoc.html"/>
[Table("dbo.vKindLoc")]
public class vKindLoc {
    /// <summary>1 = Delete value when copying properties</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vKindLoc.html#Alvao_API_Common_Model_Database_vKindLoc_CleanValueByCopying"/>
    public virtual bool CleanValueByCopying { get; set; }
    /// <summary>NodeCust table column name that stores the property value.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vKindLoc.html#Alvao_API_Common_Model_Database_vKindLoc_ColumnName"/>
    public virtual string ColumnName { get; set; }
    /// <summary>Property data type ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vKindLoc.html#Alvao_API_Common_Model_Database_vKindLoc_KindDataTypeId"/>
    public virtual int KindDataTypeId { get; set; }
    /// <summary>LCID of the language into which the localization is performed.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vKindLoc.html#Alvao_API_Common_Model_Database_vKindLoc_KindLocaleId"/>
    public virtual int KindLocaleId { get; set; }
    /// <summary>Localized property name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vKindLoc.html#Alvao_API_Common_Model_Database_vKindLoc_LocalizedName"/>
    public virtual string LocalizedName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vKindLoc.html#Alvao_API_Common_Model_Database_vKindLoc_Precision"/>
    public virtual int? Precision { get; set; }
    /// <summary>1 = property value can only be selected from the list of values</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vKindLoc.html#Alvao_API_Common_Model_Database_vKindLoc_bSelectOnly"/>
    public virtual bool bSelectOnly { get; set; }
    /// <summary>1 = global property for a class of objects. &quot;0&quot; indicates the property is considered local for each class of objects (printers, computers etc.). An automatic list of values is then put together from the values of this property for the given object class,</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vKindLoc.html#Alvao_API_Common_Model_Database_vKindLoc_bolGlobalScope"/>
    public virtual bool bolGlobalScope { get; set; }
    /// <summary>1 = property value must be unique</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vKindLoc.html#Alvao_API_Common_Model_Database_vKindLoc_bolUnique"/>
    public virtual bool bolUnique { get; set; }
    /// <summary>bit array: 0x20 = property is not heritable</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vKindLoc.html#Alvao_API_Common_Model_Database_vKindLoc_intFlags"/>
    public virtual int? intFlags { get; set; }
    /// <summary>The unique number determines the property (integrated ones are numbered), user properties do not have this number</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vKindLoc.html#Alvao_API_Common_Model_Database_vKindLoc_intKindCode"/>
    public virtual int? intKindCode { get; set; }
    /// <summary>Property definition ID (tblKind.intKindId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vKindLoc.html#Alvao_API_Common_Model_Database_vKindLoc_intKindId"/>
    public virtual int intKindId { get; set; }
    /// <summary>The sequence for table filtering can be set</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vKindLoc.html#Alvao_API_Common_Model_Database_vKindLoc_intOrder"/>
    public virtual int? intOrder { get; set; }
    /// <summary>This attribute contains the tblKind.intKindId definition of the property, from which the list of values shall be used (tblKindValue)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vKindLoc.html#Alvao_API_Common_Model_Database_vKindLoc_lintValueKindId"/>
    public virtual int? lintValueKindId { get; set; }
    /// <summary>Property name in the ALVAO system language</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vKindLoc.html#Alvao_API_Common_Model_Database_vKindLoc_txtName"/>
    public virtual string txtName { get; set; }
}
