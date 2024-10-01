﻿using Dapper;
using Dapper.Delete;
using Microsoft.Data.SqlClient;
using System.Data;

public class Program()
{
    public static void Main()
    {
        string connectionString = "Data Source = .\\ALI; Initial Catalog = MyProducts; Integrated Security = True; Trust Server Certificate = True;";

        IDbConnection connection = new SqlConnection(connectionString);

        var product = new Product() { Id = 1 };

        var sql = "DELETE FROM Products WHERE Id=@Id";

        connection.Execute(sql, product);

        Console.WriteLine("1 row affected");
    }
}