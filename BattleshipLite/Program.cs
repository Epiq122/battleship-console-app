using BattleshipLiteLibrary;
using BattleshipLiteLibrary.Models;
using System;

namespace BattleshipLite
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WelcomeMessage();

            PlayerInfoModel player1 = CreatePlayer("Player 1");
            PlayerInfoModel player2 = CreatePlayer("Player 2");

        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Battleship Lite");
            Console.WriteLine("created by Rob Gleason");
            Console.WriteLine();
        }

        private static PlayerInfoModel CreatePlayer(string playerTitle)
        {
            PlayerInfoModel output = new PlayerInfoModel();

            Console.WriteLine($"Player information for {playerTitle}");

            // Ask the user for their name
            output.Username = AskForUserName();
            // Load up the shot grid
            GameLogic.InitializeGrid(output);
            // ask the user for their 5 ship placements
            PlaceShips(output);
            // Clear
            Console.Clear();
            return output;
        }

        private static string AskForUserName()
        {
            Console.Write("What is your name: ");
            string output = Console.ReadLine();

            return output;
        }

        private static void PlaceShips(PlayerInfoModel model)
        {
            do
            {
                Console.Write($"Where do you want to place ship number {model.ShipLocations.Count + 1} : ");
                string location = Console.ReadLine();


                bool isValidLocation = GameLogic.PlaceShip(model, location);

                if (isValidLocation == false)
                {
                    Console.WriteLine("That was not a valid location. Please try again.");
                }

            } while (model.ShipLocations.Count < 5);
        }
    }

}
