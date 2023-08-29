//SoupType type = GetSoupType();
//MainIngredient ingredient = GetMainIngredient();
//Seasoning seasoning = GetSeasoning();

//var soup = (Type: type, Ingredient: ingredient, Seasoning: seasoning);

var soup = GetSoup();

DisplaySoup(soup);


(SoupType, MainIngredient, Seasoning) GetSoup()
{
    return (GetSoupType(), GetMainIngredient(), GetSeasoning());
}

void DisplaySoup((SoupType Type, MainIngredient Ingredient, Seasoning Seasoning) soup)
{
    Console.WriteLine($"{soup.Seasoning} {soup.Ingredient} {soup.Type}");
}

void DisplaySoupTypeChoices()
{
    Console.WriteLine("Pick one of these Soup Type");
    Console.WriteLine("1 - Soup");
    Console.WriteLine("2 - Stew");
    Console.WriteLine("3 - Gumbo");
    Console.Write("=> ");
}

void DisplayMainIngredientChoices()
{
    Console.WriteLine("Pick one of these Main Ingredient");
    Console.WriteLine("1 - Mushroom");
    Console.WriteLine("2 - Chicken");
    Console.WriteLine("3 - Carrot");
    Console.WriteLine("4 - Potato");
    Console.Write("=> ");
}

void DisplaySeasoningChoices()
{
    Console.WriteLine("Pick one of these Seasoning");
    Console.WriteLine("1 - Spicy");
    Console.WriteLine("2 - Salty");
    Console.WriteLine("3 - Sweet");
    Console.Write("=> ");
}

SoupType GetSoupType()
{
    DisplaySoupTypeChoices();
    string input = Console.ReadLine();
    return input switch
    {
        "1" => SoupType.Soup,
        "2" => SoupType.Stew,
        "3" => SoupType.Gumbo
    };
}

MainIngredient GetMainIngredient()
{
    DisplayMainIngredientChoices();
    string input = Console.ReadLine();
    return input switch
    {
        "1" => MainIngredient.Mushroom,
        "2" => MainIngredient.Chicken,
        "3" => MainIngredient.Carrot,
        "4" => MainIngredient.Potato
    };
}

Seasoning GetSeasoning()
{
    DisplaySeasoningChoices();
    string input = Console.ReadLine();
    return input switch
    {
        "1" => Seasoning.Spicy,
        "2" => Seasoning.Salty,
        "3" => Seasoning.Sweet
    };
}

enum SoupType{ Soup, Stew, Gumbo }
enum MainIngredient { Mushroom, Chicken, Carrot, Potato }
enum Seasoning { Spicy, Salty, Sweet }