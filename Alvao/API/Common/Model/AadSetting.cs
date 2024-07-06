namespace Alvao.API.Common.Model;

public class AadSetting
{
    public string ApplicationId { get; set; }
    public string Secret { get; set; }
    public string TenantId { get; set; }

    public AadSetting() { }
}
