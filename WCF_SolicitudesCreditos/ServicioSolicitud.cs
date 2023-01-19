using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
//Agregar...
using System.Data.Entity.Core;

namespace WCF_SolicitudesCreditos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioSolicitud" en el código y en el archivo de configuración a la vez.
    public class ServicioSolicitud : IServicioSolicitud
    {
        public List<SolicitudBE> GetAllSolicitudXAnalista(String Id_analista)
        {
            // Instanciando el modelo...
            CreditosEntities MisCr = new CreditosEntities();
            List<SolicitudBE> objListaSolicitudBE = new List<SolicitudBE>();
            try
            {
                var query = MisCr.usp_ListarSolicitudXAna(Id_analista);
                foreach (var resultado in query)
                {
                    SolicitudBE objSolicitudBE = new SolicitudBE();
                    objSolicitudBE.ld_solicitud = resultado.Id_solicitud;
                    objSolicitudBE.Id_cli = resultado.Id_cli;
                    objSolicitudBE.Ape_cli = resultado.Ape_cli;
                    objSolicitudBE.Nom_cli = resultado.Nom_cli;
                    objSolicitudBE.PRODUCTO = resultado.PRODUCTO;
                    objSolicitudBE.Fec_solicitud = resultado.Fec_solicitud;
                    objSolicitudBE.Monto_solici = Convert.ToDecimal(resultado.Monto_solici);
                    objSolicitudBE.Estado = resultado.Estado;
                    objSolicitudBE.Fec_aprobacion = Convert.ToDateTime(resultado.Fec_aprobacion);
                    objSolicitudBE.Fec_rechazo = Convert.ToDateTime(resultado.Fec_rechazo);
                    objSolicitudBE.Motivo_rechazo = resultado.Motivo_rechazo;
                    objSolicitudBE.Est_desembolso = resultado.Estado_desembolso;
                    objSolicitudBE.Fec_desembolso = Convert.ToDateTime(resultado.Fec_desembolso);
                    objSolicitudBE.Cuotas = Convert.ToInt16(resultado.Cuotas);

                    objListaSolicitudBE.Add(objSolicitudBE);
                }


                return objListaSolicitudBE;
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<SolicitudBE> GetAllSolicitudXCliente(String Id_analista)
        {
            // Instanciando el modelo...
            CreditosEntities MisCr = new CreditosEntities();
            List<SolicitudBE> objListaSolicitudBE = new List<SolicitudBE>();
            try
            {
                var query = MisCr.usp_ListarSolicitudXcliente(Id_analista);
                foreach (var resultado in query)
                {
                    SolicitudBE objSolicitudBE = new SolicitudBE();
                    objSolicitudBE.ld_solicitud = resultado.Id_solicitud;
                    objSolicitudBE.Id_cli = resultado.Id_cli;
                    objSolicitudBE.Nom_cli = resultado.Nombre_cliente;
                    objSolicitudBE.Nom_analista = resultado.Nombre_analista;
                    //objSolicitudBE.Ape_analista =resultado.nom;

                    //objSolicitudBE.Ape_cli = resultado.Dni_cli;
                    objSolicitudBE.PRODUCTO = resultado.PRODUCTO;
                    objSolicitudBE.Estado = resultado.Estado;
                    objSolicitudBE.Est_desembolso = resultado.Estado_desembolso;

                    objSolicitudBE.Tipo_producto = Convert.ToString(resultado.Tipo_producto);
                    objSolicitudBE.Monto_solici = Convert.ToDecimal(resultado.Monto_solici);
                    objSolicitudBE.Motivo_rechazo = resultado.Motivo_rechazo;
                    objSolicitudBE.Cuotas = Convert.ToInt16(resultado.Cuotas);
                    objSolicitudBE.Fec_solicitud = Convert.ToDateTime(resultado.Fec_solicitud);
                    objSolicitudBE.Fec_aprobacion = Convert.ToDateTime(resultado.Fec_aprobacion);
                    objSolicitudBE.Fec_rechazo = Convert.ToDateTime(resultado.Fec_rechazo);

                    //Probando
                    if (resultado.Motivo_rechazo == null)
                    {
                        objSolicitudBE.Motivo_rechazo = "-";
                    }
                    else
                    {
                        objSolicitudBE.Motivo_rechazo = resultado.Motivo_rechazo;
                    }

                    if (resultado.Fec_rechazo == null)
                    {
                        objSolicitudBE.PruebaFecha = "-";
                    }
                    else
                    {
                        objSolicitudBE.PruebaFecha = Convert.ToDateTime(resultado.Fec_rechazo).ToString("dd/MM/yyyy");
                    }

                    if (resultado.Fec_aprobacion == null)
                    {
                        objSolicitudBE.AprobacionFecha = "-";
                    }
                    else
                    {
                        objSolicitudBE.AprobacionFecha = Convert.ToDateTime(resultado.Fec_aprobacion).ToString("dd/MM/yyyy");
                    }

                    if (resultado.Fec_desembolso == null)
                    {
                        objSolicitudBE.RechazoFecha = "-";
                    }
                    else
                    {
                        objSolicitudBE.RechazoFecha = Convert.ToDateTime(resultado.Fec_desembolso).ToString("dd/MM/yyyy");
                    }

                    objListaSolicitudBE.Add(objSolicitudBE);
                }


                return objListaSolicitudBE;
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<SolicitudBE> GetSolicitudXFechaXAnalista(String strCodigo, DateTime Fecini, DateTime Fecfin)
        {
            
            CreditosEntities MisCr = new CreditosEntities();
            List<SolicitudBE> objListaSolicitudBE = new List<SolicitudBE>();

            try
            {
                // Empleamos LINQ...
                var query = (from oSolicitud in MisCr.vw_Detalle_Solicitud
                             where oSolicitud.Id_analista == strCodigo && oSolicitud.Fec_solicitud >= Fecini && oSolicitud.Fec_solicitud <= Fecfin
                             select oSolicitud
                             );

                // Recorremos el resultado...
                foreach (var resultado in query)
                {
                    SolicitudBE objSolicitudBE = new SolicitudBE();
                    objSolicitudBE.ld_solicitud = resultado.Id_solicitud;
                    objSolicitudBE.Id_cli = resultado.Id_cli;
                    objSolicitudBE.Nom_cli = resultado.Nom_cli;
                    objSolicitudBE.Ape_cli = resultado.Ape_cli;
                    objSolicitudBE.PRODUCTO = resultado.PRODUCTO;
                    //objSolicitudBE.Motivo_rechazo = resultado.Motivo_rechazo;
                    objSolicitudBE.Est_desembolso = resultado.Estado_desembolso;

                    objSolicitudBE.Fec_solicitud = Convert.ToDateTime(resultado.Fec_solicitud);
                    objSolicitudBE.Fec_rechazo = Convert.ToDateTime(resultado.Fec_rechazo);
                    objSolicitudBE.Fec_aprobacion = Convert.ToDateTime(resultado.Fec_aprobacion);
                    objSolicitudBE.Fec_desembolso = Convert.ToDateTime(resultado.Fec_desembolso);
                    objSolicitudBE.Est_solicitud = resultado.Estado;
                    objSolicitudBE.Id_analista = resultado.Id_analista;
                    objSolicitudBE.Nom_analista = resultado.Nombre_analista;
                    objSolicitudBE.Monto_solici = Convert.ToDecimal(resultado.Monto_solici);
                    objSolicitudBE.Cuotas = Convert.ToInt16(resultado.Cuotas);

                    //Probando
                    if(resultado.Motivo_rechazo == null)
                    {
                        objSolicitudBE.Motivo_rechazo = "-";
                    }
                    else
                    {
                        objSolicitudBE.Motivo_rechazo = resultado.Motivo_rechazo;
                    }

                    if (resultado.Fec_rechazo == null)
                    {
                        objSolicitudBE.PruebaFecha = "-";
                    }
                    else
                    {
                        objSolicitudBE.PruebaFecha = Convert.ToDateTime(resultado.Fec_rechazo).ToString("dd/MM/yyyy");
                    }

                    if(resultado.Fec_aprobacion == null)
                    {
                        objSolicitudBE.AprobacionFecha = "-";
                    }
                    else
                    {
                        objSolicitudBE.AprobacionFecha = Convert.ToDateTime(resultado.Fec_aprobacion).ToString("dd/MM/yyyy");
                    }

                    if(resultado.Fec_desembolso == null)
                    {
                        objSolicitudBE.RechazoFecha = "-";
                    }
                    else
                    {
                        objSolicitudBE.RechazoFecha = Convert.ToDateTime(resultado.Fec_desembolso).ToString("dd/MM/yyyy");
                    }


                    // Agrego la instancia a la lista
                    objListaSolicitudBE.Add(objSolicitudBE);
                }

                // Terminado el bucle, devolvemos la lista
                return objListaSolicitudBE;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<SolicitudBE> GetSolicitudXEstado(Int16 Estado)
        {
            CreditosEntities MisCre = new CreditosEntities();
            List<SolicitudBE> objListaSolicitudBE = new List<SolicitudBE>();

            try
            {

                var query = MisCre.usp_ListarSolicitudEstado(Estado);
                foreach (var resultado in query)
                {
                    SolicitudBE objSolicitudBE = new SolicitudBE();
                    objSolicitudBE.ld_solicitud = resultado.Id_solicitud;
                    objSolicitudBE.Id_cli = resultado.Id_cli;
                    objSolicitudBE.Nom_cli = resultado.Nom_cli;
                    objSolicitudBE.Ape_cli = resultado.Ape_cli;
                    objSolicitudBE.Id_analista = resultado.Id_analista;
                    objSolicitudBE.Nom_analista = resultado.Nombre_analista;
                    objSolicitudBE.PRODUCTO = resultado.PRODUCTO;
                    objSolicitudBE.Fec_solicitud = resultado.Fec_solicitud;
                    objSolicitudBE.Monto_solici = Convert.ToDecimal(resultado.Monto_solici);
                    objSolicitudBE.Estado = resultado.Estado;
                    objSolicitudBE.Fec_aprobacion = Convert.ToDateTime(resultado.Fec_aprobacion);
                    objSolicitudBE.Fec_rechazo = Convert.ToDateTime(resultado.Fec_rechazo);
                    objSolicitudBE.Motivo_rechazo = resultado.Motivo_rechazo;
                    objSolicitudBE.Est_desembolso = resultado.Estado_desembolso;
                    objSolicitudBE.Fec_desembolso = Convert.ToDateTime(resultado.Fec_desembolso);
                    objSolicitudBE.Cuotas = Convert.ToInt16(resultado.Cuotas);

                    objListaSolicitudBE.Add(objSolicitudBE);
                }

                return objListaSolicitudBE;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<SolicitudBE> GetPagoxSolicitud(String Id_solicitud)
        {
            CreditosEntities MisCre = new CreditosEntities();
            List<SolicitudBE> objListaSolicitudBE = new List<SolicitudBE>();

            try
            {

                var query = MisCre.usp_ListarPagoSolicitud(Id_solicitud);
                foreach (var resultado in query)
                {
                    SolicitudBE objSolicitudBE = new SolicitudBE();
                    objSolicitudBE.Boleta = resultado.Boleta;
                    objSolicitudBE.ld_solicitud = resultado.Id_solicitud;
                    objSolicitudBE.Id_cli = resultado.Id_cli;
                    objSolicitudBE.Nom_cli = resultado.Nombre_Completo;
                    objSolicitudBE.MontCancelado = Convert.ToSingle(resultado.Monto_cancelado);
                    objSolicitudBE.CuotaNro = Convert.ToInt16(resultado.Cuota_numero);
                    objSolicitudBE.Cuotas = Convert.ToInt16(resultado.Cuotas);
                    objSolicitudBE.Fec_pago = Convert.ToDateTime(resultado.Fec_pago);
                    objSolicitudBE.Fec_rechazo = Convert.ToDateTime(resultado.Fec_cancelacion);
                    objSolicitudBE.Retraso = Convert.ToInt16(resultado.RetrasoPago);

                    objListaSolicitudBE.Add(objSolicitudBE);
                }

                return objListaSolicitudBE;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<SolicitudBE> GetAllSolicitud()
        {
            CreditosEntities MisCr = new CreditosEntities();
            List<SolicitudBE> objListaSolicitudBE = new List<SolicitudBE>();

            try
            {
                // Empleamos LINQ...
                var query = (from oSolicitud in MisCr.vw_Detalle_Solicitud
                             select oSolicitud
                             );

                // Recorremos el resultado...
                foreach (var resultado in query)
                {
                    SolicitudBE objSolicitudBE = new SolicitudBE();
                    objSolicitudBE.ld_solicitud = resultado.Id_solicitud;
                    objSolicitudBE.Id_cli = resultado.Id_cli;
                    objSolicitudBE.Nom_cli = resultado.Nom_cli;
                    objSolicitudBE.Ape_cli = resultado.Ape_cli;
                    objSolicitudBE.PRODUCTO = resultado.PRODUCTO;
                    objSolicitudBE.Motivo_rechazo = resultado.Motivo_rechazo;
                    objSolicitudBE.Est_desembolso = resultado.Estado_desembolso;
                    objSolicitudBE.Num_cuenta = resultado.Num_cuenta;
                    objSolicitudBE.Cuotas = Convert.ToInt16(resultado.Cuotas);
                    objSolicitudBE.Estado = resultado.Estado;
                    objSolicitudBE.Fec_solicitud = Convert.ToDateTime(resultado.Fec_solicitud);
                    objSolicitudBE.Fec_rechazo = Convert.ToDateTime(resultado.Fec_rechazo);
                    objSolicitudBE.Est_solicitud = resultado.Estado;
                    objSolicitudBE.Id_analista = resultado.Id_analista;
                    objSolicitudBE.Nom_analista = resultado.Nombre_analista;
                    objSolicitudBE.Monto_solici = Convert.ToDecimal(resultado.Monto_solici);


                    // Agrego la instancia a la lista
                    objListaSolicitudBE.Add(objSolicitudBE);
                }

                // Terminado el bucle, devolvemos la lista
                return objListaSolicitudBE;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<SolicitudBE> GetSolicitudXEstadoxAnalista(Int16 Estado, String codAnalista)
        {
            CreditosEntities MisCr = new CreditosEntities();
            List<SolicitudBE> objListaSolicitudBE = new List<SolicitudBE>();

            try
            {
                // Empleamos LINQ...
                var query = (from oSolicitud in MisCr.vw_Detalle_Solicitud
                             where oSolicitud.Id_analista == codAnalista && oSolicitud.Est_solicitud == Estado
                             select oSolicitud
                             );

                // Recorremos el resultado...
                foreach (var resultado in query)
                {
                    SolicitudBE objSolicitudBE = new SolicitudBE();
                    objSolicitudBE.ld_solicitud = resultado.Id_solicitud;
                    objSolicitudBE.Id_cli = resultado.Id_cli;
                    objSolicitudBE.Nom_cli = resultado.Nom_cli;
                    objSolicitudBE.Ape_cli = resultado.Ape_cli;
                    objSolicitudBE.Id_analista = resultado.Id_analista;
                    objSolicitudBE.Nom_analista = resultado.Nombre_analista;
                    objSolicitudBE.PRODUCTO = resultado.PRODUCTO;
                    objSolicitudBE.Fec_solicitud = resultado.Fec_solicitud;
                    objSolicitudBE.Monto_solici = Convert.ToDecimal(resultado.Monto_solici);
                    objSolicitudBE.Estado = resultado.Estado;
                    objSolicitudBE.Fec_aprobacion = Convert.ToDateTime(resultado.Fec_aprobacion);
                    objSolicitudBE.Fec_rechazo = Convert.ToDateTime(resultado.Fec_rechazo);
                    objSolicitudBE.Motivo_rechazo = resultado.Motivo_rechazo;
                    objSolicitudBE.Est_desembolso = resultado.Estado_desembolso;
                    objSolicitudBE.Fec_desembolso = Convert.ToDateTime(resultado.Fec_desembolso);
                    objSolicitudBE.Cuotas = Convert.ToInt16(resultado.Cuotas);


                    // Agrego la instancia a la lista
                    objListaSolicitudBE.Add(objSolicitudBE);
                }

                // Terminado el bucle, devolvemos la lista
                return objListaSolicitudBE;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<SolicitudBE> GetSolicitudXFechaXEstado(Int16 Estado, DateTime Fecini, DateTime Fecfin)
        {
            CreditosEntities MisCr = new CreditosEntities();
            List<SolicitudBE> objListaSolicitudBE = new List<SolicitudBE>();

            try
            {
                // Empleamos LINQ...
                var query = (from oSolicitud in MisCr.vw_Detalle_Solicitud
                             where oSolicitud.Est_solicitud == Estado && oSolicitud.Fec_solicitud >= Fecini && oSolicitud.Fec_solicitud <= Fecfin
                             select oSolicitud
                             );

                // Recorremos el resultado...
                foreach (var resultado in query)
                {
                    SolicitudBE objSolicitudBE = new SolicitudBE();
                    objSolicitudBE.ld_solicitud = resultado.Id_solicitud;
                    objSolicitudBE.Id_cli = resultado.Id_cli;
                    objSolicitudBE.Nom_cli = resultado.Nom_cli;
                    objSolicitudBE.Ape_cli = resultado.Ape_cli;
                    objSolicitudBE.PRODUCTO = resultado.PRODUCTO;
                    //objSolicitudBE.Motivo_rechazo = resultado.Motivo_rechazo;
                    objSolicitudBE.Est_desembolso = resultado.Estado_desembolso;
                    objSolicitudBE.Cuotas = Convert.ToInt16(resultado.Cuotas);

                    objSolicitudBE.Fec_solicitud = Convert.ToDateTime(resultado.Fec_solicitud);
                    objSolicitudBE.Fec_rechazo = Convert.ToDateTime(resultado.Fec_rechazo);
                    objSolicitudBE.Est_solicitud = resultado.Estado;
                    objSolicitudBE.Id_analista = resultado.Id_analista;
                    objSolicitudBE.Nom_analista = resultado.Nombre_analista;
                    objSolicitudBE.Monto_solici = Convert.ToDecimal(resultado.Monto_solici);

                    //Probando
                    if (resultado.Motivo_rechazo == null)
                    {
                        objSolicitudBE.Motivo_rechazo = "-";
                    }
                    else
                    {
                        objSolicitudBE.Motivo_rechazo = resultado.Motivo_rechazo;
                    }

                    if (resultado.Fec_rechazo == null)
                    {
                        objSolicitudBE.PruebaFecha = "-";
                    }
                    else
                    {
                        objSolicitudBE.PruebaFecha = Convert.ToDateTime(resultado.Fec_rechazo).ToString("dd/MM/yyyy");
                    }

                    if (resultado.Fec_aprobacion == null)
                    {
                        objSolicitudBE.AprobacionFecha = "-";
                    }
                    else
                    {
                        objSolicitudBE.AprobacionFecha = Convert.ToDateTime(resultado.Fec_aprobacion).ToString("dd/MM/yyyy");
                    }

                    if (resultado.Fec_desembolso == null)
                    {
                        objSolicitudBE.RechazoFecha = "-";
                    }
                    else
                    {
                        objSolicitudBE.RechazoFecha = Convert.ToDateTime(resultado.Fec_desembolso).ToString("dd/MM/yyyy");
                    }


                    // Agrego la instancia a la lista
                    objListaSolicitudBE.Add(objSolicitudBE);
                }

                // Terminado el bucle, devolvemos la lista
                return objListaSolicitudBE;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
