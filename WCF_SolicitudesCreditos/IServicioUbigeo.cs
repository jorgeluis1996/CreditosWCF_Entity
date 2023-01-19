using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_SolicitudesCreditos
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioUbigeo" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioUbigeo
    {
        [OperationContract]
        List<UbigeoBE> GetDepartamentos();

        [OperationContract]
        List<UbigeoBE> GetProvincias(String idDepartamento);

        [OperationContract]
        List<UbigeoBE> GetDistritos(String idDepartamento, String idProvincia);

    }

    [DataContract]
    [Serializable]
    public class UbigeoBE
    {
        private String _idDepartamento;
        private String _Departamento;
        private String _idProvincia;
        private String _Provincia;
        private String _idDistrito;
        private String _Distrito;

        [DataMember]
        public String idDepartamento
        {
            get { return _idDepartamento; }
            set { _idDepartamento = value; }
        }

        [DataMember]
        public String Departamento
        {
            get { return _Departamento; }
            set { _Departamento = value; }
        }

        [DataMember]
        public String idProvincia
        {
            get { return _idProvincia; }
            set { _idProvincia = value; }
        }

        [DataMember]
        public String Provincia
        {
            get { return _Provincia; }
            set { _Provincia = value; }
        }

        [DataMember]
        public String idDistrito
        {
            get { return _idDistrito; }
            set { _idDistrito = value; }
        }

        [DataMember]
        public String Distriro
        {
            get { return _Distrito; }
            set { _Distrito = value; }
        }
    }
}
