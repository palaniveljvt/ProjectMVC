using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ConsoleApp1
{
    class Program
    {
        DataSet Data = new DataSet();
        static void Main(string[] args)
        {
            //using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["localConnection"].ConnectionString))
            //{
            //    var cmd = new SqlCommand("select * From shippers", connection);
            //    connection.Open();
            //    using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
            //    {
            //        while (sqlDataReader.Read())
            //        {
            //            Console.WriteLine(string.Format("shipper id is {0}, shipper name is {1} and shipper Phone is {2}", sqlDataReader[0], sqlDataReader[1], sqlDataReader[2]));

            //        }
            //    }
            //}
            //Console.ReadLine();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["localConnection"].ConnectionString))
            {
                var cmd = "select * From shippers";
                connection.Open();
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(cmd, connection);
                DataSet ss = new DataSet();
                SqlDataAdapter.Fill(ss);
                foreach (DataTable dr in ss.Tables)
                {
                    foreach(DataRow dt in dr.Rows)
                    {
                        
                            Console.WriteLine(dt["ShipperID"]);
                        
                    }
                }
                Console.ReadLine();

            }
        }
    }
}
