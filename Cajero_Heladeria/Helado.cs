using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Heladeria
{
    public class Helado
    {
        public string Sabor { get; set; }
        public string Aderezo { get; set; }
        public string Servicios { get; set; }
        public string Tamanio { get; set; }
        public string Adicional { get; set; }
        public string Cantidad { get; set; }
        public string Cliente { get; set; }
        public Helado() { }
        public Helado(string sabor, string aderezo, string servicios, string tamanio, string adicional, string cantidad)
        {
            Sabor = sabor;
            Aderezo = aderezo;
            Servicios = servicios;
            Tamanio = tamanio;
            Adicional = adicional;
            Cantidad = cantidad;
        }
    }
}
