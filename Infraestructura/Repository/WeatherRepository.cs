using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using Domain.Interfaces;

namespace Infraestructura.Repository
{
    class WeatherRepository : IModel
    {


        public void GetWeather()
        {
            //String APIKey = "35fa3e233a64b7ee191fd5d276a59fcd";

            //using (WebClient web = new WebClient())
            //{
            //    String url = String.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", txtCiudad.Text, APIKey);

            //    var json = web.DownloadString(url);

            //    root Info = JsonConvert.DeserializeObject<root>(json);
            //    Weather weather = new Weather();

            //    picIcon.Image = "https://api.openweathermap.org/img/w/04n.png" + weather.icon + ".png";
            //}
        }
    }
}
