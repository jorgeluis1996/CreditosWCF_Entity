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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCliente" en el código y en el archivo de configuración a la vez.
    public class ServicioCliente : IServicioCliente
    {
        public Boolean InsertClient(ClienteBE objClienteBE)
        {
            CreditosEntities MisCreditos = new CreditosEntities();
            try
            {

                Tb_Cliente objCliente = new Tb_Cliente();

                objCliente.Id_cli = String.Empty;
                objCliente.Nom_cli = objClienteBE.Nom_cli;
                objCliente.Ape_cli = objClienteBE.Ape_cli;
                objCliente.Dni_cli = objClienteBE.Dni_cli;
                objCliente.Ruc_cli = objClienteBE.Ruc_cli;
                objCliente.Sexo = objClienteBE.Sexo;
                objCliente.Fec_nacimiento = Convert.ToDateTime(objClienteBE.Fec_nacimiento);
                objCliente.Nivel_educacion = objClienteBE.Nivel_Educacion;
                objCliente.Estado_civil = Convert.ToInt16(objClienteBE.Estado_civil);
                objCliente.Email = objClienteBE.Email;
                objCliente.Id_ubigeo = objClienteBE.Id_ubigeo;
                objCliente.Est_cli = Convert.ToInt16(objClienteBE.Est_cli);
                objCliente.Usu_registro = objClienteBE.Usu_registro;
                //objCliente.Fec_ult_mod = Convert.ToDateTime(objClienteBE.Fec_ult_mod);
                //objCliente.Usu_ult_mod = Convert.ToString(objClienteBE.Usu_ult_mod);

                MisCreditos.Tb_Cliente.Add(objCliente);

                MisCreditos.SaveChanges();

                return true;
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Boolean UpdateClient(ClienteBE objClienteBE)
        {
            CreditosEntities MisCreditos = new CreditosEntities();

            try
            {
                Tb_Cliente objCliente = (
                       from oCliente in MisCreditos.Tb_Cliente
                       where oCliente.Id_cli == objClienteBE.Id_cliente
                       select oCliente
                   ).FirstOrDefault();

                objCliente.Id_cli = objClienteBE.Id_cliente;
                objCliente.Nom_cli = objClienteBE.Nom_cli;
                objCliente.Ape_cli = objClienteBE.Ape_cli;
                objCliente.Dni_cli = objClienteBE.Dni_cli;
                objCliente.Ruc_cli = objClienteBE.Ruc_cli;
                objCliente.Sexo = objClienteBE.Sexo;
                objCliente.Fec_nacimiento = Convert.ToDateTime(objClienteBE.Fec_nacimiento);
                objCliente.Nivel_educacion = objClienteBE.Nivel_Educacion;
                objCliente.Estado_civil = Convert.ToInt16(objClienteBE.Estado_civil);
                objCliente.Email = objClienteBE.Email;
                objCliente.Id_ubigeo = objClienteBE.Id_ubigeo;
                objCliente.Est_cli = Convert.ToInt16(objClienteBE.Est_cli);
                //objCliente.Fec_ult_mod = Convert.ToDateTime(objClienteBE.Fec_ult_mod);
                objCliente.Usu_ult_mod = Convert.ToString(objClienteBE.Usu_ult_mod);

                //MisCreditos.Tb_Cliente.Add(objCliente);

                MisCreditos.SaveChanges();

                return true;
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Boolean DeleteClient(String Id_cli)
        {
            CreditosEntities MisCreditos = new CreditosEntities();

            try
            {
                Tb_Cliente objCliente = (
                       from oCliente in MisCreditos.Tb_Cliente
                       where oCliente.Id_cli == Id_cli
                       select oCliente
                   ).FirstOrDefault();

                MisCreditos.Tb_Cliente.Remove(objCliente);
                MisCreditos.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ClienteBE GetClient(String Id_cli)
        {
            CreditosEntities MisCreditos = new CreditosEntities();

            try
            {
                Tb_Cliente objCliente = (
                       from oCliente in MisCreditos.Tb_Cliente
                       where oCliente.Id_cli == Id_cli
                       select oCliente
                   ).FirstOrDefault();

                ClienteBE objClienteBE = new ClienteBE();
                objClienteBE.Id_cliente = objCliente.Id_cli;
                objClienteBE.Nom_cli = objCliente.Nom_cli;
                objClienteBE.Ape_cli = objCliente.Ape_cli;
                objClienteBE.Dni_cli = objCliente.Dni_cli;
                objClienteBE.Ruc_cli = objCliente.Ruc_cli;
                objClienteBE.Sexo = objCliente.Sexo;
                objClienteBE.Fec_nacimiento = Convert.ToDateTime(objCliente.Fec_nacimiento);
                objClienteBE.Nivel_Educacion = objCliente.Nivel_educacion;
                objClienteBE.Estado_civil = Convert.ToInt16(objCliente.Estado_civil);
                if (objClienteBE.Estado_civil == 1)
                {
                    objClienteBE.EstCivil = "Soltero/a";
                }
                else if (objClienteBE.Estado_civil == 2)
                {
                    objClienteBE.EstCivil = "Casado/a";
                }
                else if (objClienteBE.Estado_civil == 3)
                {
                    objClienteBE.EstCivil = "Viudo/a";
                }
                else
                {
                    objClienteBE.EstCivil = "Divorciado/a";
                }
                objClienteBE.Email = objCliente.Email;
                objClienteBE.Est_cli = Convert.ToInt16(objCliente.Est_cli);

                if (objClienteBE.Est_cli == 1)
                {
                    objClienteBE.Estado = "Activo";
                }
                else
                {
                    objClienteBE.Estado = "Inactivo";
                }
                objClienteBE.Id_ubigeo = objCliente.Id_ubigeo;

                // Prueba

                objClienteBE.Provincia = objCliente.Tb_Ubigeo.Provincia;
                objClienteBE.Distrito = objCliente.Tb_Ubigeo.Distrito;
                objClienteBE.Departamento = objCliente.Tb_Ubigeo.Departamento;

                // Fin prueba

                return objClienteBE;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ClienteBE> GetAllClientes()
        {
            CreditosEntities MisCreditos = new CreditosEntities();
            try
            {
                List<ClienteBE> objListaCliente = new List<ClienteBE>();

                var query = (from oCliente in MisCreditos.vw_Detalle_Cliente
                             select oCliente);
                foreach (var objCliente in query)
                {

                    ClienteBE objClienteBE = new ClienteBE();
                    objClienteBE.Id_cliente = objCliente.Id_cli;
                    objClienteBE.Nom_cli = objCliente.Nom_cli;
                    objClienteBE.Ape_cli = objCliente.Ape_cli;
                    objClienteBE.ApellNombre = objCliente.Ape_cli + ", " + objCliente.Nom_cli;
                    objClienteBE.Dni_cli = objCliente.Dni_cli;
                    objClienteBE.Ruc_cli = objCliente.Ruc_cli;
                    objClienteBE.Sexo = objCliente.Sexo;
                    objClienteBE.Fec_nacimiento = Convert.ToDateTime(objCliente.Fec_nacimiento);
                    objClienteBE.Edad = Convert.ToInt16(objCliente.Edad);
                    objClienteBE.Nivel_Educacion = objCliente.Nivel_educacion;
                    objClienteBE.Estado_civil = Convert.ToInt16(objCliente.Estado_civil);                   
                    objClienteBE.EstCivil = objCliente.EstadoCivil;
                    objClienteBE.Email = objCliente.Email;
                    objClienteBE.Est_cli = Convert.ToInt16(objCliente.Est_cli);

                    if (objClienteBE.Est_cli == 1)
                    {
                        objClienteBE.Estado = "Activo";
                    }
                    else
                    {
                        objClienteBE.Estado = "Inactivo";
                    }
                    objClienteBE.Id_ubigeo = objCliente.Id_ubigeo;                    

                    objListaCliente.Add(objClienteBE);
                }

                return objListaCliente;

            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //public ClienteBE GetUbigeo(String Id_cli)
        //{
        //    CreditosEntities MisCreditos = new CreditosEntities();

        //    try
        //    {
        //        Tb_Cliente objCliente = (
        //               from oCliente in MisCreditos.Tb_Cliente
        //               where oCliente.Id_cli == Id_cli
        //               select oCliente
        //           ).FirstOrDefault();

        //        ClienteBE objClienteBE = new ClienteBE();
        //        objClienteBE.Id_cliente = objCliente.Id_cli;
        //        objClienteBE.Nom_cli = objCliente.Nom_cli;
        //        objClienteBE.Ape_cli = objCliente.Ape_cli;
        //        objClienteBE.Dni_cli = objCliente.Dni_cli;
        //        objClienteBE.Ruc_cli = objCliente.Ruc_cli;
        //        objClienteBE.Sexo = objCliente.Sexo;
        //        objClienteBE.Fec_nacimiento = Convert.ToDateTime(objCliente.Fec_nacimiento);
        //        objClienteBE.Nivel_Educacion = objCliente.Nivel_educacion;
        //        objClienteBE.Estado_civil = Convert.ToInt16(objCliente.Estado_civil);
        //        if (objClienteBE.Estado_civil == 1)
        //        {
        //            objClienteBE.EstCivil = "Soltero/a";
        //        }
        //        else if (objClienteBE.Estado_civil == 2)
        //        {
        //            objClienteBE.EstCivil = "Casado/a";
        //        }
        //        else if (objClienteBE.Estado_civil == 3)
        //        {
        //            objClienteBE.EstCivil = "Viudo/a";
        //        }
        //        else
        //        {
        //            objClienteBE.EstCivil = "Divorciado/a";
        //        }
        //        objClienteBE.Email = objCliente.Email;
        //        objClienteBE.Est_cli = Convert.ToInt16(objCliente.Est_cli);

        //        if (objClienteBE.Est_cli == 1)
        //        {
        //            objClienteBE.Estado = "Activo";
        //        }
        //        else
        //        {
        //            objClienteBE.Estado = "Inactivo";
        //        }
        //        objClienteBE.Id_ubigeo = objCliente.Id_ubigeo;

        //        return objClienteBE;
        //    }
        //    catch (EntityException ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

    }
}
