int[] firstArray = new int[5];

// Get number value to array
for (int index = 0; index <= 4; index++)
{
    Console.Write($"Enter number {index + 1}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    firstArray[index] = number;
}

// Copy value to second array
int[] secondArray = new int[5];
for (int index = 0; index < firstArray.Length; index++)
{
    secondArray[index] = firstArray[index];
}


// Display contents of both array
Console.WriteLine("Contents of arrays...");
for (int index = 0; index < 5; index++)
{
    Console.WriteLine($"first array: {firstArray[index]} and second array: {secondArray[index]}");
}






