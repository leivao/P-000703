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
        public IHttpActionResult ConsultarClientes()
        {
            ConsultarClientesReq oReq = new ConsultarClientesReq();
            ConsultarClientesRes oRes = new ConsultarClientesRes();

            oRes = _consultasLN.ConsultarClientes(oReq);
            return Json(new { data = oRes.ListadoClientes });
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
        public IHttpActionResult ConsultarPolizaId(ConsultarPolizaxIDReq objReq)  
        {
           
            ConsultarPolizaxIDRes oRes = new ConsultarPolizaxIDRes();          
            oRes = _consultasLN.ConsultarPolizaxID(objReq);
            return Json(new { data = oRes.ListadoPolizas });
        }

        [HttpPost]
        public IHttpActionResult ConsultarPolizaCliente(ConsultarPolizaClienteReq objReq)
        {
            //ConsultarPolizaClienteReq oReq = new ConsultarPolizaClienteReq();
            ConsultarPolizaClienteRes oRes = new ConsultarPolizaClienteRes();

            oRes = _consultasLN.ConsultarPolizaCliente(objReq);
            return Json(new { data = oRes.ListadoPolizas });
        }

        [HttpPost]
        public IHttpActionResult ConsultarPolizaClientexID(ConsultarPolizaClientexIDReq objReq)
        {
            //ConsultarPolizaClienteReq oReq = new ConsultarPolizaClienteReq();
            ConsultarPolizaClientexIDRes oRes = new ConsultarPolizaClientexIDRes();

            oRes = _consultasLN.ConsultarPolizaClientexID(objReq);
            return Json(new { data = oRes.ListadoPolizas });
        }
    }
}
