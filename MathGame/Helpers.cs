using MathGame.Model;

namespace MathGame;

internal class Helpers
{
    private static List<Game> games = new List<Game>();
    internal static void PrintGames()
    {
        Console.WriteLine("Previous Games");
        Console.WriteLine("------------------------------");
        foreach (var game in games)
        {
            Console.WriteLine($"{game.Date} - {game.Type} - Score: {game.Score}");
        }
        Console.WriteLine("------------------------------\n");
        Console.WriteLine("Press any key to go back to the main menu");
        Console.ReadLine();
    }

    internal static void AddToHistory(int gameScore, Game.GameType gameType)
    {
        games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
            });
    }

    internal static int[] GetDivisionNumbers()
    {
        var random = new Random();
        int firstNumber = random.Next(1, 99);
        int secondNumber = random.Next(1, 99);

        var result = new int[2];

        while (firstNumber % secondNumber != 0)
        {
            firstNumber = random.Next(1, 99);
            secondNumber = random.Next(1, 99);
        }
    
        result[0] = firstNumber;
        result[1] = secondNumber;
    
        return result;
    }

    internal static string? ValidateInput(string result)
    {
        while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
        {
            Console.WriteLine("Your answer needs to be an integer. try again.");
            result = Console.ReadLine();
        }
        return result;
    }
}