using System;

info info = new();
List<string> FaveDishes = new List<string>(); // Lista då man själv ska bestämma hur många favoriträtter man har. En array har en fast mängd innehåll medans en lista kan lägga till nya hela tiden

//Spelet

Console.WriteLine("HEllo what is your name!?");
string name = info.Namer("name");

Console.Clear();

Console.WriteLine($"Hello {name}! How old are you?");
float age = info.Ager("", 0, false);

Console.Clear();

Console.WriteLine("How many favourite dishes do you have?");
int amountOfDishes = info.AmountOfDishes("", 0, false);

Console.WriteLine($"Please tell me your {amountOfDishes} favourite dishes");
string dish = "";

for (int i = 0; i < amountOfDishes; i++)
{
    dish = Console.ReadLine();
    FaveDishes.Add(dish);
}

Console.Clear();

Console.WriteLine($"Your {amountOfDishes} favourite dishes are...");
foreach (var dishItem in FaveDishes)
{
    Console.WriteLine(dishItem);
}
Console.ReadLine();