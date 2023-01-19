using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_SolicitudesCreditos
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IservicioAnalista" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IservicioAnalista
    {
        [OperationContract]
        List<AnalistaBE> GetRankingAnalista(Int32 vTop, Int32 vEstSolicitud);

        [OperationContract]
        List<AnalistaBE> GetAllAnalista();

        [OperationContract]
        Int16 GetContarAnalistasXSolicitudes(String strCod, Int16 Est_Solicitud);

        [OperationContract]
        AnalistaBE GetAnalista(String Id_analista);
    }

    [DataContract]
    [Serializable]
    public class AnalistaBE
    {
        // Miembros privados
        private String mvarId_analista;
        private String mvarNom_analista;
        private String mvarApe_analista;
        private String mvarApellNombre;
        private String mvarId_agencia;
        private DateTime mvarFec_Ingreso;
        private String mvarDni_analista;
        private String mvarEmail_Analista;
        private Int32 mvanet_Value;
        private Int32 mvaumeroSolicitudes;

        [DataMember]
        public String Id_analista
        {
            get { return mvarId_analista; }
            set { mvarId_analista = value; }
        }

        [DataMember]
        public Int32 NumeroSolicitudes
        {
            get { return mvaumeroSolicitudes; }
            set { mvaumeroSolicitudes = value; }
        }

        [DataMember]
        public Int32 Net_value
        {
            get { return mvanet_Value; }
            set { mvanet_Value = value; }
        }

        [DataMember]
        public String Nom_analista
        {
            get { return mvarNom_analista; }
            set { mvarNom_analista = value; }
        }

        [DataMember]
        public String Ape_analista
        {
            get { return mvarApe_analista; }
            set { mvarApe_analista = value; }
        }

        [DataMember]
        public String ApellNombre
        {
            get { return mvarApellNombre; }
            set { mvarApellNombre = value; }
        }

        [DataMember]
        public String Id_agencia
        {
            get { return mvarId_agencia; }
            set { mvarId_agencia = value; }
        }

        [DataMember]
        public DateTime Fec_Ingreso
        {
            get { return mvarFec_Ingreso; }
            set { mvarFec_Ingreso = value; }
        }

        [DataMember]
        public String DNI_analista
        {
            get { return mvarDni_analista; }
            set { mvarDni_analista = value; }
        }

        [DataMember]
        public String Email_analista
        {
            get { return mvarEmail_Analista; }
            set { mvarEmail_Analista = value; }
        }
    }
}
