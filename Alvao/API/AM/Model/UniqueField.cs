namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Model_UniqueField.htm"/>
public class UniqueField
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_UniqueField_ColPos.htm"/>
    public int ColPos { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_UniqueField_Global.htm"/>
    public bool Global { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_UniqueField_Id.htm"/>
    public int Id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_UniqueField_Name.htm"/>
    public string Name { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Model_UniqueField__ctor.htm"/>
    public UniqueField(
        int id,
        string name,
        int colPos,
        bool global
    )
    { }
}
