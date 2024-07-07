namespace Alvao.API.SD.Model;

public class ApprovalSchemaStepModel
{
    public bool AuthorityManagerOfUser { get; set; }
    public bool AuthorityRequester { get; set; }
    public bool AuthorityRootManagerOfUser { get; set; }
    public bool AutoApproveByRequester { get; set; }
    public bool AutoApproveStepsSameApprover { get; set; }
    public double ExpirationHours { get; set; }
    public int TicketApprovalId { get; set; }

    public ApprovalSchemaStepModel() { }
}
