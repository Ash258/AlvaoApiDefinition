using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

[TableAttribute("dbo.SectionSequence")]
public class SectionSequence
{
    public virtual int NextSectionId { get; set; }

    public SectionSequence() { }
}
