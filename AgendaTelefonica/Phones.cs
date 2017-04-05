using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AgendaTelefonica
{
    public class Phones
    {
        /// <summary>
        /// Hecho por Albert Ramirez para Proyecto 3
        /// Fecha: 4 Abril 2017
        /// Correo: arbert.jr@hotmail.com
        /// </summary>

        public int codigo { get; set; }
        public string Telefono { get; set; }
        public string Tipo { get; set; }

        public Phones() { }
        public Phones(int c, string t, string ti)
        {
            codigo = c;
            Telefono = t;
            Tipo = ti;
        }

        public static string addNewPhone(int codigoContacto, string telefono, string tipo)
        {
            string mensaje = null;
            using (SqlConnection con = Connection.getConnection())
            {
                if (tipo == "casa")
                {
                    SqlCommand comand = new SqlCommand();
                    comand.Connection = con;
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    comand.CommandText = "addHouse";

                    comand.Parameters.Add(new SqlParameter("@Telefono", System.Data.SqlDbType.VarChar));
                    comand.Parameters["@Telefono"].Value = telefono;

                    comand.Parameters.Add(new SqlParameter("@codigoContacto", System.Data.SqlDbType.Int));
                    comand.Parameters["@codigoContacto"].Value = codigoContacto;

                    int r = comand.ExecuteNonQuery();

                    if (r > 0)
                    {
                        mensaje = "El Telefono de casa:" + telefono + " fue añadido con exito";
                    }
                    else
                    {
                        mensaje = "No se pudo añadir el telefono de casa";
                    }
                    con.Close();
                }
                else if (tipo == "trabajo")
                {
                    SqlCommand comand = new SqlCommand();
                    comand.Connection = con;
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    comand.CommandText = "addWork";

                    comand.Parameters.Add(new SqlParameter("@Telefono", System.Data.SqlDbType.VarChar));
                    comand.Parameters["@Telefono"].Value = telefono;

                    comand.Parameters.Add(new SqlParameter("@codigoContacto", System.Data.SqlDbType.Int));
                    comand.Parameters["@codigoContacto"].Value = codigoContacto;

                    int r = comand.ExecuteNonQuery();

                    if (r > 0)
                    {
                        mensaje = "El Telefono del trabajo:" + telefono + " fue añadido con exito";
                    }
                    else
                    {
                        mensaje = "No se pudo añadir el telefono del trabajo";
                    }
                    con.Close();
                }
                else if (tipo == "celular")
                {
                    SqlCommand comand = new SqlCommand();
                    comand.Connection = con;
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    comand.CommandText = "addCellPhone";

                    comand.Parameters.Add(new SqlParameter("@Telefono", System.Data.SqlDbType.VarChar));
                    comand.Parameters["@Telefono"].Value = telefono;

                    comand.Parameters.Add(new SqlParameter("@codigoContacto", System.Data.SqlDbType.Int));
                    comand.Parameters["@codigoContacto"].Value = codigoContacto;

                    int r = comand.ExecuteNonQuery();

                    if(r > 0)
                    {
                        mensaje = "El Celular:" + telefono + " fue añadido con exito";
                    }
                    else
                    {
                        mensaje = "No se pudo añadir el celular";
                    }
                    con.Close();
                }
            }
            return mensaje;
        }

        public static string deletePhone(int codigoContacto, string Telefono, string tipo)
        {
            string mensaje = null;
            using (SqlConnection con = Connection.getConnection())
            {
                if (tipo == "casa")
                {
                    SqlCommand casa = new SqlCommand();
                    casa.Connection = con;
                    casa.CommandType = System.Data.CommandType.StoredProcedure;
                    casa.CommandText = "deleteHouse";

                    casa.Parameters.Add(new SqlParameter("@numero", System.Data.SqlDbType.VarChar));
                    casa.Parameters["@numero"].Value = Telefono;

                    casa.Parameters.Add(new SqlParameter("@codigoContacto", System.Data.SqlDbType.Int));
                    casa.Parameters["@codigoContacto"].Value = codigoContacto;

                    if(casa.ExecuteNonQuery() > 0)
                    {
                        mensaje = "Telefono Eliminado correctamente";
                    }
                    else
                    {
                        mensaje = "No se pudo Eliminar el Telefono";
                    }
                }
                else if (tipo == "celular")
                {
                    SqlCommand celular = new SqlCommand();
                    celular.Connection = con;
                    celular.CommandText = "deleteCellphone";
                    celular.CommandType = System.Data.CommandType.StoredProcedure;

                    celular.Parameters.Add(new SqlParameter("@numero", System.Data.SqlDbType.VarChar));
                    celular.Parameters["@numero"].Value = Telefono;

                    celular.Parameters.Add(new SqlParameter("@codigoContacto", System.Data.SqlDbType.Int));
                    celular.Parameters["@codigoContacto"].Value = codigoContacto;

                    if (celular.ExecuteNonQuery() > 0)
                    {
                        mensaje = "Telefono Eliminado correctamente";
                    }
                    else
                    {
                        mensaje = "No se pudo Eliminar el Telefono";
                    }
                }
                else if(tipo == "trabajo")
                {
                    SqlCommand trabajo = new SqlCommand();
                    trabajo.Connection = con;
                    trabajo.CommandText = "deleteWork";
                    trabajo.CommandType = System.Data.CommandType.StoredProcedure;

                    trabajo.Parameters.Add(new SqlParameter("@numero", System.Data.SqlDbType.VarChar));
                    trabajo.Parameters["@numero"].Value = Telefono;

                    trabajo.Parameters.Add(new SqlParameter("@codigoContacto", System.Data.SqlDbType.Int));
                    trabajo.Parameters["@codigoContacto"].Value = codigoContacto;

                    if (trabajo.ExecuteNonQuery() > 0)
                    {
                        mensaje = "Telefono Eliminado correctamente";
                    }
                    else
                    {
                        mensaje = "No se pudo Eliminar el Telefono";
                    }
                }
                else
                {
                    mensaje = "No se pudo identificar el numero a borrar, Intentelo nuevamente";
                }
                con.Close();
            }
            return mensaje;
        }

        public static string modifyPhone(int codigoContacto, int codigoNumero, string telefono, string tipo)
        {
            string mensaje = null;
            using(SqlConnection con = Connection.getConnection())
            {
                if(tipo == "casa")
                {
                    SqlCommand comand = new SqlCommand();
                    comand.Connection = con;
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    comand.CommandText = "modifyHouse";

                    comand.Parameters.Add(new SqlParameter("@codigoContacto", System.Data.SqlDbType.Int));
                    comand.Parameters["@codigoContacto"].Value = codigoContacto;

                    comand.Parameters.Add(new SqlParameter("@codigoNumero", System.Data.SqlDbType.Int));
                    comand.Parameters["@codigoNumero"].Value = codigoNumero;

                    comand.Parameters.Add(new SqlParameter("@telefono", System.Data.SqlDbType.VarChar));
                    comand.Parameters["@telefono"].Value = telefono;

                    if(comand.ExecuteNonQuery() > 0)
                    {
                        mensaje = "El telefono fue modificado correctamente; el nuevo telefono es: " + telefono;
                    }
                    else
                    {
                        mensaje = "No se pudo modificar el telefono";
                    }
                }
                else if(tipo == "celular")
                {
                    SqlCommand comand = new SqlCommand();
                    comand.Connection = con;
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    comand.CommandText = "modifyCellphone";

                    comand.Parameters.Add(new SqlParameter("@codigoContacto", System.Data.SqlDbType.Int));
                    comand.Parameters["@codigoContacto"].Value = codigoContacto;

                    comand.Parameters.Add(new SqlParameter("@codigoNumero", System.Data.SqlDbType.Int));
                    comand.Parameters["@codigoNumero"].Value = codigoNumero;

                    comand.Parameters.Add(new SqlParameter("@telefono", System.Data.SqlDbType.VarChar));
                    comand.Parameters["@telefono"].Value = telefono;

                    if (comand.ExecuteNonQuery() > 0)
                    {
                        mensaje = "El telefono fue modificado correctamente; el nuevo telefono es: " + telefono;
                    }
                    else
                    {
                        mensaje = "No se pudo modificar el telefono";
                    }
                }
                else if(tipo == "trabajo")
                {
                    SqlCommand comand = new SqlCommand();
                    comand.Connection = con;
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    comand.CommandText = "modifyWork";

                    comand.Parameters.Add(new SqlParameter("@codigoContacto", System.Data.SqlDbType.Int));
                    comand.Parameters["@codigoContacto"].Value = codigoContacto;

                    comand.Parameters.Add(new SqlParameter("@codigoNumero", System.Data.SqlDbType.Int));
                    comand.Parameters["@codigoNumero"].Value = codigoNumero;

                    comand.Parameters.Add(new SqlParameter("@telefono", System.Data.SqlDbType.VarChar));
                    comand.Parameters["@telefono"].Value = telefono;

                    if (comand.ExecuteNonQuery() > 0)
                    {
                        mensaje = "El telefono fue modificado correctamente; el nuevo telefono es: " + telefono;
                    }
                    else
                    {
                        mensaje = "No se pudo modificar el telefono";
                    }
                }
                con.Close();
            }
            return mensaje;
        }

        public static Phones getPhoneInfo(int codigoContacto, string telefono, string tipo)
        {
            Phones pInfoPhone = new Phones();
            using (SqlConnection con = Connection.getConnection())
            {
                if(tipo == "casa")
                {
                    SqlCommand comand = new SqlCommand();
                    comand.Connection = con;
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    comand.CommandText = "getPhoneHouse";

                    comand.Parameters.Add(new SqlParameter("@codigoContacto", System.Data.SqlDbType.Int));
                    comand.Parameters["@codigoContacto"].Value = codigoContacto;

                    comand.Parameters.Add(new SqlParameter("@telefono", System.Data.SqlDbType.VarChar));
                    comand.Parameters["@telefono"].Value = telefono;

                    SqlDataReader re = comand.ExecuteReader();
                    if (re.Read())
                    {
                        pInfoPhone.codigo = Convert.ToInt32(re["c"]);
                        pInfoPhone.Telefono = re["t"].ToString();
                        pInfoPhone.Tipo = "casa";
                    }
                    else
                    {
                        pInfoPhone = null;
                    }
                }
                else if(tipo == "celular")
                {
                    SqlCommand comand = new SqlCommand();
                    comand.Connection = con;
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    comand.CommandText = "getPhoneCellphone";

                    comand.Parameters.Add(new SqlParameter("@codigoContacto", System.Data.SqlDbType.Int));
                    comand.Parameters["@codigoContacto"].Value = codigoContacto;

                    comand.Parameters.Add(new SqlParameter("@telefono", System.Data.SqlDbType.VarChar));
                    comand.Parameters["@telefono"].Value = telefono;

                    SqlDataReader re = comand.ExecuteReader();
                    if (re.Read())
                    {
                        pInfoPhone.codigo = Convert.ToInt32(re["c"]);
                        pInfoPhone.Telefono = re["t"].ToString();
                        pInfoPhone.Tipo = "celular";
                    }
                    else
                    {
                        pInfoPhone = null;
                    }
                }
                else if(tipo == "trabajo")
                {
                    SqlCommand comand = new SqlCommand();
                    comand.Connection = con;
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    comand.CommandText = "getPhoneWork";

                    comand.Parameters.Add(new SqlParameter("@codigoContacto", System.Data.SqlDbType.Int));
                    comand.Parameters["@codigoContacto"].Value = codigoContacto;

                    comand.Parameters.Add(new SqlParameter("@telefono", System.Data.SqlDbType.VarChar));
                    comand.Parameters["@telefono"].Value = telefono;

                    SqlDataReader re = comand.ExecuteReader();
                    if (re.Read())
                    {
                        pInfoPhone.codigo = Convert.ToInt32(re["c"]);
                        pInfoPhone.Telefono = re["t"].ToString();
                        pInfoPhone.Tipo = "trabajo";
                    }
                    else
                    {
                        pInfoPhone = null;
                    }
                }
                con.Close();
            }
            return pInfoPhone;
        }

        // metodos para validar los numeros de telefonos tipos object
        public static pBasePhones validateCellphoneSame(int codigoContacto, string telefono)
        {
            pBasePhones pInfoPhone = new pBasePhones();
            using (SqlConnection con = Connection.getConnection())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.CommandText = "CellphoneValidationSame";

                comand.Parameters.Add(new SqlParameter("@codigoContacto", System.Data.SqlDbType.Int));
                comand.Parameters["@codigoContacto"].Value = codigoContacto;

                comand.Parameters.Add(new SqlParameter("@telefono", System.Data.SqlDbType.VarChar));
                comand.Parameters["@telefono"].Value = telefono;

                SqlDataReader re = comand.ExecuteReader();

                if (re.Read())
                {
                    pInfoPhone.codigo = Convert.ToInt32(re["c"]);
                    pInfoPhone.Telefono = re["t"].ToString();
                    pInfoPhone.codigoContacto = Convert.ToInt32(re["con"]);
                    pInfoPhone.Tipo = "celular";
                }
                else
                {
                    pInfoPhone = null;
                }
                con.Close();
            }
            return pInfoPhone;
        }
        public static pBasePhones validateHouseSame(int codigoContacto, string telefono)
        {
            pBasePhones pInfoPhone = new pBasePhones();
            using (SqlConnection con = Connection.getConnection())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.CommandText = "houseValidationSame";

                comand.Parameters.Add(new SqlParameter("@codigoContacto", System.Data.SqlDbType.Int));
                comand.Parameters["@codigoContacto"].Value = codigoContacto;

                comand.Parameters.Add(new SqlParameter("@telefono", System.Data.SqlDbType.VarChar));
                comand.Parameters["@telefono"].Value = telefono;

                SqlDataReader re = comand.ExecuteReader();

                if (re.Read())
                {
                    pInfoPhone.codigo = Convert.ToInt32(re["c"]);
                    pInfoPhone.Telefono = re["t"].ToString();
                    pInfoPhone.codigoContacto = Convert.ToInt32(re["con"]);
                    pInfoPhone.Tipo = "casa";
                }
                else
                {
                    pInfoPhone = null;
                }
                con.Close();
            }
            return pInfoPhone;
        }
        public static pBasePhones validateWorkSame(int codigoContacto, string telefono)
        {
            pBasePhones pInfoPhone = new pBasePhones();
            using (SqlConnection con = Connection.getConnection())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.CommandText = "WorkValidationSame";

                comand.Parameters.Add(new SqlParameter("@codigoContacto", System.Data.SqlDbType.Int));
                comand.Parameters["@codigoContacto"].Value = codigoContacto;

                comand.Parameters.Add(new SqlParameter("@telefono", System.Data.SqlDbType.VarChar));
                comand.Parameters["@telefono"].Value = telefono;

                SqlDataReader re = comand.ExecuteReader();

                if (re.Read())
                {
                    pInfoPhone.codigo = Convert.ToInt32(re["c"]);
                    pInfoPhone.Telefono = re["t"].ToString();
                    pInfoPhone.codigoContacto = Convert.ToInt32(re["con"]);
                    pInfoPhone.Tipo = "trabajo";
                }
                else
                {
                    pInfoPhone = null;
                }
                con.Close();
            }
            return pInfoPhone;
        }
        public static pBasePhones validateWorkDiff(int codigoContacto, string telefono)
        {
            pBasePhones pInfoPhone = new pBasePhones();
            using (SqlConnection con = Connection.getConnection())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.CommandText = "workValidationDiff";

                comand.Parameters.Add(new SqlParameter("@codigoContacto", System.Data.SqlDbType.Int));
                comand.Parameters["@codigoContacto"].Value = codigoContacto;

                comand.Parameters.Add(new SqlParameter("@telefono", System.Data.SqlDbType.VarChar));
                comand.Parameters["@telefono"].Value = telefono;

                SqlDataReader re = comand.ExecuteReader();

                if (re.Read())
                {
                    pInfoPhone.codigo = Convert.ToInt32(re["c"]);
                    pInfoPhone.Telefono = re["t"].ToString();
                    pInfoPhone.codigoContacto = Convert.ToInt32(re["con"]);
                    pInfoPhone.Tipo = "trabajo";
                }
                else
                {
                    pInfoPhone = null;
                }
                con.Close();
            }
            return pInfoPhone;
        }
        public static pBasePhones validateCellphoneDiff(int codigoContacto, string telefono)
        {
            pBasePhones pInfoPhone = new pBasePhones();
            using (SqlConnection con = Connection.getConnection())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.CommandText = "CellphoneValidationDiff";

                comand.Parameters.Add(new SqlParameter("@codigoContacto", System.Data.SqlDbType.Int));
                comand.Parameters["@codigoContacto"].Value = codigoContacto;

                comand.Parameters.Add(new SqlParameter("@telefono", System.Data.SqlDbType.VarChar));
                comand.Parameters["@telefono"].Value = telefono;

                SqlDataReader re = comand.ExecuteReader();

                if (re.Read())
                {
                    pInfoPhone.codigo = Convert.ToInt32(re["c"]);
                    pInfoPhone.Telefono = re["t"].ToString();
                    pInfoPhone.codigoContacto = Convert.ToInt32(re["con"]);
                    pInfoPhone.Tipo = "celular";
                }
                else
                {
                    pInfoPhone = null;
                }
                con.Close();
            }
            return pInfoPhone;
        }
        public static pBasePhones validateHouseDiff(int codigoContacto, string telefono)
        {
            pBasePhones pInfoPhone = new pBasePhones();
            using (SqlConnection con = Connection.getConnection())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.CommandText = "houseValidationDiff";

                comand.Parameters.Add(new SqlParameter("@codigoContacto", System.Data.SqlDbType.Int));
                comand.Parameters["@codigoContacto"].Value = codigoContacto;

                comand.Parameters.Add(new SqlParameter("@telefono", System.Data.SqlDbType.VarChar));
                comand.Parameters["@telefono"].Value = telefono;

                SqlDataReader re = comand.ExecuteReader();

                if (re.Read())
                {
                    pInfoPhone.codigo = Convert.ToInt32(re["c"]);
                    pInfoPhone.Telefono = re["t"].ToString();
                    pInfoPhone.codigoContacto = Convert.ToInt32(re["con"]);
                    pInfoPhone.Tipo = "casa";
                }
                else
                {
                    pInfoPhone = null;
                }
                con.Close();
            }
            return pInfoPhone;
        }

        // metodo para validar el numero en diferentes contactos
        public static bool validatePhoneDiff(int codigoContacto, string telefono)
        {
            bool validation = false;

            // validar el celular
            if(validateCellphoneDiff(codigoContacto, telefono) != null)
            {
                validation = true;
            }

            // validar el telefono de la casa
            if(validateHouseDiff(codigoContacto, telefono) != null)
            {
                validation = true;
            }

            // validar el trabajo
            if (validateWorkDiff(codigoContacto, telefono) != null)
            {
                validation = true;
            }

            return validation;
        }

        // metodo para validar el numero en el mismo contacto
        public static bool validatePhoneSame(int codigoContacto, string telefono)
        {
            bool validation = false;
            
            // para validar el celular
            if(validateCellphoneSame(codigoContacto, telefono) != null)
            {
                validation = true;
            }

            // para validar el telefono de la casa
            if(validateHouseSame(codigoContacto, telefono) != null)
            {
                validation = true;
            }

            // para validar el telefono del trabajo
            if(validateWorkSame(codigoContacto, telefono) != null)
            {
                validation = true;
            }

            return validation;
        }

        // metodo para obtener el nombre del contacto que tiene el numero registrado
        public static string getContactNameDiff(int codigoContacto, string telefono)
        {
            string mensaje = "El Numero de telefono ya esta registrado en el/los contacto(s): \n";

            // para obtener la informacion de los contactos que tienen el numero registrado 
            if (validateCellphoneDiff(codigoContacto, telefono) != null)
            {
                pBasePhones pPhoneInfo = validateCellphoneDiff(codigoContacto, telefono);
                Contact pInfoContact = Contact.getInfoContactWID(pPhoneInfo.codigoContacto);
                mensaje += pInfoContact.name + " " + pInfoContact.lastName + " como parte del numero de: " + pPhoneInfo.Tipo + "\n";
            }

            if (validateHouseDiff(codigoContacto, telefono) != null)
            {
                pBasePhones pPhoneInfo = validateHouseDiff(codigoContacto, telefono);
                Contact pInfoContact = Contact.getInfoContactWID(pPhoneInfo.codigoContacto);
                mensaje += pInfoContact.name + " " + pInfoContact.lastName + " como parte del numero de: " + pPhoneInfo.Tipo + "\n";
            }

            if (validateWorkDiff(codigoContacto, telefono) != null)
            {
                pBasePhones pPhoneInfo = validateWorkDiff(codigoContacto, telefono);
                Contact pInfoContact = Contact.getInfoContactWID(pPhoneInfo.codigoContacto);
                mensaje += pInfoContact.name + " " + pInfoContact.lastName + " como parte del numero de: " + pPhoneInfo.Tipo + "\n";
            }

            return mensaje;
        }

        // metodo para obtener en donde esta registrado el numero de telefono
        public static string getContactNameSame(int codigoContacto, string telefono)
        {
            string mensaje = "El Numero de telefono ya esta registrado como parte del numero de: \n";

            // para obtener la informacion de los contactos que tienen el numero registrado 
            if (validateCellphoneSame(codigoContacto, telefono) != null)
            {
                pBasePhones pPhoneInfo = validateCellphoneSame(codigoContacto, telefono);
                mensaje +="-" + pPhoneInfo.Tipo + "\n";
            }

            if (validateHouseSame(codigoContacto, telefono) != null)
            {
                pBasePhones pPhoneInfo = validateHouseSame(codigoContacto, telefono);
                mensaje += "-" + pPhoneInfo.Tipo + "\n";
            }

            if (validateWorkSame(codigoContacto, telefono) != null)
            {
                pBasePhones pPhoneInfo = validateWorkSame(codigoContacto, telefono);
                mensaje += "-" + pPhoneInfo.Tipo + "\n";
            }

            return mensaje;
        }
    }
    public class pBasePhones
    {
        public int codigo { get; set; }
        public string Telefono { get; set; }
        public string NombreContacto { get; set; }
        public int codigoContacto { get; set; }
        public string Tipo { get; set; }

        public pBasePhones() { }
        public pBasePhones(int c, string te, string n, int cc, string ti)
        {
            codigo = c;
            Telefono = te;
            NombreContacto = n;
            codigoContacto = cc;
            Tipo = ti;
        }
    }
}
/// <summary>
/// Hecho por Albert Ramirez para Proyecto 3
/// Fecha: 4 Abril 2017
/// Correo: arbert.jr@hotmail.com
/// </summary>
