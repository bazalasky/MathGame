using MathGame.Model;

namespace MathGame;

public class GameEngine
{
    internal void AdditionGame(string message)
{
    Console.WriteLine(message);
    int score = 0;
    var keepPlaying = true;
    while (keepPlaying)
    {
        Console.Clear();
        var random = new Random();
        int firstNumber = random.Next(1, 9);
        int secondNumber = random.Next(1, 9);
        Console.WriteLine($"\n{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();
        result = Helpers.ValidateInput(result);

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            score++;
            Console.WriteLine("Correct!");
            Console.WriteLine($"Score: {score}\n");
        }
        else
        {
            score--;
            Console.WriteLine("Incorrect.");
            Console.WriteLine($"Score: {score}\n");
        }
        Console.WriteLine("Would you like to keep playing? (Y/N)");
        var response = Console.ReadLine().Trim().ToLower();
        if (response == "y")
        {
            keepPlaying = true;
        }
        else if (response == "n")
        {
            keepPlaying = false;
            Console.WriteLine($"\nYour final score is {score}"); 
            Helpers.AddToHistory(score, Game.GameType.Addition);
            Console.WriteLine("Press any key to go back to the main menu");
            Console.ReadLine();
        }
        else
        {
            keepPlaying = false;
            Console.WriteLine("\nInvalid input. Ending game.");
            Console.WriteLine($"Your final score is {score}");
            Helpers.AddToHistory(score, Game.GameType.Addition);
            Console.WriteLine("Press any key to go back to the main menu");
            Console.ReadLine();
        }
    }
}

    internal void SubtractionGame(string message)
    {
        Console.WriteLine(message);
        int score = 0;
        var keepPlaying = true;
        while (keepPlaying)
        {
            Console.Clear();
            var random = new Random();
            int firstNumber = random.Next(1, 9);
            int secondNumber = random.Next(1, 9);
            Console.WriteLine($"\n{firstNumber} - {secondNumber}");
            var result = Console.ReadLine();
            result = Helpers.ValidateInput(result);

            if (int.Parse(result) == firstNumber - secondNumber)
            {
                score++;
                Console.WriteLine("Correct!");
                Console.WriteLine($"Score: {score}\n");
            }
            else
            {
                score--;
                Console.WriteLine("Incorrect.");
                Console.WriteLine($"Score: {score}\n");
            }
            Console.WriteLine("Would you like to keep playing? (Y/N)");
            var response = Console.ReadLine().Trim().ToLower();
            if (response == "y")
            {
                keepPlaying = true;
            }
            else if (response == "n")
            {
                keepPlaying = false;
                Console.WriteLine($"\nYour final score is {score}");
                Helpers.AddToHistory(score, Game.GameType.Subtraction);
                Console.WriteLine("Press any key to go back to the main menu");
                Console.ReadLine();
            }
            else
            {
                keepPlaying = false;
                Console.WriteLine("\nInvalid input. Ending game.");
                Console.WriteLine($"Your final score is {score}");
                Helpers.AddToHistory(score, Game.GameType.Subtraction);
                Console.WriteLine("Press any key to go back to the main menu");
                Console.ReadLine();
            }
        }
    }

    internal void MultiplicationGame(string message)
    {
        Console.WriteLine(message);
        int score = 0;
        var keepPlaying = true;
        while (keepPlaying)
        {
            Console.Clear();
            var random = new Random();
            int firstNumber = random.Next(1, 9);
            int secondNumber = random.Next(1, 9);
            Console.WriteLine($"\n{firstNumber} * {secondNumber}");
            var result = Console.ReadLine();
            result = Helpers.ValidateInput(result);

            if (int.Parse(result) == firstNumber * secondNumber)
            {
                score++;
                Console.WriteLine("Correct!");
                Console.WriteLine($"Score: {score}\n");
            }
            else
            {
                score--;
                Console.WriteLine("Incorrect.");
                Console.WriteLine($"Score: {score}\n");
            }
            Console.WriteLine("\nWould you like to keep playing? (Y/N)");
            var response = Console.ReadLine().Trim().ToLower();
            if (response == "y")
            {
                keepPlaying = true;
            }
            else if (response == "n")
            {
                keepPlaying = false;
                Console.WriteLine($"Your final score is {score}");
                Helpers.AddToHistory(score, Game.GameType.Multiplication);
                Console.WriteLine("Press any key to go back to the main menu");
                Console.ReadLine();
            }
            else
            {
                keepPlaying = false;
                Console.WriteLine("\nInvalid input. Ending game.");
                Console.WriteLine($"Your final score is {score}");
                Helpers.AddToHistory(score, Game.GameType.Multiplication);
                Console.WriteLine("Press any key to go back to the main menu");
                Console.ReadLine();
            }
        }

    }

    internal void DivisionGame(string message)
    {
        Console.WriteLine(message);
        int score = 0;
        var keepPlaying = true;
        while (keepPlaying)
        {
            Console.Clear();
            int[] numbers = Helpers.GetDivisionNumbers();
            int firstNumber = numbers[0];
            int secondNumber = numbers[1];
            Console.WriteLine($"\n{firstNumber} / {secondNumber}");
            var result = Console.ReadLine();
            result = Helpers.ValidateInput(result);
            
            if (int.Parse(result) == firstNumber / secondNumber)
            {
                score++;
                Console.WriteLine("Correct!");
                Console.WriteLine($"Score: {score}\n");
            }
            else
            {
                score--;
                Console.WriteLine("Incorrect.");
                Console.WriteLine($"Score: {score}\n");
            }
            Console.WriteLine("Would you like to keep playing? (Y/N)");
            var response = Console.ReadLine().Trim().ToLower();
            if (response == "y")
            {
                keepPlaying = true;
            }
            else if (response == "n")
            {
                keepPlaying = false;
                Console.WriteLine($"\nYour final score is {score}");
                Helpers.AddToHistory(score, Game.GameType.Division);
                Console.WriteLine("Press any key to go back to the main menu");
                Console.ReadLine();
            }
            else
            {
                keepPlaying = false;
                Console.WriteLine("\nInvalid input. Ending game.");
                Console.WriteLine($"Your final score is {score}");
                Helpers.AddToHistory(score, Game.GameType.Division);
                Console.WriteLine("Press any key to go back to the main menu");
                Console.ReadLine();
            }
        }

    }
}