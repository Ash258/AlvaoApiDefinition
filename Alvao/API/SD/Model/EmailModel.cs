namespace Alvao.API.SD.Model;

public class EmailModel : IEquatable<EmailModel>
{
    public string Address { get; set; }
    public bool ShouldDisplay { get; }
    public string Text { get; set; }
    public const string EmailFormat = @"(?:(?:(?<text>([^\<;]{1,})|(['""][^@]{1,}['""]\s*))?\<(?<address>[\w\.!#$%&amp;'*+\-/=?\^_`{|}~]+@[A-Za-z0-9\.\+\-_%]+)\>)|(?:(?<address>[\w\.!#$%&amp;'*+\-/=?\^_`{|}~]+@[A-Za-z0-9\.\+\-_%]+)))(['])?(?:[;\,])?";
    public const string EmailPattern = @"^[\w!#$%&amp;'*+\-/=?\^_`{|}~]+(\.[\w!#$%&amp;'*+\-/=?\^_`{|}~]+)*@(?!-)((([\-\w]*(\w)+\.(?!-))+[a-zA-Z]{2,})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";

    public EmailModel() { }
    public EmailModel(
        IEqualityComparer<EmailModel> comparerer
    )
    { }
    public EmailModel(
        string addressWithText,
        IEqualityComparer<EmailModel> comparerer = null
    )
    { }
    public EmailModel(
        string address,
        string text,
        IEqualityComparer<EmailModel> comparerer = null
    )
    { }

    /// <param name="other"> </param>
    public bool Equals(
        EmailModel other
    )
    { throw new System.NotImplementedException(); }

    /// <param name="obj"> </param>
    public override bool Equals(
        Object obj
    )
    { throw new System.NotImplementedException(); }

    public override int GetHashCode() { throw new System.NotImplementedException(); }

    /// <param name="left"> </param>
    /// <param name="right"> </param>
    public static EmailModel ToEmailModel(
        EmailModel left,
        EmailModel right
    )
    { throw new System.NotImplementedException(); }

    public override string ToString() { throw new System.NotImplementedException(); }
}
