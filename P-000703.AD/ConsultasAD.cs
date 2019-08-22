﻿using P_000703.Entidades.Salida;
using P_000703.Entidades.Entrada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;

namespace P_000703.AD
{
    public class ConsultasAD
    {
        public ConsultarPolizaRes ConsultarPoliza(ConsultarPolizaReq objReq)
        {
            ConsultarPolizaRes objResultado = new ConsultarPolizaRes();

            ObjectParameter objEstado = new ObjectParameter("ESTADO", P_000703.Entidades.Constantes.COD_CORRECTO);
            ObjectParameter objMensaje = new ObjectParameter("MENSAJE", string.Empty);

            try
            {
                using (P_000703.MD.SEGUROSEntities objModelo = new P_000703.MD.SEGUROSEntities())
                {
                    objResultado.ListadoPolizas = objModelo.PA_CONS_POL_POLIZA(objEstado,
                                                                                        objMensaje).ToList();

                    //Se valida el resultado
                    if (objResultado?.ListadoPolizas == null || objEstado.Value.ToString().Equals(Entidades.Constantes.COD_ERROR))
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

        public ConsultarPolizaClienteRes ConsultarPolizaCliente(ConsultarPolizaClienteReq objReq)
        {
            ConsultarPolizaClienteRes objResultado = new ConsultarPolizaClienteRes();

            ObjectParameter objEstado = new ObjectParameter("ESTADO", P_000703.Entidades.Constantes.COD_CORRECTO);
            ObjectParameter objMensaje = new ObjectParameter("MENSAJE", string.Empty);

            try
            {
                using (P_000703.MD.SEGUROSEntities objModelo = new P_000703.MD.SEGUROSEntities())
                {
                    objResultado.ListadoPolizas = objModelo.PA_CONS_POL_POLIZA_X_CLIENTE(objReq.Crm_Cliente, objEstado,
                                                                                        objMensaje).ToList();

                    //Se valida el resultado
                    if (objResultado?.ListadoPolizas == null || objEstado.Value.ToString().Equals(Entidades.Constantes.COD_ERROR))
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

        public ConsultarTipoCubrimientoRes ConsultarTipoCubrimiento(ConsultarTipoCubrimientoReq objReq)
        {
            ConsultarTipoCubrimientoRes objResultado = new ConsultarTipoCubrimientoRes();

            ObjectParameter objEstado = new ObjectParameter("ESTADO", P_000703.Entidades.Constantes.COD_CORRECTO);
            ObjectParameter objMensaje = new ObjectParameter("MENSAJE", string.Empty);

            try
            {
                using (P_000703.MD.SEGUROSEntities objModelo = new P_000703.MD.SEGUROSEntities())
                {
                    objResultado.ListadoTipoCubrimiento = objModelo.PA_CONS_POL_TIPO_CUBRIMIENTO(objEstado,
                                                                                        objMensaje).ToList();

                    //Se valida el resultado
                    if (objResultado?.ListadoTipoCubrimiento == null || objEstado.Value.ToString().Equals(Entidades.Constantes.COD_ERROR))
                    {
                        objResultado.Estado = Entidades.Constantes.COD_ERROR;
                        objResultado.Mensaje = objMensaje.Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                objResultado.Estado = Entidades.Constantes.COD_ERROR;
                objResultado.Mensaje =  ((ex.InnerException != null) ? Environment.NewLine + ex.InnerException.Message : string.Empty);
                throw;
            }
            finally
            {
                objEstado = null;
                objMensaje = null;
            }
            return objResultado;
        }

        public ConsultarTipoRiesgoRes ConsultarTipoRiesgo(ConsultarTipoRiesgoReq objReq)
        {
            ConsultarTipoRiesgoRes objResultado = new ConsultarTipoRiesgoRes();

            ObjectParameter objEstado = new ObjectParameter("ESTADO", P_000703.Entidades.Constantes.COD_CORRECTO);
            ObjectParameter objMensaje = new ObjectParameter("MENSAJE", string.Empty);

            try
            {
                using (P_000703.MD.SEGUROSEntities objModelo = new P_000703.MD.SEGUROSEntities())
                {
                    objResultado.ListadoTipoRiesgo = objModelo.PA_CONS_POL_TIPO_RIESGO(objEstado,
                                                                                        objMensaje).ToList();

                    //Se valida el resultado
                    if (objResultado?.ListadoTipoRiesgo == null || objEstado.Value.ToString().Equals(Entidades.Constantes.COD_ERROR))
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
