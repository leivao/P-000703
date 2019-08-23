using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace P_000703.Web.Tests.Integracion
{
   
    [TestClass]
    public class IntegracionWebApiTest
    {
        string _URL_API = ConfigurationManager.AppSettings["url_sitio"];
        [TestMethod, TestCategory("Integración")]
        public void ConsultaTiposCubrimiento()
        {

        }
    }
}
