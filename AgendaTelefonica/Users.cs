using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AgendaTelefonica
{
    class Users
    {
        /// <summary>
        /// Hecho por Albert Ramirez para Proyecto 3
        /// Fecha: 4 Abril 2017
        /// Correo: arbert.jr@hotmail.com
        /// </summary>

        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nivel { get; set; }

        public Users() { }
        public Users(int pID, string pName, string pLastName, string pNivel)
        {
            ID = pID;
            Nombre = pName;
            Apellido = pLastName;
            Nivel = pNivel;
        }

        public static string registerUsuario(string nombre, string apellido, string contrasena, string nivel, string foto)
        {
            string mensaje = null;
            using(SqlConnection con = Connection.getConnection())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.CommandText = "registerUsuario";

                comand.Parameters.Add(new SqlParameter("@nombre", System.Data.SqlDbType.VarChar));
                comand.Parameters["@nombre"].Value = nombre;

                comand.Parameters.Add(new SqlParameter("@apellido", System.Data.SqlDbType.VarChar));
                comand.Parameters["@apellido"].Value = apellido;

                comand.Parameters.Add(new SqlParameter("@contrasena", System.Data.SqlDbType.VarChar));
                comand.Parameters["@contrasena"].Value = contrasena;

                comand.Parameters.Add(new SqlParameter("@nivel", System.Data.SqlDbType.VarChar));
                comand.Parameters["@nivel"].Value = nivel;

                comand.Parameters.Add(new SqlParameter("@foto", System.Data.SqlDbType.VarChar));
                comand.Parameters["@foto"].Value = foto;

                int r = comand.ExecuteNonQuery();
                if(r > 0)
                {
                    mensaje = "El Usuario: " + nombre + " " + apellido + " ha sido registrado";
                }
                else
                {
                    mensaje = "No se pudo registrar el Usuario";
                }
                con.Close();
            }
            return mensaje;
        }

        public static string modifyUsuario(int codigo, string nombre, string apellido, string contrasena, string nivel, string foto)
        {
            string mensaje = null;
            using (SqlConnection con = Connection.getConnection())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.CommandText = "modifyUsuario";

                comand.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int));
                comand.Parameters["@codigo"].Value = codigo;

                comand.Parameters.Add(new SqlParameter("@nombre", System.Data.SqlDbType.VarChar));
                comand.Parameters["@nombre"].Value = nombre;

                comand.Parameters.Add(new SqlParameter("@apellido", System.Data.SqlDbType.VarChar));
                comand.Parameters["@apellido"].Value = apellido;

                comand.Parameters.Add(new SqlParameter("@contrasena", System.Data.SqlDbType.VarChar));
                comand.Parameters["@contrasena"].Value = contrasena;

                comand.Parameters.Add(new SqlParameter("@nivel", System.Data.SqlDbType.VarChar));
                comand.Parameters["@nivel"].Value = nivel;

                comand.Parameters.Add(new SqlParameter("@foto", System.Data.SqlDbType.VarChar));
                comand.Parameters["@foto"].Value = foto;

                int r = comand.ExecuteNonQuery();
                if (r > 0)
                {
                    mensaje = "El Usuario: " + nombre + " " + apellido + " ha sido modificado";
                }
                else
                {
                    mensaje = "No se pudo modificar el Usuario";
                }
                con.Close();
            }
            return mensaje;
        }


        // se concatena el nombre con el apellido de la siguiente manera  nombre.apellido y se envian por el parametro username
        public static bool login(string username, string password)
        {
            bool r = false;
            using(SqlConnection con = Connection.getConnection())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.CommandText = "loginUsuario";

                comand.Parameters.Add(new SqlParameter("@nombre", System.Data.SqlDbType.VarChar));
                comand.Parameters["@nombre"].Value = username;

                comand.Parameters.Add(new SqlParameter("@contrasena", System.Data.SqlDbType.VarChar));
                comand.Parameters["@contrasena"].Value = password;

                int result = Convert.ToInt32(comand.ExecuteScalar());

                if(result == 1)
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

        public static string deleteUsuario(int codigo)
        {
            string mensaje = null;

            using(SqlConnection con = Connection.getConnection())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.CommandText = "deleteUsuario";

                comand.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int));
                comand.Parameters["@codigo"].Value = codigo;

                int r = comand.ExecuteNonQuery();
                if(r > 0)
                {
                    mensaje = "El usuario fue eliminado";
                }
                else
                {
                    mensaje = "No se pudo eliminar el usuario";
                }
                con.Close();
            }
            return mensaje;
        }

        public static bool validate(string username)
        {
            bool r = false;
            using (SqlConnection con = Connection.getConnection())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.CommandText = "userValidation";

                comand.Parameters.Add(new SqlParameter("@usernarme", System.Data.SqlDbType.VarChar));
                comand.Parameters["@usernarme"].Value = username;

                int result = Convert.ToInt32(comand.ExecuteScalar());

                if (result == 1)
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

        public static UsersBase getUserInfoWID(int codigo)
        {
            UsersBase UserInfo = new UsersBase();
            using(SqlConnection con = Connection.getConnection())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.CommandText = "getUserInfoWID";

                comand.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int));
                comand.Parameters["@codigo"].Value = codigo;

                SqlDataReader re = comand.ExecuteReader();

                if (re.Read())
                {
                    UserInfo.ID = Convert.ToInt32(re["id"]);
                    UserInfo.Nombre = re["n"].ToString();
                    UserInfo.Apellido = re["l"].ToString();
                    UserInfo.Nivel = re["ni"].ToString();
                    UserInfo.Foto = re["fo"].ToString();
                    UserInfo.Contrasena = re["contra"].ToString();
                }
                else
                {
                    UserInfo = null;
                }
                con.Close();
            }
            return UserInfo;
        }

        public static UsersBase getUserInfoWUsername(string Username)
        {
            UsersBase UserInfo = new UsersBase();
            using (SqlConnection con = Connection.getConnection())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.CommandText = "getUserInfoWUsername";

                comand.Parameters.Add(new SqlParameter("@username", System.Data.SqlDbType.VarChar));
                comand.Parameters["@username"].Value = Username;

                SqlDataReader re = comand.ExecuteReader();

                if (re.Read())
                {
                    UserInfo.ID = Convert.ToInt32(re["id"]);
                    UserInfo.Nombre = re["n"].ToString();
                    UserInfo.Apellido = re["l"].ToString();
                    UserInfo.Nivel = re["ni"].ToString();
                    UserInfo.Foto = re["fo"].ToString();
                    UserInfo.Contrasena = re["contra"].ToString();
                }
                else
                {
                    UserInfo = null;
                }
                con.Close();
            }
            return UserInfo;
        }

        public static List<Users> searchEngineUsers(string nombre, string apellido)
        {
            List<Users> list = new List<Users>();
            using (SqlConnection con = Connection.getConnection())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.CommandText = "searchEngineUsers";

                comand.Parameters.Add(new SqlParameter("@nombre", System.Data.SqlDbType.VarChar));
                comand.Parameters["@nombre"].Value = nombre;

                comand.Parameters.Add(new SqlParameter("@apellido", System.Data.SqlDbType.VarChar));
                comand.Parameters["@apellido"].Value = apellido;

                SqlDataReader re = comand.ExecuteReader();

                while(re.Read())
                {
                    Users UserInfo = new Users();

                    UserInfo.ID = Convert.ToInt32(re["id"]);
                    UserInfo.Nombre = re["n"].ToString();
                    UserInfo.Apellido = re["l"].ToString();
                    UserInfo.Nivel = re["ni"].ToString();

                    list.Add(UserInfo);
                }
                con.Close();
            }
            return list;
        }
    }

    // Esta clase obtiene toda la info del Usuario incluyendo su foto.
    public class UsersBase
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nivel { get; set; }
        public string Foto { get; set; }
        public string Contrasena { get; set; }

        public UsersBase() { }
        public UsersBase(int id, string n, string a, string ni, string fo, string co)
        {
            ID = id;
            Nombre = n;
            Apellido = a;
            Nivel = n;
            Foto = fo;
            Contrasena = co;
        }
    }
}
/// <summary>
/// Hecho por Albert Ramirez para Proyecto 3
/// Fecha: 4 Abril 2017
/// Correo: arbert.jr@hotmail.com
/// </summary>

