for (int i = 1; i <= 100; i++)
{
    string blastType;

    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        blastType = "Electic and Fire";
    }
    else if (i % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        blastType = "Fire";
    }
    else if (i % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        blastType = "Electric";
    }
    else
        blastType = "Normal";

    Console.WriteLine($"{i}: {blastType}");
    Console.ForegroundColor = ConsoleColor.White;
}


