using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AgendaTelefonica
{
    public class Pictures
    {
        /// <summary>
        /// Hecho por Albert Ramirez para Proyecto 3
        /// Fecha: 4 Abril 2017
        /// Correo: arbert.jr@hotmail.com
        /// </summary>

        public int codigo { get; set; }
        public string Path { get; set; }
        public int codigoContacto { get; set; }

        public Pictures() { }
        public Pictures(int c, string p, int cc)
        {
            codigo = c;
            Path = p;
            codigoContacto = cc;
        }

        // metodo para registrar una nueva imagen
        public static string registerImage(string path, int codigoContacto)
        {
            string mensaje = null;
            using (SqlConnection con = Connection.getConnection())
            {
                SqlCommand comand = new SqlCommand();
                comand.CommandText = "registerImage";
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.Connection = con;

                comand.Parameters.Add(new SqlParameter("@codigoContacto", System.Data.SqlDbType.Int));
                comand.Parameters["@codigoContacto"].Value = codigoContacto;

                comand.Parameters.Add(new SqlParameter("@Path", System.Data.SqlDbType.VarChar));
                comand.Parameters["@Path"].Value = path;

                if (comand.ExecuteNonQuery() > 0)
                {
                    mensaje = "La imagen se guardo correctamente";
                }
                else
                {
                    mensaje = "La imagen no se pudo guardar";
                }
                con.Close();
            }
            return mensaje;
        }

        // metodo para eliminar una foto
        public static string deleteImage(int codigoImagen)
        {
            string mensaje;
            using (SqlConnection con = Connection.getConnection())
            {
                SqlCommand comand = new SqlCommand();
                comand.CommandText = "deleteImage";
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.Connection = con;

                comand.Parameters.Add(new SqlParameter("@codigoImagen", System.Data.SqlDbType.Int));
                comand.Parameters["@codigoImagen"].Value = codigoImagen;

                if (comand.ExecuteNonQuery() > 0)
                {
                    mensaje = "La imagen se elimino correctamente";
                }
                else
                {
                    mensaje = "La imagen no se pudo eliminar";
                }
                con.Close();
            }
            return mensaje;
        }

        // metodo for getting all pictures
        public static List<Pictures> listPicture(int codigoContacto)
        {
            List<Pictures> list = new List<Pictures>();
            using (SqlConnection con = Connection.getConnection())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "listImages";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@codigoContacto", System.Data.SqlDbType.Int));
                comand.Parameters["@codigoContacto"].Value = codigoContacto;

                SqlDataReader re = comand.ExecuteReader();

                while (re.Read())
                {
                    Pictures pPicture = new Pictures();
                    pPicture.codigo = Convert.ToInt32(re["c"]);
                    pPicture.Path = re["p"].ToString();
                    pPicture.codigoContacto = Convert.ToInt32(re["cc"]);

                    list.Add(pPicture);
                }
                con.Close();
            }
            return list;
        }
    }
}
/// <summary>
/// Hecho por Albert Ramirez para Proyecto 3
/// Fecha: 4 Abril 2017
/// Correo: arbert.jr@hotmail.com
/// </summary>

