namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.AutomaticMonitorCreationModel.html"/>
public class AutomaticMonitorCreationModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.AutomaticMonitorCreationModel.OwnershipValueBehavior.html#fields"/>
    public enum OwnershipValueBehavior {
        CompanyAssigned = 0,
        CompanyShared = 1,
        Personal = 2,
    }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.AutomaticMonitorCreationModel.html#Alvao_API_AM_Model_AutomaticMonitorCreationModel_CreateAnywhere"/>
    public bool CreateAnywhere { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.AutomaticMonitorCreationModel.html#Alvao_API_AM_Model_AutomaticMonitorCreationModel_ExceptionClassIds"/>
    public IEnumerable<int> ExceptionClassIds { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.AutomaticMonitorCreationModel.html#Alvao_API_AM_Model_AutomaticMonitorCreationModel_IsEnabled"/>
    public bool IsEnabled { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.AutomaticMonitorCreationModel.html#Alvao_API_AM_Model_AutomaticMonitorCreationModel_PlaceAlongside"/>
    public bool PlaceAlongside { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.AutomaticMonitorCreationModel.html#Alvao_API_AM_Model_AutomaticMonitorCreationModel_ScopeParentNodeIds"/>
    public IEnumerable<int> ScopeParentNodeIds { get; set; }
}
