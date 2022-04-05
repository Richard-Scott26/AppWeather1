using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWeather1
{
    public class WeatherInfo
    {
        public class Main
        {
            public double temp { get; set; }
            public double pressure { get; set; }
            public double humidity { get; set; }
        }

        public class root
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }

        public class Sys
        {
            public long Sunrise { get; set; }
            public long Sunset { get; set; }
        }

        public class Weather
        {
            public String main { get; set; }
            public String descripcion { get; set; }
            public String icon { get; set; }
        }

        public class Wind
        {
            public double speed { get; set; }
        }

        public class Root
        {
            public root coord { get; set; }
            public List<Weather> weather { get; set; }
            public Main main { get; set; }
            public Wind wind { get; set; }
            public Sys sys { get; set; }
        }
    }
}
