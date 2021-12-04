using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBUI
{
    class DBManager
    {
        DataSet ds = new DataSet();

        private DBManager()
        {
        }

        private static DBManager instance_ = new DBManager();

        public static DBManager GetInstance()
        {
            return instance_;
        }

        // SELECT
        public DataTable select(string SQL)
        {
            MySqlConnection conn = new MySqlConnection("Server=34.64.115.175;Port=3306;Database=CHAT;Uid=root;Pwd=dbp2021;Charset=utf8");

            DataTable dt = new DataTable();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = SQL;
                da.SelectCommand = cmd;
                conn.Open();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine(e.ToString());
                Console.WriteLine(SQL);
            }
            finally
            {
                conn.Close();
            }

            return null;

        }
        // UPDATE,DELETE,INSERT
        public void executeQuerry(string SQL)
        {
        MySqlConnection conn = new MySqlConnection("Server=34.64.115.175;Port=3306;Database=CHAT;Uid=root;Pwd=dbp2021;Charset=utf8");

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
                finally
                {
                    conn.Close();
                }
            }
        }
        public void msgexecuteQuerry(string SQL)
        {

            MySqlConnection msg_conn = new MySqlConnection("Server=34.64.115.175;Port=3306;Database=CHAT;Uid=root;Pwd=dbp2021;Charset=utf8");
            using (msg_conn)
            {
                try
                {
                    msg_conn.Open();
                    MySqlCommand command = new MySqlCommand(SQL, msg_conn);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    msg_conn.Close();
                }
            }
        }
        // 이미지가 포함된 정보를 DB에 넣을때 사용하는 쿼리
        // EX) 유저
        public void insert_Image(PictureBox pbxImage, string sql)
        {
            MySqlConnection conn = new MySqlConnection("Server=34.64.115.175;Port=3306;Database=CHAT;Uid=root;Pwd=dbp2021;Charset=utf8");

            MemoryStream ms = new MemoryStream();
            pbxImage.Image.Save(ms, pbxImage.Image.RawFormat);
            byte[] img = ms.ToArray();
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(sql, conn);

                command.Parameters.Add("@Image", MySqlDbType.Blob);
                command.Parameters["@Image"].Value = img;
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                conn.Close();
            }

        }
        public void update_Image(PictureBox pbxImage, string sql)
        {
            MySqlConnection conn = new MySqlConnection("Server=34.64.115.175;Port=3306;Database=CHAT;Uid=root;Pwd=dbp2021;Charset=utf8");

            MemoryStream ms = new MemoryStream();
            pbxImage.Image.Save(ms, pbxImage.Image.RawFormat);
            byte[] img = ms.ToArray();

            conn.Open();

            var command = new MySqlCommand(sql, conn);

            var paramUserImage = new MySqlParameter("@Image", MySqlDbType.Blob, img.Length);

            paramUserImage.Value = img;

            command.Parameters.Add(paramUserImage);

            command.ExecuteNonQuery();

            conn.Close();

        }
        // 유저 한명을 가져오는 쿼리
        public UserInfo select_profile(string SQL)
        {
            MySqlConnection conn = new MySqlConnection("Server=34.64.115.175;Port=3306;Database=CHAT;Uid=root;Pwd=dbp2021;Charset=utf8");
            UserInfo user = new UserInfo();
            DataTable datatable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = SQL;
            da.SelectCommand = cmd;
            conn.Open();
            da.Fill(datatable);
            conn.Close();
            Byte[] bytes = null;

            RoundPictureBox pb = new RoundPictureBox();
            try
            {
                bytes = (byte[])datatable.Rows[0][7];
                if (bytes != null)
                {
                    pb.Image = new Bitmap(new MemoryStream(bytes));
                }
            }
            catch
            {
                pb = null;
            }
            finally
            {
                conn.Close();
            }

            user = new UserInfo(Convert.ToInt32(datatable.Rows[0][0]), Convert.ToString(datatable.Rows[0][1]), Convert.ToString(datatable.Rows[0][2]), Convert.ToString(datatable.Rows[0][3]), Convert.ToDateTime(datatable.Rows[0][4]), Convert.ToString(datatable.Rows[0][5]), Convert.ToString(datatable.Rows[0][6]), pb);


            return user;

        }


        public List<EmoticonInfo> select_Emoticon(string SQL)
        {
            MySqlConnection conn = new MySqlConnection("Server=34.64.115.175;Port=3306;Database=CHAT;Uid=root;Pwd=dbp2021;Charset=utf8");
            List<EmoticonInfo> emoticons = new List<EmoticonInfo>();
            DataTable datatable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = SQL;
            da.SelectCommand = cmd;
            conn.Open();
            da.Fill(datatable);
            conn.Close();
            Byte[] bytes = null;

            PictureBox pb = new PictureBox();
            try
            {
                foreach(DataRow data in datatable.Rows)
                {
                    bytes = (byte[])data[1];
                    if (bytes != null)
                    {
                        pb.Image = new Bitmap(new MemoryStream(bytes));
                    }
                    emoticons.Add(new EmoticonInfo(Convert.ToInt32(data[0]),pb));
                }
                
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }


            return emoticons;

        }
        //친구목록을 가져오는 쿼리문
        public List<UserInfo> select_Friends(string SQL)
        {

            MySqlConnection conn = new MySqlConnection("Server=34.64.115.175;Port=3306;Database=CHAT;Uid=root;Pwd=dbp2021;Charset=utf8");

            List<UserInfo> result = new List<UserInfo>();
            //try
            //{
            //string SQL = "SELECT * FROM CHAT.UserInfo;";
            DataTable datatable = new DataTable();//DB로 부터 가져온 값을 넣는 곳(DataSet)
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = SQL;
            da.SelectCommand = cmd;
            conn.Open();
            da.Fill(datatable);
            conn.Close();
            Byte[] bytes = null;
            foreach (DataRow data in datatable.Rows)
            {
                RoundPictureBox pb = new RoundPictureBox();
                try
                {
                    bytes = (byte[])data[6];
                    if (bytes != null)
                    {
                        pb.Image = new Bitmap(new MemoryStream(bytes));
                    }
                }
                catch
                {
                    pb = null;
                }
                finally
                {
                    conn.Close();
                }

                result.Add(new UserInfo(Convert.ToInt32(data[0]), Convert.ToInt32(data[1]), Convert.ToString(data[2]), Convert.ToString(data[3]), Convert.ToDateTime(data[4]), Convert.ToString(data[5]), pb));
            }
            //}
            //catch
            //{
            //    return null;
            //}
            return result;
        }

        public void init()
        {
            MySqlConnection conn = new MySqlConnection("Server=34.64.115.175;Port=3306;Database=CHAT;Uid=root;Pwd=dbp2021;Charset=utf8");
            try
            {
                conn.Close();
            }
            catch
            {
                return;
            }
            finally
            {
                conn.Close();
            }

        }
        //DB 정보의 유무를 확인하는 쿼리
        public int exist(string SQL)
        {
            MySqlConnection conn = new MySqlConnection("Server=34.64.115.175;Port=3306;Database=CHAT;Uid=root;Pwd=dbp2021;Charset=utf8");

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
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
