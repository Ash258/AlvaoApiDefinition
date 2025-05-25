using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Employee absence records.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tTimeOff.html"/>
[Table("dbo.tTimeOff")]
public class tTimeOff {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tTimeOff.html#Alvao_API_Common_Model_Database_tTimeOff_bHalf"/>
    public virtual bool bHalf { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tTimeOff.html#Alvao_API_Common_Model_Database_tTimeOff_dCreated"/>
    public virtual DateTime dCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tTimeOff.html#Alvao_API_Common_Model_Database_tTimeOff_dModified"/>
    public virtual DateTime dModified { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tTimeOff.html#Alvao_API_Common_Model_Database_tTimeOff_dTimeOff"/>
    public virtual DateTime dTimeOff { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tTimeOff.html#Alvao_API_Common_Model_Database_tTimeOff_iTimeOffId"/>
    [Key]
    public virtual int iTimeOffId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tTimeOff.html#Alvao_API_Common_Model_Database_tTimeOff_liCreatedPersonId"/>
    public virtual int? liCreatedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tTimeOff.html#Alvao_API_Common_Model_Database_tTimeOff_liModifiedPersonId"/>
    public virtual int? liModifiedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tTimeOff.html#Alvao_API_Common_Model_Database_tTimeOff_liPersonId"/>
    public virtual int liPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tTimeOff.html#Alvao_API_Common_Model_Database_tTimeOff_liTimeOffKindId"/>
    public virtual int liTimeOffKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tTimeOff.html#Alvao_API_Common_Model_Database_tTimeOff_mNotes"/>
    public virtual string mNotes { get; set; }
}
