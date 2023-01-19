using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_SolicitudesCreditos
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioSolicitud" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioSolicitud
    {
        [OperationContract]
        List<SolicitudBE> GetAllSolicitud();

        [OperationContract]
        List<SolicitudBE> GetAllSolicitudXAnalista(String Id_analista);


        [OperationContract]
        List<SolicitudBE> GetAllSolicitudXCliente(String Id_cli);


        [OperationContract]
        List<SolicitudBE> GetSolicitudXFechaXAnalista(String strCodigo, DateTime Fecini, DateTime Fecfin);

        [OperationContract]
        List<SolicitudBE> GetSolicitudXEstado(Int16 Estado);

        [OperationContract]
        List<SolicitudBE> GetSolicitudXEstadoxAnalista(Int16 Estado, String codAnalista);

        [OperationContract]
        List<SolicitudBE> GetPagoxSolicitud(String Id_solicitud);

        [OperationContract]
        List<SolicitudBE> GetSolicitudXFechaXEstado(Int16 Estado, DateTime Fecini, DateTime Fecfin);
    }

    [DataContract]
    [Serializable]

    public class SolicitudBE
    {
        private String mvarid_solicitud;
        private String mvarnom_analista;
        private String mvarape_analista;
        private String mvarnom_cli;
        private String mvarape_cli;
        private String mvarproducto;

        private String mvarid_cli;
        private String mvarid_analista;
        private String mvartipo_producto;
        private DateTime mvarfec_solicitud;
        private Decimal mvarmonto_solici;
        private String mvarnum_cuenta;
        private String mvarest_solicitud;
        private DateTime mvarfec_aprobacion;
        private DateTime mvarfec_rechazo;
        private String mvarmotivo_rechazo;
        private String mvarest_desembolso;
        private DateTime mvarfec_desembolso;
        private DateTime mvarfec_pago;
        private DateTime mvarfec_reg;
        private String mvarusu_registro;
        private DateTime mvarfec_ult_mod;
        private String mvarusu_ult_mod;
        private Int16 mvarcuotas;

        private String mvarid_agencia;
        private String mvarnom_agencia;

        private String mvaragen_direccion;
        private String mvardepartamento;
        private String mvardistrito;
        private String mvarestado;
        private String mvarprovincia;

        private String _Boleta;
        private Single _MontCancelado;
        private Int16 _CuotaNro;
        private Int16 _Retraso;

        // Probando
        private String _PruebaFecha;
        private String _AprobacionFecha;
        private String _DesembolsoFecha;

        [DataMember]
        public String PruebaFecha
        {
            get { return _PruebaFecha; }
            set { _PruebaFecha = value; }
        }

        [DataMember]
        public String AprobacionFecha
        {
            get { return _AprobacionFecha; }
            set { _AprobacionFecha = value; }
        }

        [DataMember]
        public String RechazoFecha
        {
            get { return _DesembolsoFecha; }
            set { _DesembolsoFecha = value; }
        }
        // Fin probando

        [DataMember]
        public String Boleta
        {
            get { return _Boleta; }
            set { _Boleta = value; }
        }

        [DataMember]
        public Single MontCancelado
        {
            get { return _MontCancelado; }
            set { _MontCancelado = value; }
        }

        [DataMember]
        public Int16 CuotaNro
        {
            get { return _CuotaNro; }
            set { _CuotaNro = value; }
        }

        [DataMember]
        public Int16 Retraso
        {
            get { return _Retraso; }
            set { _Retraso = value; }
        }

        [DataMember]
        public String Agen_direccion
        {
            get { return mvaragen_direccion; }
            set { mvaragen_direccion = value; }
        }
        [DataMember]
        public String Departamento
        {
            get { return mvardepartamento; }
            set { mvardepartamento = value; }
        }
        [DataMember]
        public String Distrito
        {
            get { return mvardistrito; }
            set { mvardistrito = value; }
        }
        [DataMember]
        public String Estado
        {
            get { return mvarestado; }
            set { mvarestado = value; }
        }
        [DataMember]
        public String Provincia
        {
            get { return mvarprovincia; }
            set { mvarprovincia = value; }
        }

        [DataMember]
        public String ld_solicitud
        {
            get { return mvarid_solicitud; }
            set { mvarid_solicitud = value; }
        }

        [DataMember]
        public String Id_cli
        {
            get { return mvarid_cli; }
            set { mvarid_cli = value; }
        }
        [DataMember]
        public String Nom_analista
        {
            get { return mvarnom_analista; }
            set { mvarnom_analista = value; }
        }
        [DataMember]
        public String Ape_analista
        {
            get { return mvarape_analista; }
            set { mvarape_analista = value; }
        }
        [DataMember]
        public String Nom_cli
        {
            get { return mvarnom_cli; }
            set { mvarnom_cli = value; }
        }
        [DataMember]
        public String Ape_cli
        {
            get { return mvarape_cli; }
            set { mvarape_cli = value; }
        }
        [DataMember]
        public String PRODUCTO
        {
            get { return mvarproducto; }
            set { mvarproducto = value; }
        }
        [DataMember]
        public String Id_analista
        {
            get { return mvarid_analista; }
            set { mvarid_analista = value; }
        }
        [DataMember]
        public String Tipo_producto
        {
            get { return mvartipo_producto; }
            set { mvartipo_producto = value; }
        }
        [DataMember]
        public DateTime Fec_solicitud
        {
            get { return mvarfec_solicitud; }
            set { mvarfec_solicitud = value; }
        }
        [DataMember]
        public Decimal Monto_solici
        {
            get { return mvarmonto_solici; }
            set { mvarmonto_solici = value; }
        }
        [DataMember]
        public String Num_cuenta
        {
            get { return mvarnum_cuenta; }
            set { mvarnum_cuenta = value; }
        }
        [DataMember]
        public String Est_solicitud
        {
            get { return mvarest_solicitud; }
            set { mvarest_solicitud = value; }
        }
        [DataMember]
        public DateTime Fec_aprobacion
        {
            get { return mvarfec_aprobacion; }
            set { mvarfec_aprobacion = value; }
        }
        [DataMember]
        public DateTime Fec_rechazo
        {
            get { return mvarfec_rechazo; }
            set { mvarfec_rechazo = value; }
        }
        [DataMember]
        public String Motivo_rechazo
        {
            get { return mvarmotivo_rechazo; }
            set { mvarmotivo_rechazo = value; }
        }
        [DataMember]
        public String Est_desembolso
        {
            get { return mvarest_desembolso; }
            set { mvarest_desembolso = value; }
        }
        [DataMember]
        public DateTime Fec_desembolso
        {
            get { return mvarfec_desembolso; }
            set { mvarfec_desembolso = value; }
        }
        [DataMember]
        public DateTime Fec_pago
        {
            get { return mvarfec_pago; }
            set { mvarfec_pago = value; }
        }
        [DataMember]
        public DateTime Fec_reg
        {
            get { return mvarfec_reg; }
            set { mvarfec_reg = value; }
        }
        [DataMember]
        public String Usu_registro
        {
            get { return mvarusu_registro; }
            set { mvarusu_registro = value; }
        }
        [DataMember]
        public DateTime Fec_ult_mod
        {
            get { return mvarfec_ult_mod; }
            set { mvarfec_ult_mod = value; }
        }
        [DataMember]
        public String Usu_ult_mod
        {
            get { return mvarusu_ult_mod; }
            set { mvarusu_ult_mod = value; }
        }
        [DataMember]
        public Int16 Cuotas
        {
            get { return mvarcuotas; }
            set { mvarcuotas = value; }
        }
        [DataMember]
        public String Id_agencia
        {
            get { return mvarid_agencia; }
            set { mvarid_agencia = value; }
        }
        public String Nom_agencia
        {
            get { return mvarnom_agencia; }
            set { mvarnom_agencia = value; }
        }
    }

}
