﻿using RestaurantBL;
using RestaurantUI;

namespace RestauranUI;

class SearchRestaurantMenu : IMenu
{
    readonly IRestaurantLogic logic;

    public SearchRestaurantMenu(IRestaurantLogic logic)
    {
        this.logic = logic;
    }

    public void Display()
    {
        Console.WriteLine("Please select an option to filter the restaurant database");
        Console.WriteLine("Press <1> By Name");
        Console.WriteLine("Press <0> Go Back");
    }

    public string UserChoice()
    {
        // Console.ReadLine returns null if redirecting from a file and the file ends
        if (Console.ReadLine() is not string userInput)
            throw new InvalidDataException("end of input");

        switch (userInput)
        {
            case "0":
                return "MainMenu";
            case "1":
                // Logic to display results
                Console.Write("Please enter the name ");
                if (Console.ReadLine() is not string name)
                    throw new InvalidDataException("end of input");
                List<RestaurantModels.Restaurant>? results = logic.SearchRestaurant(name, name);
                if (results.Count > 0)
                {
                    foreach (RestaurantModels.Restaurant? r in results)
                    {
                        Console.WriteLine("=================");
                        Console.WriteLine(r.ToString());
                    }
                }
                else
                {
                    Console.WriteLine($"Restaurant with search string {name} not found");
                }
                Console.WriteLine("Press <enter> to continue");
                Console.ReadLine();
                return "MainMenu";
            default:
                Console.WriteLine("Please enter a valid response");
                Console.WriteLine("Please press <enter> to continue");
                Console.ReadLine();
                return "SearchRestaurant";
        }
    }
}