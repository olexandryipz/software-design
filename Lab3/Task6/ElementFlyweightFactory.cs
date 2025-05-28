using System.Collections.Generic;

public class ElementFlyweightFactory
{
    private Dictionary<string, ElementFlyweight> _flyweights = new();

    public LightElementNode GetElement(string tagName)
    {
        if (!_flyweights.ContainsKey(tagName))
        {
            _flyweights[tagName] = new ElementFlyweight(tagName, TagType.Paired);
        }
        return _flyweights[tagName].CreateElement();
    }

    public int Count => _flyweights.Count;
}
