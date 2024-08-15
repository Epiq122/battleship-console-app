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
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Battleship Lite");
            Console.WriteLine("created by Rob Gleason");
            Console.WriteLine();
        }

        private static PlayerInfoModel CreatePlayer()
        {
            PlayerInfoModel output = new PlayerInfoModel();

            // Ask the user for their name
            output.Username = AskForUserName();
            // Load up the shot grid
            GameLogic.InitializeGrid(output);
            // ask the user for their 5 ship placements
            // Clear
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

            } while (model.ShipLocations.Count < 5);
        }
    }

}
