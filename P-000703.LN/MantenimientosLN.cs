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
    public class MantenimientosLN : IMantenimientosLN
    {
        IMantenimientosAD _mantenimientosAD;
        public MantenimientosLN()
        {

        }
        public MantenimientosLN(IMantenimientosAD mantenimientosAD)
        {
            this._mantenimientosAD = mantenimientosAD;
        }
        public MantenimientoPolizaClienteRes MantenimientoPolizaCliente(MantenimientoPolizaClienteReq objReq)
        {
           
            MantenimientoPolizaClienteRes objResultado = new MantenimientoPolizaClienteRes();

            try
            {
                objResultado = _mantenimientosAD.MantenimientoPolizaCliente(objReq);

            }
            catch (Exception ex)
            {
                objResultado.Estado = Entidades.Constantes.COD_ERROR;
                objResultado.Mensaje = ((ex.InnerException != null) ? Environment.NewLine + ex.InnerException.Message : string.Empty);
                throw;
            }
            finally
            {
                _mantenimientosAD = null;
            }
            return objResultado;
        }
        public MantenimientoPolizaRes MantenimientoPoliza(MantenimientoPolizaReq objReq)
        {
           
            MantenimientoPolizaRes objResultado = new MantenimientoPolizaRes();

            try
            {
                objResultado = _mantenimientosAD.MantenimientoPoliza(objReq);

            }
            catch (Exception ex)
            {
                objResultado.Estado = Entidades.Constantes.COD_ERROR;
                objResultado.Mensaje = ((ex.InnerException != null) ? Environment.NewLine + ex.InnerException.Message : string.Empty);
                throw;
            }
            finally
            {
                _mantenimientosAD = null;
            }
            return objResultado;
        }
    }
}
