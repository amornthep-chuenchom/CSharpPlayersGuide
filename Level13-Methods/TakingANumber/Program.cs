using System.Reflection.Metadata.Ecma335;

int number = AskForNumberInRange("Enter number: ", 0, 10);

Console.WriteLine($"Your input number is {number}");


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
        if (number >= min && number <= max)
            return number;
    }
}


// Alternative version
//int AskForNumberInRange(string text, int min, int max)
//{
//    int number;
//    do
//    {
//        number = AskForNumber(text);
//    } while (number < min || number > max);

//    return number;
//}



