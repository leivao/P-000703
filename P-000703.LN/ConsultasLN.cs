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
    public class ConsultasLN : IConsultasLN
    {
        public ConsultarClientesRes ConsultarClientes(ConsultarClientesReq objReq)
        {
            ConsultasAD consultasAD = new ConsultasAD();
            ConsultarClientesRes objResultado = new ConsultarClientesRes();

            try
            {
                objResultado = consultasAD.ConsultarClientes(objReq);

            }
            catch (Exception ex)
            {
                objResultado.Estado = Entidades.Constantes.COD_ERROR;
                objResultado.Mensaje = ((ex.InnerException != null) ? Environment.NewLine + ex.InnerException.Message : string.Empty);
                throw;
            }
            finally
            {
                consultasAD = null;
            }
            return objResultado;
        }
        public ConsultarPolizaRes ConsultarPoliza(ConsultarPolizaReq objReq)
        {
            ConsultasAD consultasAD = new ConsultasAD();
            ConsultarPolizaRes objResultado = new ConsultarPolizaRes();

            try
            {
                objResultado = consultasAD.ConsultarPoliza(objReq);

            }
            catch (Exception ex)
            {
                objResultado.Estado = Entidades.Constantes.COD_ERROR;
                objResultado.Mensaje = ((ex.InnerException != null) ? Environment.NewLine + ex.InnerException.Message : string.Empty);
                throw;
            }
            finally
            {
                consultasAD = null;
            }
            return objResultado;
        }

        public ConsultarPolizaxIDRes ConsultarPolizaxID(ConsultarPolizaxIDReq objReq)
        {
            ConsultasAD consultasAD = new ConsultasAD();
            ConsultarPolizaxIDRes objResultado = new ConsultarPolizaxIDRes();

            try
            {
                objResultado = consultasAD.ConsultarPolizaxID(objReq);

            }
            catch (Exception ex)
            {
                objResultado.Estado = Entidades.Constantes.COD_ERROR;
                objResultado.Mensaje = ((ex.InnerException != null) ? Environment.NewLine + ex.InnerException.Message : string.Empty);
                throw;
            }
            finally
            {
                consultasAD = null;
            }
            return objResultado;
        }

        public ConsultarPolizaClienteRes ConsultarPolizaCliente(ConsultarPolizaClienteReq objReq)
        {
            ConsultasAD consultasAD = new ConsultasAD();
            ConsultarPolizaClienteRes objResultado = new ConsultarPolizaClienteRes();

            try
            {
                objResultado = consultasAD.ConsultarPolizaCliente(objReq);

            }
            catch (Exception ex)
            {
                objResultado.Estado = Entidades.Constantes.COD_ERROR;
                objResultado.Mensaje = ((ex.InnerException != null) ? Environment.NewLine + ex.InnerException.Message : string.Empty);
                throw;
            }
            finally
            {

                consultasAD = null;
            }


            return objResultado;
        }

        public ConsultarPolizaClientexIDRes ConsultarPolizaClientexID(ConsultarPolizaClientexIDReq objReq)
        {
            ConsultasAD consultasAD = new ConsultasAD();
            ConsultarPolizaClientexIDRes objResultado = new ConsultarPolizaClientexIDRes();

            try
            {
                objResultado = consultasAD.ConsultarPolizaClientexID(objReq);

            }
            catch (Exception ex)
            {
                objResultado.Estado = Entidades.Constantes.COD_ERROR;
                objResultado.Mensaje = ((ex.InnerException != null) ? Environment.NewLine + ex.InnerException.Message : string.Empty);
                throw;
            }
            finally
            {

                consultasAD = null;
            }


            return objResultado;
        }

        public ConsultarTipoCubrimientoRes ConsultarTipoCubrimiento(ConsultarTipoCubrimientoReq objReq)
        {
            ConsultasAD consultasAD = new ConsultasAD();
            ConsultarTipoCubrimientoRes objResultado = new ConsultarTipoCubrimientoRes();

            try
            {
                objResultado = consultasAD.ConsultarTipoCubrimiento(objReq);

            }
            catch (Exception ex)
            {
                objResultado.Estado = Entidades.Constantes.COD_ERROR;
                objResultado.Mensaje = ((ex.InnerException != null) ? Environment.NewLine + ex.InnerException.Message : string.Empty);
                throw;
            }
            finally
            {
                
                consultasAD = null;
            }


            return objResultado;
        }

        public ConsultarTipoRiesgoRes ConsultarTipoRiesgo(ConsultarTipoRiesgoReq objReq)
        {
            ConsultasAD consultasAD = new ConsultasAD();
            ConsultarTipoRiesgoRes objResultado = new ConsultarTipoRiesgoRes();

            try
            {
                objResultado = consultasAD.ConsultarTipoRiesgo(objReq);

            }
            catch (Exception ex)
            {
                objResultado.Estado = Entidades.Constantes.COD_ERROR;
                objResultado.Mensaje = ((ex.InnerException != null) ? Environment.NewLine + ex.InnerException.Message : string.Empty);
                throw;
            }
            finally
            {
                // liberamos la memoria
                consultasAD = null;
            }


            return objResultado;
        }
    }
}
