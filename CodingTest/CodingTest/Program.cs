using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Coding_Test
{
    internal class Program
    {
        private static string parameterName;

        public static SqlDbType SqlDbType { get; private set; }
        public static int Value { get; private set; }
        public static ParameterDirection direction { get; private set; }

        static void Main(string[] args)
        {
            try
            {
                string cs = "data source=.; database=EmployeeMAnagement; integrated security=SSPI";
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "spGetCode_Employee";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter param1 = new SqlParameter(parameterName = "@EmployeeName", SqlDbType = SqlDbType.Int, Value = 3, Direction = ParameterDirection.Input);


                    conn.Open();
                    SqlDataReader rd=cmd.ExecuteReader();
                    Console.WriteLine("Employee Data");
                    while (rd.Read())
                    {
                        Console.WriteLine(rd[0] + "," + rd[1] + "," + rd[2] + "," + rd[3]);
                    }
                }  
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);   
            }
            Console.ReadLine(); 
        }
    }
}
