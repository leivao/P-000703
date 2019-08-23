using P_000703.Entidades.Salida;
using P_000703.Entidades.Entrada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;
using System.Globalization;

namespace P_000703.AD
{
    public class MantenimientosAD : IMantenimientosAD
    {
        public MantenimientoPolizaRes MantenimientoPoliza(MantenimientoPolizaReq objReq)
        {
            MantenimientoPolizaRes objResultado = new MantenimientoPolizaRes();

            ObjectParameter objEstado = new ObjectParameter("ESTADO", P_000703.Entidades.Constantes.COD_CORRECTO);
            ObjectParameter objMensaje = new ObjectParameter("MENSAJE", string.Empty);

            try
            {
                using (P_000703.MD.SEGUROSEntities objModelo = new P_000703.MD.SEGUROSEntities())
                {
                    objModelo.PA_MANT_POL_POLIZA(objReq.TipoOperacion
                      , objReq?.Pol_Poliza == null ? Guid.NewGuid() : new Guid(objReq.Pol_Poliza)
                        , objReq.Nombre
                        , objReq?.TipoCubrimiento == null ? Guid.NewGuid() : new Guid(objReq.TipoCubrimiento)
                        , objReq.Descripcion
                        , DateTime.ParseExact((objReq?.InicioVigencia ?? DateTime.Now.ToString("dd/MM/yyyy")), "dd/MM/yyyy", CultureInfo.InvariantCulture)
                        , objReq.PeriodoCobertura
                        , objReq.Precio
                        , objReq?.Pol_Tipo_Riesgo == null ? Guid.NewGuid() : new Guid(objReq.Pol_Tipo_Riesgo), objEstado, objMensaje);
                    objResultado.Estado = objEstado.Value.ToString();
                    objResultado.Mensaje = objMensaje.Value.ToString();
                    if (objEstado.Value.ToString().Equals(Entidades.Constantes.COD_ERROR))
                    {
                        objResultado.Estado = Entidades.Constantes.COD_ERROR;
                        objResultado.Mensaje = objMensaje.Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                objResultado.Estado = Entidades.Constantes.COD_ERROR;
                objResultado.Mensaje = ((ex.InnerException != null) ? Environment.NewLine + ex.InnerException.Message : string.Empty);
                
            }
            finally
            {
                objEstado = null;
                objMensaje = null;
            }
            return objResultado;
        }

        public MantenimientoPolizaClienteRes MantenimientoPolizaCliente(MantenimientoPolizaClienteReq objReq)
        {
            MantenimientoPolizaClienteRes objResultado = new MantenimientoPolizaClienteRes();

            ObjectParameter objEstado = new ObjectParameter("ESTADO", P_000703.Entidades.Constantes.COD_CORRECTO);
            ObjectParameter objMensaje = new ObjectParameter("MENSAJE", string.Empty);

            try
            {
                using (P_000703.MD.SEGUROSEntities objModelo = new P_000703.MD.SEGUROSEntities())
                {
                    objModelo.PA_MANT_POL_POLIZA_X_CLIENTE(objReq.TipoOperacion
                        , new Guid(objReq.Pol_Poliza ?? Guid.Empty.ToString())
                        , new Guid(objReq.Crm_Cliente ?? Guid.Empty.ToString())
                        , objReq.Nombre_Cliente ?? String.Empty
                        , objReq.Correo_Cliente ?? String.Empty
                        , new Guid(objReq?.RegistradoPor ?? Guid.Empty.ToString())
                        , DateTime.Now, objEstado, objMensaje);

                    if (objEstado.Value.ToString().Equals(Entidades.Constantes.COD_ERROR))
                    {
                        objResultado.Estado = Entidades.Constantes.COD_ERROR;
                        objResultado.Mensaje = objMensaje.Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                objResultado.Estado = Entidades.Constantes.COD_ERROR;
                objResultado.Mensaje = ((ex.InnerException != null) ? Environment.NewLine + ex.InnerException.Message : string.Empty);
                throw;
            }
            finally
            {
                objEstado = null;
                objMensaje = null;
            }
            return objResultado;
        }
    }
}
