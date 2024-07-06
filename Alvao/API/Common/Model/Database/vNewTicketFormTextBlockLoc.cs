using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

[TableAttribute("dbo.vNewTicketFormTextBlockLoc")]
public class vNewTicketFormTextBlockLoc
{
    public virtual int id { get; set; }
    public virtual int iLocaleId { get; set; }
    public virtual int Order { get; set; }
    public virtual int SectionId { get; set; }
    public virtual string TextHtml { get; set; }

    public vNewTicketFormTextBlockLoc() { }
}
