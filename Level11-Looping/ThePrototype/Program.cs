int firstUserNumber;
int secondUserNumber;

do
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    firstUserNumber = Convert.ToInt32(Console.ReadLine());
} while (firstUserNumber < 0 || firstUserNumber > 100);

Console.Clear();

Console.WriteLine("User 2, guess the number.");
while (true)
{
    Console.Write("What is your next guess? ");
    secondUserNumber = Convert.ToInt32(Console.ReadLine());

    if (secondUserNumber == firstUserNumber)
        break;
    else if (secondUserNumber > firstUserNumber)
        Console.WriteLine($"{secondUserNumber} is too high.");
    else if (secondUserNumber < firstUserNumber)
        Console.WriteLine($"{secondUserNumber} is too low.");
}

Console.WriteLine("You guessed the number!");





