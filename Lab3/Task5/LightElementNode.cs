using System;
using System.Collections;
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

public class LightElementNode : LightNode, IEnumerable<LightNode>
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

    public IEnumerator<LightNode> GetEnumerator()
    {
        yield return this;

        foreach (var child in Children)
        {
            if (child is LightElementNode elementChild)
            {
                foreach (var descendant in elementChild)
                {
                    yield return descendant;
                }
            }
            else
            {
                yield return child;
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerable<LightNode> BreadthFirstTraversal()
    {
        Queue<LightNode> queue = new Queue<LightNode>();
        queue.Enqueue(this);

        while (queue.Count > 0)
        {
            LightNode current = queue.Dequeue();
            yield return current;

            if (current is LightElementNode elementNode)
            {
                foreach (var child in elementNode.Children)
                {
                    queue.Enqueue(child);
                }
            }
        }
    }
}
