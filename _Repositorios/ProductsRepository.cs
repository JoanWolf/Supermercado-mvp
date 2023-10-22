using Microsoft.Data.SqlClient;
using Supermarket_mvp.Modelos;
using Supermarket_mvp.Vista;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp._Repositorios
{
    internal class ProductsRepository: BaseRepository, IProductsRepository
    {
        public ProductsRepository(string connectionString)
        {
            this.connectionString = connectionString;
            FeedComboBoxCategorias();
        }
        public void Add(ProductsModel productsModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Products VALUES (@name, @price, @stock, @idcategory)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productsModel.Name;
                command.Parameters.Add("@price", SqlDbType.Int).Value = productsModel.Price;
                command.Parameters.Add("@stock", SqlDbType.Int).Value = productsModel.Stock;
                command.Parameters.Add("@idcategory", SqlDbType.Int).Value = productsModel.Category_Id;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection?.Open();
                command.Connection = connection;
                command.CommandText = "Delete from Products Where Products_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ProductsModel productsModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Products
                                       SET Products_Name = @name,
                                       Products_Price = @price,
                                       Products_Stock = @stock
                                       WHERE Products_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productsModel.Name;
                command.Parameters.Add("@price", SqlDbType.Int).Value = productsModel.Price;
                command.Parameters.Add("@stock", SqlDbType.Int).Value = productsModel.Stock;
                command.Parameters.Add("@id", SqlDbType.Int).Value = productsModel.Id;       
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProductsModel> GetAll()
        {
            var productsList = new List<ProductsModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Products ORDER BY Products_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productsModel = new ProductsModel();
                        productsModel.Id = (int)reader["Products_Id"];
                        productsModel.Name = reader["Products_Name"].ToString();
                        productsModel.Price = (int)reader["Products_Price"];
                        productsModel.Category_Id = (int)reader["Products_IdCategory"];
                        productsModel.Stock= (int)reader["Products_Stock"];
                        productsList.Add(productsModel);
                    }
                }
            }
            return productsList;
        }

        public IEnumerable<ProductsModel> GetByValue(string value)
        {
            var productsList = new List<ProductsModel>();
            int productsId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string productsName = value;
            string productsICategory = value;
            string productsStock = value;
            string productsPrice = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * From Products
                                        WHERE Products_Id=@id or Products_Name LIKE @name+ '%'
                                        or Products_Price LIKE @price+ '%'
                                        or Products_Stock LIKE @stock+ '%'
                                        or Products_IdCategory LIKE @idcategory+ '%'
                                        ORDER By Products_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = productsId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productsName;
                command.Parameters.Add("@idcategory", SqlDbType.NVarChar).Value = productsICategory;
                command.Parameters.Add("@stock", SqlDbType.NVarChar).Value = productsStock;
                command.Parameters.Add("@price", SqlDbType.NVarChar).Value = productsPrice;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productsModel = new ProductsModel();
                        productsModel.Id = (int)reader["Products_Id"];
                        productsModel.Name = reader["Products_Name"].ToString();
                        productsModel.Price = (int)reader["Products_Price"];
                        productsModel.Stock = (int)reader["Products_Stock"];
                        productsModel.Category_Id = (int)reader["Products_IdCategory"];
                        productsList.Add(productsModel);
                    }
                }
            }
            return productsList;
        }

        public void FeedComboBoxCategorias()
        {
            ProductsView.CBoxIdCategory.Items.Clear();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Category";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string item = reader.GetInt32("Category_Id") + "  -  " + reader.GetString("Category_Name");
                        ProductsView.CBoxIdCategory.Items.Add(item);
                    }
                }
            }

        }

    }
}
