namespace DependencyInjectionSample;

using System;
using Chickensoft.AutoInject;
using Godot;
using SuperNodes.Types;


[SuperNode(typeof(Dependent))]
public partial class ScoreView : Node, IObserver<int>
{
    private IDisposable? scoreEventDisposable;

    public override partial void _Notification(int what);

    [Dependency]
    private IScoreEvent ScoreEvent => DependOn<IScoreEvent>();


    public void OnResolved()
    {
        scoreEventDisposable = ScoreEvent.Subscribe(this);
    }

    public void OnTreeExit()
    {
        scoreEventDisposable?.Dispose();
    }

    void IObserver<int>.OnCompleted()
    {

    }

    void IObserver<int>.OnError(Exception error)
    {

    }

    void IObserver<int>.OnNext(int value)
    {
        GD.Print($"Update Score: {value}");
    }
}
