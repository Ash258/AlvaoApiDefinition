using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

[TableAttribute("dbo.NewTicketFormTextBlock")]
public class NewTicketFormTextBlock
{
    [KeyAttribute]
    public virtual int id { get; set; }
    public virtual int Order { get; set; }
    public virtual int SectionId { get; set; }
    public virtual string TextHtml { get; set; }

    public NewTicketFormTextBlock() { }
}
