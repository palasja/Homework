using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace Task6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const string queryCreateTable = @"create table Stories(Id int NOT NULL,Name nvarchar(50) NULL,Description nvarchar(15))";
            const string queryInsert = @"insert into Stories ([id], [Name], [Description]) 
                                   values (1, 'Fairytail of the lost needle', 'None'),
                                     (2, 'Foundation', 'None'),
                                    (3, 'Cool story, Bob', 'None')";
            const string querySelect = @"SELECT * FROM Stories";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["Task6_3"].ConnectionString;
                SqlCommand command = new SqlCommand(queryCreateTable, connection);
                connection.Open();
                command.ExecuteNonQuery();
                //Insert
                SqlCommand commandInsert = new SqlCommand(queryInsert, connection);
                commandInsert.ExecuteNonQuery();
                //Select
                SqlCommand commandSelect = new SqlCommand(querySelect, connection);
                using (SqlDataReader sqlReader = commandSelect.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        Console.WriteLine($"{sqlReader[0].ToString()}\t{sqlReader[1].ToString()}\t{sqlReader[2].ToString()} ");
                    }
                }
            }

            Console.Read();
        }
    }
}
