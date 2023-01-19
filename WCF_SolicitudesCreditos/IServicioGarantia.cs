using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_SolicitudesCreditos
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioGarantia" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioGarantia
    {
        [OperationContract]
        Boolean InsertGarantia(GarantiaBE objGarantiaBE);

        [OperationContract]
        Boolean UpdateGarantia(GarantiaBE objGarantiaBE);

        [OperationContract]
        Boolean DeleteGarantia(int Id_garantia);

        [OperationContract]
        GarantiaBE GetGarantiaPorCliente(String Id_cli);

        [OperationContract]
        GarantiaBE GetGarantia(int Id_garantia);

        [OperationContract]
        List<GarantiaBE> GetAllGarantias();
    }

    [DataContract]
    [Serializable]
    public class GarantiaBE
    {
        // Miembros privados
        private int id_garantia;
        private String tip_garantia;
        private String des_garantia;
        private String _nomCliente;
        private String _apeCliente;
        private Single valor_garantia;
        private String id_cli;
        private int est_garantia;
        private String estado;
        private DateTime fec_reg;
        private String usu_registro;
        private DateTime fec_ult_mod;
        private String usu_ult_mod;

        [DataMember]
        public int Id_garantia
        {
            get { return id_garantia; }
            set { id_garantia = value; }
        }

        [DataMember]
        public String Tip_garantia
        {
            get { return tip_garantia; }
            set { tip_garantia = value; }
        }

        [DataMember]
        public String Des_garantia
        {
            get { return des_garantia; }
            set { des_garantia = value; }
        }

        [DataMember]
        public String nomCliente
        {
            get { return _nomCliente; }
            set { _nomCliente = value; }
        }

        [DataMember]
        public String apeCliente
        {
            get { return _apeCliente; }
            set { _apeCliente = value; }
        }

        [DataMember]
        public Single Valor_garantia
        {
            get { return valor_garantia; }
            set { valor_garantia = value; }
        }

        [DataMember]
        public String Id_cli
        {
            get { return id_cli; }
            set { id_cli = value; }
        }

        [DataMember]
        public int Est_garantia
        {
            get { return est_garantia; }
            set { est_garantia = value; }
        }

        [DataMember]
        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        [DataMember]
        public DateTime Fec_reg
        {
            get { return fec_reg; }
            set { fec_reg = value; }
        }

        [DataMember]
        public String Usu_registro
        {
            get { return usu_registro; }
            set { usu_registro = value; }
        }

        [DataMember]
        public DateTime Fec_ult_mod
        {
            get { return fec_ult_mod; }
            set { fec_ult_mod = value; }
        }
        [DataMember]
        public String Usu_ult_mod
        {
            get { return usu_ult_mod; }
            set { usu_ult_mod = value; }
        }
    }

}
