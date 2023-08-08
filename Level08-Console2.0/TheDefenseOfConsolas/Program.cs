Console.Title = "Defense of Consolas";

Console.Write("Target Row? ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Target Column? ");
int column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Deploy to: ");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"({row + 1}, {column})");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"({row}, {column + 1})");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"({(row - 1)}, {column})");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"({(row)}, {column - 1})");

Console.Beep(444, 5000);

Console.ForegroundColor = ConsoleColor.White;













