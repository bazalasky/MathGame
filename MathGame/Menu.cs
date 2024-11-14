using System.Data;
using System.Linq.Expressions;
using System.Threading.Channels;

namespace MathGame;

public class Menu
{
    GameEngine engine = new();
    internal void ShowMenu(string name, DateTime date)
    {
        Console.Clear();
        Console.WriteLine($"Hello {name}. It's {date}. This is your math game. It's great that you're working on improving yourself.\n");
        Console.WriteLine("Press any key to show menu.");
        Console.ReadLine();
        bool isGameOn = true;

        do
        {
            Console.Clear();
            Console.WriteLine($@"What would you like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
H - Game History
Q - Quit");
            Console.WriteLine("-----------------------------------");

            var gameSelected = Console.ReadLine().Trim().ToLower();

            switch (gameSelected)
            {
                case "a":
                    engine.AdditionGame("Addition game selected");
                    break;
                case "s":
                    engine.SubtractionGame("Subtraction game selected");
                    break;
                case "m":
                    engine.MultiplicationGame("Multiplication game selected");
                    break;
                case "d":
                    engine.DivisionGame("Division game selected");
                    break;
                case "h":
                    Helpers.PrintGames();
                    break;
                case "q":
                    Console.WriteLine("\nGoodbye");
                    isGameOn = false;
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    Environment.Exit(1);
                    break;
            }
        } while (isGameOn);
    }

}