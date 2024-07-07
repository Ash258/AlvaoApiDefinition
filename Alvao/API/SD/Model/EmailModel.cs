namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Model_EmailModel.htm"/>
public class EmailModel : IEquatable<EmailModel>
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_EmailModel_Address.htm"/>
    public string Address { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_EmailModel_ShouldDisplay.htm"/>
    public bool ShouldDisplay { get; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_EmailModel_Text.htm"/>
    public string Text { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/F_Alvao_API_SD_Model_EmailModel_EmailFormat.htm"/>
    public const string EmailFormat = @"(?:(?:(?<text>([^\<;]{1,})|(['""][^@]{1,}['""]\s*))?\<(?<address>[\w\.!#$%&amp;'*+\-/=?\^_`{|}~]+@[A-Za-z0-9\.\+\-_%]+)\>)|(?:(?<address>[\w\.!#$%&amp;'*+\-/=?\^_`{|}~]+@[A-Za-z0-9\.\+\-_%]+)))(['])?(?:[;\,])?";
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/F_Alvao_API_SD_Model_EmailModel_EmailPattern.htm"/>
    public const string EmailPattern = @"^[\w!#$%&amp;'*+\-/=?\^_`{|}~]+(\.[\w!#$%&amp;'*+\-/=?\^_`{|}~]+)*@(?!-)((([\-\w]*(\w)+\.(?!-))+[a-zA-Z]{2,})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_EmailModel__ctor.htm"/>
    public EmailModel() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_EmailModel__ctor_1.htm"/>
    public EmailModel(
        IEqualityComparer<EmailModel> comparerer
    )
    { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_EmailModel__ctor_2.htm"/>
    public EmailModel(
        string addressWithText,
        IEqualityComparer<EmailModel> comparerer = null
    )
    { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_EmailModel__ctor_3.htm"/>
    public EmailModel(
        string address,
        string text,
        IEqualityComparer<EmailModel> comparerer = null
    )
    { }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_EmailModel_Equals.htm"/>
    ///
    /// <param name="other"> </param>
    public bool Equals(
        EmailModel other
    )
    { throw new System.NotImplementedException(); }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_EmailModel_Equals_1.htm"/>
    ///
    /// <param name="obj"> </param>
    public override bool Equals(
        Object obj
    )
    { throw new System.NotImplementedException(); }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_EmailModel_GetHashCode.htm"/>
    public override int GetHashCode() { throw new System.NotImplementedException(); }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_EmailModel_ToEmailModel.htm"/>
    ///
    /// <param name="left"> </param>
    /// <param name="right"> </param>
    public static EmailModel ToEmailModel(
        EmailModel left,
        EmailModel right
    )
    { throw new System.NotImplementedException(); }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_EmailModel_ToString.htm"/>
    public override string ToString() { throw new System.NotImplementedException(); }
}
