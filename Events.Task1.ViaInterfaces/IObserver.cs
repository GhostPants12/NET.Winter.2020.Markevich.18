using System;
using System.Collections.Generic;
using System.Text;

namespace Events.Task1
{
    public interface IObserver
    {
        /// <summary>Updates the info.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="temperature">The temperature.</param>
        /// <param name="humidity">The humidity.</param>
        /// <param name="pressure">The pressure.</param>
        void Update(IObservable sender, int temperature, int humidity, int pressure);
    }
}
