using System;

class Program
{
    static void Main()
    {
        ILogger consoleLogger = new Logger();
        consoleLogger.Log("This is a log message");
        consoleLogger.Error("This is an error");
        consoleLogger.Warn("This is a warning");

        Console.WriteLine();

        var fileWriter = new FileWriter("log.txt");
        ILogger fileLogger = new FileLoggerAdapter(fileWriter);
        fileLogger.Log("Logging to file");
        fileLogger.Error("File error occurred");
        fileLogger.Warn("File warning message");

        Console.WriteLine("File logging done. Check log.txt");
    }
}
