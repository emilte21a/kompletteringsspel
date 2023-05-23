using System;

public class info
{
    public int maxDishes = 10;
    public int minDishes = 1;
    public string Namer(string name)
    {
        name = Console.ReadLine();
        return name;
    }
    public float Ager(string ageString, float ageFloat, bool isNumeric)
    {
        ageString = Console.ReadLine();
        isNumeric = float.TryParse(ageString, out ageFloat);

        while (!isNumeric || ageFloat < 1)
        {
            if (ageFloat < 0)
            {
                Console.WriteLine("Write a number larger than 0!??");
            }
            else if (!isNumeric)
            {
                Console.WriteLine("Write a number!");
            }
            ageString = Console.ReadLine();
            isNumeric = float.TryParse(ageString, out ageFloat);
        }

        ageFloat = float.Parse(ageString);
        return ageFloat;
    }

    public int AmountOfDishes(string dishesString, int dishesInt, bool isNumeric)
    {
        dishesString = Console.ReadLine();
        isNumeric = Int32.TryParse(dishesString, out dishesInt);
        
        while (!isNumeric || dishesInt < minDishes || dishesInt > maxDishes)
        {
            if (dishesInt < minDishes || dishesInt > maxDishes)
            {
                Console.WriteLine($"Write a number larger than {minDishes} and smaller than {maxDishes}!??");
            }
            else if (!isNumeric)
            {
                Console.WriteLine("Write a whole number !");
            }
            dishesString = Console.ReadLine();
            isNumeric = Int32.TryParse(dishesString, out dishesInt);
        }

        dishesInt = Int32.Parse(dishesString);
        return dishesInt;
    }

   
}