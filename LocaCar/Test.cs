using System;
 using System.Data;
 using MySql.Data.MySqlClient;
 
 public class Test
 {
    public static void Main(string[] args)
    {
      string connectionString = "Server=localhost;User ID=root;Database=locacar;Port=3306;Pooling=false";
MySqlConnection connection = new MySqlConnection( connectionString );

try
{
    Console.WriteLine( "Trying to open database connection ..." );
    connection.Open();
}
catch(Exception ex)
{
    Console.WriteLine(ex.ToString());
}

connection.Close();
    }
 }