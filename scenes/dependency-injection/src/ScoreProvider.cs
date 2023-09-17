namespace DependencyInjectionSample;

using Chickensoft.AutoInject;
using Godot;
using SuperNodes.Types;

[SuperNode(typeof(Provider))]
public partial class ScoreProvider : Node,
                                    IProvide<IScoreEvent>,
                                    IProvide<IAddScore>
{
    private readonly Score score = new Score();

    public override partial void _Notification(int what);

    IScoreEvent IProvide<IScoreEvent>.Value() => score;
    IAddScore IProvide<IAddScore>.Value() => score;


    // Call the Provide() method once your dependencies have been initialized.
    public void OnReady() => Provide();

    public void OnProvided()
    {

    }
}
