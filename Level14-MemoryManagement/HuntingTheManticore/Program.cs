int manticoreHealth = 10;
int cityHealth = 15;
int round = 1;

int manticoreDistance = GetNumberInRange("Player 1, how far away from the city do you want " +
    "to station the Manticore?", 0, 100);

Console.Clear();

Console.WriteLine("Player 2, it is your turn.");

while (cityHealth > 0 && manticoreHealth > 0)
{
    Console.WriteLine("-----------------------------------------------------------");
    DisplayStat(round, cityHealth, manticoreHealth);
    DisplayCannonDamage(round);
    int shootDamage = ShootManticore(round, manticoreDistance);

    if (shootDamage > 0) manticoreHealth -= shootDamage;
    if (manticoreHealth > 0) cityHealth -= 1;

    round++;
}

if (IsCityWin(manticoreHealth, cityHealth))
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("City lose");
}


bool IsCityWin(int manticoreHealth, int cityHealth)
{
    return manticoreHealth <= 0 && cityHealth > 0 ? true : false; 
}

int ShootManticore(int round, int manticoreDistance)
{
    int targetRange = GetTargetRange();
    int damage = 0;
    string hitOrMiss;

    if (targetRange > manticoreDistance)
        hitOrMiss = "OVERSHOT";
    else if (targetRange < manticoreDistance)
        hitOrMiss = "FELL SHORT";
    else
    {
        hitOrMiss = "DIRECT HIT";
        damage = ComputeCannonDamage(round);
    }

    Console.WriteLine($"That round {hitOrMiss} the target.");

    return damage;
}

int GetTargetRange()
{
    int targetRange = GetNumber("Enter desired cannon range:");
    return targetRange;
}

void DisplayCannonDamage(int round)
{
    int damage = ComputeCannonDamage(round);
    Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");
}

int ComputeCannonDamage(int round)
{
    int damage;

    if (round % 3 == 0 && round % 5 == 0) damage = 10;
    else if (round % 3 == 0 || round % 5 == 0) damage = 3;
    else damage = 1;

    return damage;
}

void DisplayStat(int round, int cityHealth, int manticoreHealth)
{
    Console.WriteLine($"STATUS: Round: {round} City: {cityHealth}/15 Manticore: {manticoreHealth}/10");
}


string GetText(string text)
{
    Console.Write(text + " ");
    string textInput = Console.ReadLine();

    return textInput;
}

int GetNumber(string text)
{
    string textInput = GetText(text);
    int numberInput = Convert.ToInt32(textInput);

    return numberInput;
}

int GetNumberInRange(string text, int min, int max)
{
    while (true)
    {
        int numberInput = GetNumber(text);

        if (numberInput >= min && numberInput <= max)
            return numberInput;
    }
}
