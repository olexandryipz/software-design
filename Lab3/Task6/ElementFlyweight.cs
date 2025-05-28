public class ElementFlyweight
{
    public string TagName { get; }
    public TagType TagType { get; }

    public ElementFlyweight(string tagName, TagType tagType)
    {
        TagName = tagName;
        TagType = tagType;
    }

    public LightElementNode CreateElement()
    {
        return new LightElementNode(TagName, TagType);
    }
}
