using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Employee absence records.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tTimeOff.html"/>
[Table("dbo.tTimeOff")]
public class tTimeOff {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tTimeOff.html#Alvao_API_Common_Model_Database_tTimeOff_bHalf"/>
    /// <remarks>Column <c>bHalf</c>: bit, not null.</remarks>
    public virtual bool bHalf { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tTimeOff.html#Alvao_API_Common_Model_Database_tTimeOff_dCreated"/>
    /// <remarks>Column <c>dCreated</c>: datetime, not null.</remarks>
    public virtual DateTime dCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tTimeOff.html#Alvao_API_Common_Model_Database_tTimeOff_dModified"/>
    /// <remarks>Column <c>dModified</c>: datetime, not null.</remarks>
    public virtual DateTime dModified { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tTimeOff.html#Alvao_API_Common_Model_Database_tTimeOff_dTimeOff"/>
    /// <remarks>Column <c>dTimeOff</c>: datetime, not null.</remarks>
    public virtual DateTime dTimeOff { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tTimeOff.html#Alvao_API_Common_Model_Database_tTimeOff_iTimeOffId"/>
    /// <remarks>Column <c>iTimeOffId</c>: int, not null.</remarks>
    [Key]
    public virtual int iTimeOffId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tTimeOff.html#Alvao_API_Common_Model_Database_tTimeOff_liCreatedPersonId"/>
    /// <remarks>Column <c>liCreatedPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? liCreatedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tTimeOff.html#Alvao_API_Common_Model_Database_tTimeOff_liModifiedPersonId"/>
    /// <remarks>Column <c>liModifiedPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? liModifiedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tTimeOff.html#Alvao_API_Common_Model_Database_tTimeOff_liPersonId"/>
    /// <remarks>Column <c>liPersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int liPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tTimeOff.html#Alvao_API_Common_Model_Database_tTimeOff_liTimeOffKindId"/>
    /// <remarks>Column <c>liTimeOffKindId</c>: int, not null. References <see cref="tTimeOffKind"/>.</remarks>
    public virtual int liTimeOffKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tTimeOff.html#Alvao_API_Common_Model_Database_tTimeOff_mNotes"/>
    /// <remarks>Column <c>mNotes</c>: nvarchar(max), null.</remarks>
    public virtual string mNotes { get; set; }
}
