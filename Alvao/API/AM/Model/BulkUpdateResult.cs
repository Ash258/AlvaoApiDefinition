namespace Alvao.API.AM.Model;

/// <summary>Result of a bulk property update operation.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.BulkUpdateResult.html"/>
public class BulkUpdateResult {
    /// <summary>Aggregated error message from custom actions (if any).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.BulkUpdateResult.html#Alvao_API_AM_Model_BulkUpdateResult_ErrorMessage"/>
    public string ErrorMessage { get; set; }
    /// <summary>Object IDs that were skipped because the property was not found on the object.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.BulkUpdateResult.html#Alvao_API_AM_Model_BulkUpdateResult_MissingPropertyObjectIds"/>
    public IList<int> MissingPropertyObjectIds { get; set; }
    /// <summary>Object IDs that were skipped because the custom action rejected the modification.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.BulkUpdateResult.html#Alvao_API_AM_Model_BulkUpdateResult_RejectedObjectIds"/>
    public IList<int> RejectedObjectIds { get; set; }
    /// <summary>Object IDs that were skipped because the user does not have write permission.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.BulkUpdateResult.html#Alvao_API_AM_Model_BulkUpdateResult_UnauthorizedObjectIds"/>
    public IList<int> UnauthorizedObjectIds { get; set; }
    /// <summary>Object IDs that were successfully updated.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.BulkUpdateResult.html#Alvao_API_AM_Model_BulkUpdateResult_UpdatedObjectIds"/>
    public IList<int> UpdatedObjectIds { get; set; }
}
