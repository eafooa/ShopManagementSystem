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
using System.IO;

namespace ShopManagementSystem
{
    public partial class AddProducts : Form
    {
        public string ConnStr { get; set ;}

        public AddProducts()
        {
            InitializeComponent();
            ConnStr = ConfigurationManager.ConnectionStrings["DB_SMSConnectionString"].ConnectionString;
        }

        private void AddProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sMSDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.sMSDataSet.Categories);

            lblDate.Text = DateTime.Now.ToString("d");
            ViewAllProducts();

        }

        private void ViewAllProducts()
        {
            string product;

            try
            {
                using (SqlConnection con = new SqlConnection(ConnStr))
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
                            a.ImagePath,
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
                        lv.SubItems.Add(Reader.GetDateTime(7).Date.ToString("d"));
                        lv.SubItems.Add(Reader.GetString(8));
                        lv.SubItems.Add(Reader.GetString(9));
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

        private void bynUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog op1 = new OpenFileDialog();
            op1.Multiselect = false;
            op1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (op1.ShowDialog() == DialogResult.OK)
            {
                txtImage.Text = op1.SafeFileName;
                lblImagePath.Text = op1.FileName;
                //File.Copy(op1.FileName, "C:\\Tmp\\" + "00" +txtImage.Text);
                //MessageBox.Show(Convert.ToString(count) + " File copied");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int? categoryId = cbCategory.SelectedValue as int?;
            string sql = "";

            if (String.IsNullOrEmpty(txtId.Text))
            {
                sql = @"
                         insert into [Products] (
                            CategoryId, ProductName, AvailableQuantity, 
                            PurchasePrice, SalePrice, UserId, Description, ImagePath)
                            Values (" + categoryId + ",'" + txtPName.Text + "',"
                            + nudQuantity.Value + "," + txtPprice.Text + ","
                            + txtSprice.Text + "," + lblUserId.Text + ",'"
                            + txtDescription.Text + "','" + txtImage.Text + "')";
            }
            else
            {
                sql = @"Update [Products] set 
                        CategoryId=" + categoryId +
                        ",ProductName='" + txtPName.Text +
                        "',AvailableQuantity=" + nudQuantity.Value +
                        ",PurchasePrice=" + txtPprice.Text +
                        ",SalePrice=" + txtSprice.Text +
                        ",UserId=" + lblUserId.Text +
                        ",Description='" + txtDescription.Text +
                        "',ImagePath='" + txtImage.Text +
                        "' where id = " + txtId.Text;
            }

            
            try
            {
                using (SqlConnection con = new SqlConnection(ConnStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    int Reader = cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            if (!String.IsNullOrEmpty(lblImagePath.Text))
                File.Copy(lblImagePath.Text, @"..\..\Images\" + txtImage.Text, true);

            ClearAllData();
            ViewAllProducts();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllData();
        }

        private void ClearAllData()
        {
            txtId.Clear();
            txtPName.Clear();
            nudQuantity.ResetText();
            txtPprice.Clear();
            txtSprice.Clear();
            txtDescription.Clear();
            txtImage.Clear();
        }

        private void ProductList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtId.Text = ProductList.SelectedItems[0].SubItems[0].Text;
            txtPName.Text = ProductList.SelectedItems[0].SubItems[2].Text;
            nudQuantity.Value = Convert.ToInt32(ProductList.SelectedItems[0].SubItems[3].Text);
            txtPprice.Text = ProductList.SelectedItems[0].SubItems[4].Text;
            txtSprice.Text = ProductList.SelectedItems[0].SubItems[5].Text;
            txtImage.Text = ProductList.SelectedItems[0].SubItems[8].Text;
            txtDescription.Text = ProductList.SelectedItems[0].SubItems[9].Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"
                         delete [Products] where id = "+ txtId.Text, con);
                    int Reader = cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            ClearAllData();
            ViewAllProducts();
        }

        private void btnUnfilter_Click(object sender, EventArgs e)
        {
            ViewAllProducts();
            txtFCategory.Clear();
            txtFId.Clear();
            txtFName.Clear();
        }

        private void txtFCategory_TextChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem row in ProductList.Items)
            {
                if (!row.SubItems[1].Text.ToUpper().Contains(txtFCategory.Text.ToUpper()))
                {
                    row.Remove();
                }
            }
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem row in ProductList.Items)
            {
                if (!row.SubItems[2].Text.ToUpper().Contains(txtFName.Text.ToUpper()))
                {
                    row.Remove();
                }
            }
        }

        private void txtFId_TextChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem row in ProductList.Items)
            {
                if (!row.SubItems[0].Text.ToUpper().Contains(txtFId.Text.ToUpper()))
                {
                    row.Remove();
                }
            }
        }
    }
}
