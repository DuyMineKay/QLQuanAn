using System.Data;
using System.Data.SqlClient;

namespace QLQuanAn.DAO
{
    internal class DataProvider
    {
        private static DataProvider instance; /*đóng gói ctrl + R + E */

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        private string connectionSTR = "Data Source=DESKTOP-DMK\\DMK;Initial Catalog=QLQuanAn;Integrated Security=True";/* bỏ Trust Server Certificate=True*/

        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {

            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {


                connection.Open(); /*mở kết nối*/

                SqlCommand conmand = new SqlCommand(query, connection);


                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            conmand.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(conmand);

                adapter.Fill(data);

                connection.Close(); /*đóng kết nối*/
            }

            return data;
        }


        public int ExcuteNonQuery(string query, object[] parameter = null)
        {

            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {


                connection.Open(); /*mở kết nối*/

                SqlCommand conmand = new SqlCommand(query, connection);


                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            conmand.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = conmand.ExecuteNonQuery();


                connection.Close(); /*đóng kết nối*/
            }

            return data;
        }

        public object ExcuteScalar(string query, object[] parameter = null)
        {

            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {


                connection.Open(); /*mở kết nối*/

                SqlCommand conmand = new SqlCommand(query, connection);


                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            conmand.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = conmand.ExecuteScalar();


                connection.Close(); /*đóng kết nối*/
            }

            return data;
        }
    }
}
