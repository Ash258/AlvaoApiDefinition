using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Map for determining the type of object based on device descriptions in SNMP.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_SnmpDeviceTypeMap.htm"/>
[TableAttribute("dbo.SnmpDeviceTypeMap")]
public class SnmpDeviceTypeMap
{
    /// <summary>Object type (see tblClass).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SnmpDeviceTypeMap_ClassId.htm"/>
    public virtual int? ClassId { get; set; }
    /// <summary>Record id</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SnmpDeviceTypeMap_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Regex pattern of the "sysDescr" SNMP values (OID 1.3.6.1.2.1.1.1) associated with this record. See Regular Expression Language - Quick Reference.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SnmpDeviceTypeMap_SysDescrRegex.htm"/>
    public virtual string SysDescrRegex { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_SnmpDeviceTypeMap__ctor.htm"/>
    public SnmpDeviceTypeMap() { }
}
