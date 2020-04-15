using System;
using System.Collections.Generic;
using System.Text;

namespace game_stone_scissors_paper
{
    class Heroes
    {
        //Fields
        protected string name;
        protected string weapon;
        protected int numberOfLives;
        protected int power;

        public Heroes() { }//Default constructor

        //Constructor
        public Heroes(string name, string weapon, int numberOfLives, int power)
        {
            this.name = name;
            this.weapon = weapon;
            this.numberOfLives = numberOfLives;
            this.power = power;
        }

        //Properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Weapon
        {
            get { return this.weapon; }
            set { this.weapon = value; }
        }

        public int NumberOfLives
        {
            get { return this.numberOfLives; }
            set { this.numberOfLives = value; }
        }

        public int Power
        {
            get { return this.power; }
            set { this.power = value; }
        }

        //Method
        //Print player status
        public void PrintStats()
        {
            Console.WriteLine("Character's name is {0}", name);
            Console.WriteLine("Number of lives: {0}", numberOfLives);
            Console.WriteLine("Power value is: {0}", power);
            Console.WriteLine("You play with: {0}", weapon);
            Console.WriteLine("");
        }



    }

    class Battle : Heroes//Inheritance-class Person
    {
        //Method
        //Checking the user-specified value
        public static void gameStart(Heroes a, Heroes b)

        {
            if (a.Weapon == "stone")
            {
                if (b.Weapon == "scissors")
                {
                    b.Power -= 1;
                    b.NumberOfLives -= 1;
                    Console.WriteLine($"{a.Name} is a winner");
                }
                else if (b.Weapon == "stone")
                {
                    Console.WriteLine("There is no winner");
                }
                else if (b.Weapon == "paper")
                {
                    a.Power -= 1;
                    a.NumberOfLives -= 1;
                    Console.WriteLine($"{b.Name} is a winner");
                }

            }
            else if (a.Weapon == "scissors")
            {
                if (b.Weapon == "scissors")
                {
                    Console.WriteLine("There is no winner");
                }

                if (b.Weapon == "stone")
                {
                    a.Power -= 1;
                    a.NumberOfLives -= 1;
                    Console.WriteLine($"{b.Name} is a winner");
                }

                if (b.Weapon == "paper")
                {
                    b.Power -= 1;
                    b.NumberOfLives -= 1;
                    Console.WriteLine($"{a.Name} is a winner");
                }

            }
            else if (a.Weapon == "paper")
            {
                if (b.Weapon == "scissors")
                {
                    a.Power -= 1;
                    a.NumberOfLives -= 1;
                    Console.WriteLine($"{b.Name} is a winner");
                }

                if (b.Weapon == "stone")
                {
                    b.Power -= 1;
                    b.NumberOfLives -= 1;
                    Console.WriteLine($"{a.Name} is a winner");
                }
                if (b.Weapon == "paper")
                {

                    Console.WriteLine("There is no winner");
                }


            }
            else
            {
                Console.WriteLine("There is no such weapon");

            }


        }

    }
}
