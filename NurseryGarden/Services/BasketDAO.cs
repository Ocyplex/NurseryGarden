using NurseryGarden.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace NurseryGarden.Services
{
    public class BasketDAO
    {
        public List<ProductModel>Basket = new List<ProductModel>();

        /*
        public List<ProductModel> ShowBasket(UserModel userModel)
        {
            List<BasketModel> UserBasket = Basket.Where(j => userModel.Id == j.Id).ToList();
            try
            {
                return UserBasket.First().myBasket;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return UserBasket.First().myBasket;
        }
        */


        public void AddtoBasket()
        {

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

            string sqlStatement = "UPDATE dbo.TreeProductTable SET Amount = @newAmount WHERE ID = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sqlStatement, connection))
                {
                    //cmd.Parameters.AddWithValue("newAmout", newAmount);
                    //cmd.Parameters.AddWithValue("id", id);
                    try
                    {
                        connection.Open();
                        // Execute the update query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Update successful!");
                        }
                        else
                        {
                            Console.WriteLine("No rows were updated.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

        }
    }
}
