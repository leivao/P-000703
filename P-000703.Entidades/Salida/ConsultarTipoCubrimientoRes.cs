using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P_000703.Entidades;

namespace P_000703.Entidades.Salida
{
    [Serializable]
    public class ConsultarTipoCubrimientoRes : BaseRes
    {
        public List<PA_CONS_POL_TIPO_CUBRIMIENTO_Result> ListadoTipoCubrimiento { get; set; }
    }
}
