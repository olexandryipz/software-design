using System;

public abstract class LightNode
{
    public void Render()
    {
        OnCreated();
        OnInserted();
        OnStylesApplied();
        OnClassListApplied();
        OnTextRendered();
        OnRemoved();
    }

    protected virtual void OnCreated() { }
    protected virtual void OnInserted() { }
    protected virtual void OnStylesApplied() { }
    protected virtual void OnClassListApplied() { }
    protected virtual void OnTextRendered() { }
    protected virtual void OnRemoved() { }

    public abstract string OuterHTML { get; }
    public abstract string InnerHTML { get; }
}