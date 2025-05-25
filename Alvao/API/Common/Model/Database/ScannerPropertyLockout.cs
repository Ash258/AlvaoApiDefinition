using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Locking of values of object properties (dbo.tblKind) for editing by scanners (dbo.Scanner).</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ScannerPropertyLockout.html"/>
[Table("dbo.ScannerPropertyLockout")]
public class ScannerPropertyLockout {
    /// <summary>Object type (tblClass.intClassId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ScannerPropertyLockout.html#Alvao_API_Common_Model_Database_ScannerPropertyLockout_ClassId"/>
    public virtual int ClassId { get; set; }
    /// <summary>A property definition (tblKind.intKindId) which is locked for editing by the non-empty value of the property LockingKindId.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ScannerPropertyLockout.html#Alvao_API_Common_Model_Database_ScannerPropertyLockout_LockedKindId"/>
    public virtual int LockedKindId { get; set; }
    /// <summary>A property definition (tblKind.intKindId) whose non-empty value locks the property LockedKindId for editing.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ScannerPropertyLockout.html#Alvao_API_Common_Model_Database_ScannerPropertyLockout_LockingKindId"/>
    public virtual int LockingKindId { get; set; }
    /// <summary>Scanner (Scanner.id)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ScannerPropertyLockout.html#Alvao_API_Common_Model_Database_ScannerPropertyLockout_ScannerId"/>
    public virtual int ScannerId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ScannerPropertyLockout.html#Alvao_API_Common_Model_Database_ScannerPropertyLockout_id"/>
    [Key]
    public virtual int id { get; set; }
}
