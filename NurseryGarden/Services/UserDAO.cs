using NuGet.Protocol.Plugins;
using NurseryGarden.Models;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace NurseryGarden.Services
{
    public class UserDAO
    {

        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public bool InsertIntoDB(UserModel userModel)
        {

                string sqlStatement = "INSERT INTO dbo.RUserTable VALUES (@USERNAME,@EMAIL,@PASSWORD)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlStatement, connection))
                    {
                        cmd.Parameters.AddWithValue("@USERNAME", userModel.UserName);
                        cmd.Parameters.AddWithValue("@EMAIL", userModel.Email);
                        cmd.Parameters.AddWithValue("@PASSWORD", userModel.Password);
                        {
                            try
                            {
                                connection.Open();
                                cmd.ExecuteNonQuery();
                                return true;
                            }

                            catch (Exception ex)
                            {
                                {
                                    Console.WriteLine(ex.Message);
                                    return false;
                                }
                            }
                        }


                    }
                }

        }

        public bool CheckIfNotUsed(UserModel userModel)
        {
            string sqlStatement = "SELECT COUNT(*) FROM dbo.RUserTable WHERE EMAIL = @EMAIL";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sqlStatement, connection))
                {
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@EMAIL", userModel.Email);
                            connection.Open();
                            int emailCount = (int)cmd.ExecuteScalar();
                            if (emailCount > 0)
                            {
                                return false;
                            }
                            else
                            { 
                                return true;
                            }
                        }

                        catch (Exception ex)
                        {
                            {
                                Console.WriteLine(ex.Message);
                                return false;
                            }
                        }
                    }


                }
            }
        }
    }
}
