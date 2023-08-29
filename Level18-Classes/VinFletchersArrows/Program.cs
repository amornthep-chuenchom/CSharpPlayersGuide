var arrow = GetArrow();
Console.WriteLine($"Your arrow costs {arrow.GetCost()} gold.");

Arrow GetArrow()
{
    Arrowhead arrowhead = GetArrowheadType();
    Fletching fletching = GetFletchingType();
    float length = GetLength();

    return new Arrow(arrowhead, fletching, length);
}

Arrowhead GetArrowheadType()
{
    Console.Write("Arrowhead Type (steel, wood, obsidian): ");
    string input = Console.ReadLine();

    return input switch
    {
        "steel"     => Arrowhead.Steel,
        "wood"      => Arrowhead.Wood,
        "obsidian"  => Arrowhead.Obsidian
    };
}

Fletching GetFletchingType()
{
    Console.Write("Fletching Type (plastic, turkey feather, goose feather): ");
    string input = Console.ReadLine();

    return input switch
    {
        "plastic"           => Fletching.Plastic,
        "turkey feather"    => Fletching.TurkeyFeathers,
        "goose feather"     => Fletching.GooseFeathers
    };
}

float GetLength()
{
    float length = 0;

    while (length < 60 || length > 100)
    {
        Console.Write("Arrow length (between 60 and 100): ");
        length = Convert.ToSingle(Console.ReadLine());
    }

    return length;
}

class Arrow
{
    public Arrowhead _arrowhead;
    public Fletching _fletching;
    public float _length;

    public Arrow() : this(Arrowhead.Steel, Fletching.Plastic, 60)
    {

    }

    public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
    {
        _arrowhead = arrowhead;
        _fletching = fletching;
        _length = length;
    }

    public int GetArrowHeadCost(Arrowhead arrowhead)
    {
        return arrowhead switch
        {
            Arrowhead.Steel     => 10,
            Arrowhead.Wood      => 3,
            Arrowhead.Obsidian  => 5
        };
    }

    public int GetFletchingCost(Fletching fletching)
    {
        return fletching switch
        {
            Fletching.Plastic        => 10,
            Fletching.TurkeyFeathers => 5,
            Fletching.GooseFeathers  => 3
        };
    }

    public float GetLengthCost(float length)
    {
        return length * 0.05f;
    }

    public float GetCost()
    {
        int arrowheadCost = GetArrowHeadCost(_arrowhead);
        int fletchingCost = GetFletchingCost(_fletching);
        float lengthCost = GetLengthCost(_length);

        return arrowheadCost + fletchingCost + lengthCost;
    }
}


enum Arrowhead { Steel, Wood, Obsidian }
enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }
