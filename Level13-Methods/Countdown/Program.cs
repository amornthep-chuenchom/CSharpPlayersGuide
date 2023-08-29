Season current = Season.Summer;



Console.WriteLine(default(Season));

//Console.WriteLine(current + 1);

//Countdown(10);

void Countdown(int number)
{
    if (number == 0) return;

    Console.WriteLine(number);
    Countdown(number - 1);
}

enum Season
{
    Winter = 1,
    Spring,
    Summer,
    Fall
}

