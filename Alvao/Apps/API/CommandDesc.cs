// CAUTION: Manually guessed object based on the documentation. It does not need to be completely accurate.

namespace Alvao.Apps.API;

public class CommandDesc {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Position { get; set; }
    public string Icon { get; set; }

    public CommandDesc(int id, string name, int position, string icon) {
        Id = id;
        Name = name;
        Position = position;
        Icon = icon;
    }
}
