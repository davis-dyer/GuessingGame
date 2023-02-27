using System;

//Phase 1

//Console.Write(userGuess);

//Phase 1,2,3
Console.WriteLine("Select the difficulty level... (Easy, Medium, Hard)");
string userSelect = Console.ReadLine().ToLower();

int newFunc(string param)
{
    int x = 0;
    if (param == "easy")
    {
        x = 8;
    }
    else if (param == "medium") 
    {
        x = 6;
    }
    else if (param == "hard")
    {
        x = 4;
    };
    else if (param == "cheater")
    {
        x = 100;
    }
    return x;
};

int input = newFunc(userSelect);

Random r = new Random();
int secretFormula = r.Next(1,101);
Console.WriteLine("Can you guess the secret number?");
for (int i = 0; i < input; i++)
{
    string userGuess = Console.ReadLine();
    int guess = int.Parse(userGuess);
    if (guess == secretFormula)
    {
        Console.WriteLine("Look at you, couldn't be happier.");
        break;
    }
    else
    {
        if (guess > secretFormula)
        {
            Console.WriteLine($"Try again (Last guess:{guess}; Guesses left:{input-1-i}; Too High)");
        }
        else if (guess < secretFormula)
        {
            Console.WriteLine($"Try again (Last guess:{guess}; Guesses left:{input-1-i}; Too Low)");
        };
    };
};









/* namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
} */
