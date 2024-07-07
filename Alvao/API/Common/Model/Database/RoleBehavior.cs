using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Types of system rolls, e.g. all users, administrators, ...
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_RoleBehavior.htm"/>
[TableAttribute("dbo.RoleBehavior")]
public class RoleBehavior
{
    public enum BehaviorId
    {
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

    public virtual string _RoleBehavior { get; set; }
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }

    public RoleBehavior() { }
}
