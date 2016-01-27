//PRODUCT FORM
//NEHA GHORPADE

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProductForm
{
    public partial class formProductCatalog : Form
    {
        SqlConnection connection = TravelExpertsDB.GetConnection(); //Gets the connection string
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int i;


        //private Product product; 
        

        public formProductCatalog()
        {
            InitializeComponent();
        }

        private void formProductCatalog_Load(object sender, EventArgs e)
        {
            DisplayData();     //Loads the gridview        
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Check if textbox is empty
            if (string.IsNullOrEmpty(txtEnterData.Text))
            {
                MessageBox.Show("Please Provide Details in the Textbox!");
            }
            else
            {
                cmd = new SqlCommand("insert into Products(ProdName) values(@ProdName) ", connection);
                try
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@ProdName", txtEnterData.Text);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                    DisplayData(); //Update and display the gridview
                    MessageBox.Show("New Product Inserted Successfully");
                    ClearData();
                }
                
            }  
        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Products ", connection);
            adapt.Fill(dt);    
            
            dgvProductCatalog.DataSource = dt;
            connection.Close();
        }
        //Clear Data  
        private void ClearData()
        {
            txtEnterData.Text = "";
        }

        private void dgvProductCatalog_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtEnterData.Text = dgvProductCatalog.Rows[e.RowIndex].Cells[1].Value.ToString();  
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Check if textbox is empty then prompt the user 
            if (string.IsNullOrEmpty(txtEnterData.Text))
            {
                MessageBox.Show("Please enter product name in the Textbox!");
            }

            else
            {
                //cmd = new SqlCommand("UPDATE Products SET ProdName = @newProdName WHERE ProductId=" + dgvProductCatalog.SelectedCells[0].Value.ToString() + "", connection); //where product id is the selected cell
                cmd = new SqlCommand("UPDATE Products SET ProdName = @newProdName WHERE ProductId=" + dgvProductCatalog.SelectedRows[0].Cells[0].Value.ToString() + " ", connection); //(When you click on product name it throws message as "Incorrect value near " "")
                try
                {
                    connection.Open();
                    
                    cmd.Parameters.AddWithValue("@newProdName", txtEnterData.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                    DisplayData();
                    ClearData();
                }
                
            }
            
            //DataGridViewRow row = dgvProductCatalog.Rows[i];
            //row.Cells[1].Value = txtEnterData.Text;
                   
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (dgvProductCatalog.Rows.Count > 1 && dgvProductCatalog.SelectedRows[0].Index != dgvProductCatalog.Rows.Count - 1)
            {
                cmd = new SqlCommand("DELETE FROM Products WHERE ProductId= " + dgvProductCatalog.SelectedRows[0].Cells[0].Value.ToString() + " " , connection);
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                    dgvProductCatalog.Rows.RemoveAt(dgvProductCatalog.SelectedRows[0].Index);
                    MessageBox.Show("Record Deleted Successfully!");
                    DisplayData();
                    ClearData();
                }
            }
            else 
            { 
                MessageBox.Show("Record not deleted"); 
            }
                       
            
        }

        private void dgvProductCatalog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataGridViewRow row = dgvProductCatalog.Rows[i];
            txtEnterData.Text = row.Cells[1].Value.ToString();  //Displays the selected product cell value in the textbox    

        }  

        
    }
}
