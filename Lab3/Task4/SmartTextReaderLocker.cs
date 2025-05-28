using System;
using System.Text.RegularExpressions;

public class SmartTextReaderLocker : ISmartTextReader
{
    private readonly SmartTextReader _reader = new SmartTextReader();
    private readonly Regex _pattern;

    public SmartTextReaderLocker(string pattern)
    {
        _pattern = new Regex(pattern, RegexOptions.IgnoreCase);
    }

    public char[][] ReadText(string path)
    {
        if (_pattern.IsMatch(path))
        {
            Console.WriteLine("Access denied!");
            return Array.Empty<char[]>();
        }
        return _reader.ReadText(path);
    }
}
