using System;
using System.Collections.Generic;
using System.Text;

namespace Events.Task1
{
    public class CurrentConditionsReport
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

        /// <summary>Reports about current condition.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The <see cref="WeatherDataChangedEventArgs"/> instance containing the event data.</param>
        public void Report(object sender, WeatherDataChangedEventArgs args)
        {
            this.Temperature = args.NewTemperature;
            this.Humidity = args.NewHumidity;
            this.Pressure = args.NewPressure;
            Console.WriteLine($"Current temperature is {this.Temperature} degrees celsius.");
            Console.WriteLine($"Current humidity is {this.Humidity} percent.");
            Console.WriteLine($"Current pressure is {this.Pressure} kPa.");
            Console.WriteLine("-----------------------------------------------------------");
        }
    }
}
