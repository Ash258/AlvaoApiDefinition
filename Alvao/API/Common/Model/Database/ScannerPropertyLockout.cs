using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Locking of values of object properties (dbo.tblProperty) for editing by scanners (dbo.Scanner).
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_ScannerPropertyLockout.htm"/>
[TableAttribute("dbo.ScannerPropertyLockout")]
public class ScannerPropertyLockout
{
    /// <summary>Object kind (tblClass.intClassId)</summary>
    public virtual int ClassId { get; set; }
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>A property definition (tblKind.intKindId) which is locked for editing by the non-empty value of the property LockingKindId.</summary>
    public virtual int LockedKindId { get; set; }
    /// <summary>A property definition (tblKind.intKindId) whose non-empty value (tblProperty) locks the property LockedKindId for editing.</summary>
    public virtual int LockingKindId { get; set; }
    /// <summary>Scanner (Scanner.id)</summary>
    public virtual int ScannerId { get; set; }

    public ScannerPropertyLockout() { }
}
