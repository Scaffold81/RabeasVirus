#nullable enable
using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace Game.DataProvders
{
    public class DataProviderBase: IDataProvider
    {
        public Dictionary<Enum, BehaviorSubject<object?>> _observables = new();

        public void Publish(Enum controlName, object value)
        {
            EnsureCreated(controlName);
            _observables[controlName].OnNext(value);
        }

        public object? GetValue(Enum name)
        {
            return _observables.ContainsKey(name)
                ? _observables[name].Value
                : null;
        }

        public IObservable<TValue> Receive<TValue>(Enum name)
        {
            EnsureCreated(name);

            return _observables[name].Where(value => value is TValue)!.Cast<TValue>();
        }

        private void EnsureCreated(Enum name)
        {
            lock (_observables)
            {
                if (_observables.ContainsKey(name) == false)
                    _observables[name] = new BehaviorSubject<object?>(null);
            }
        }

        public void Clear()
        {
            _observables.Clear();
        }
    }
}