var arrow = GetArrow();
Console.WriteLine($"Your arrow cost is {arrow.GetCost()}");

Arrow GetArrow()
{
    return new Arrow(GetArrowhead(), GetFletching(), GetLength());
}

Arrowhead GetArrowhead()
{
    Console.Write("Pick your Arrowhead (steel, wood, obsidian): ");
    return Console.ReadLine() switch
    {
        "steel"     => Arrowhead.Steel,
        "wood"      => Arrowhead.Wood,
        "obsidian"  => Arrowhead.Obsidian
    };
}

Fletching GetFletching()
{
    Console.Write("Pick your Fletching (plastic, turkey feathers, goose feathers): ");
    return Console.ReadLine() switch
    {
        "plastic"           => Fletching.Plastic,
        "turkey feathers"   => Fletching.TurkeyFeathers,
        "goose feathers"    => Fletching.GooseFeathers
    };
}

float GetLength()
{
    float length = 0;

    while (length < 60 || length > 100)
    {
        Console.Write("Pick your Arrow's length between 60 - 100: ");
        length = Convert.ToSingle(Console.ReadLine());
    }

    return length;
}

public class Arrow
{
    private Arrowhead _arrowhead;
    private Fletching _fletching;
    private float _length;

    public Arrow() : this(Arrowhead.Steel, Fletching.Plastic, 60f)
    {

    }

    public Arrow(Arrowhead arrowHead, Fletching fletching, float length)
    {
        _arrowhead = arrowHead;
        _fletching = fletching;
        _length = length;
    }

    public Arrowhead GetArrowhead() => _arrowhead;
    public Fletching GetFletching() => _fletching;
    public float GetLength() => _length;

    public float GetCost()
    {
        var arrowheadCost = _arrowhead switch
        {
            Arrowhead.Steel     => 10,
            Arrowhead.Wood      => 3,
            Arrowhead.Obsidian  => 5
        };

        var fletchingCost = _fletching switch
        {
            Fletching.Plastic           => 10,
            Fletching.TurkeyFeathers    => 5,
            Fletching.GooseFeathers     => 3
        };

        var lengthCost = _length * 0.05f;

        var arrowCost = arrowheadCost + fletchingCost + lengthCost;

        return arrowCost;
    }

}


public enum Arrowhead { Steel, Wood, Obsidian }
public enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }