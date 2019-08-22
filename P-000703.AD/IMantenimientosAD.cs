using P_000703.Entidades.Salida;
using P_000703.Entidades.Entrada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;

namespace P_000703.AD
{
    public interface IMantenimientosAD
    {
        MantenimientoPolizaRes MantenimientoPoliza(MantenimientoPolizaReq objReq);
        MantenimientoPolizaClienteRes MantenimientoPolizaCliente(MantenimientoPolizaClienteReq objReq);
    }
}
