using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Sqlserver
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string connStr = "Server= USHYDYAMPALAM1; Database=Sept2024Db; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connStr);
            //conn.ConnectionString = connStr;

            string cmdText = " SELECT * FROM Product_table";
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter(cmdText, connStr);
            DataSet ds = new DataSet();

            adapter.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine("{0},{1},{2},{3},{4}", row["pid"].ToString(), row["pname"].ToString(), row["price"].ToString(), row["quantity"].ToString(), row["category"].ToString());
            }




            Console.ReadLine();




        }
    }
}
