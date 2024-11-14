// See https://aka.ms/new-console-template for more information
using MathGame;

var menu = new Menu();
DateTime date = DateTime.UtcNow;
var games = new List<string>();
string name = GetName();

menu.ShowMenu(name, date);

string GetName()
{
    Console.WriteLine("Please type your name");
    var name = Console.ReadLine();

    while (string.IsNullOrEmpty(name))
    {
        Console.WriteLine("Name cant be empty.");
        name = Console.ReadLine();
    }
    
    return name;
}
