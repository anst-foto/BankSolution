namespace BankSolution.Logger;

public class FileLogger : ILogger
{
    private readonly string _path;

    public FileLogger(string path = "log.txt")
    {
        _path = path;
    }

    private void WriteToFile(string message)
    {
        using var file = new StreamWriter(_path, append: true);
        file.WriteLine(message);
    }

    public void LogInfo(string message)
    {
        WriteToFile($"[INFO] {DateTime.Now:G} {message}");
    }

    public void LogError(string message)
    {
        WriteToFile($"[ERROR] {DateTime.Now:G} {message}");
    }
}