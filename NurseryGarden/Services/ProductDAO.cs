﻿using NurseryGarden.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace NurseryGarden.Services
{
    public class ProductDAO
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;Connect Timeout=30;Encrypt=False;";


        public List<ProductModel> GetAllProductToList()
        {
            List<ProductModel> allProducts = new List<ProductModel>();
            string sqlStatement = "SELECT * FROM dbo.TreeProductTable";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sqlStatement, connection)) 
                    {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            allProducts.Add(new ProductModel() {Id = (int)reader[0], ProductName = (string)reader[1], Description = (string)reader[2], Price = (decimal)reader[3]}); 
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    }
            }


            return allProducts;
        }
    }
}