using System.Collections.Generic;
using System.Text;

public enum TagType { Paired, Single }

public class LightElementNode : LightNode
{
    public string TagName { get; }
    public TagType TagType { get; }
    public List<LightNode> Children { get; }

    public LightElementNode(string tagName, TagType tagType)
    {
        TagName = tagName;
        TagType = tagType;
        Children = new List<LightNode>();
    }

    public void AddChild(LightNode child) => Children.Add(child);

    public override string InnerHTML
    {
        get
        {
            StringBuilder sb = new StringBuilder();
            foreach (var child in Children)
                sb.Append(child.OuterHTML);
            return sb.ToString();
        }
    }

    public override string OuterHTML
    {
        get
        {
            if (TagType == TagType.Single)
                return $"<{TagName}/>";
            else
                return $"<{TagName}>{InnerHTML}</{TagName}>";
        }
    }
}
