using System;
using System.Collections.Generic;
using System.IO;

public class SmartTextReader : ISmartTextReader
{
    public char[][] ReadText(string path)
    {
        List<char[]> lines = new List<char[]>();
        using (StreamReader sr = new StreamReader(path))
        {
            string? line;
            while ((line = sr.ReadLine()) != null)
            {
                lines.Add(line.ToCharArray());
            }
        }
        return lines.ToArray();
    }
}
