#nullable enable
using System;

namespace Game.DataProvders
{
    public interface IDataProvider
    {
        void Clear();
        object? GetValue(Enum name);
        void Publish(Enum controlName, object value);
        IObservable<TValue> Receive<TValue>(Enum name);
    }
}