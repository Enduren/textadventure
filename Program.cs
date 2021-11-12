﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace textAdventure2
{
    class Program
    {
        static void Main(string[] args)
        {
            gameTitle();
            first();

        }

        public static void gameTitle()
        {
            Console.WriteLine("Hey this in the beginning of a text adventure game.");
            Console.WriteLine("Press 'Enter' to begin.");
            Console.ReadLine();
            Console.Clear();
            first();

        }

        public static void first()
        {
            string choice;

            Console.WriteLine("You are lost in a forest");
            Console.WriteLine("What do you do?");
            Console.WriteLine("1. seek out help");
            Console.WriteLine("2. look for water");
            Console.WriteLine("3. Build a Shelter");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "seek out help":
                case "seek":
                    {
                        Console.WriteLine("You walk down the forest path seeking out help.");
                        Console.WriteLine("You shout for help and your voice echoes through the area.");
                        Console.WriteLine("Birds fly over head and wild animal noises surround you.");
                        Console.WriteLine("Soon you notice a Bear charging your way.");
                        Console.WriteLine("Unfortunately there is no escape.");
                        Console.ReadLine();
                        gameOver();
                        break;
                    }
                case "2":
                case "look for water":
                    {
                        Console.WriteLine("You search for water in the area.");
                        Console.WriteLine("You find a water source nearby and begin drinking from it");
                        Console.WriteLine("After drinking some water, you are no longer thirsty and continue your journey");
                        Console.ReadLine();
                        second();
                        break;
                    }
                case "3":
                case "build":
                case "build a shelter":
                    {
                        Console.WriteLine("You gather materials for building a shelter in the forest.");
                        Console.WriteLine("After a few hours you are able to erect a sturdy shelter.");
                        Console.WriteLine("You feel a bit safer but night is soon approaching."); ;
                        Console.ReadLine();
                        second();
                        break;
                    }
                default:
                    {

                        Console.WriteLine("Command is invalid...");
                        Console.WriteLine("Press 'Enter' to restart.");
                        Console.ReadLine();
                        first();
                        break;
                    }
            }
        }

        public static void second()
        {
            Random rnd = new Random();
            string[] secondOptions = { "A fierce thunder storm is on the horizon , will you take shelter?",
            "Your stomach begins to growl, will you search for food?",
            "You hear the sound of music off in the distance, will you search for the source?"};
            int randomNumber = rnd.Next(0, 3);
            string secText = secondOptions[randomNumber];

            string secChoice;

            Console.WriteLine(secText);
            Console.WriteLine("Yes or No");
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "yes" || secChoice == "y")
            {
                Console.WriteLine("You feel as if something or someone is stalking you, but decide to ignore the feeling and continue.");
                Console.ReadLine();
                Console.Clear();
                third();

            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.WriteLine("You stand idle and feel a sharp claw swipe your back , and jagged teeth tear at your legs");
                Console.WriteLine("All is pain, followed by darkness.");
                Console.ReadLine();
                gameOver();

            }
            else
            {
                Console.WriteLine("You must reply Yes or no.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                second();
            }

        }



        public static void third()

        {
            int Choice;
            Console.WriteLine("You hear a growl and movement int the trees");
            Console.WriteLine("your stomach sinks and your eyes go wide as you scan the direction of the sound");
            Console.WriteLine("Will you fight or flee? Type 1 or 2.");
            Console.Write("Decision: ");
            int.TryParse(Console.ReadLine(), out Choice);
            int loop = 0;
            bool dead = false;
            while (Choice != 1 && dead == false)
            {
                if (loop <= 0)
                {
                    Console.WriteLine("You are too slow, a large bear leaps out and claws you in the chest.");
                    Console.WriteLine("You are bleeding profusely now, will your flee or fight?");
                    Console.Write("Decision: ");
                    int.TryParse(Console.ReadLine(), out Choice);
                    loop++;
                }
                else if (loop >= 1)
                {
                    Console.WriteLine("The bear grabs you by your pants, you are kicking and screaming.");
                    Console.WriteLine("Fear and adrenaline surge with in you. Fight or Flee? 1 or 2? ");
                    Console.Write("Decision: ");
                    int.TryParse(Console.ReadLine(), out Choice);
                    dead = true;
                }

            }
            if (dead == true)
            {
                Console.WriteLine("The bear swipes at your back , and jagged teeth tear at your legs");
                Console.WriteLine("You blackout because of the damage.");
                Console.ReadLine();
                gameOver();
            }
            else

            {
                Console.WriteLine("You fight with all your might causing the bear to flee.");
                Console.ReadLine();
                youWin();
            }
        }


        public static void gameOver()
        {
            Console.Clear();
            Console.WriteLine("The Bear Killed you.");
            Console.WriteLine("All is quite and the woods continues it's course.");
           
            Console.WriteLine(@"   
                                  {''-''}
                                   (o o)
                                 ,--`Y'--.
                                 ``:   ;''
                                   / _ \
                                  ()' `()
                                       ");

            Console.WriteLine("The End?(Evil Laugh)");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }

        public static void youWin()
        {
            Console.Clear();
            Console.WriteLine("You have survived.");
            Console.WriteLine("A group of rangers spot you.");
            Console.WriteLine("You are saved.");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }


    }
}