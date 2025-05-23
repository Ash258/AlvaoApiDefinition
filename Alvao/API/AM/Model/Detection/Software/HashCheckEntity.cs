namespace Alvao.API.AM.Model.Detection.Software;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Software.HashCheckEntity.html"/>
public class HashCheckEntity {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Software.HashCheckEntity.html#Alvao_API_AM_Model_Detection_Software_HashCheckEntity_CsvSignature"/>
    public string CsvSignature { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Software.HashCheckEntity.html#Alvao_API_AM_Model_Detection_Software_HashCheckEntity_Hash"/>
    public byte[] Hash { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Software.HashCheckEntity.html#Alvao_API_AM_Model_Detection_Software_HashCheckEntity_Id"/>
    public int Id { get; set; }

}
