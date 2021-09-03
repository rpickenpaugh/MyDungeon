using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatsLib;

namespace MyDungeon
{
    class DungeonExe
    {
        static void Main(string[] args)
        {


            Console.Title = "My <3 Dungeon";
            Console.WriteLine("Welcome to My Dungeon <3\n");
            bool nameBlank = true;
            bool heroCreate = false;
            CharacterStats c1 = new CharacterStats("characterName", "characterRace", "characterClass", 10, 10, 10, 10, 10, 10, 10, 10m, 10m, 10, 10m);
            do
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Choose a name for your hero:\n");
                    c1.CharacterName = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(c1.CharacterName))
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a valid name");
                    }//end if Null name
                    else
                    {
                        nameBlank = false;
                    }//end else

                } while (nameBlank);
                Console.Clear();
                Console.WriteLine("What race is your hero?\n");
                //TODO - Add races
                c1.CharacterRace = Console.ReadLine();
                Console.Clear();
                Console.Clear();
                Console.WriteLine("What class is your hero?\n");
                //TODO - Add classes
                c1.CharacterClass = Console.ReadLine();
                Console.Clear();

                bool heroConfirm = true;

                do
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Your name is {0}\nYour race is {1}\nAnd your class is {2}\n\nIs this correct?", c1.CharacterName, c1.CharacterRace, c1.CharacterClass);
                    ConsoleKey characterRedo = Console.ReadKey(false).Key;
                    switch (characterRedo)
                    {
                        case ConsoleKey.N:
                            heroConfirm = false;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Re-select your hero.\n");
                            break;
                        case ConsoleKey.Y:
                            heroConfirm = false;
                            heroCreate = true;
                            break;
                        default:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Incorrect response.\n");
                            break;
                    }
                } while (heroConfirm);
            } while (heroCreate == false);
            Console.Clear();
            //Variable for score
            int battleVictories = 0;
            //TODO Create player

            //DoWhile for game
            bool exitGame = false;
            do
            {
                bool reloadNonEncMenu = false;
                #region Non-Encounter Menu
                do
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Main Menu:\n" +
                    "C) Character Menu\n" +
                    "S) Search Surroundings\n" +
                    "X) Exit\n");

                    ConsoleKey userChoice = Console.ReadKey(false).Key;

                    Console.Clear();
                    switch (userChoice)
                    {
                        case ConsoleKey.C:
                            Console.WriteLine("Character Stats\n");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(c1);
                            Console.ForegroundColor = ConsoleColor.White;
                            //TODO - Add Character Menu Class
                            break;
                        case ConsoleKey.E:
                            Console.WriteLine("Equipment Menu\n");
                            break;
                            //TODO - Add Equipment Lib
                        case ConsoleKey.S:
                            Console.WriteLine("Searching Surroundings...\n");
                            //TODO - Add Map Scenario Lib
                            break;
                        case ConsoleKey.X:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Did you mean to Exit?\nY) Yes\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Press any other key to continue...\n");
                            ConsoleKey userExitChoice = Console.ReadKey(false).Key;
                            bool userExitBool = false;
                            do
                            {
                                if (userExitChoice == ConsoleKey.Y)
                                {
                                    userExitBool = true;
                                    exitGame = true;
                                }
                                else
                                {
                                    userExitBool = true;
                                    Console.Clear();
                                }
                            } while (!userExitBool);
                            break;
                        default:
                            break;
                    }//end switch userChoice


                } while (!exitGame && !reloadNonEncMenu);
                #endregion
            } while (!exitGame);
        }//end Main()
    }//end class
}//end namespace
