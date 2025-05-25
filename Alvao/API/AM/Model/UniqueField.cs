namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.UniqueField.html"/>
public class UniqueField {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.UniqueField.html#Alvao_API_AM_Model_UniqueField_ColPos"/>
    public int ColPos { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.UniqueField.html#Alvao_API_AM_Model_UniqueField_ColumnName"/>
    public string ColumnName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.UniqueField.html#Alvao_API_AM_Model_UniqueField_Global"/>
    public bool Global { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.UniqueField.html#Alvao_API_AM_Model_UniqueField_Id"/>
    public int Id { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.UniqueField.html#Alvao_API_AM_Model_UniqueField_KindDataType"/>
    public int KindDataType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.UniqueField.html#Alvao_API_AM_Model_UniqueField_Name"/>
    public string Name { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.UniqueField.html#Alvao_API_AM_Model_UniqueField__ctor_System_Int32_System_String_System_String_System_Int32_System_Boolean_System_Int32_"/>
    public UniqueField(int id, string columnName, string name, int colPos, bool global, int kindDataType) { }
}
