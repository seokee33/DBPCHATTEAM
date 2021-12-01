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
        MySqlConnection conn = new MySqlConnection("Server=34.64.115.175;Port=3306;Database=CHAT;Uid=root;Pwd=dbp2021;Charset=utf8");
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
        // UPDATE,DELETE,INSERT
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
        // 이미지가 포함된 정보를 DB에 넣을때 사용하는 쿼리
        // EX) 유저
        public void insert_Image(PictureBox pbxImage, string sql)
        {
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

        }
        public void update_Image(PictureBox pbxImage, string sql)
        {
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

            user = new UserInfo(Convert.ToInt32(datatable.Rows[0][0]), Convert.ToString(datatable.Rows[0][1]), Convert.ToString(datatable.Rows[0][2]), Convert.ToString(datatable.Rows[0][3]), Convert.ToDateTime(datatable.Rows[0][4]), Convert.ToString(datatable.Rows[0][5]), Convert.ToString(datatable.Rows[0][6]), pb);


            return user;

        }

        //친구목록을 가져오는 쿼리문
        public List<UserInfo> select_Friends(string SQL)
        {
            List<UserInfo> result = new List<UserInfo>();
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
                    bytes = (byte[])data[5];
                    if (bytes != null)
                    {
                        pb.Image = new Bitmap(new MemoryStream(bytes));
                    }
                }
                catch
                {
                    pb = null;
                }

                result.Add(new UserInfo(Convert.ToInt32(data[0]), Convert.ToString(data[1]), Convert.ToString(data[2]), Convert.ToDateTime(data[3]), Convert.ToString(data[4]), pb));
            }

            return result;
        }

        //DB 정보의 유무를 확인하는 쿼리
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
