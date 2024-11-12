// See https://aka.ms/new-console-template for more information
DateTime date = DateTime.UtcNow;
string name = GetName();

Menu(name);

string GetName()
{
    Console.WriteLine("Please type your name");
    var name = Console.ReadLine();
    return name;
}

void Menu(string name)
{
    bool isGameOn = true;

    do
    {
        Console.Clear();
        Console.WriteLine("-----------------------------------");
        Console.WriteLine(
            $"Hello {name}. It's {date}. This is your math game. It's great that you're working on improving yourself.\n");
        Console.WriteLine($@"What would you like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit");
        Console.WriteLine("-----------------------------------");

        var gameSelected = Console.ReadLine().Trim().ToLower();

        switch (gameSelected)
        {
            case "a":
                AdditionGame("Addition game selected");
                break;
            case "s":
                SubtractionGame("Subtraction game selected");
                break;
            case "m":
                MultiplicationGame("Multiplication game selected");
                break;
            case "d":
                DivisionGame("Division game selected");
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

void AdditionGame(string message)
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
            Console.WriteLine("Press any key to go back to the main menu");
            Console.ReadLine();
        }
        else
        {
            keepPlaying = false;
            Console.WriteLine("\nInvalid input. Ending game.");
            Console.WriteLine($"Your final score is {score}");
            Console.WriteLine("Press any key to go back to the main menu");
            Console.ReadLine();
        }
    }
}

void SubtractionGame(string message)
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
            Console.WriteLine("Press any key to go back to the main menu");
            Console.ReadLine();
        }
        else
        {
            keepPlaying = false;
            Console.WriteLine("\nInvalid input. Ending game.");
            Console.WriteLine($"Your final score is {score}");
            Console.WriteLine("Press any key to go back to the main menu");
            Console.ReadLine();
        }
    }
}

void MultiplicationGame(string message)
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
            Console.WriteLine("Press any key to go back to the main menu");
            Console.ReadLine();
        }
        else
        {
            keepPlaying = false;
            Console.WriteLine("\nInvalid input. Ending game.");
            Console.WriteLine($"Your final score is {score}");
            Console.WriteLine("Press any key to go back to the main menu");
            Console.ReadLine();
        }
    }

}

void DivisionGame(string message)
{
    Console.WriteLine(message);
    int score = 0;
    var keepPlaying = true;
    while (keepPlaying)
    {
        Console.Clear();
        int[] numbers = GetDivisionNumbers();
        int firstNumber = numbers[0];
        int secondNumber = numbers[1];
        Console.WriteLine($"\n{firstNumber} / {secondNumber}");
        var result = Console.ReadLine();

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
            Console.WriteLine("Press any key to go back to the main menu");
            Console.ReadLine();
        }
        else
        {
            keepPlaying = false;
            Console.WriteLine("\nInvalid input. Ending game.");
            Console.WriteLine($"Your final score is {score}");
            Console.WriteLine("Press any key to go back to the main menu");
            Console.ReadLine();
        }
    }

}

int[] GetDivisionNumbers()
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
