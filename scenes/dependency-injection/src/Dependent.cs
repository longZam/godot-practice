namespace DISample;

using System.Diagnostics;
using Godot;
using Godot.DependencyInjection.Attributes;
using System.Reflection;

public partial class Dependent : Node
{
    private ISomeService? service;


    [Inject]
    public void Constructor(ISomeService service)
    {
        this.service = service;
    }

    public override void _Ready()
    {
        service?.Foo();
    }
}
