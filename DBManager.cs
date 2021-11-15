using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUI
{
    class DBManager
    {
        MySqlConnection conn = new MySqlConnection("Server=34.64.115.175;Port=3306;Database=CHAT;Uid=root;Pwd=dbp2021;Charset=utf8");
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
