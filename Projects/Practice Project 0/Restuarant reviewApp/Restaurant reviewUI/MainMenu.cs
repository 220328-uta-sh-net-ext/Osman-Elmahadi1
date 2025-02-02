﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_reviewUI
{
    /*MainMenu class implements IMenu interface but since it is a class it needs to 
    give actual implementation details to the respective methods*/
    class MainMenu : IMenu
    {
        public void Display()
        {
            throw new NotImplementedException();
        }

        public string Login()
        {
            throw new NotImplementedException();
        }

        public string UserChoice()
        {
            throw new NotImplementedException();
        }

        class CMainMenu : IMenu
        {

            public void Display()
            {
                Console.WriteLine("Welcome to this Restuarant Application.");
                Console.WriteLine("Please choose to login or create a user.");
                Console.WriteLine("Press <4> Create Restaurant");
                Console.WriteLine("Press <3> Display Restaurant");
                Console.WriteLine("Press <2> Create user");
                Console.WriteLine("Press <1> Login");
                Console.WriteLine("Press <0> Exit");
            }

            public override bool Equals(object? obj)
            {
                return base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public string Login()
            {
                string userInput = Console.ReadLine();
                //Login menu
                switch (userInput)
                {
                    case "0":
                        return "Exit";
                    case "1":
                        return "Login";
                    case "2":
                        return "Create user";
                    case "3":
                        return "Display Restaurant";
                    case "4":
                        return "Create Restaurant";
                    default:
                        Console.WriteLine("Please input a valid response");
                        Console.WriteLine("Please press <enter> to continue");
                        Console.ReadLine();
                        return "MainMenu";
                }
            }

            public override string? ToString()
            {
                return base.ToString();
            }

            public string UserChoice()
            {
                string otherinpute = Console.ReadLine();
                switch (otherinpute)
                {
                    case "0":
                        return "Exit";
                    case "1":
                        return "Login";
                    case "2":
                        return "Create User";
                    case "3":
                        return "Display Restaurant";
                    case "4":
                        return "Create Restaurant";
                    default:
                        Console.WriteLine("Please input a valid response");
                        Console.WriteLine("Please press <enter> to continue");
                        Console.ReadLine();
                        return "MainMenu";

                }
            }
        }
    }
}

