using System;

public class SmartTextChecker : ISmartTextReader
{
    private SmartTextReader _reader = new SmartTextReader();

    public char[][] ReadText(string path)
    {
        Console.WriteLine($"[LOG] Opening file: {path}");
        char[][] result = _reader.ReadText(path);
        Console.WriteLine("[LOG] File read successfully.");

        int lineCount = result.Length;
        int charCount = 0;
        foreach (var line in result)
            charCount += line.Length;

        Console.WriteLine($"[LOG] Lines: {lineCount}, Characters: {charCount}");
        Console.WriteLine("[LOG] File closed.");
        return result;
    }
}
