using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Repositories.GenericCoreImpl
{
    public class GenericCore
    {
        public static void Main()
        {

        SqlConnection sqlConnectrion;

        string connectionString = "Data Source=CRLHL-ALIIKHAI1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        try
        {
                sqlConnectrion = new SqlConnection(connectionString);
                sqlConnectrion.Open();

                Console.WriteLine("Connection successfull");
        
        }catch(Exception e){
                Console.WriteLine("Exception");
        }

            
}
         

    }



}
