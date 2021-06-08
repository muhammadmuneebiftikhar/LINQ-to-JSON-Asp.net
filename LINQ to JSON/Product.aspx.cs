using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ_to_JSON
{
    public partial class Product : System.Web.UI.Page
    {
        public class Products
        {
            public string ID { get; set; }
            public string TITLE { get; set; }
            public string UNIT_PRICE { get; set; }
            public string EXPIRE { get; set; }
            public string MANUFACTURE { get; set; }
            public string STOCK { get; set;}

        }
        List<Dictionary<string, object>> rows;
        System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();

        protected void Page_Load(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(Server.MapPath("Product.json"));
            string json = reader.ReadToEnd();
            rows = serializer.Deserialize<List<Dictionary<string, object>>>(json);
            reader.Close();
            if(!IsPostBack)
            {
                txtMain.Text = serializer.Serialize(rows);
                LoadGridView();
            }
        }
        private void LoadGridView()
        {
            var data = rows.Select(x => new Products
            {
                ID = x["P_ID"].ToString(),
                TITLE = x["P_TITLE"].ToString(),
                UNIT_PRICE = x["P_UNIT_PRICE"].ToString(),
                EXPIRE = x["P_EXPIRE"].ToString(),
                MANUFACTURE = x["P_MANUFACTURE"].ToString(),
                STOCK = x["P_STOCK"].ToString(),
            }) ;

            GridView1.DataSource = data;
            GridView1.DataBind();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> row = new Dictionary<string, object>();
            row.Add("P_ID", txtID.Text);
            row.Add("P_TITLE", txTitle.Text);
            row.Add("P_UNIT_PRICE", txtUnitPrice.Text);
            row.Add("P_EXPIRE", txtExpire.Text);
            row.Add("P_MANUFACTURE", txtManufacture.Text);
            row.Add("P_STOCK", txtStock.Text);
            rows.Add(row);
            txtMain.Text = serializer.Serialize(rows);
            LoadGridView();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> row = new Dictionary<string, object>();
            row.Add("P_ID", txtID.Text);

            row = rows.SingleOrDefault(x => row.All(x.Contains));
            row["P_TITLE"] = txTitle.Text;
            row.Add("P_UNIT_PRICE", txtUnitPrice.Text);
            row.Add("P_EXPIRE", txtExpire.Text);
            row.Add("P_MANUFACTURE", txtManufacture.Text);
            row.Add("P_STOCK", txtStock.Text);
            txtMain.Text = serializer.Serialize(rows);
            LoadGridView();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> row = new Dictionary<string, object>();
            row.Add("P_ID", txtID.Text);

            row = rows.SingleOrDefault(x => row.All(x.Contains));
            txTitle.Text = row["P_TITLE"].ToString();
            txtUnitPrice.Text = row["P_UNIT_PRICE"].ToString();
            txtExpire.Text = row["P_EXPIRE"].ToString();
            txtManufacture.Text = row["P_MANUFACTURE"].ToString();
            txtStock.Text = row["P_STOCK"].ToString();

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> row = new Dictionary<string, object>();
            row.Add("P_ID", txtID.Text);
            row = rows.SingleOrDefault(x => row.All(x.Contains));
            rows.Remove(row);
            txtMain.Text = serializer.Serialize(rows);
            LoadGridView();
        }

        protected void btnSaveToFile_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter myFile = new System.IO.StreamWriter(Server.MapPath("Product.json"));
            if(!txtMain.Text.Equals(""))
            {
                myFile.WriteLine(txtMain.Text);
            }
            myFile.Close();
        }
    }
}