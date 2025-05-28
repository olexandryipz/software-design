using System;

class Program
{
    static void PrintMatrix(char[][] matrix)
    {
        foreach (var line in matrix)
        {
            Console.WriteLine(new string(line));
        }
    }

    static void Main()
    {
        string filePath = "sample.txt";

        ISmartTextReader loggerProxy = new SmartTextChecker();
        ISmartTextReader lockedProxy = new SmartTextReaderLocker(@"secret|protected");

        Console.WriteLine("=== Reading with Logger ===");
        var matrix1 = loggerProxy.ReadText(filePath);
        PrintMatrix(matrix1);

        Console.WriteLine("\n=== Reading with Locker (denied) ===");
        var matrix2 = lockedProxy.ReadText("secret_data.txt");

        Console.WriteLine("\n=== Reading with Locker (allowed) ===");
        var matrix3 = lockedProxy.ReadText(filePath);
        PrintMatrix(matrix3);
    }
}
