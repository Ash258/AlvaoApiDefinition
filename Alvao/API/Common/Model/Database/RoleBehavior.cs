using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Types of system rolls, e.g. all users, administrators, ...</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RoleBehavior.html"/>
[Table("dbo.RoleBehavior")]
public class RoleBehavior {
    /// <summary>Enumeration representing system groups.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RoleBehavior.BehaviorId.html#fields"/>
    public enum BehaviorId {
        Custom = 1,
        WorkTime = 2,
        Administrators = 3,
        SoftwareManagers = 5,
        TeamManagers = 6,
        ContactsManagers = 7,
        AssetAdministrators = 8,
        SoftwareLicenseManagers = 9,
        AssetReaders = 10,
        AssetManagers = 11,
        HwAndSwDetectionsManagers = 12,
        Accountants = 13,
        AssetRelationsManagers = 14,
        AssetRelationsReaders = 15,
        AssetSwProfilesManagers = 16,
        KindReaders = 17,
        KindManagers = 18,
        InsiderPreviewTesters = 19,
        RegisteredUsers = 20,
        SectionAdmin = 21,
        SettingsManager = 22,
        CustomApplicationsManager = 23,
        TicketRequesterAuthority = 24,
        SqlQueryManagers = 25,
        KnowledgeBaseRootAdministrator = 26,
        ContactsReader = 27,
    }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RoleBehavior.html#Alvao_API_Common_Model_Database_RoleBehavior__RoleBehavior"/>
    public virtual string _RoleBehavior { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RoleBehavior.html#Alvao_API_Common_Model_Database_RoleBehavior_id"/>
    [ExplicitKey]
    public virtual int id { get; set; }
}
