using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_000703.Entidades.Salida
{
    [Serializable]
    public class ConsultarPolizaClientexIDRes : BaseRes
    {
        public List<PA_CONS_POL_POLIZA_X_CLIENTE_X_ID_Result> ListadoPolizas { get; set; }
    }
}
