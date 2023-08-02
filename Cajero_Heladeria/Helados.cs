using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Heladeria
{
    public class Helados
    {
        public List<Helado> ListHelados { get; set; }
        public Helados()
        {
            ListHelados = new List<Helado>();
        }
        public void Agregar(Helado helado)
        {
            ListHelados.Add(helado);
        }
        public List<Helado> ImprimirHelados()
        {
            List<Helado> imphelados = new List<Helado>();
            foreach (Helado helado in ListHelados)
            {
                imphelados.Add(helado);
            }
            return imphelados;
        }
        public List<Helado> HeladoXCliente(string cliente)
        {
            List<Helado> aux = new List<Helado>();
            foreach (Helado helado in ListHelados)
            {
                if (helado.Cliente.StartsWith(cliente))
                {
                    aux.Add(helado);
                }
            }
            return aux;
        }
    }
}