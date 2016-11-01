using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_testing_tut.Models;

namespace unit_testing_tut.Services
{
    public interface IMountainWeatherService
    {
        IEnumerable<Location> GetAreas();
        ForecastReport GetAreaForecast(int id);
    }

    public class MountainWeatherService : IMountainWeatherService
    {
        public IEnumerable<Location> GetAreas()
        {
            return new Location[]
            {
                new Location { Id = 100, Name = "Area 1" },
                new Location { Id = 101, Name = "Area 2" },
                new Location { Id = 102, Name = "Area 3" },
                new Location { Id = 103, Name = "Area 4" },
                new Location { Id = 104, Name = "Area 5" },
            };
        }
        public ForecastReport GetAreaForecast(int id)
        {
            switch (id)
            {
                case 100 : return new ForecastReport { Forecast =  "Today will be fine and dry." };
                case 101 : return new ForecastReport { Forecast =  "Today will be wet and windy." };
                case 102 : return new ForecastReport { Forecast =  "Blizzards expected throughout the day." };
                case 103 : return new ForecastReport { Forecast =  "Today will be very cold with occasional snow snowers." };
                case 104 : return new ForecastReport { Forecast =  "High winds and white out conditions expected." };
                default:
                    return null;
            }
        }
    }
}
