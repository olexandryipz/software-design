using System;
using System.Collections.Generic;
using System.Text;

public enum DisplayType
{
    Block,
    Inline
}

public enum TagType
{
    Paired,
    Single
}

public class LightElementNode : LightNode
{
    public string TagName { get; }
    public DisplayType Display { get; }
    public TagType TagType { get; }
    public List<string> CssClasses { get; }
    public List<LightNode> Children { get; }

    public LightElementNode(string tagName, DisplayType display, TagType tagType)
    {
        TagName = tagName;
        Display = display;
        TagType = tagType;
        CssClasses = new List<string>();
        Children = new List<LightNode>();
    }

    public void AddClass(string cssClass) => CssClasses.Add(cssClass);
    public void AddChild(LightNode node) => Children.Add(node);

    public override string InnerHTML
    {
        get
        {
            StringBuilder sb = new StringBuilder();
            foreach (var child in Children)
            {
                sb.Append(child.OuterHTML);
            }
            return sb.ToString();
        }
    }

    public override string OuterHTML
    {
        get
        {
            string classes = CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";
            if (TagType == TagType.Single)
            {
                return $"<{TagName}{classes}/>";
            }
            else
            {
                return $"<{TagName}{classes}>{InnerHTML}</{TagName}>";
            }
        }
    }

    protected override void OnCreated()
    {
        Console.WriteLine($"[OnCreated] Element <{TagName}> created.");
    }

    protected override void OnInserted()
    {
        Console.WriteLine($"[OnInserted] Element <{TagName}> inserted.");
    }

    protected override void OnStylesApplied()
    {
        Console.WriteLine($"[OnStylesApplied] Styles applied to <{TagName}>.");
    }

    protected override void OnClassListApplied()
    {
        Console.WriteLine($"[OnClassListApplied] Classes applied to <{TagName}>: {string.Join(", ", CssClasses)}");
    }

    protected override void OnTextRendered()
    {
        Console.WriteLine($"[OnTextRendered] Text rendered inside <{TagName}>.");
    }

    protected override void OnRemoved()
    {
        Console.WriteLine($"[OnRemoved] Element <{TagName}> removed.");
    }
}