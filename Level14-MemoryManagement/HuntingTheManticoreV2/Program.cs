int manticoreHealth = 10;
int cityHealth = 15;
int round = 1;

int range = AskForNumberInRange("Player 1, how far away from the city do you want to station the Manticore?", 0, 100);
Console.Clear();

Console.WriteLine("Player 2, It is your turn.");

while (manticoreHealth > 0 && cityHealth > 0)
{
    Console.WriteLine("-----------------------------------------------------------");
    DisplayStatus(round, cityHealth, manticoreHealth);
    
    int damage = DamageForRound(round);
    Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");

    int targetRange = AskForNumber("Enter desired cannon range:");

    DisplayOverOrUnder(targetRange, range);


    if (targetRange == range) manticoreHealth -= damage;

    if (manticoreHealth > 0) cityHealth--;

    round++;

}

bool isWin = cityHealth > 0;
DisplayWinOrLoss(isWin);


// -----------------------------------------------------METHOD---------------------------------------------------------

void DisplayWinOrLoss(bool isWin)
{
    if (isWin)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The city has been destroyed. The Manticore and the Uncoded One have won.");
    }
}

void DisplayOverOrUnder(int targetRange, int range)
{
    if (targetRange > range) Console.WriteLine("That round OVERSHOT the target.");
    else if (targetRange < range) Console.WriteLine("That round FELL SHORT of the target.");
    else if (targetRange == range) Console.WriteLine("That round was a DIRECT HIT!");
}

int DamageForRound(int round)
{
    if (round % 3 == 0 && round % 5 == 0) return 10;
    else if (round % 3 == 0 || round % 5 == 0) return 3;
    else return 1;
}

void DisplayStatus(int round, int cityHealth, int manticoreHealth) 
    => Console.WriteLine($"STATUS: Round: {round} City: {cityHealth}/15 Manticore: {manticoreHealth}/10");


int AskForNumber(string text)
{
    Console.Write(text + " ");
    int number = Convert.ToInt32(Console.ReadLine());

    return number;
}

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        int number = AskForNumber(text);

        if (number >= min && number <= max ) return number;
    }
}


