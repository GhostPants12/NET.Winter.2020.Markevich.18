using System;
using System.Collections.Generic;
using System.Text;

namespace Events.Task1
{
    public class WeatherDataChangedEventArgs : EventArgs
    {
        /// <summary>Initializes a new instance of the <see cref="WeatherDataChangedEventArgs"/> class.</summary>
        /// <param name="newTemperature">The new temperature.</param>
        /// <param name="newHumidity">The new humidity.</param>
        /// <param name="newPressure">The new pressure.</param>
        public WeatherDataChangedEventArgs(int newTemperature, int newHumidity, int newPressure)
        {
            this.NewTemperature = newTemperature;
            this.NewHumidity = newHumidity;
            this.NewPressure = newPressure;
        }

        /// <summary>Gets the new temperature.</summary>
        /// <value>The new temperature.</value>
        public int NewTemperature { get; }

        /// <summary>Gets the new humidity.</summary>
        /// <value>The new humidity.</value>
        public int NewHumidity { get; }

        /// <summary>Gets the new pressure.</summary>
        /// <value>The new pressure.</value>
        public int NewPressure { get; }
    }
}
