using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ShoeCollectionWithDatabase
{
    public static class ShoeDB
    {
        public static List<Shoe> GetAllShoes()
        {
            List<Shoe> shoeList = new List<Shoe>();
            SqlConnection connection = DBConnection.GetConnection();
            string selectString = "SELECT Brand, Model, Colorway, Size FROM Shoes ORDER BY Brand ASC";
            SqlCommand selectCommand = new SqlCommand(selectString, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    Shoe tempShoe = new Shoe
                    {
                        Brand = reader["Brand"].ToString(),
                        Model = reader["Model"].ToString(),
                        Colorway = reader["Colorway"].ToString(),
                        Size = (decimal)reader["Size"],
                    };

                    shoeList.Add(tempShoe);
                }

            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                connection.Close();
            }

            return shoeList;
        }

        public static Shoe GetShoe(string brand, string model, string colorway, decimal size)
        {
            Shoe tempShoe = null;

            SqlConnection connection = DBConnection.GetConnection();
            string selectString = "SELECT Brand, Model, Colorway, Size FROM Shoes WHERE Brand=@brand AND Model=@model AND Colorway=@colorway AND Size=@size";
            SqlCommand selectCommand = new SqlCommand(selectString, connection);
            selectCommand.Parameters.AddWithValue("@brand", brand);
            selectCommand.Parameters.AddWithValue("@model", model);
            selectCommand.Parameters.AddWithValue("@colorway", colorway);
            selectCommand.Parameters.AddWithValue("@size", size);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();

                // If the grader is found, stores all information about the grader into an object
                if (reader.Read())
                {
                    tempShoe = new Shoe
                    {
                        Brand = reader["Brand"].ToString(),
                        Model = reader["Model"].ToString(),
                        Colorway = reader["Colorway"].ToString(),
                        Size = (decimal)reader["Size"],
                    };
                }
            }

            catch(Exception ex)
            {
                throw ex;
            }

            finally
            {
                connection.Close();
            }

            return tempShoe;

        }

        public static void AddShoe(Shoe tempShoe)
        {
            SqlConnection connection = DBConnection.GetConnection();
            string insertString = "INSERT INTO Shoes (Brand, Model, Colorway, Size)" +
                                  "VALUES (@brand, @model, @colorway, @size)";
            SqlCommand insertCommand = new SqlCommand(insertString, connection);

            insertCommand.Parameters.AddWithValue("@brand", tempShoe.Brand);
            insertCommand.Parameters.AddWithValue("@model", tempShoe.Model);
            insertCommand.Parameters.AddWithValue("@colorway", tempShoe.Colorway);
            insertCommand.Parameters.AddWithValue("@size", tempShoe.Size);

            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();

            }
        
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                connection.Close();
            }
        }

        public static void DeleteShoe(Shoe tempShoe)
        {
            SqlConnection connection = DBConnection.GetConnection();
            string deleteString = "DELETE FROM Shoes WHERE Brand=@brand AND Model=@model AND Colorway=@colorway AND Size=@size";
            SqlCommand deleteCommand = new SqlCommand(deleteString, connection);
            deleteCommand.Parameters.AddWithValue("@brand", tempShoe.Brand);
            deleteCommand.Parameters.AddWithValue("@model", tempShoe.Model);
            deleteCommand.Parameters.AddWithValue("@colorway", tempShoe.Colorway);
            deleteCommand.Parameters.AddWithValue("@size", tempShoe.Size);

            try
            {
                // Executes the query 
                connection.Open();
                deleteCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
