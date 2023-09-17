namespace DependencyInjectionSample;

using Chickensoft.AutoInject;
using Godot;
using SuperNodes.Types;

[SuperNode(typeof(Dependent))]
public partial class StringIntDependent : Node
{
    public override partial void _Notification(int what);

    [Dependency]
    public string StrDependency => DependOn<string>();
    [Dependency]
    public int IntDependency => DependOn<int>();

    public void OnResolved()
    {
        GD.Print($"> {GetPath()}");
        GD.Print(StrDependency);
        GD.Print(IntDependency);
    }
}
