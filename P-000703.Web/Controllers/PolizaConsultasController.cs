using P_000703.Entidades.Entrada;
using P_000703.Entidades.Salida;
using P_000703.LN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;


namespace P_000703.Web.Controllers
{
    public class PolizaConsultasController : ApiController
    {
        ConsultasLN _consultasLN;

        public PolizaConsultasController()
        {
            _consultasLN = new ConsultasLN();
        }

       

        [HttpPost]

        public IHttpActionResult ConsultarTipoCubrimiento()
        {
            ConsultarTipoCubrimientoReq oReq = new ConsultarTipoCubrimientoReq();
            ConsultarTipoCubrimientoRes oRes = new ConsultarTipoCubrimientoRes();
            
            oRes = _consultasLN.ConsultarTipoCubrimiento(oReq);

      
            return Json(new { data = oRes.ListadoTipoCubrimiento});
       
        }

        [HttpPost]
        public IHttpActionResult ConsultarTipoRiesgo()
        {
            ConsultarTipoRiesgoReq oReq = new ConsultarTipoRiesgoReq();
            ConsultarTipoRiesgoRes oRes = new ConsultarTipoRiesgoRes();
            
            oRes = _consultasLN.ConsultarTipoRiesgo(oReq);
            return Json(new { data = oRes.ListadoTipoRiesgo });
        }

        [HttpPost]
        public IHttpActionResult ConsultarPoliza()
        {
            ConsultarPolizaReq oReq = new ConsultarPolizaReq();
            ConsultarPolizaRes oRes = new ConsultarPolizaRes();

            oRes = _consultasLN.ConsultarPoliza(oReq);
            return Json(new { data = oRes.ListadoPolizas });
        }
        [HttpPost]
        public ConsultarPolizaClienteRes ConsultarPolizaCliente()
        {
            ConsultarPolizaClienteReq oReq = new ConsultarPolizaClienteReq();
            ConsultarPolizaClienteRes oRes = new ConsultarPolizaClienteRes();

            oRes = _consultasLN.ConsultarPolizaCliente(oReq);
            return oRes;
        }
    }
}
