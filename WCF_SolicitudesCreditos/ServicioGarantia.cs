using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
//Agregamos...
using System.Data.Entity.Core;

namespace WCF_SolicitudesCreditos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioGarantia" en el código y en el archivo de configuración a la vez.
    public class ServicioGarantia : IServicioGarantia
    {
        public Boolean InsertGarantia(GarantiaBE objGarantiaBE)
        {
            CreditosEntities MisCreditos = new CreditosEntities();
            try
            {

                Tb_Garantia objGarantia = new Tb_Garantia();

                objGarantia.Tip_garantia = objGarantiaBE.Tip_garantia;
                objGarantia.Des_garantia = objGarantiaBE.Des_garantia;
                objGarantia.Valor_garantia = Convert.ToDecimal(objGarantiaBE.Valor_garantia);
                objGarantia.Id_cli = objGarantiaBE.Id_cli;
                objGarantia.Est_garantia = Convert.ToInt16(objGarantiaBE.Est_garantia);
                objGarantia.Usu_registro = objGarantiaBE.Usu_registro;

                /*objGarantia.Id_garantia = Int32.Empty;
                
                objGarantia.Tip_garantia = objGarantiaBE.Tip_garantia;
                objGarantia.Des_garantia = objGarantiaBE.Des_garantia;
                objGarantia.Valor_garantia = Convert.ToSingle(objGarantiaBE.Valor_garantia);
                objGarantiaBE.Valor_garantia = Convert.ToSingle(objGarantia.Valor_garantia);
                objGarantia.Id_cli = objGarantiaBE.Id_cli;
                objGarantia.Est_garantia = objGarantiaBE.Est_garantia;
                objGarantia.Usu_registro = objGarantiaBE.Usu_registro;*/

                MisCreditos.Tb_Garantia.Add(objGarantia);

                MisCreditos.SaveChanges();

                return true;
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Boolean UpdateGarantia(GarantiaBE objGarantiaBE)
        {
            CreditosEntities MisCreditos = new CreditosEntities();

            try
            {
                Tb_Garantia objGarantia = (
                    from oGarantia in MisCreditos.Tb_Garantia
                    where oGarantia.Id_garantia == objGarantiaBE.Id_garantia
                    select oGarantia).FirstOrDefault();

                objGarantia.Id_garantia = objGarantiaBE.Id_garantia;
                objGarantia.Des_garantia = objGarantiaBE.Des_garantia;
                //objGarantia.Valor_garantia = objGarantiaBE.Valor_garantia;
                objGarantia.Valor_garantia = Convert.ToInt32(objGarantiaBE.Valor_garantia);
                objGarantia.Id_cli = objGarantiaBE.Id_cli;
                objGarantia.Est_garantia = objGarantiaBE.Est_garantia;
                objGarantia.Fec_reg = objGarantiaBE.Fec_reg;
                objGarantia.Usu_registro = objGarantiaBE.Usu_registro;
                objGarantia.Fec_ult_mod = objGarantiaBE.Fec_ult_mod;
                objGarantia.Usu_ult_mod = objGarantiaBE.Usu_ult_mod;
                objGarantia.Tip_garantia = objGarantiaBE.Tip_garantia;


                MisCreditos.SaveChanges();

                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Boolean DeleteGarantia(int Id_garantia)
        {
            CreditosEntities MisCreditos = new CreditosEntities();
            try
            {
                Tb_Garantia objGarantia = (
                    from oGarantia in MisCreditos.Tb_Garantia
                    where oGarantia.Id_garantia == Id_garantia
                    select oGarantia).FirstOrDefault();

                MisCreditos.Tb_Garantia.Remove(objGarantia);

                MisCreditos.SaveChanges();

                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public GarantiaBE GetGarantiaPorCliente(String Id_cli)
        {
            // Instanciamos el modelo
            CreditosEntities MisCreditos = new CreditosEntities();

            try
            {
                // Ubicamos al vendedor que se desaea consultar
                Tb_Garantia objGarantia = (
                        from oGarantia in MisCreditos.Tb_Garantia
                        where oGarantia.Id_cli == Id_cli
                        select oGarantia
                    ).FirstOrDefault();

                // Creamos una instancia de la DataContractual VendedorBE para retornar los datos del vendedor consultado...
                GarantiaBE objGarantiaBE = new GarantiaBE();
                objGarantiaBE.Id_garantia = objGarantia.Id_garantia;
                objGarantiaBE.Tip_garantia = objGarantia.Tip_garantia;
                objGarantiaBE.Des_garantia = objGarantia.Des_garantia;
                //objGarantiaBE.Valor_garantia = Convert.ToDecimal(objGarantia.Valor_garantia);
                objGarantia.Valor_garantia = Convert.ToDecimal(objGarantiaBE.Valor_garantia);
                objGarantiaBE.Usu_registro = objGarantia.Usu_registro;
                objGarantiaBE.Est_garantia = Convert.ToInt16(objGarantia.Est_garantia);

                if (objGarantiaBE.Tip_garantia == "Mueble")
                {
                    objGarantiaBE.Tip_garantia = "Mueble";
                }
                else if (objGarantiaBE.Tip_garantia == "Inmueble")
                {
                    objGarantiaBE.Tip_garantia = "Inmueble";
                }
                else
                {
                    objGarantiaBE.Tip_garantia = "Vehiculos";
                }



                // Devolvemos el estado descriptivo...
                if (objGarantiaBE.Est_garantia == 1)
                {
                    objGarantiaBE.Estado = "Activo";
                }
                else
                {
                    objGarantiaBE.Estado = "Inactivo";
                }

                return objGarantiaBE;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public GarantiaBE GetGarantia(int Id_garantia)
        {
            CreditosEntities MisCreditos = new CreditosEntities();

            try
            {
                Tb_Garantia objGarantia = (
                    from oGarantia in MisCreditos.Tb_Garantia
                    where oGarantia.Id_garantia == Id_garantia
                    select oGarantia
                    ).FirstOrDefault();

                GarantiaBE objGarantiaBE = new GarantiaBE();
                objGarantiaBE.Id_garantia = objGarantia.Id_garantia;
                objGarantiaBE.Tip_garantia = objGarantia.Tip_garantia;
                objGarantiaBE.Des_garantia = objGarantia.Des_garantia;
                //objGarantia.Valor_garantia = Convert.ToSingle(objGarantiaBE.Valor_garantia);
                objGarantiaBE.Valor_garantia = Convert.ToSingle(objGarantia.Valor_garantia);
                objGarantiaBE.Id_cli = objGarantia.Id_cli;
                objGarantiaBE.Est_garantia = Convert.ToInt16(objGarantia.Est_garantia);
                objGarantiaBE.Tip_garantia = objGarantia.Tip_garantia;

                /*if(objGarantiaBE.Tip_garantia == "Mueble")
                {
                    objGarantiaBE.Tip_garantia = "Mueble";
                }
                if (objGarantiaBE.Tip_garantia == "Inmueble")
                {
                    objGarantiaBE.Tip_garantia = "Inmueble";
                }
                if (objGarantiaBE.Tip_garantia == "Automovil")
                {
                    objGarantiaBE.Tip_garantia = "Automovil";
                }*/

                return objGarantiaBE;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<GarantiaBE> GetAllGarantias()
        {
            CreditosEntities MisCreditos = new CreditosEntities();
            try
            {
                List<GarantiaBE> objListarGarantia = new List<GarantiaBE>();

                var query = (from oGarantia in MisCreditos.vw_Detalle_Garantia
                             select oGarantia);

                foreach (var objGarantia in query)
                {
                    GarantiaBE objGarantiaBE = new GarantiaBE();
                    objGarantiaBE.Id_garantia = objGarantia.Id_garantia;
                    objGarantiaBE.nomCliente = objGarantia.Nom_cli;
                    objGarantiaBE.apeCliente = objGarantia.Ape_cli;
                    objGarantiaBE.Tip_garantia = objGarantia.Tip_garantia;
                    objGarantiaBE.Des_garantia = objGarantia.Des_garantia;
                    objGarantiaBE.Valor_garantia = Convert.ToSingle(objGarantia.Valor_garantia);
                    objGarantiaBE.Id_cli = objGarantia.Id_cli;
                    objGarantiaBE.Est_garantia = Convert.ToInt16(objGarantia.Est_garantia);

                    if (objGarantiaBE.Est_garantia == 1)
                    {
                        objGarantiaBE.Estado = "Activo";
                    }
                    else
                    {
                        objGarantiaBE.Estado = "Inactivo";
                    }
                    objListarGarantia.Add(objGarantiaBE);
                }
                return objListarGarantia;
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
