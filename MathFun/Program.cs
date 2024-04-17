using System;
using System.Collections.Generic;

internal class Program
{
    /*
    Create a function 'Welcome()' that takes a string parameter 'name' and returns a string greeting that says "Welcome, <name>!"
    */
    public static string Welcome(string name)
    {
        return $"Welcome, {name}!";
    }

    /*
    Create a function 'RandomWelcome()' that returns a random welcome message from a list of welcome messages.
    Details:
    Limit the number of welcome messages to 5.
    */
    public static string RandomWelcome()
    {
        var welcomeMessages = new List<string>
        {
            "Welcome, friend!",
            "Welcome, stranger!",
            "Welcome, buddy!",
            "Welcome, pal!",
            "Welcome, mate!"
        };

        var random = new Random();
        var index = random.Next(welcomeMessages.Count);
        return welcomeMessages[index];
    }


    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}