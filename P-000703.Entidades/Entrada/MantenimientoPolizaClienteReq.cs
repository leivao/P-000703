using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_000703.Entidades.Entrada
{
    [Serializable]
    public class MantenimientoPolizaClienteReq
    {
        public int TipoOperacion { get; set; }
        public Guid Pol_Poliza { get; set; }
        public Guid Crm_Cliente { get; set; }
        public Guid RegistradoPor { get; set; }
        //public DateTime FechaRegistro { get; set; }
    }
}
