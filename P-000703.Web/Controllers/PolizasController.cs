using P_000703.Entidades.Entrada;
using P_000703.Entidades.Salida;
using P_000703.LN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace P_000703.Web.Controllers
{
    public class PolizasController : ApiController
    {
        // GET: api/Polizas
        [HttpGet]
        public ConsultarTipoCubrimientoRes ConsultarTipoCubrimiento()
        {
            ConsultarTipoCubrimientoReq oReq = new ConsultarTipoCubrimientoReq();
            ConsultarTipoCubrimientoRes oRes = new ConsultarTipoCubrimientoRes();
            ConsultasLN consultasLN = new ConsultasLN();
            oRes = consultasLN.ConsultarTipoCubrimiento(oReq);
            return oRes;
        }

        [HttpGet]
        public ConsultarTipoRiesgoRes ConsultarTipoRiesgo()
        {
            ConsultarTipoRiesgoReq oReq = new ConsultarTipoRiesgoReq();
            ConsultarTipoRiesgoRes oRes = new ConsultarTipoRiesgoRes();
            ConsultasLN consultasLN = new ConsultasLN();
            oRes = consultasLN.ConsultarTipoRiesgo(oReq);
            return oRes;
        }

        [HttpPost]
        public MantenimientoPolizaClienteRes MantenimientoPolizaCliente(MantenimientoPolizaClienteReq objReq)
        {
            MantenimientoPolizaClienteReq oReq = new MantenimientoPolizaClienteReq();
            MantenimientoPolizaClienteRes oRes = new MantenimientoPolizaClienteRes();
            MantenimientosLN mantenimientos = new MantenimientosLN();
            oRes = mantenimientos.MantenimientoPolizaCliente(oReq);
            return oRes;
        }

        [HttpPost]
        public MantenimientoPolizaRes MantenimientoPoliza(HttpRequestMessage objReq)
        {
            var respuestaRecibida = objReq.Content.ReadAsStringAsync();
            MantenimientoPolizaReq oReq = new MantenimientoPolizaReq();
            MantenimientoPolizaRes oRes = new MantenimientoPolizaRes();
            MantenimientosLN mantenimientos = new MantenimientosLN();
            oRes = mantenimientos.MantenimientoPoliza(oReq);
            return oRes;
        }

    }
}
