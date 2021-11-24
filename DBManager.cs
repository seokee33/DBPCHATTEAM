using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBUI
{
    class DBManager
    {
        MySqlConnection conn = new MySqlConnection("Server=34.64.115.175;Port=3306;Database=CHAT;Uid=root;Pwd=dbp2021;Charset=utf8");
        //string str_conn = "Server=34.64.115.175;Port=3306;Database=CHAT;Uid=root;Pwd=dbp2021;Charset=utf8";
        //SqlConnection conn2 = new SqlConnection("Server=34.64.115.175;Port=3306;Database=CHAT;Uid=root;Pwd=dbp2021;Charset=utf8");
        DataSet ds = new DataSet();

        private DBManager() {
        }

        private static DBManager instance_ = new DBManager();

        public static DBManager GetInstance()
        {
            return instance_;
        }

        public DataSet select(string SQL, string dt)
        {

            ds.Clear();
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = SQL;
            da.SelectCommand = cmd;
            conn.Open();
            da.Fill(ds, dt);
            conn.Close();
            return ds;
        }
        public DataTable select2(string SQL)
        {

            ds.Clear();
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = conn.CreateCommand();
            DataTable dt = new DataTable();
            cmd.CommandText = SQL;
            da.SelectCommand = cmd;
            conn.Open();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public void executeQuerry(string SQL)
        {
            using (conn)
            {
                try
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(SQL, conn);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        public void insert_Image(PictureBox pbxImage,string sql,int imageID)
        {
            MemoryStream ms = new MemoryStream();
            pbxImage.Image.Save(ms,pbxImage.Image.RawFormat);
            byte[] img = ms.ToArray();
            try{
                conn.Open();
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.Add("@id", MySqlDbType.Int32,11);
                command.Parameters.Add("@img", MySqlDbType.Blob);

                command.Parameters["@id"].Value = imageID;
                command.Parameters["@img"].Value = img;
                conn.Close();
            }catch(Exception e){
                Console.WriteLine(e);
            }
            
        }

        public int exist(string SQL)
        {
            using (conn)
            {
                try
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(SQL, conn);
                    MySqlDataReader rdr = command.ExecuteReader();

                    rdr.Read();
                    int result = Convert.ToInt32(rdr["exist"]);
                    if (result == 0)
                        return 0;
                    else
                        return 1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return 99999;
                }
            }
        }
    }
}
