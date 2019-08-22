using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P_000703.Entidades.Salida;
using P_000703.Entidades.Entrada;
using P_000703.AD;

namespace P_000703.LN
{
    public interface IMantenimientosLN
    {
        MantenimientoPolizaClienteRes MantenimientoPolizaCliente(MantenimientoPolizaClienteReq objReq);
        MantenimientoPolizaRes MantenimientoPoliza(MantenimientoPolizaReq objReq);
    }
}
