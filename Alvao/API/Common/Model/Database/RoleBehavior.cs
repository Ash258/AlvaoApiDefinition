using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Types of system rolls, e.g. all users, administrators, ...</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RoleBehavior.html"/>
[Table("dbo.RoleBehavior")]
public class RoleBehavior {
    /// <summary>Enumeration representing system groups.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RoleBehavior.BehaviorId.html#fields"/>
    public enum BehaviorId {
        Accountants = 13,
        Administrators = 3,
        AssetAdministrators = 8,
        AssetManagers = 11,
        AssetReaders = 10,
        AssetRelationsManagers = 14,
        AssetRelationsReaders = 15,
        AssetSwProfilesManagers = 16,
        ContactsManagers = 7,
        ContactsReader = 27,
        Custom = 1,
        CustomApplicationsManager = 23,
        HwAndSwDetectionsManagers = 12,
        InsiderPreviewTesters = 19,
        KindManagers = 18,
        KindReaders = 17,
        KnowledgeBaseRootAdministrator = 26,
        RegisteredUsers = 20,
        SectionAdmin = 21,
        SettingsManager = 22,
        SoftwareLicenseManagers = 9,
        SoftwareManagers = 5,
        SqlQueryManagers = 25,
        TeamManagers = 6,
        TicketRequesterAuthority = 24,
        WorkTime = 2,
    }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RoleBehavior.html#Alvao_API_Common_Model_Database_RoleBehavior__RoleBehavior"/>
    public virtual string _RoleBehavior { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RoleBehavior.html#Alvao_API_Common_Model_Database_RoleBehavior_id"/>
    [ExplicitKey]
    public virtual int id { get; set; }
}
