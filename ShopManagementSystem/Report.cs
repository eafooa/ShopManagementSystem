using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Configuration;

namespace ShopManagementSystem
{
    public partial class Report : Form
    {
        public string ConnStr { get; set; }

        public Report()
        {
            InitializeComponent();
            ConnStr = ConfigurationManager.ConnectionStrings["DB_SMSConnectionString"].ConnectionString;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // DataContext takes a connection string. 
            SaleDataContext db = new SaleDataContext();

            // Query for report data
            dgvReport.DataSource =
                (from i in db.OrderItems
                join o in db.Orders
                    on i.BillNo equals o.BillNo
                join p in db.Products
                    on i.ProdId equals p.Id
                join c in db.Categories
                    on p.CategoryId equals c.Id
                //group c by c.CategoryName into CategoryName
                select new { c.CategoryName, i.Quantity, i.ExtPrice }).GroupBy(p=> new { p.CategoryName })
                       .Select(g=> new {
                           CategoryName = g.Key.CategoryName,
                           Quantity = g.Sum(y=> y.Quantity),
                           Amount = g.Sum(y=> y.ExtPrice)
                       });
        }
    }
}
