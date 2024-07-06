using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

[TableAttribute("dbo.vNewTicketFormSectionLoc")]
public class vNewTicketFormSectionLoc
{
    public virtual bool Expand { get; set; }
    public virtual int id { get; set; }
    public virtual int LocaleId { get; set; }
    public virtual string Name { get; set; }
    public virtual int Order { get; set; }
    public virtual int SectionId { get; set; }

    public vNewTicketFormSectionLoc() { }
}
