using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main()
    {
        var factory = new ElementFlyweightFactory();
        var root = new LightElementNode("div", TagType.Paired);

        string[] lines = File.ReadAllLines("book.txt");

        foreach (string line in lines)
        {
            LightElementNode element;
            if (line == lines[0])
            {
                element = factory.GetElement("h1");
            }
            else if (line.Length < 20)
            {
                element = factory.GetElement("h2");
            }
            else if (char.IsWhiteSpace(line[0]))
            {
                element = factory.GetElement("blockquote");
            }
            else
            {
                element = factory.GetElement("p");
            }

            element.AddChild(new LightTextNode(line));
            root.AddChild(element);
        }

        Console.WriteLine(root.OuterHTML);
        Console.WriteLine($"\nFlyweights used: {factory.Count}");

        Process proc = Process.GetCurrentProcess();
        Console.WriteLine($"Memory used: {proc.PrivateMemorySize64 / 1024} KB");
    }
}
