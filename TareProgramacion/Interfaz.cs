using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareProgramacion
{
    public partial class FrmApp : Form
    {
        private string localCustomerID;
        public FrmApp()
        {
            InitializeComponent();
        }

        string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

        private void TextBoxFiller(string CustomerID, string CompanyName, string ContactName, string ContactTitle, string Address,
            string City, string Region, string PostalCode, string Country, string Phone, string Fax)
        {
            txtCustomerID.Text = CustomerID;
            txtCompanyName.Text = CompanyName;
            txtContactName.Text = ContactName;
            txtContactTitle.Text = ContactTitle;
            txtAddress.Text = Address;
            txtCity.Text = City;
            txtRegion.Text = Region;
            txtPostalCode.Text = PostalCode;
            txtFax.Text = Fax;
            txtPais.Text = Country;
            txtTelefono.Text = Phone;

            localCustomerID = CustomerID;

        }


        private void TextBoxCleaner()
        {
            foreach (var item in grpDATOS.Controls.OfType<TextBox>())
                item.Clear();
        }

        private bool TextBoxChecker()
        {
            if (txtCustomerID.Text == string.Empty | txtCompanyName.Text == string.Empty)
            {
                MessageBox.Show("Customer ID y/o Nombre de la Compañia no pueden estar vacios.","ERROR", MessageBoxButtons.OK);
                return true;
            }
            return false;    
                
        }
        private void getDataBase()
        {
            string Query = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax FROM Customers ORDER BY CustomerID;";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(Query, conn);
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvDATA.DataSource = dataTable;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void InsertData()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    string Query = "INSERT INTO Customers(CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country" +
                        ",Phone,Fax) VALUES('" + txtCustomerID.Text + "','" + txtCompanyName.Text + "','" + txtContactName.Text + "','" + txtContactTitle.Text + "','" + txtAddress.Text + "','" + txtCity.Text + "','" +
                        txtRegion.Text + "','" + txtPostalCode.Text + "','" + txtPais.Text + "','" + txtTelefono.Text + "','" + txtFax.Text + "')";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("INSERTADO CORRECTAMENTE", "SUCCESS", MessageBoxButtons.OK);
                    getDataBase();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    string Query = "UPDATE Customers SET CustomerID = '" + txtCustomerID.Text + "', CompanyName = '" + txtCompanyName.Text + "', ContactName = '" + txtContactName.Text + "', ContactTitle = '" + txtContactTitle.Text + "', Address = '" + txtAddress.Text +
                        "', City = '" + txtCity.Text + "', Region = '" + txtRegion.Text + "', PostalCode ='" + txtPostalCode.Text + "', Country = '" + txtPais.Text + "', Phone ='" + txtTelefono.Text + "', Fax = '" + txtFax.Text + "' WHERE CustomerID = '" + localCustomerID + "'";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("DATOS ACTUALIZADOS CORRECTAMENTE", null, MessageBoxButtons.OK);
                    getDataBase();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void DeleteData()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    string Query = "DELETE FROM Customers WHERE CustomerID = '" + txtCustomerID.Text + "'";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("DATO ELIMINADO CORRECTAMENTE", null, MessageBoxButtons.OK);
                    getDataBase();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvDATA.Visible = false;
            this.Size = new System.Drawing.Size(322, 429);
            grpDATOS.Visible = false;
            this.btnDelete.Visible = false;
            this.btnUpdate.Visible = false;
            this.btnInsert.Visible = false;
            this.btnLimpiar.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Seguro que Desea salir?", "Advertencia", MessageBoxButtons.OKCancel);

            if (d == DialogResult.OK)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //RESIZING UI
            this.Size = new System.Drawing.Size(1000, 800);
            //HANDLING
            this.button1.Visible = false;

            this.btnInsert.Visible = true;
            this.btnDelete.Visible = true;
            this.btnUpdate.Visible = true;
            this.grpDATOS.Visible = true;
            this.btnLimpiar.Visible = true;
            //RESIZING COMPONENTS

            this.btnSalir.Location = new Point(900, 120);
            this.btnLimpiar.Location = new Point(900, 150);
            this.btnUpdate.Location = new Point(820, 120);
            this.btnDelete.Location = new Point(740, 120);
            this.btnInsert.Location = new Point(660, 120);
            this.label1.Location = new Point(380, 9);
            this.grpDATOS.Location = new Point(0, 50);
            this.dgvDATA.Size = new Size(100, 300);
            dgvDATA.Visible = true;

            getDataBase();

        }

        private void dgvDATA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDATA.Rows[e.RowIndex];
                TextBoxFiller(row.Cells["CustomerID"].Value.ToString(), row.Cells["CompanyName"].Value.ToString(), row.Cells["ContactName"].Value.ToString(), row.Cells["ContactTitle"].Value.ToString(), row.Cells["Address"].Value.ToString(),
                    row.Cells["City"].Value.ToString(), row.Cells["Region"].Value.ToString(), row.Cells["PostalCode"].Value.ToString(), row.Cells["Country"].Value.ToString(), row.Cells["Phone"].Value.ToString(),
                    row.Cells["Fax"].Value.ToString());
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(!TextBoxChecker())
                InsertData();
                TextBoxCleaner();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!TextBoxChecker())
                UpdateData();
                TextBoxCleaner();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!TextBoxChecker())
                DeleteData();
                TextBoxCleaner();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            TextBoxCleaner();
        }

        private void txtCustomerID_Validating(object sender, CancelEventArgs e)
        {
            if(txtCustomerID.Text.Length > 5) 
            {
                MessageBox.Show("El Valor de Customer ID, no puede superar los 5 Caracteres.", "ERROR", MessageBoxButtons.OK);
                txtCustomerID.Clear();
            }
        }
    }
}