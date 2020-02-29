using System;
using System.Collections.Generic;
using System.Text;

namespace Events.Task1
{
    public class WeatherData : IObservable
    {
        private readonly Random random = new Random(Environment.TickCount);

        private List<IObserver> observers = new List<IObserver>();

        /// <summary>Initializes a new instance of the <see cref="WeatherData"/> class.</summary>
        /// <param name="temp">The temperature.</param>
        /// <param name="hum">The humidity.</param>
        /// <param name="pres">The pressure.</param>
        public WeatherData(int temp, int hum, int pres)
        {
            this.Temperature = temp;
            this.Humidity = hum;
            this.Pressure = pres;
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

        /// <summary>Notifies about changes of this instance.</summary>
        void IObservable.Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(this, this.Temperature, this.Humidity, this.Pressure);
            }
        }

        /// <summary>Randomizes the weather data.</summary>
        public void RandomizeWeatherData()
        {
            this.Temperature = this.random.Next(0, 100);
            this.Humidity = this.random.Next(0, 100);
            this.Pressure = this.random.Next(0, 100);
            ((IObservable)this).Notify();
        }

        /// <summary>Registers the specified observer.</summary>
        /// <param name="observer">The observer.</param>
        public void Register(IObserver observer)
        {
            this.observers.Add(observer);
        }

        /// <summary>Unregisters the specified observer.</summary>
        /// <param name="observer">The observer.</param>
        public void Unregister(IObserver observer)
        {
            this.observers.Remove(observer);
        }
    }
}
