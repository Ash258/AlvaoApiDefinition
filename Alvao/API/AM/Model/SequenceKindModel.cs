using Alvao.API.Common.Model.Database;

namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SequenceKindModel.html"/>
public record SequenceKindModel : IEquatable<SequenceKindModel> {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SequenceKindModel.html#Alvao_API_AM_Model_SequenceKindModel_kind"/>
    public tblKind kind { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SequenceKindModel.html#Alvao_API_AM_Model_SequenceKindModel_sequenceId"/>
    public int sequenceId { get; init; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SequenceKindModel.html#Alvao_API_AM_Model_SequenceKindModel__ctor_System_Int32_Alvao_API_Common_Model_Database_tblKind_"/>
    public SequenceKindModel(int sequenceId, tblKind kind) { }
}
