Console.Write("How many provinces you have: ");
int provinces = Convert.ToInt32(Console.ReadLine());

Console.Write("How many duchies you have: ");
int duchies = Convert.ToInt32(Console.ReadLine());

Console.Write("How many estates you have: ");
int estates = Convert.ToInt32(Console.ReadLine());

int provincesPoint = provinces * 6;
int duchiesPoint = duchies * 3;
int estatesPoint = estates * 1;

int totalPoint = provincesPoint + duchiesPoint + estatesPoint;

Console.WriteLine("Total Point: " + totalPoint);



