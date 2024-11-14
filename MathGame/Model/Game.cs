using System.Runtime.InteropServices.JavaScript;

namespace MathGame.Model;

internal class Game
{
    private int _score;

    // public int Score
    // {
    //     get { return _score; }
    //     set { _score = value; }
    // }
    
    internal DateTime Date { get; set; }
    
    internal int Score { get; set; }
    
    internal GameType Type { get; set; }

    internal enum GameType
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }
}