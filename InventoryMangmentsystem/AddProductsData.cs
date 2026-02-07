using System.Collections.Generic;
using System.Data.SqlClient;

namespace InventoryMangmentsystem
{
    class AddProductsData
    {
        public int ID { get; set; } //0
        public string ProdID { get; set; }//1
        public string ProdName { get; set; }//2
        public string Category { get; set; }//3
        public string Price { get; set; }//4
        public string Stock { get; set; }//5
        public string ImagePath { get; set; }//6
        public string Status { get; set; }//7
        public string Date { get; set; }//8
        public List<AddProductsData> AllProductsData()
        {
            List<AddProductsData> listData = new List<AddProductsData>();
            using (
        SqlConnection connect
            = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\inventory.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();
                string selectData = "select * from products";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        AddProductsData apData = new AddProductsData();
                        apData.ID = (int)reader["id"];
                        apData.ProdID = reader["prod_id"].ToString();
                        apData.ProdName = reader["prod_name"].ToString();
                        apData.Category = reader["category"].ToString();
                        apData.Price = reader["price"].ToString();
                        apData.Stock = reader["stock"].ToString();
                        apData.ImagePath = reader["image_path"].ToString();
                        apData.Status = reader["status"].ToString();
                        apData.Date = reader["date_insert"].ToString();
                        listData.Add(apData);
                    }
                }

            }
            return listData;
        }

        // references
        public List<AddProductsData> AllAvailableProducts()
        {
            List<AddProductsData> listData = new List<AddProductsData>();

            using (SqlConnection connect
                = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\inventory.mdf;Integrated Security=True"))
            {
                connect.Open();

                string selectData = "SELECT * FROM products WHERE status = @status";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@status", "Available");

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        AddProductsData apData = new AddProductsData();
                        apData.ID = (int)reader["id"];
                        apData.ProdID = reader["prod_id"].ToString();
                        apData.ProdName = reader["prod_name"].ToString();
                        apData.Category = reader["category"].ToString();
                        apData.Price = reader["price"].ToString();
                        apData.Stock = reader["stock"].ToString();
                        apData.ImagePath = reader["image_path"].ToString();
                        apData.Status = reader["status"].ToString();
                        apData.Date = reader["date_insert"].ToString();

                        listData.Add(apData);
                    }
                }
            }

            return listData;
        }
    }
    
}

