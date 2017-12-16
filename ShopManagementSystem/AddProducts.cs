using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ShopManagementSystem
{
    public partial class AddProducts : Form
    {
        public AddProducts()
        {
            InitializeComponent();
        }

        private void AddProducts_Load(object sender, EventArgs e)
        {
            
            string connStr = ConfigurationManager.ConnectionStrings["DB_SMSConnectionString"].ConnectionString;
            DataTable dt = new DataTable();
            string product;

            try
            {
                using (SqlConnection con = new SqlConnection(connStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"
                         SELECT a.id as ProductId,
                            b.CategoryName,
                            a.ProductName,
                            a.AvailableQuantity as Quantity,
                            a.PurchasePrice,
                            a.SalePrice,
                            c.Name as InsertedBy,
                            a.CreatedDate,
                            a.Description
                        FROM[Products] a, [Categories] b, Users c
                        where b.Id = a.CategoryId and c.Id = a.UserId
                        ", con);
                    SqlDataReader Reader = cmd.ExecuteReader();

                    ProductList.Items.Clear();

                    while (Reader.Read())
                    {
                        product = Reader.GetInt32(0).ToString();
                        ListViewItem lv = new ListViewItem(Reader.GetInt32(0).ToString());
                        lv.SubItems.Add(Reader.GetString(1));
                        lv.SubItems.Add(Reader.GetString(2));
                        lv.SubItems.Add(Reader.GetInt32(3).ToString());
                        lv.SubItems.Add(Reader.GetDecimal(4).ToString());
                        lv.SubItems.Add(Reader.GetDecimal(5).ToString());
                        lv.SubItems.Add(Reader.GetString(6));
                        lv.SubItems.Add(Reader.GetDateTime(7).ToString());
                        lv.SubItems.Add(Reader.GetString(8));
                        ProductList.Items.Add(lv);


                    }

                    Reader.Close();
                    con.Close();
                }
            }
            catch (Exception ex)
            {

                throw;
            }


        }
    }
}
