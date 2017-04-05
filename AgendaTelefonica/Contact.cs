using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AgendaTelefonica
{
    public class Contact
    {
        /// <summary>
        /// Hecho por Albert Ramirez para Proyecto 3
        /// Fecha: 4 Abril 2017
        /// Correo: arbert.jr@hotmail.com
        /// </summary>


        public int id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string Email { get; set; }
        public int idImage { get; set; }

        public Contact() { }
        public Contact(int pid, string pName, string pLastName, string pEmail, int pIdImage)
        {
            id = pid;
            name = pName;
            lastName = pLastName;
            Email = pEmail;
            idImage = pIdImage;
        }

        public static string registerContact(Contact pC)
        {
            string mensaje = null;
            using(SqlConnection con = Connection.getConnection())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.CommandText = "registerContact";

                comand.Parameters.Add(new SqlParameter("@nombre", System.Data.SqlDbType.VarChar));
                comand.Parameters["@nombre"].Value = pC.name;

                comand.Parameters.Add(new SqlParameter("@lastname", System.Data.SqlDbType.VarChar));
                comand.Parameters["@lastname"].Value = pC.lastName;

                comand.Parameters.Add(new SqlParameter("@email", System.Data.SqlDbType.VarChar));
                comand.Parameters["@email"].Value = pC.Email;

                comand.Parameters.Add(new SqlParameter("@codigoImagen", System.Data.SqlDbType.Int));
                comand.Parameters["@codigoImagen"].Value = pC.idImage;


                int r = comand.ExecuteNonQuery();
                if(r > 0)
                {
                    mensaje = "Contacto:" + pC.name + " " + pC.lastName + " Registrado con exito!";
                }
                else
                {
                    mensaje = "No se pudo registrar, Intentelo nuevamente";
                }
                con.Close();
            }
            return mensaje;
        }

        public static string modifyContact(Contact pC)
        {
            string mensaje = null;
            using(SqlConnection con = Connection.getConnection())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.CommandText = "modifyContact";

                comand.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int));
                comand.Parameters["@codigo"].Value = pC.id;

                comand.Parameters.Add(new SqlParameter("@nombre", System.Data.SqlDbType.VarChar));
                comand.Parameters["@nombre"].Value = pC.name;

                comand.Parameters.Add(new SqlParameter("@lastname", System.Data.SqlDbType.VarChar));
                comand.Parameters["@lastname"].Value = pC.lastName;

                comand.Parameters.Add(new SqlParameter("@email", System.Data.SqlDbType.VarChar));
                comand.Parameters["@email"].Value = pC.Email;

                int r = comand.ExecuteNonQuery();
                if(r > 0)
                {
                    mensaje = "El contacto: " + pC.name + " " + pC.lastName + " Fue modificado con exito";
                }
                else
                {
                    mensaje = "No se pudo modificar, Intentelo nuevamente";
                }
                con.Close();
            }
            return mensaje;
        }

        public static string deleteContact(Contact pC)
        {
            string mensaje = null;
            using(SqlConnection con = Connection.getConnection())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.CommandText = "deleteContact";

                comand.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int));
                comand.Parameters["@codigo"].Value = pC.id;

                int r01 = comand.ExecuteNonQuery();

                if(r01 > 0)
                {
                    mensaje = "El contacto: " + pC.name + " " + pC.lastName + " Fue eliminado";
                }
                else
                {
                    mensaje = "No se pudo eliminar";
                }
                con.Close();
            }
            return mensaje;
        }

        public static bool Validate(string nombre, string apellido)
        {
            bool r = false;
            using(SqlConnection con = Connection.getConnection())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.CommandText = "validateContact";

                comand.Parameters.Add(new SqlParameter("@nombre", System.Data.SqlDbType.VarChar));
                comand.Parameters["@nombre"].Value = nombre;

                comand.Parameters.Add(new SqlParameter("@apellido", System.Data.SqlDbType.VarChar));
                comand.Parameters["@apellido"].Value = apellido;

                int qty = Convert.ToInt32(comand.ExecuteScalar());

                if(qty >= 1)
                {
                    r = true;
                }
                else
                {
                    r = false;
                }
                con.Close();
            }
            return r;
        }

        public static Contact getInfoContact(string nombre, string apellido)
        {
            Contact pInfoContact = new Contact();
            using(SqlConnection con = Connection.getConnection())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "getInfoContact";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@nombre", System.Data.SqlDbType.VarChar));
                comand.Parameters["@nombre"].Value = nombre;

                comand.Parameters.Add(new SqlParameter("@apellido", System.Data.SqlDbType.VarChar));
                comand.Parameters["@apellido"].Value = apellido;

                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    pInfoContact.id = Convert.ToInt32(re["ID"]);
                    pInfoContact.name = re["Nombre"].ToString();
                    pInfoContact.lastName = re["Apellido"].ToString();
                    pInfoContact.Email = re["Correo"].ToString();
                    pInfoContact.idImage = Convert.ToInt32(re["Foto"]);
                }
                con.Close();
            }
            return pInfoContact;
        }

        public static List<pListContact> searchEngine(string nombre, string apellido)
        {
            List<pListContact> list = new List<pListContact>();
            using(SqlConnection con = Connection.getConnection())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.CommandText = "searchEngineContacts";

                comand.Parameters.Add(new SqlParameter("@nombre", System.Data.SqlDbType.VarChar));
                comand.Parameters["@nombre"].Value = nombre;

                comand.Parameters.Add(new SqlParameter("@apellido", System.Data.SqlDbType.VarChar));
                comand.Parameters["@apellido"].Value = apellido;

                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    pListContact pContactInfo = new pListContact();
                    pContactInfo.Codigo = Convert.ToInt32(re["cod"]);
                    pContactInfo.Nombre = re["n"].ToString();
                    pContactInfo.Apellido = re["l"].ToString();
                    pContactInfo.Correo = re["co"].ToString();

                    list.Add(pContactInfo);
                }
                con.Close();
            }
            return list;
        }

        public static Contact getInfoContactWID(int codigo)
        {
            Contact pInfoContact = new Contact();
            using (SqlConnection con = Connection.getConnection())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "getInfoContactWID";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int));
                comand.Parameters["@codigo"].Value = codigo;

                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    pInfoContact.id = Convert.ToInt32(re["cod"]);
                    pInfoContact.name = re["n"].ToString();
                    pInfoContact.lastName = re["l"].ToString();
                    pInfoContact.Email = re["co"].ToString();
                    pInfoContact.idImage = Convert.ToInt32(re["fo"]);
                }
                con.Close();
            }
            return pInfoContact;
        }
    }
    public class pListContact
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }

        public pListContact()
        {

        }
        public pListContact(int c, string n, string a, string co)
        {
            Codigo = c;
            Nombre = n;
            Apellido = a;
            Correo = co;
        }
    }
}
/// <summary>
/// Hecho por Albert Ramirez para Proyecto 3
/// Fecha: 4 Abril 2017
/// Correo: arbert.jr@hotmail.com
/// </summary>

