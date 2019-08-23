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
    public interface IConsultasAD
    {
        ConsultarClientesRes ConsultarClientes(ConsultarClientesReq objReq);
        ConsultarPolizaRes ConsultarPoliza(ConsultarPolizaReq objReq);
        ConsultarPolizaxIDRes ConsultarPolizaxID(ConsultarPolizaxIDReq objReq);
        ConsultarPolizaClienteRes ConsultarPolizaCliente(ConsultarPolizaClienteReq objReq);
        ConsultarPolizaClientexIDRes ConsultarPolizaClientexID(ConsultarPolizaClientexIDReq objReq);
        ConsultarTipoCubrimientoRes ConsultarTipoCubrimiento(ConsultarTipoCubrimientoReq objReq);
        ConsultarTipoRiesgoRes ConsultarTipoRiesgo(ConsultarTipoRiesgoReq objReq);
    }
}
