using System;
using System.Configuration;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using P_000703.Entidades;
using P_000703.Entidades.Entrada;
using P_000703.Entidades.Salida;
using P_000703.Web.Controllers;

namespace P_000703.Web.Tests.Controllers
{
    [TestClass]
    public class PolizaMantenimientoControllerTest
    {
        
        [TestMethod]
        public void IngresarPolizaCasoRiesgoBajo()
        {
            PolizaMantenimientoController polizaMantenimientoController = new PolizaMantenimientoController();
            MantenimientoPolizaReq objReq = new MantenimientoPolizaReq();
            //var objRes = new MantenimientoPolizaRes();
            MantenimientoPolizaRes objRes = new MantenimientoPolizaRes();
            objReq.TipoOperacion = (int)Constantes.TIPO_OPERACION.INSERTAR;
            //Cubrimiento 40%, riesgo bajo
            objReq.Pol_Poliza = Guid.NewGuid().ToString();
            objReq.Nombre = "POLIZA 001";
            objReq.TipoCubrimiento = ConfigurationManager.AppSettings["cubrimiento_mas_50"];
            objReq.Descripcion = "Descripción";
            objReq.InicioVigencia = DateTime.Now.ToString("dd/MM/yyyy");
            objReq.PeriodoCobertura = 12;
            objReq.Precio = 2100;
            //Riesgo bajo
            objReq.Pol_Tipo_Riesgo = ConfigurationManager.AppSettings["riesgo_bajo"];
            var objRes1 = polizaMantenimientoController.MantenimientoPoliza(objReq);
            Assert.AreEqual(String.Empty, objRes1);
        }

        [TestMethod]
        public void IngresarPolizaCasoRiesgoMedio()
        {
            PolizaMantenimientoController polizaMantenimientoController = new PolizaMantenimientoController();
            MantenimientoPolizaReq objReq = new MantenimientoPolizaReq();
            MantenimientoPolizaRes objRes = new MantenimientoPolizaRes();
            objReq.TipoOperacion = (int)Constantes.TIPO_OPERACION.INSERTAR;
            //Cubrimiento 40%, riesgo bajo
            objReq.Pol_Poliza = Guid.NewGuid().ToString();
            objReq.Nombre = "POLIZA 001";
            objReq.TipoCubrimiento = ConfigurationManager.AppSettings["cubrimiento_mas_50"];
            objReq.Descripcion = "Descripción";
            objReq.InicioVigencia = DateTime.Now.ToString("dd/MM/yyyy");
            objReq.PeriodoCobertura = 12;
            objReq.Precio = 2100;
            //Riesgo bajo
            objReq.Pol_Tipo_Riesgo = ConfigurationManager.AppSettings["riesgo_medio"];
            var objRes1 = polizaMantenimientoController.MantenimientoPoliza(objReq);
            Assert.AreEqual(String.Empty, objRes1);
        }

        [TestMethod]
        public void IngresarPolizaCasoRiesgoAlto()
        {
            PolizaMantenimientoController polizaMantenimientoController = new PolizaMantenimientoController();
            MantenimientoPolizaReq objReq = new MantenimientoPolizaReq();
            MantenimientoPolizaRes objRes = new MantenimientoPolizaRes();
            objReq.TipoOperacion = (int)Constantes.TIPO_OPERACION.INSERTAR;
            //Cubrimiento 40%, riesgo bajo
            objReq.Pol_Poliza = Guid.NewGuid().ToString();
            objReq.Nombre = "POLIZA 001";
            objReq.TipoCubrimiento = ConfigurationManager.AppSettings["cubrimiento_mas_50"];
            objReq.Descripcion = "Descripción";
            objReq.InicioVigencia = DateTime.Now.ToString("dd/MM/yyyy");
            objReq.PeriodoCobertura = 12;
            objReq.Precio = 2100;
            //Riesgo bajo
            objReq.Pol_Tipo_Riesgo = ConfigurationManager.AppSettings["riesgo_alto"];
            var objRes1 = polizaMantenimientoController.MantenimientoPoliza(objReq);
           
            Assert.AreEqual("La cobertura supera el máximo permitido para el tipo de riesgo.", objRes1);
        }
    }
}
