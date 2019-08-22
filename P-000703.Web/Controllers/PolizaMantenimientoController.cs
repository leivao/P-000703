using P_000703.AD;
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
    public class PolizaMantenimientoController : ApiController
    {
        

        public PolizaMantenimientoController()
        {
            
        }

        /*public PolizaMantenimientoController(IMantenimientosLN mantenimientoLN)
        {
            _mantenimientoLN = mantenimientoLN;
        }*/

        [HttpPost]
        public MantenimientoPolizaClienteRes MantenimientoPolizaCliente(MantenimientoPolizaClienteReq objReq)
        {
            MantenimientoPolizaClienteRes oRes = new MantenimientoPolizaClienteRes();
            MantenimientosAD _mantenimientoAD = new MantenimientosAD();
            MantenimientosLN _mantenimientoLN = new MantenimientosLN(_mantenimientoAD);
            oRes = _mantenimientoLN.MantenimientoPolizaCliente(objReq);
            return oRes;
        }

        [HttpPost]
        public MantenimientoPolizaRes MantenimientoPoliza(MantenimientoPolizaReq objReq)
        {
            MantenimientosAD _mantenimientoAD = new MantenimientosAD();
            MantenimientosLN _mantenimientoLN = new MantenimientosLN(_mantenimientoAD);
            
            //MantenimientoPolizaReq oReq = new MantenimientoPolizaReq();
            MantenimientoPolizaRes oRes = new MantenimientoPolizaRes();
            
            oRes = _mantenimientoLN.MantenimientoPoliza(objReq);
            return oRes;
        }

    }
}
