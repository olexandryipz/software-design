using System;

class Program
{
    static void Main()
    {
        var div = new LightElementNode("div", DisplayType.Block, TagType.Paired);
        div.AddClass("container");

        var header = new LightElementNode("h1", DisplayType.Block, TagType.Paired);
        header.AddChild(new LightTextNode("Title"));

        var paragraph = new LightElementNode("p", DisplayType.Block, TagType.Paired);
        paragraph.AddChild(new LightTextNode("Hello "));

        var bold = new LightElementNode("b", DisplayType.Inline, TagType.Paired);
        bold.AddChild(new LightTextNode("world"));

        paragraph.AddChild(bold);

        div.AddChild(header);
        div.AddChild(paragraph);

        Console.WriteLine("--- Rendered HTML ---");
        Console.WriteLine(div.OuterHTML);

        Console.WriteLine("\n--- DFS Traversal ---");
        foreach (var node in div)
        {
            Console.WriteLine(node.OuterHTML);
        }

        Console.WriteLine("\n--- BFS Traversal ---");
        foreach (var node in div.BreadthFirstTraversal())
        {
            Console.WriteLine(node.OuterHTML);
        }
    }
}
