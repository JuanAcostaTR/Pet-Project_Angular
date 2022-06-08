using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MascotasWebApp.Models
{
    public class GestorMascota
    {

        public List<Mascota> getMascota()
        {
            List<Mascota> lista = new List<Mascota>();
            string strConn = ConfigurationManager.ConnectionStrings["BDLocal"].ToString();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Mascota_All";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string nombre = dr.GetString(1).Trim();
                    DateTime fechaNacimiento = dr.GetDateTime(2);
                    string observaciones = dr.GetString(3).Trim();
                    bool soporteEmocional = dr.GetBoolean(4);
                    bool lazarillo = dr.GetBoolean(5);
                    bool activo = dr.GetBoolean(6);
                    int idTipo = dr.GetInt32(7);

                    Mascota mascota = new Mascota(id, nombre, fechaNacimiento, observaciones, soporteEmocional, lazarillo, activo, idTipo);

                    lista.Add(mascota);
                }

                dr.Close();
                conn.Close();
            }

            return lista;
        }

        public bool addMascota(Mascota mascota)
        {
            bool res = false;

            string strConn = ConfigurationManager.ConnectionStrings["BDLocal"].ToString();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "Mascota_Add";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", mascota.Nombre);
                cmd.Parameters.AddWithValue("@FechaNacimiento", mascota.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Observacines", mascota.Observaciones);
                cmd.Parameters.AddWithValue("@SoporteEmocional", mascota.SoporteEmocional);
                cmd.Parameters.AddWithValue("@Lazarillo", mascota.Lazarillo);
                cmd.Parameters.AddWithValue("@IDTipo", mascota.IDTipo);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    res = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    res = false;
                    throw;
                }
                finally
                {
                    cmd.Parameters.Clear();
                    conn.Close();
                }

                return res;
            }
        }

        public bool updateMascota(int id, Mascota mascota)
        {
            bool res = false;

            string strConn = ConfigurationManager.ConnectionStrings["BDLocal"].ToString();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "Mascota_Update";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Nombre", mascota.Nombre);
                cmd.Parameters.AddWithValue("@FechaNacimiento", mascota.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Observacines", mascota.Observaciones);
                cmd.Parameters.AddWithValue("@SoporteEmocional", mascota.SoporteEmocional);
                cmd.Parameters.AddWithValue("@Lazarillo", mascota.Lazarillo);
                cmd.Parameters.AddWithValue("@IDTipo", mascota.IDTipo);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    res = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    res = false;
                    throw;
                }
                finally
                {
                    cmd.Parameters.Clear();
                    conn.Close();
                }

                return res;
            }
        }

        public bool deleteMascota(int id)
        {
            bool res = false;

            string strConn = ConfigurationManager.ConnectionStrings["BDLocal"].ToString();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "Mascota_Delete";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    res = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    res = false;
                    throw;
                }
                finally
                {
                    cmd.Parameters.Clear();
                    conn.Close();
                }

                return res;
            }
        }
    }
}