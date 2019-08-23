using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace P_000703.Entidades.Entrada
{

    public class MantenimientoPolizaReq
    {
        public int TipoOperacion { get; set; }
        public string Pol_Poliza { get; set; }

        public string Nombre { get; set; }
        public string TipoCubrimiento { get; set; }
        public String Descripcion { get; set; }
        public String InicioVigencia { get; set; }
        public int PeriodoCobertura { get; set; }
        public Decimal Precio { get; set; }
        public string Pol_Tipo_Riesgo { get; set; }
    }
}
