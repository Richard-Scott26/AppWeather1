using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWeather1
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GetWeather();
        }

        public void GetWeather()
        {
            String APIKey = "35fa3e233a64b7ee191fd5d276a59fcd";

            using (WebClient web = new WebClient())
            {
                String url = String.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", txtCiudad.Text, APIKey);

                var json = web.DownloadString(url);

                WeatherInfo.Root Info = JsonConvert.DeserializeObject<WeatherInfo.Root>(json);

                picIcon.ImageLocation = "https://api.openweathermap.org/img/w/04n.png" +Info.weather[0].icon +".png";
                lblCondition.Text = Info.weather[0].main;
                lblDetails.Text = Info.weather[0].descripcion;
                lblSunset.Text = ConvertDateTime(Info.sys.Sunset).ToShortTimeString();
                lblSunrise.Text = ConvertDateTime(Info.sys.Sunrise).ToShortTimeString();

                lblSpeed.Text = Info.wind.speed.ToString();
                lblPressure.Text = Info.main.pressure.ToString();
            }
        }

        DateTime ConvertDateTime(long Milisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();

            day = day.AddMilliseconds(Milisec).ToLocalTime();

            return day;
        }

    }
}
