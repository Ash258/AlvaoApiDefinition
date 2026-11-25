using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Personal monitors.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vPersonalMonitors.html"/>
[Table("dbo.vPersonalMonitors")]
public class vPersonalMonitors {
    /// <summary>Date of the last scan of the monitor.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vPersonalMonitors.html#Alvao_API_Common_Model_Database_vPersonalMonitors_LastScanDate"/>
    public virtual DateTime? LastScanDate { get; set; }
    /// <summary>Monitor manufacturer.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vPersonalMonitors.html#Alvao_API_Common_Model_Database_vPersonalMonitors_Manufacturer"/>
    public virtual string Manufacturer { get; set; }
    /// <summary>Monitor model.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vPersonalMonitors.html#Alvao_API_Common_Model_Database_vPersonalMonitors_Model"/>
    public virtual string Model { get; set; }
    /// <summary>Computer to which the monitor was last connected during scan.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vPersonalMonitors.html#Alvao_API_Common_Model_Database_vPersonalMonitors_MonitorComputerLastScan"/>
    public virtual string MonitorComputerLastScan { get; set; }
    /// <summary>Name of the monitor object in the object tree.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vPersonalMonitors.html#Alvao_API_Common_Model_Database_vPersonalMonitors_Name"/>
    public virtual string Name { get; set; }
    /// <summary>Monitor object ID (tblNode.intNodeId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vPersonalMonitors.html#Alvao_API_Common_Model_Database_vPersonalMonitors_NodeId"/>
    public virtual int NodeId { get; set; }
    /// <summary>Full path of the monitor object in the object tree.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vPersonalMonitors.html#Alvao_API_Common_Model_Database_vPersonalMonitors_Path"/>
    public virtual string Path { get; set; }
    /// <summary>Monitor serial number.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vPersonalMonitors.html#Alvao_API_Common_Model_Database_vPersonalMonitors_SerialNumber"/>
    public virtual string SerialNumber { get; set; }
    /// <summary>Unique identifier of the monitor object (tblNode.UniqueId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vPersonalMonitors.html#Alvao_API_Common_Model_Database_vPersonalMonitors_UniqueId"/>
    public virtual string UniqueId { get; set; }
}
