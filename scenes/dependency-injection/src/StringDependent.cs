namespace DependencyInjectionSample;

using Chickensoft.AutoInject;
using Godot;
using SuperNodes.Types;

[SuperNode(typeof(Dependent))]
public partial class StringDependent : Node
{
    public override partial void _Notification(int what);

    [Dependency]
    public string MyDependency => DependOn<string>();


    public void OnResolved()
    {
        GD.Print($"> {GetPath()}");
        GD.Print(MyDependency);
    }
}
