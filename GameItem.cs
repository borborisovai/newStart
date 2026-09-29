namespace newStart;

public class GameItem
{
    public string Name {get; set;} = string.Empty;
    public Rarity Rarity {get; set;} = Rarity.Common;
    public string Description {get; set;} = string.Empty;

}

public enum Rarity {
    Common,
    Rare,
    Mystic,
    Legendary
}

