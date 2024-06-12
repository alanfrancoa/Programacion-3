using StockManagementService.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementService.DAO
{
    public class ProductDAO
    {
        private IDbConnection PrepareConnection() 
        {
            string StringConnection = "server=PCGAMINGALAN\\SQLEXPRESS; database=ProductManagement; Integrated Security=true";
            SqlConnection connection = new SqlConnection(StringConnection);
            connection.Open(); 
            return connection;
        }
        //DAO Functions (Insert, Update, Delete, GetAllProducts ✅, GetByID✅)
        
        public bool Insert(Product product) 
        {
            string Query = $"INSERT INTO PRODUCTS (PRODUCT_NAME, PRODUCT_BRAND, PRODUCT_SIZE, SIZE_UNIT, PRODUCT_TYPE, STOCK) VALUES ('{product.ProductName}', '{product.ProductBrand}', {product.ProductSize}, '{product.SizeUnit}', '{product.ProductType}', {product.Stock})";

            var DbConnection = PrepareConnection();
            var DbCommand = DbConnection.CreateCommand();
            DbCommand.CommandText = Query;
            int RowsAffected = DbCommand.ExecuteNonQuery();

            DbConnection.Close();

            return RowsAffected > 0;
        }

        public bool Update( string productName, string productBrand, decimal productSize, string sizeUnit, string productType, long stock)
        {
            string Query = $"UPDATE PRODUCTS SET PRODUCT_NAME = '{productName}', PRODUCT_BRAND = '{productBrand}', PRODUCT_SIZE = {productSize}, SIZE_UNIT = '{sizeUnit}', PRODUCT_TYPE = '{productType}', STOCK = {stock}";
            var DbConnection = PrepareConnection();
            var Command = DbConnection.CreateCommand();
            Command.CommandText = Query;
            int rowsAffected = Command.ExecuteNonQuery();
            DbConnection.Close();
            return rowsAffected > 0;
        }

        public bool Delete(long id) 
        {
            string Query = $"DELETE FROM PRODUCTS WHERE ID = {id}";
            var DbConnection = PrepareConnection();
            var Command = DbConnection.CreateCommand();
            Command.CommandText = Query;
            int rowsAffected = Command.ExecuteNonQuery();
            DbConnection.Close();
            return rowsAffected > 0;
        }

        public List<Product> GetAllProducts()
        {
            var ProductsList = new List<Product>();

            IDbConnection DbConnection = PrepareConnection();
            IDbCommand DbCommand = DbConnection.CreateCommand();

            DbCommand.CommandText = "SELECT ID, PRODUCT_NAME, PRODUCT_BRAND, PRODUCT_SIZE, SIZE_UNIT, PRODUCT_TYPE, STOCK FROM PRODUCTS";

            IDataReader DbDataReader = DbCommand.ExecuteReader();

            while (DbDataReader.Read())
            {
                Product product = new Product()
                {
                    Id = DbDataReader.GetInt32(0),
                    ProductName = DbDataReader.GetString(1),
                    ProductBrand = DbDataReader.GetString(2),
                    ProductSize = DbDataReader.GetDecimal(3),
                    SizeUnit = DbDataReader.GetString(4),
                    ProductType = DbDataReader.GetString(5),
                    Stock = DbDataReader.GetInt32(6)
                };

                ProductsList.Add(product);
            }
            DbConnection.Close();
            return ProductsList;
        }
        
        public Product GetProductByID(int id) 
        {
            string query = $"SELECT ID, PRODUCT_NAME, PRODUCT_BRAND, PRODUCT_SIZE, SIZE_UNIT, PRODUCT_TYPE, STOCK FROM PRODUCTS WHERE ID={id}";
            IDbConnection DbConnection = PrepareConnection();
            IDbCommand dbCommand = DbConnection.CreateCommand();
            dbCommand.CommandText = query;
            IDataReader dataReader = dbCommand.ExecuteReader();

            Product newProduct = null;
            if (dataReader.Read()) 
            {
                newProduct = new Product()
                {
                    Id = dataReader.GetInt32(0),
                    ProductName = dataReader.GetString(1),
                    ProductBrand = dataReader.GetString(2),
                    ProductSize = dataReader.GetDecimal(3),
                    SizeUnit = dataReader.GetString(4),
                    ProductType = dataReader.GetString(5),
                    Stock = dataReader.GetInt32(6)
                };
            }
            DbConnection.Close ();
            return newProduct;

        }

    }
}
