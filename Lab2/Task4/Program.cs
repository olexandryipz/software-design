using System;

class Program
{
    static void Main()
    {
        Virus parentVirus = new Virus("ParentVirus", "TypeA", 10.5, 5);

        Virus child1 = new Virus("Child1", "TypeB", 5.0, 2);
        Virus child2 = new Virus("Child2", "TypeB", 4.5, 1);

        parentVirus.AddChild(child1);
        parentVirus.AddChild(child2);

        Virus grandchild1 = new Virus("Grandchild1", "TypeC", 2.0, 1);
        Virus grandchild2 = new Virus("Grandchild2", "TypeC", 1.5, 1);

        child1.AddChild(grandchild1);
        child2.AddChild(grandchild2);

        Console.WriteLine("Original virus family:");
        parentVirus.Print();

        Console.WriteLine("\nCloning parent virus...");

        Virus clonedVirus = (Virus)parentVirus.Clone();

        Console.WriteLine("\nCloned virus family:");
        clonedVirus.Print();

        Console.WriteLine("\nCheck if original and clone are different instances:");
        Console.WriteLine($"Parent and clone are same instance? {ReferenceEquals(parentVirus, clonedVirus)}");
        Console.WriteLine($"Child1 and clone's Child1 are same instance? {ReferenceEquals(parentVirus.Children[0], clonedVirus.Children[0])}");
    }
}
