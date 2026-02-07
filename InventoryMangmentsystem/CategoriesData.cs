using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace InventoryMangmentsystem
{
    internal class CategoriesData
    {
        public int ID { set; get; }
        public string Catagory { set; get; }

        public string Date { set; get; }

        public List<CategoriesData> AllCategoriesData()
        {
            List<CategoriesData> listData = new List<CategoriesData>();
            using (
        SqlConnection connect
            = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\inventory.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();
                string selectData = "SELECT * FROM catagories";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        CategoriesData cData = new CategoriesData();
                        cData.ID = (int)reader["id"];
                        cData.Catagory = reader["catagory"].ToString();
                        cData.Date = reader["date"].ToString();


                        listData.Add(cData);
                    }
                }

            }
            return listData;
        }
    }
}
