using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ProductApp.Models;

namespace ProductManagementApp.Data
{
    public class ProductDAL
    {
        private readonly string connectionString;

        public ProductDAL(IConfiguration config)
        {
           connectionString = config["ConnectionStrings:DefaultConnection"];
        }

        // INSERT
        public void InsertProduct(Product product)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(connectionString);
                using SqlCommand cmd = new SqlCommand("sp_InsertProduct", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@ProductName", product.ProductName));
                cmd.Parameters.Add(new SqlParameter("@Category", product.Category));
                cmd.Parameters.Add(new SqlParameter("@Price", product.Price));

                conn.Open();
                cmd.ExecuteNonQuery();

                Console.WriteLine("Product inserted successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Insert Error: " + ex.Message);
            }
        }

        // READ
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            try
            {
                using SqlConnection conn = new SqlConnection(connectionString);
                using SqlCommand cmd = new SqlCommand("sp_GetAllProducts", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                using SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    products.Add(new Product
                    {
                        ProductId = Convert.ToInt32(reader["ProductId"]),
                        ProductName = reader["ProductName"].ToString() ?? "",
                        Category = reader["Category"].ToString() ?? "",
                        Price = Convert.ToDecimal(reader["Price"])
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Read Error: " + ex.Message);
            }

            return products;
        }

        // UPDATE
        public void UpdateProduct(Product product)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(connectionString);
                using SqlCommand cmd = new SqlCommand("sp_UpdateProduct", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@ProductId", product.ProductId));
                cmd.Parameters.Add(new SqlParameter("@ProductName", product.ProductName));
                cmd.Parameters.Add(new SqlParameter("@Category", product.Category));
                cmd.Parameters.Add(new SqlParameter("@Price", product.Price));

                conn.Open();
                cmd.ExecuteNonQuery();

                Console.WriteLine(" Product updated successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Update Error: " + ex.Message);
            }
        }

        // DELETE
        public void DeleteProduct(int productId)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(connectionString);
                using SqlCommand cmd = new SqlCommand("sp_DeleteProduct", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@ProductId", productId));

                conn.Open();
                cmd.ExecuteNonQuery();

                Console.WriteLine("Product deleted successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Delete Error: " + ex.Message);
            }
        }
    }
}