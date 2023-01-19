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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "servicioAnalista" en el código y en el archivo de configuración a la vez.
    public class servicioAnalista : IservicioAnalista
    {
        public List<AnalistaBE> GetRankingAnalista(Int32 vTop, Int32 vEstSolicitud)
        {
            CreditosEntities MisCreditos = new CreditosEntities();
            List<AnalistaBE> objListaAnalistaRank = new List<AnalistaBE>();
            try
            {
                var query = MisCreditos.usp_RankingAnalistas(vTop, vEstSolicitud);

                foreach (var resultado in query)
                {
                    AnalistaBE objAnalistaBE = new AnalistaBE();

                    objAnalistaBE.Id_analista = resultado.Id_analista;
                    objAnalistaBE.Nom_analista = resultado.Nombre_analista;
                    objAnalistaBE.Net_value = Convert.ToInt32(resultado.net_value);
                    objAnalistaBE.NumeroSolicitudes = Convert.ToInt32(resultado.NumeroSolicitudes);

                    objListaAnalistaRank.Add(objAnalistaBE);


                }
                return objListaAnalistaRank;

            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public List<AnalistaBE> GetAllAnalista()
        {
            CreditosEntities MisCreditos = new CreditosEntities();
            try
            {
                List<AnalistaBE> objListaAnalista = new List<AnalistaBE>();

                var query = (from oAnalista in MisCreditos.Tb_Analista
                             select oAnalista);
                foreach (var objAnalista in query)
                {

                    AnalistaBE objAnalistaBE = new AnalistaBE();
                    objAnalistaBE.Id_analista = objAnalista.Id_analista;
                    objAnalistaBE.Nom_analista = objAnalista.Nom_analista;
                    objAnalistaBE.Ape_analista = objAnalista.Ape_analista;
                    objAnalistaBE.ApellNombre = objAnalista.Ape_analista + ", " + objAnalista.Nom_analista;
                    objAnalistaBE.Id_agencia = objAnalista.Id_agencia;
                    objAnalistaBE.Fec_Ingreso = Convert.ToDateTime(objAnalista.Fec_ingreso);
                    objAnalistaBE.DNI_analista = objAnalista.DNI_analista;
                    objAnalistaBE.Email_analista = objAnalista.Email_analista;

                    objListaAnalista.Add(objAnalistaBE);
                }

                return objListaAnalista;

            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Int16 GetContarAnalistasXSolicitudes(String strCod, Int16 Est_Solicitud)
        {
            CreditosEntities MisCreditos = new CreditosEntities();
            try
            {
                Int16 catSolicitudes = Convert.ToInt16
                    (
                        (
                        from oAnalista in MisCreditos.Tb_Solicitud
                        where oAnalista.Id_analista == strCod && oAnalista.Est_solicitud == Est_Solicitud
                        select oAnalista
                        ).Count()
                    );
                return catSolicitudes;
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public AnalistaBE GetAnalista(String Id_analista)
        {
            CreditosEntities MisCreditos = new CreditosEntities();

            try
            {
                Tb_Analista objAnalista = (
                       from oAnalista in MisCreditos.Tb_Analista
                       where oAnalista.Id_analista== Id_analista
                       select oAnalista
                   ).FirstOrDefault();

                AnalistaBE objAnalistaBE = new AnalistaBE();
                objAnalistaBE.Nom_analista = objAnalista.Nom_analista;
                objAnalistaBE.ApellNombre = objAnalista.Ape_analista;
                objAnalistaBE.Fec_Ingreso = objAnalista.Fec_ingreso;
                objAnalistaBE.DNI_analista = objAnalista.DNI_analista;
                objAnalistaBE.Email_analista = objAnalista.Email_analista;

                return objAnalistaBE;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
