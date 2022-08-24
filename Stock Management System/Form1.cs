using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing.Printing;
using Syncfusion.Windows.Forms.Barcode;

namespace Stock_Management_System
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {

            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            LoadData();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();

            string connectionString;
            SqlConnection con;
            connectionString = @"Data Source=.;Initial Catalog=StockSystemdb;Integrated Security=True";
            con = new SqlConnection(connectionString);
            con.Open();


            SqlCommand cmd = new SqlCommand("INSERT INTO StockSystemdb.dbo.ProductDetails(barCode, productName, productCategory, quantity, sellingPrice, costPrice) Values(@barCode, @productName, @productCategory, @quantity, @sellingPrice, @costPrice)", con);  
            cmd.Parameters.AddWithValue("@barCode", rnd1.Next());
            cmd.Parameters.AddWithValue("@productCategory", cat_combobx.Text);
            cmd.Parameters.AddWithValue("@productName", prod_txt.Text);
            cmd.Parameters.AddWithValue("@costPrice", cost_txt.Text);
            cmd.Parameters.AddWithValue("@sellingPrice", selling_txt.Text);
            cmd.Parameters.AddWithValue("@quantity", quantity_txt.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("New Product Registered");
            con.Close();

            LoadData();

            Application.Restart();


        }
        private bool IfProductsExists(SqlConnection con, string productName)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select 1 From StockSystemdb.dbo.ProductDetails WHERE productName ='" + productName + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0) 
            {
                return true;
            }
            else 
            { 
                return false; 
            }
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            barcodetxt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            cat_combobx.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            prod_txt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            cost_txt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            selling_txt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            quantity_txt.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }
        public void LoadData() {

            string connectionString;
            SqlConnection con;
            connectionString = @"Data Source=.;Initial Catalog=StockSystemdb;Integrated Security=True";
            con = new SqlConnection(connectionString);

            SqlDataAdapter sda = new SqlDataAdapter("Select * From StockSystemdb.dbo.ProductDetails", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["barCode"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["productCategory"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["productName"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["costPrice"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["sellingPrice"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["quantity"].ToString();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //method for editing the products in the database
            string connetionString;
            SqlConnection con;
            connetionString = @"Data Source=.;Initial Catalog=StockSystemdb;Integrated Security=True";
            con = new SqlConnection(connetionString);
            con.Open();

            var sqlQuery = "";
            if (productExist(con, barcodetxt.Text))
            {
                //using the UPDATE query string to edit the products in the table
                sqlQuery = @"UPDATE StockSystemdb.dbo.ProductDetails
                            SET
                                productName = '" + prod_txt.Text + "',productCategory = '" + cat_combobx.Text + "' ,quantity = '" + quantity_txt.Text + "', sellingPrice = '" + selling_txt.Text + "',costPrice = '" + cost_txt.Text + "' WHERE barCode = '" + barcodetxt.Text + "'";
            }
            else
            {
                sqlQuery = @"INSERT INTO ProductDetails (productName, productCategory, quantity, sellingPrice, costPrice) 
                Values ('" + prod_txt.Text + "' , '" + cat_combobx.Text + "' , '" + quantity_txt.Text + "' , '" + selling_txt.Text + "' , '" + cost_txt.Text + "')";
            }

            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();

            Application.Restart();
        }
        private bool productExist(SqlConnection con, String barCode)
        {
            //checking to see if the product exists
            SqlDataAdapter sda = new SqlDataAdapter("Select 1 From StockSystemdb.dbo.ProductDetails WHERE barCode = '" + barCode + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //opening new connection
            string connetionString;
            SqlConnection con;
            connetionString = @"Data Source=.;Initial Catalog=StockSystemdb;Integrated Security=True";
            con = new SqlConnection(connetionString);

            //creation of a new query string 
            var sqlQuery = "";
            if (productExist(con, barcodetxt.Text))
            {
                //opening the connection and deleting the object from the database if the product exists
                con.Open();
                sqlQuery = @"Delete from StockSystemdb.dbo.productDetails WHERE barCode = '" + barcodetxt.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("There is no Record Found");
            }


            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Initialize the Barcode control
            SfBarcode barcode = new SfBarcode();
            //Set the barcode symbology type
            barcode.Symbology = BarcodeSymbolType.Code128A;
            //Set the input text
            barcode.Text = barcodetxt.Text;
            //Set the barcode size
            barcode.Size = pictureBox1.Size;
            //Export the Barcode control as image
            pictureBox1.Image = barcode.ToImage();
            Bitmap bitmap = new Bitmap(barcode.ToImage());
        }

        private void prod_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
