using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model.SolverAvailability;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.SolverAvailabilityModel.html"/>
public class SolverAvailabilityModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.SolverAvailabilityModel.html#Alvao_API_SD_Model_SolverAvailability_SolverAvailabilityModel_Availability"/>
    public SolverAvailabilityModel.AvailabilityModel Availability { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.SolverAvailabilityModel.html#Alvao_API_SD_Model_SolverAvailability_SolverAvailabilityModel_Person"/>
    public tPerson Person { get; set; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.SolverAvailabilityModel.AvailabilityModel.html"/>
    public record AvailabilityModel : IEquatable<AvailabilityModel> {
        /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.SolverAvailabilityModel.AvailabilityModel.html#Alvao_API_SD_Model_SolverAvailability_SolverAvailabilityModel_AvailabilityModel_CalendarDeltaEnd"/>
        public DateTime? CalendarDeltaEnd { get; init; }
        /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.SolverAvailabilityModel.AvailabilityModel.html#Alvao_API_SD_Model_SolverAvailability_SolverAvailabilityModel_AvailabilityModel_CalendarDeltaLink"/>
        public string CalendarDeltaLink { get; init; }
        /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.SolverAvailabilityModel.AvailabilityModel.html#Alvao_API_SD_Model_SolverAvailability_SolverAvailabilityModel_AvailabilityModel_CalendarDeltaStart"/>
        public DateTime? CalendarDeltaStart { get; init; }
        /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.SolverAvailabilityModel.AvailabilityModel.html#Alvao_API_SD_Model_SolverAvailability_SolverAvailabilityModel_AvailabilityModel_CalendarLastUpdate"/>
        public DateTime? CalendarLastUpdate { get; init; }
        /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.SolverAvailabilityModel.AvailabilityModel.html#Alvao_API_SD_Model_SolverAvailability_SolverAvailabilityModel_AvailabilityModel_ShiftsLastUpdate"/>
        public DateTime? ShiftsLastUpdate { get; init; }

        /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.SolverAvailabilityModel.AvailabilityModel.html#Alvao_API_SD_Model_SolverAvailability_SolverAvailabilityModel_AvailabilityModel__ctor_System_Nullable_System_DateTime__System_String_System_Nullable_System_DateTime__System_Nullable_System_DateTime__System_Nullable_System_DateTime__"/>
        public AvailabilityModel(DateTime? CalendarLastUpdate = null, string CalendarDeltaLink = null, DateTime? CalendarDeltaStart = null, DateTime? CalendarDeltaEnd = null, DateTime? ShiftsLastUpdate = null) { }
    }
}
