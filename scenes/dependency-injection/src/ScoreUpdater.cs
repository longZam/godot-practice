namespace DependencyInjectionSample;

using System;
using System.Threading;
using System.Threading.Tasks;
using Chickensoft.AutoInject;
using Godot;
using SuperNodes.Types;


[SuperNode(typeof(Dependent))]
public partial class ScoreUpdater : Node, IObserver<int>
{
    private IAddScore? addScore;

    public override partial void _Notification(int what);

    [Dependency]
    private IAddScore AddScore => DependOn<IAddScore>();


    public void OnResolved()
    {
        this.addScore = DependOn<IAddScore>();

        Coroutine();
    }

    public async void Coroutine()
    {
        for (int i = 0; i < 10; i++)
        {
            addScore?.AddScore();

            await Task.Run(() => Thread.Sleep(1000));
        }
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
