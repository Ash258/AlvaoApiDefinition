using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

[TableAttribute("dbo.NewTicketFormSection")]
public class NewTicketFormSection
{
    public virtual bool Expand { get; set; }
    [KeyAttribute]
    public virtual int id { get; set; }
    public virtual string Name { get; set; }
    public virtual int Order { get; set; }
    public virtual int SectionId { get; set; }

    public NewTicketFormSection() { }
}
