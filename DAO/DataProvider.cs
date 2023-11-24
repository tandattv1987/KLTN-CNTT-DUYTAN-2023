using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data;
using System.Drawing;


namespace QUANLYBANHANG.DAO
{
    public class DataProvider
    {

        private static DataProvider instance; //Ctrl+R+E

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }


        //private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=QLBH;User ID=QLBH;Password=11";
        private string connectionString = "Data Source = .\\SQLEXPRESS;User ID = qlbh; Password=11;Connect Timeout = 30; Encrypt=False;Trust Server Certificate=False;Application Intent = ReadWrite; Multi Subnet Failover=False";

        public DataTable ExecuteQuery(string query, object[] parameter = null)
                {
            //if (parameter is null)
            //{
            //    throw new ArgumentNullException(nameof(parameter));
            //}

            DataTable data = new DataTable();
            SqlConnection connection;
            using (connection = new SqlConnection(connectionString))
            {   //open connection
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                //if (parameter != null)
                //{
                //    string[] listParam = query.Split(' ');
                //     int i = 0;
                //    foreach (string item in listParam)
                //    {
                //        if (item.Contains('@'))
                //       {
                //command.Parameters.AddWithValue(item, parameter[i]);
                //           i++;
                //        }
                //   }
                //}
                command.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            SqlConnection connection;

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listParam = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParam)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        //SELECT count *
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            SqlConnection connection;
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listParam = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParam)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}
