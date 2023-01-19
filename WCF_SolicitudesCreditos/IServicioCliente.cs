using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_SolicitudesCreditos
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioCliente" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioCliente
    {
        [OperationContract]
        Boolean InsertClient(ClienteBE objClienteBE);

        [OperationContract]
        Boolean UpdateClient(ClienteBE objClienteBE);

        [OperationContract]
        Boolean DeleteClient(String Id_cli);

        [OperationContract]
        ClienteBE GetClient(String Id_cli);

        [OperationContract]
        List<ClienteBE> GetAllClientes();
    }

    [DataContract]
    [Serializable]

    public class ClienteBE
    {
        private String mvarId_cli;
        private String mvarNom_cli;
        private String mvarApe_cli;
        private String mvarApellNombre;
        private String mvarDni_cli;
        private String mvarRuc_cli;
        private String mvarSexo;
        private DateTime mvarFec_nacimiento;
        private Int16 mvarEdad;
        private String mvarNivel_Educacion;
        private Int16 mvarEstado_civil;
        private String mvarEstCivil;
        private String mvarEmail;
        private String mvarId_ubigeo;
        private Int16 mvarEst_cli;
        private String mvarEstado;
        private DateTime mvarFec_reg;
        private String mvarUsu_registro;
        private DateTime mvarFec_ult_mod;
        private String mvarUsu_ult_mod;

        // Pruebas

        private String _Departamento;
        private String _Provincia;
        private String _Distrito;

        [DataMember]
        public String Departamento
        {
            get { return _Departamento; }
            set { _Departamento = value; }
        }
        [DataMember]
        public String Provincia
        {
            get { return _Provincia; }
            set { _Provincia = value; }
        }
        [DataMember]
        public String Distrito
        {
            get { return _Distrito; }
            set { _Distrito = value; }
        }

        // Fin pruebas

        [DataMember]
        public String Id_cliente
        {
            get { return mvarId_cli; }
            set { mvarId_cli = value; }
        }

        [DataMember]
        public String Nom_cli
        {
            get { return mvarNom_cli; }
            set { mvarNom_cli = value; }
        }


        [DataMember]
        public String Ape_cli
        {
            get { return mvarApe_cli; }
            set { mvarApe_cli = value; }
        }

        [DataMember]
        public String ApellNombre
        {
            get { return mvarApellNombre; }
            set { mvarApellNombre = value; }
        }

        [DataMember]
        public String Dni_cli
        {
            get { return mvarDni_cli; }
            set { mvarDni_cli = value; }
        }

        [DataMember]
        public String Ruc_cli
        {
            get { return mvarRuc_cli; }
            set { mvarRuc_cli = value; }
        }

        [DataMember]
        public String Sexo
        {
            get { return mvarSexo; }
            set { mvarSexo = value; }
        }

        [DataMember]
        public DateTime Fec_nacimiento
        {
            get { return mvarFec_nacimiento; }
            set { mvarFec_nacimiento = value; }
        }

        [DataMember]
        public Int16 Edad
        {
            get { return mvarEdad; }
            set { mvarEdad = value; }
        }

        [DataMember]
        public Int16 Estado_civil
        {
            get { return mvarEstado_civil; }
            set { mvarEstado_civil = value; }
        }

        [DataMember]
        public String EstCivil
        {
            get { return mvarEstCivil; }
            set { mvarEstCivil = value; }
        }

        [DataMember]
        public String Nivel_Educacion
        {
            get { return mvarNivel_Educacion; }
            set { mvarNivel_Educacion = value; }
        }

        [DataMember]
        public String Email
        {
            get { return mvarEmail; }
            set { mvarEmail = value; }
        }

        [DataMember]
        public String Id_ubigeo
        {
            get { return mvarId_ubigeo; }
            set { mvarId_ubigeo = value; }
        }

        [DataMember]
        public Int16 Est_cli
        {
            get { return mvarEst_cli; }
            set { mvarEst_cli = value; }
        }

        [DataMember]
        public String Estado
        {
            get { return mvarEstado; }
            set { mvarEstado = value; }
        }


        [DataMember]
        public DateTime Fec_reg
        {
            get { return mvarFec_reg; }
            set { mvarFec_reg = value; }
        }

        [DataMember]
        public String Usu_registro
        {
            get { return mvarUsu_registro; }
            set { mvarUsu_registro = value; }
        }

        [DataMember]
        public DateTime Fec_ult_mod
        {
            get { return mvarFec_ult_mod; }
            set { mvarFec_ult_mod = value; }
        }

        [DataMember]
        public String Usu_ult_mod
        {
            get { return mvarUsu_ult_mod; }
            set { mvarUsu_ult_mod = value; }
        }

    }    

}
