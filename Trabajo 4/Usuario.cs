using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_4
{
    public class Usuario
    {
        public int Semana { get; set; }

        public int Peso { get; set; }

        public string Ejercicio { get; set; }

        public int IdOrden { get; set; }

        public bool Validar()
        {
            bool resp = false;

            if (Peso < 100 )
            {
                resp = true;
            }
            return resp;
        }

    }
}
