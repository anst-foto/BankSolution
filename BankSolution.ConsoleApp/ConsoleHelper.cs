using BankSolution.Core;

namespace BankSolution.ConsoleApp;

public static class ConsoleHelper
{
    private static void Print(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public static void PrintAccount(Account account)
    {
        var message = $"{account.Id} : {account.Person.FullName} -> {account.Balance}";
        Print(message, ConsoleColor.Green);
    }

    public static void PrintError(string message)
    {
        Print(message, ConsoleColor.DarkRed);
    }
}