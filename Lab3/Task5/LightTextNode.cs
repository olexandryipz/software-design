using System;

public class LightTextNode : LightNode
{
    public string Text { get; }

    public LightTextNode(string text)
    {
        Text = text;
    }

    public override string OuterHTML => Text;

    public override string InnerHTML => Text;

    protected override void OnCreated()
    {
        Console.WriteLine($"[OnCreated] Text node created: \"{Text}\"");
    }

    protected override void OnInserted()
    {
        Console.WriteLine($"[OnInserted] Text node inserted: \"{Text}\"");
    }

    protected override void OnTextRendered()
    {
        Console.WriteLine($"[OnTextRendered] Text rendered: \"{Text}\"");
    }
}