using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Weather
    {
        public String main { get; set; }
        public String descripcion { get; set; }
        public String icon { get; set; }
    }
}
