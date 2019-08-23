using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_000703.Entidades.Entrada
{
    
    public class MantenimientoPolizaClienteReq
    {
        public int TipoOperacion { get; set; }
        public String Pol_Poliza { get; set; }
        public String Crm_Cliente { get; set; }
        public String Nombre_Cliente { get; set; }
        public String Correo_Cliente { get; set; }
        public String RegistradoPor { get; set; }
        //public DateTime FechaRegistro { get; set; }
    }
}
