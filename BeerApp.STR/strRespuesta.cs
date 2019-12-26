using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerApp.STR
{
    public class strRespuesta
    {
        public bool IsError { get; set; }
        public string Message { get; set; }
        public List<strProductos> Productos { get; set; }
        public List<strConductores> Conductores { get; set; }
        public List<strEnvios> Envios { get; set; }
        public List<strEnvioProductos> EnvioProductos { get; set; }
    }
}
