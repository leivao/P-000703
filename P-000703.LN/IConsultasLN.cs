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
    public interface IConsultasLN
    {
        ConsultarPolizaRes ConsultarPoliza(ConsultarPolizaReq objReq);
        ConsultarPolizaClienteRes ConsultarPolizaCliente(ConsultarPolizaClienteReq objReq);
        ConsultarTipoCubrimientoRes ConsultarTipoCubrimiento(ConsultarTipoCubrimientoReq objReq);
        ConsultarTipoRiesgoRes ConsultarTipoRiesgo(ConsultarTipoRiesgoReq objReq);
    }
}
