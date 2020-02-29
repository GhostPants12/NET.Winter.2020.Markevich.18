using System;
using System.Collections.Generic;
using System.Text;

namespace Events.Task1
{
    public class CurrentConditionsReport : IObserver
    {
        /// <summary>Initializes a new instance of the <see cref="CurrentConditionsReport"/> class.</summary>
        /// <param name="temperature">The temperature.</param>
        /// <param name="humidity">The humidity.</param>
        /// <param name="pressure">The pressure.</param>
        public CurrentConditionsReport(int temperature, int humidity, int pressure)
        {
            this.Temperature = temperature;
            this.Humidity = humidity;
            this.Pressure = pressure;
        }

        /// <summary>Gets the temperature.</summary>
        /// <value>The temperature.</value>
        public int Temperature { get; private set; }

        /// <summary>Gets the humidity.</summary>
        /// <value>The humidity.</value>
        public int Humidity { get; private set; }

        /// <summary>Gets the pressure.</summary>
        /// <value>The pressure.</value>
        public int Pressure { get; private set; }

        /// <summary>Updates the report's info.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="newTemperature">The new temperature.</param>
        /// <param name="newHumidity">The new humidity.</param>
        /// <param name="newPressure">The new pressure.</param>
        public void Update(IObservable sender, int newTemperature, int newHumidity, int newPressure)
        {
            this.Temperature = newTemperature;
            this.Humidity = newHumidity;
            this.Pressure = newPressure;
            Console.WriteLine($"Current temperature is {this.Temperature} degrees celsius.");
            Console.WriteLine($"Current humidity is {this.Humidity} percent.");
            Console.WriteLine($"Current pressure is {this.Pressure} kPa.");
            Console.WriteLine("-----------------------------------------------------------");
        }
    }
}
