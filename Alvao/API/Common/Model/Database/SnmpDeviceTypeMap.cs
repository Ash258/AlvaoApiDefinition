using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Map for determining the type of object based on device descriptions in SNMP.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SnmpDeviceTypeMap.html"/>
[Table("dbo.SnmpDeviceTypeMap")]
public class SnmpDeviceTypeMap {
    /// <summary>Object type (see tblClass).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SnmpDeviceTypeMap.html#Alvao_API_Common_Model_Database_SnmpDeviceTypeMap_ClassId"/>
    /// <remarks>Column <c>ClassId</c>: int, null. References <see cref="tblClass"/>.</remarks>
    public virtual int? ClassId { get; set; }
    /// <summary>
    /// Regex pattern of the &quot;sysDescr&quot; SNMP values (OID 1.3.6.1.2.1.1.1) associated with this record. See
    /// Regular Expression Language - Quick Reference.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SnmpDeviceTypeMap.html#Alvao_API_Common_Model_Database_SnmpDeviceTypeMap_SysDescrRegex"/>
    /// <remarks>Column <c>SysDescrRegex</c>: nvarchar(max), not null.</remarks>
    public virtual string SysDescrRegex { get; set; }
    /// <summary>Record id</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SnmpDeviceTypeMap.html#Alvao_API_Common_Model_Database_SnmpDeviceTypeMap_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
