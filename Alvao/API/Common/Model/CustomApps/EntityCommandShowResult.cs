// CAUTION: Manually guessed object based on the documentation. It does not need to be completely accurate.

namespace Alvao.API.Common.Model.CustomApps;

public class EntityCommandShowResult {
    public string Name { get; }
    public bool Show { get; }
    public int Position { get; }
    public string Icon { get; }

    public EntityCommandShowResult(bool show, string name, string icon, int position) {
        Show = show;
        Name = name;
        Icon = icon;
        Position = position;
    }
}
