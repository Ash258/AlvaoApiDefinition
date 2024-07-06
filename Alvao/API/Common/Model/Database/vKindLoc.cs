using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Translations of the object properties in all languages ​​used.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vKindLoc.htm"/>
[TableAttribute("dbo.vKindLoc")]
public class vKindLoc
{
    /// <summary>1 = global property for a class of objects. "0" indicates the property is considered local for each class of objects (printers, computers etc.). An automatic list of values is then put together from the values of this property for the given object class,</summary>
    public virtual bool bolGlobalScope { get; set; }
    /// <summary>1 = property value must be unique</summary>
    public virtual bool bolUnique { get; set; }
    /// <summary>1 = property value can only be selected from the list of values</summary>
    public virtual bool bSelectOnly { get; set; }
    /// <summary>1 = Delete value when copying properties</summary>
    public virtual bool CleanValueByCopying { get; set; }
    /// <summary>bit array: 0x20 = property is not heritable</summary>
    public virtual int? intFlags { get; set; }
    /// <summary>The unique number determines the property (integrated ones are numbered), user properties do not have this number</summary>
    public virtual int? intKindCode { get; set; }
    /// <summary>Property definition ID (tblKind.intKindId)</summary>
    public virtual int intKindId { get; set; }
    /// <summary>The sequence for table filtering can be set</summary>
    public virtual int? intOrder { get; set; }
    /// <summary>Property data type ID</summary>
    public virtual int KindDataTypeId { get; set; }
    /// <summary>LCID of the language into which the localization is performed.</summary>
    public virtual int KindLocaleId { get; set; }
    /// <summary>Icon (tblIcon.intIconId)</summary>
    public virtual int? lintIconId { get; set; }
    /// <summary>This attribute contains the tblKind.intKindId definition of the property, from which the list of values shall be used (tblKindValue)</summary>
    public virtual int? lintValueKindId { get; set; }
    /// <summary>Localized property name</summary>
    public virtual string LocalizedName { get; set; }
    /// <summary>Property name in the ALVAO system language</summary>
    public virtual string txtName { get; set; }

    public vKindLoc() { }
}
