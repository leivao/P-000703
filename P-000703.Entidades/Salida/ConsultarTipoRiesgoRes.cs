﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_000703.Entidades.Salida
{
    [Serializable]
    public class ConsultarTipoRiesgoRes : BaseRes
    {
        
        public List<PA_CONS_POL_TIPO_RIESGO_Result> ListadoTipoRiesgo { get; set; }
    }
}
