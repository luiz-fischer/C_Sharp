using System;
using MySql.Data.MySqlClient;

static void Main()
{
    //Aqui você substitui pelos seus dados
    var connString = "Server=localhost;Database=LocaCar;Uid=root;Pwd="; 
    var connection = new MySqlConnection(connString);
    var command = connection.CreateCommand();

    try
    {
        connection.Open();
        command.CommandText = "INSERT INTO cliente (nome) VALUES ('TESTE')";
        command.ExecuteNonQuery();
    }
    finally
    {
        if(connection.State == ConnectionState.Open)
            connection.Close();            
    }
}