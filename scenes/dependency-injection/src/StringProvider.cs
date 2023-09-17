namespace DependencyInjectionSample;

using Chickensoft.AutoInject;
using Godot;
using SuperNodes.Types;

[SuperNode(typeof(Provider))]
public partial class StringProvider : Node, IProvide<string>
{
    [Export]
    private string dependency = "";


    public override partial void _Notification(int what);
    string IProvide<string>.Value() => dependency;


    // Call the Provide() method once your dependencies have been initialized.
    public void OnReady() => Provide();

    public void OnProvided()
    {

    }
}
