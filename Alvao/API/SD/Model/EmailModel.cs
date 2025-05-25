namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.EmailModel.html"/>
public class EmailModel : IEquatable<EmailModel> {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.EmailModel.html#Alvao_API_SD_Model_EmailModel_EmailFormat"/>
    public const string EmailFormat = "(?:(?:(?<text>([^\\<;]{1,})|(['\"][^@]{1,}['\"]\\s*))?\\<(?<address>[\\w\\.!#$%&'*+\\-/=?\\^_`{|}~]+@[A-Za-z0-9\\.\\+\\-_%]+)\\>)|(?:(?<address>[\\w\\.!#$%&'*+\\-/=?\\^_`{|}~]+@[A-Za-z0-9\\.\\+\\-_%]+)))(['])?(?:[;\\,])?";
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.EmailModel.html#Alvao_API_SD_Model_EmailModel_EmailPattern"/>
    public const string EmailPattern = "^[\\w!#$%&'*+\\-/=?\\^_`{|}~]+(\\.[\\w!#$%&'*+\\-/=?\\^_`{|}~]+)*@(?!-)((([\\-\\w]*(\\w)+\\.(?!-))+[a-zA-Z]{2,})|(([0-9]{1,3}\\.){3}[0-9]{1,3}))$";

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.EmailModel.html#Alvao_API_SD_Model_EmailModel_Address"/>
    public string Address { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.EmailModel.html#Alvao_API_SD_Model_EmailModel_ShouldDisplay"/>
    public bool ShouldDisplay { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.EmailModel.html#Alvao_API_SD_Model_EmailModel_Text"/>
    public string Text { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.EmailModel.html#Alvao_API_SD_Model_EmailModel__ctor"/>
    public EmailModel() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.EmailModel.html#Alvao_API_SD_Model_EmailModel__ctor_System_Collections_Generic_IEqualityComparer_Alvao_API_SD_Model_EmailModel__"/>
    public EmailModel(IEqualityComparer<EmailModel> comparer) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.EmailModel.html#Alvao_API_SD_Model_EmailModel__ctor_System_String_System_Collections_Generic_IEqualityComparer_Alvao_API_SD_Model_EmailModel__"/>
    public EmailModel(string addressWithText, IEqualityComparer<EmailModel> comparerer = null) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.EmailModel.html#Alvao_API_SD_Model_EmailModel__ctor_System_String_System_String_System_Collections_Generic_IEqualityComparer_Alvao_API_SD_Model_EmailModel__"/>
    public EmailModel(string address, string text, IEqualityComparer<EmailModel> comparerer = null) { }

    /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.EmailModel.html#Alvao_API_SD_Model_EmailModel_Equals_Alvao_API_SD_Model_EmailModel_"/>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
    public bool Equals(EmailModel other) { throw new System.NotImplementedException(); }
    /// <summary>Determines whether the specified object is equal to the current object.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.EmailModel.html#Alvao_API_SD_Model_EmailModel_Equals_System_Object_"/>
    /// <param name="obj">The object to compare with the current object.</param>
    /// <returns>true if the specified object  is equal to the current object; otherwise, false.</returns>
    public override bool Equals(object obj) { throw new System.NotImplementedException(); }
    /// <summary>Serves as the default hash function.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.EmailModel.html#Alvao_API_SD_Model_EmailModel_GetHashCode"/>
    /// <returns>A hash code for the current object.</returns>
    public override int GetHashCode() { throw new System.NotImplementedException(); }
    /// <summary>Returns a string that represents the current object.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.EmailModel.html#Alvao_API_SD_Model_EmailModel_ToString"/>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString() { throw new System.NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.EmailModel.html#Alvao_API_SD_Model_EmailModel_op_Explicit_System_String__Alvao_API_SD_Model_EmailModel"/>
    public static explicit operator EmailModel(string value) { throw new System.NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.EmailModel.html#Alvao_API_SD_Model_EmailModel_op_Implicit_Alvao_API_SD_Model_EmailModel__System_String"/>
    public static implicit operator string(EmailModel value) { throw new System.NotImplementedException(); }
}
