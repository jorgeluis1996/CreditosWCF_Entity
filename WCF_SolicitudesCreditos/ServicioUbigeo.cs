using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
// Agregar...
using System.Data.Entity.Core; //EntityException

namespace WCF_SolicitudesCreditos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUbigeo" en el código y en el archivo de configuración a la vez.
    public class ServicioUbigeo : IServicioUbigeo
    {
        public List<UbigeoBE> GetDepartamentos()
        {
            CreditosEntities misCreditos = new CreditosEntities();

            try
            {
                List<UbigeoBE> listaDepartamento = new List<UbigeoBE>();

                var query = misCreditos.usp_Ubigeo_Departamentos();

                foreach(var resultado in query)
                {
                    UbigeoBE objUbigeoBE = new UbigeoBE();
                    objUbigeoBE.idDepartamento = resultado.IDDEPA;
                    objUbigeoBE.Departamento = resultado.DEPARTAMENTO;

                    listaDepartamento.Add(objUbigeoBE);
                }

                return listaDepartamento;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<UbigeoBE> GetProvincias(String idDepartamento)
        {
            CreditosEntities misCreditos = new CreditosEntities();

            try
            {
                List<UbigeoBE> listaProvincias = new List<UbigeoBE>();

                var query = misCreditos.usp_Ubigeo_ProvinciasDepartamento(idDepartamento);

                foreach (var resultado in query)
                {
                    UbigeoBE objUbigeoBE = new UbigeoBE();
                    objUbigeoBE.idProvincia = resultado.IDPROV;
                    objUbigeoBE.Provincia = resultado.PROVINCIA;

                    listaProvincias.Add(objUbigeoBE);
                }

                return listaProvincias;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<UbigeoBE> GetDistritos(String idDepartamento, String idProvincia)
        {
            CreditosEntities misCreditos = new CreditosEntities();

            try
            {
                List<UbigeoBE> listaDistritos = new List<UbigeoBE>();

                var query = misCreditos.usp_Ubigeo_DistritosProvinciaDepartamento(idDepartamento, idProvincia);

                foreach (var resultado in query)
                {
                    UbigeoBE objUbigeoBE = new UbigeoBE();
                    objUbigeoBE.idDistrito = resultado.IDDIST;
                    objUbigeoBE.Distriro = resultado.DISTRITO;

                    listaDistritos.Add(objUbigeoBE);
                }

                return listaDistritos;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
