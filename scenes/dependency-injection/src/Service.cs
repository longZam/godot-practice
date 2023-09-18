namespace DISample;

using Godot;


public partial class Service : Node, ISomeService
{
    public void Foo()
    {
        GD.Print("Bar");
    }
}
