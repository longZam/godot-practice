namespace DependencyInjectionSample;

using Chickensoft.AutoInject;
using Godot;
using SuperNodes.Types;

[SuperNode(typeof(Provider))]
public partial class IntProvider : Node, IProvide<int>
{
    [Export]
    private int dependency;


    public override partial void _Notification(int what);
    int IProvide<int>.Value() => dependency;


    // Call the Provide() method once your dependencies have been initialized.
    public void OnReady() => Provide();

    public void OnProvided()
    {

    }
}
