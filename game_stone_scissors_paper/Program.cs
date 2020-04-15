using System;

namespace game_stone_scissors_paper
{
    //Да се напрви клас Герои. 
    //Да се направят поне 2 героя.
    //Всеки герои има име, оръжие,брой животи и сила. 
    //Да се направи клас Битка и да се организира съревнование между 2 героя. 
    //Да се отпечата победителя. При един удар се губи живот.
    //Животите са 2. Силата е от 1 до 3.  Оръжия: камък, ножица, хартия.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select your weapon: stone,scissors or paper");
            string weapon = Console.ReadLine();//User input

            Heroes h1 = new Heroes("Mario Bros", weapon, 2, 3);//Make object from class Heroes

            h1.PrintStats();//Calling the method from class Heroes to print object data

            Console.WriteLine("Select a weapon for the second player: stone,scissors or paper");

            string weapon1 = Console.ReadLine();//User input

            Heroes h2 = new Heroes("Scorpion", weapon1, 2, 3);//Make the second object from class Heroes

            h2.PrintStats();//Calling the method from class Heroes to print object data

            Console.WriteLine("");
            Console.WriteLine("Start the game");
            Console.ReadKey();

            Console.Clear();
            Battle.gameStart(h1, h2);//Calling method from class Battle to start game

            Console.WriteLine("Do you want to see the status of your characters? yes or no.");
            string check = Console.ReadLine();//User input
            //check
            if (check == "yes")
            {
                h1.PrintStats();
                h2.PrintStats();
            }
            else if (check == "no")
            {
                Console.Clear();
            }

        }
    }
}
