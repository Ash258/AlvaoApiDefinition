using Alvao.API.AM.Model;

namespace Alvao.API.AM;

/// <summary>Facade class grouping object risk management methods</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.ObjectRiskManagement.html"/>
public static class ObjectRiskManagement {
    /// <summary>Checks whether risk management related data has been affected.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.ObjectRiskManagement.html#Alvao_API_AM_ObjectRiskManagement_IsRiskManagementRelatedDataUpdated_System_Int32_System_Nullable_System_Int32__Alvao_API_AM_Model_Property_"/>
    /// <returns>True, if some of the relevant Risk management data has been updated.</returns>
    public static bool IsRiskManagementRelatedDataUpdated(int personId, int? relationId, Property prop = null) { throw new NotImplementedException(); }
    /// <summary>Checks whether the relation is of Risk management type.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.ObjectRiskManagement.html#Alvao_API_AM_ObjectRiskManagement_IsRiskManagementRelation_System_Int32_"/>
    /// <returns>True, if relation is of Risk management type.</returns>
    public static bool IsRiskManagementRelation(int relationId) { throw new NotImplementedException(); }
    /// <summary>Creates and updates Risk management relations between Threats, Vulnerabilites and Assets.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.ObjectRiskManagement.html#Alvao_API_AM_ObjectRiskManagement_UpdateRiskManagementRelations_System_Int32_"/>
    public static void UpdateRiskManagementRelations(int personId) { throw new NotImplementedException(); }
}
