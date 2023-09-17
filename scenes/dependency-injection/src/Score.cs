using System;
using System.Collections.Generic;

namespace DependencyInjectionSample;


public interface IScoreEvent : IObservable<int>
{

}

public interface IAddScore
{
    void AddScore();
}

public class Score : IScoreEvent, IAddScore
{
    private class Disposable : IDisposable
    {
        private readonly HashSet<IObserver<int>> observers;
        private readonly IObserver<int> observer;


        public Disposable(HashSet<IObserver<int>> observers, IObserver<int> observer)
        {
            this.observers = observers;
            this.observer = observer;
        }

        void IDisposable.Dispose()
        {
            this.observers.Remove(observer);
        }
    }


    private readonly HashSet<IObserver<int>> observers;

    public int Value { get; private set; }


    public Score()
    {
        this.observers = new HashSet<IObserver<int>>();
    }

    void IAddScore.AddScore()
    {
        Value += 1;

        foreach (var observer in observers)
            observer.OnNext(Value);
    }

    IDisposable IObservable<int>.Subscribe(IObserver<int> observer)
    {
        if (!observers.Add(observer))
            throw new Exception();

        Disposable disposable = new Disposable(observers, observer);
        return disposable;
    }
}
