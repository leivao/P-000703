﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_000703.Entidades.Salida
{
    [Serializable]
    public class ConsultarClientesRes : BaseRes
    {
        public List<PA_CONS_CRM_CLIENTE_Result> ListadoClientes { get; set; }
    }
}