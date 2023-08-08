int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

// calculate minimum value
int currentSmallest = int.MaxValue;

foreach (int value in array)
    if (value < currentSmallest) 
        currentSmallest = value;

Console.WriteLine($"Smallest value of array is {currentSmallest}");

// calculate average value
int total = 0;

foreach (int value in array)
    total += value;

float average = (float)total / array.Length;

Console.WriteLine($"Average value of array is {average}");


