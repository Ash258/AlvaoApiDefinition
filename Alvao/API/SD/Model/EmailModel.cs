namespace Alvao.API.SD.Model;

public class EmailModel : IEquatable<EmailModel>
{
    public const string EmailFormat = @"(?:(?:(?<text>([^\<;]{1,})|(['""][^@]{1,}['""]\s*))?\<(?<address>[\w\.!#$%&amp;'*+\-/=?\^_`{|}~]+@[A-Za-z0-9\.\+\-_%]+)\>)|(?:(?<address>[\w\.!#$%&amp;'*+\-/=?\^_`{|}~]+@[A-Za-z0-9\.\+\-_%]+)))(['])?(?:[;\,])?";
    public const string EmailPattern = @"^[\w!#$%&amp;'*+\-/=?\^_`{|}~]+(\.[\w!#$%&amp;'*+\-/=?\^_`{|}~]+)*@(?!-)((([\-\w]*(\w)+\.(?!-))+[a-zA-Z]{2,})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";

    public bool Equals(EmailModel? other)
    {
        throw new NotImplementedException();
    }
}
