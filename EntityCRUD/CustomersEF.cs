using EntityCRUD.Data;
using EntityCRUD.Models;

namespace EntityCRUD
{
    public partial class CustomersEF : Form
    {
        public CustomersEF()
        {
            InitializeComponent();
        }


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

        }

        private void getDataBase()
        {
            using (var dbContext = new NorthwindContext())
            {
                dgvDATA.DataSource = dbContext.Customers.ToList();
            }
        }

        private void InsertData()
        {
            using (var dbContext = new NorthwindContext())
            {
                try
                {
                    var customer = new Customer()
                    {
                        CustomerId = txtCustomerID.Text,
                        CompanyName = txtCompanyName.Text,
                        ContactName = txtContactName.Text,
                        ContactTitle = txtContactTitle.Text,
                        Address = txtAddress.Text,
                        City = txtCity.Text,
                        Region = txtRegion.Text,
                        PostalCode = txtPostalCode.Text,
                        Fax = txtFax.Text,
                        Country = txtPais.Text,
                        Phone = txtTelefono.Text
                    };

                    dbContext.Customers.Add(customer);
                    dbContext.SaveChanges();
                    MessageBox.Show("INSERTADO CORRECTAMENTE", "SUCCESS", MessageBoxButtons.OK);
                    getDataBase();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }

            }
        }

        private void UpdateData()
        {

            using (var dbContext = new NorthwindContext())
            {
                try
                {
                    var customer = dbContext.Customers.Find(txtCustomerID.Text);
                    customer.CompanyName = txtCompanyName.Text;
                    customer.ContactName = txtContactName.Text;
                    customer.ContactTitle = txtContactTitle.Text;
                    customer.Address = txtAddress.Text;
                    customer.City = txtCity.Text;
                    customer.Region = txtRegion.Text;
                    customer.PostalCode = txtPostalCode.Text;
                    customer.Fax = txtFax.Text;
                    customer.Country = txtPais.Text;
                    customer.Phone = txtTelefono.Text;


                    dbContext.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    dbContext.SaveChanges();
                    MessageBox.Show("DATOS ACTUALIZADOS CORRECTAMENTE", null, MessageBoxButtons.OK);
                    getDataBase();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }

            }
        }

        private void DeleteData()
        {
            using (var dbContext = new NorthwindContext())
            {
                try
                {
                    var customer = dbContext.Customers.Find(txtCustomerID.Text);
                    dbContext.Customers.Remove(customer!);
                    dbContext.SaveChanges();
                    MessageBox.Show("DATO ELIMINADO CORRECTAMENTE", null, MessageBoxButtons.OK);
                    getDataBase();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
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
                try
                {
                    DataGridViewRow row = dgvDATA.Rows[e.RowIndex];
                    TextBoxFiller(row.Cells["CustomerID"].Value.ToString(), row.Cells["CompanyName"].Value.ToString(), row.Cells["ContactName"].Value.ToString(), row.Cells["ContactTitle"].Value.ToString(), row.Cells["Address"].Value.ToString(),
                        row.Cells["City"].Value.ToString(), row.Cells["Region"].Value.ToString(), row.Cells["PostalCode"].Value.ToString(), row.Cells["Country"].Value.ToString(), row.Cells["Phone"].Value.ToString(),
                        row.Cells["Fax"].Value.ToString());
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            foreach (var item in grpDATOS.Controls.OfType<TextBox>())
                item.Clear();
        }
    }
}