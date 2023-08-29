var arrow = GetArrow();
Console.WriteLine($"Your arrow costs {arrow.Cost} gold.");
Console.WriteLine();

Arrow GetArrow()
{
    return new Arrow(GetArrowhead(), GetFletching(), GetLength());
}

Arrowhead GetArrowhead()
{
    Console.Write("Pick Arrowhead (steel, wood, obsidian): ");
    return Console.ReadLine() switch
    {
        "steel"     => Arrowhead.Steel,
        "wood"      => Arrowhead.Wood,
        "obsidian"  => Arrowhead.Obsidian
    };
}

Fletching GetFletching()
{
    Console.Write("Pick Fletching (plastic, turkey feathers, goose feathers): ");
    return Console.ReadLine() switch
    {
        "plastic" => Fletching.Plastic,
        "turkey feathers" => Fletching.TurkeyFeathers,
        "goose feathers" => Fletching.GooseFeathers
    };
}

float GetLength()
{
    float length = 0;

    while (length < 60 || length > 100)
    {
        Console.Write("Pick arrow's length between (60-100): ");
        length = Convert.ToSingle(Console.ReadLine());
    }
    return length;
}

class Arrow
{
    public Arrowhead Arrowhead { get; }
    public Fletching Fletching { get; }
    public float Length { get; }


    public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
    {
        Arrowhead = arrowhead;
        Fletching = fletching;
        Length = length;
    }

    public float Cost
    {
        get
        {
            var arrowheadCost = Arrowhead switch
            {
                Arrowhead.Steel => 10,
                Arrowhead.Wood => 3,
                Arrowhead.Obsidian => 5
            };

            var fletchingCost = Fletching switch
            {
                Fletching.Plastic => 10,
                Fletching.TurkeyFeathers => 5,
                Fletching.GooseFeathers => 3
            };

            var lengthCost = Length * 0.05f;

            return arrowheadCost + fletchingCost + lengthCost;
        }
    }
}


enum Arrowhead { Steel, Wood, Obsidian }
enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }


