using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    class Root
    {
        public root coord { get; set; }
        public List<Weather> weather { get; set; }
        public Main main { get; set; }
        public Wind wind { get; set; }
        public Sys sys { get; set; }
    }
}
