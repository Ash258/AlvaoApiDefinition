namespace Alvao.API.AM.Model;

public class AutoAssignedLicense
{
    public string AutoAssignFilter { get; set; }
    public string Centre { get; set; }
    public int Cnt { get; set; }
    public int ItemId { get; set; }
    public int LicHistId { get; set; }
    public string LicOrganization { get; set; }
    public int ProductId { get; set; }

    public AutoAssignedLicense() { }
}
