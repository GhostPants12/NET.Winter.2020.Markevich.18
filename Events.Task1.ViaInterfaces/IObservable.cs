using System;
using System.Collections.Generic;
using System.Text;

namespace Events.Task1
{
    public interface IObservable
    {
        /// <summary>Registers the specified observer.</summary>
        /// <param name="observer">The observer.</param>
        void Register(IObserver observer);

        /// <summary>Unregisters the specified observer.</summary>
        /// <param name="observer">The observer.</param>
        void Unregister(IObserver observer);

        /// <summary>Notifies about changes of this instance.</summary>
        void Notify();
    }
}
