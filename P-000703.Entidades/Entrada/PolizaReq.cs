using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace P_000703.Entidades.Entrada
{
    [Serializable]
    public class PolizaReq
    {
        public int TipoOperacion { get; set; }
        public Guid Pol_Poliza { get; set; }
        [DataMember]
        public String Nombre { get; set; }
        public Guid TipoCubrimiento { get; set; }
        public String Descripcion { get; set; }
        public DateTime InicioVigencia { get; set; }
        public int PeriodoCobertura { get; set; }
        public Decimal Precio { get; set; }
        public Guid Pol_Tipo_Riesgo { get; set; }
    }
}
