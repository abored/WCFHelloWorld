using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HelloServer
{
    public class DBAccess : IDBAccess
    {
        public string GetNameID(int id)
        {
            Random randomGen = new Random();
            
            Thread.Sleep(randomGen.Next(1000,5000));
            string name = "";
            SqlConnection con = new SqlConnection("Server=tcp:dingler.database.windows.net,1433;Database=MyFirstSQL;User ID=dingler@dingler;Password=Gpgf23!qazqaz;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            SqlCommand com = new SqlCommand("SELECT * FROM Customer WHERE ID=" + id,con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                name = (string)reader["Name"];
            }

            return name;
        }
    }
}
