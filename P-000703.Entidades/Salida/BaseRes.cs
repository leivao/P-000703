using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_000703.Entidades.Salida
{
    [Serializable]
    public class BaseRes
    {
        public string Estado { get; set; }
        public string Mensaje { get; set; }
        public string ListadoItems { get; set; }
    }
}
