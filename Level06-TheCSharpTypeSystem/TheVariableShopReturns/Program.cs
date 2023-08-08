




char charType = 'A';

string stringType = "Amornthep";

byte byteType = 10;
sbyte sByteType = -10;
short shortType = -10;
ushort uShortType = 10;
int intType = 10;
uint uIntType = 10U; // ใช้ int literal เฉย ๆ ไม่ต้องมี suffix ก็ได้
long longType = 10L; // ใช้ int literal เฉย ๆ ไม่ต้องมี suffix ก็ได้
ulong uLongType = 10UL; // ใช้ int literal เฉย ๆ ไม่ต้องมี suffix ก็ได้

float floatType = 3.14F;
double doubleType = 3.14;
decimal decimalType = 3.14M;

bool boolType = true;

Console.WriteLine(charType);
Console.WriteLine(stringType);
Console.WriteLine(byteType);
Console.WriteLine(sByteType);
Console.WriteLine(shortType);
Console.WriteLine(uShortType);
Console.WriteLine(intType);
Console.WriteLine(uIntType);
Console.WriteLine(longType);
Console.WriteLine(uLongType);
Console.WriteLine(floatType);
Console.WriteLine(doubleType);
Console.WriteLine(decimalType);
Console.WriteLine(boolType);

// assign new different literal value
Console.WriteLine();
Console.WriteLine("Update new value!");
Console.WriteLine("");
charType = 'Z';
stringType = "Anonymous";

byteType = 100;
sByteType = -100;
shortType = -100;
uShortType = 100;
intType = 100;
uIntType = 100;
longType = 100;
uLongType = 100;

floatType = 0.007f;
doubleType = 0.007;
decimalType = 0.007m;

boolType = false;

Console.WriteLine(charType);
Console.WriteLine(stringType);
Console.WriteLine(byteType);
Console.WriteLine(sByteType);
Console.WriteLine(shortType);
Console.WriteLine(uShortType);
Console.WriteLine(intType);
Console.WriteLine(uIntType);
Console.WriteLine(longType);
Console.WriteLine(uLongType);
Console.WriteLine(floatType);
Console.WriteLine(doubleType);
Console.WriteLine(decimalType);
Console.WriteLine(boolType);




