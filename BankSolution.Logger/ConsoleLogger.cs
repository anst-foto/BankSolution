namespace BankSolution.Logger;

public class ConsoleLogger : ILogger
{
    private static void Print(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }
    public void LogInfo(string message)
    {
        Print($"[INFO] {DateTime.Now:G} {message}", ConsoleColor.Blue);
    }

    public void LogError(string message)
    {
        Print($"[ERROR] {DateTime.Now:G} {message}", ConsoleColor.Red);
    }
}