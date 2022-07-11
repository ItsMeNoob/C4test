using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4test.Classes
{
    internal class Query
    {
        Conn conn = new Conn();
        private string query = null;
        private NpgsqlCommand cmd;


        public bool LoginSuccessful(string username, string password)
        {
            bool st;
            if (string.IsNullOrEmpty(username) == false && string.IsNullOrEmpty(password) == false)
            {

                try
                {

                    conn.connection.Open();
                    query = @"select * from userloginVeryf(:puser,:ppassword)";

                    cmd = new Npgsql.NpgsqlCommand(query, conn.connection);

                    cmd.Parameters.AddWithValue("puser", username);
                    cmd.Parameters.AddWithValue("ppassword", password);


                    st = (bool)cmd.ExecuteScalar();
                    conn.connection.Close();

                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                st = false;
            }

            return st;
        }

        public DataTable GetData()
        {
            string aceptingNewVisits;
            string Projectenabled;
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Project name", typeof(string));
            dt.Columns.Add("Project enabled", typeof(string));
            dt.Columns.Add("Acepting new visits", typeof(string));
            dt.Columns.Add("Suported image type", typeof(string));


            try
                {

                    conn.connection.Open();
                    query = "SELECT *	FROM public.\"gridView\" ";


                cmd = new Npgsql.NpgsqlCommand(query, conn.connection);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (Boolean.TryParse(dr[5].ToString(), out bool anv)&& anv ==true)
                    {
                        aceptingNewVisits = "YES";
                    }
                    else
                    {
                        aceptingNewVisits = "NO";
                    }
                    if (int.TryParse(dr[4].ToString(), out int inv)&& inv ==1)
                    {
                        Projectenabled = "YES";
                    }
                    else
                    {
                        Projectenabled = "NO";
                    }

                    dt.Rows.Add(dr[0].ToString(), dr[1].ToString(), Projectenabled, aceptingNewVisits, dr[3].ToString());
                    
                   
                }

                   
                    conn.connection.Close();

                }
                catch (Exception)
                {

                    throw;
                }
            
           

            return dt;
        }
        public bool updatedata(int id, string name, int suportedimagetypes, int projectEnabled, bool acceptingNewVisits)
        {
            bool unetoUspesno;


            try
            {

                query = @"CALL public.updateproject(	:id, :namep, 	:suportedimagetypes, 	:projectenabled, 	:acceptingnewvisits)";
              


                cmd = new Npgsql.NpgsqlCommand(query, conn.connection);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("namep", name);
                cmd.Parameters.AddWithValue("suportedimagetypes", suportedimagetypes);
                cmd.Parameters.AddWithValue("projectenabled", projectEnabled);
                cmd.Parameters.AddWithValue("acceptingnewvisits", acceptingNewVisits);
                conn.connection.Open();
                cmd.ExecuteReader();
                //NpgsqlDataReader dr = cmd.ExecuteReader();



                unetoUspesno = true;



            }
            catch (Exception)
            {
                unetoUspesno = false;
                
            }
            finally
            {

                conn.connection.Close();
            }

            return unetoUspesno;


        }

        public bool insertdata(string name, int suportedimagetypes, int projectEnabled, bool acceptingNewVisits)
        {
            bool unetoUspesno;


            try
            {


               
                 query = "CALL public.insertproject( @namep, @suportedimagetypes, @projectenabled, @acceptingnewvisits );";


                cmd = new Npgsql.NpgsqlCommand(query, conn.connection);
                cmd.Parameters.AddWithValue("namep", name);
                cmd.Parameters.AddWithValue("suportedimagetypes", suportedimagetypes);
                cmd.Parameters.AddWithValue("projectenabled", projectEnabled);
                cmd.Parameters.AddWithValue("acceptingnewvisits", acceptingNewVisits);
                conn.connection.Open();
                cmd.ExecuteReader();
               



                unetoUspesno = true;



            }
            catch (Exception)
            {
                unetoUspesno = false;
               
                
            }
            finally {

                conn.connection.Close();
            }

            return unetoUspesno;

            
        }



    }
}
