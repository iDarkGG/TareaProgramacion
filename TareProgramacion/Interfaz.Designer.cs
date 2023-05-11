namespace TareProgramacion
{
    partial class FrmApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            btnSalir = new Button();
            dgvDATA = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtCompanyName = new TextBox();
            txtContactName = new TextBox();
            txtAddress = new TextBox();
            txtContactTitle = new TextBox();
            txtPais = new TextBox();
            txtPostalCode = new TextBox();
            txtRegion = new TextBox();
            txtCity = new TextBox();
            txtFax = new TextBox();
            txtTelefono = new TextBox();
            grpDATOS = new GroupBox();
            txtCustomerID = new TextBox();
            lblCustomerID = new Label();
            lblFax = new Label();
            lblTelefono = new Label();
            blPais = new Label();
            lblCodigoPostal = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnInsert = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDATA).BeginInit();
            grpDATOS.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 116);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "CARGAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 9);
            label1.Name = "label1";
            label1.Size = new Size(214, 15);
            label1.TabIndex = 1;
            label1.Text = "POR FAVOR SELECCIONE UNA OPCION";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(223, 116);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvDATA
            // 
            dgvDATA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDATA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDATA.Dock = DockStyle.Bottom;
            dgvDATA.Location = new Point(0, 444);
            dgvDATA.Name = "dgvDATA";
            dgvDATA.RowTemplate.Height = 25;
            dgvDATA.Size = new Size(1011, 150);
            dgvDATA.TabIndex = 3;
            dgvDATA.CellClick += dgvDATA_CellClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(93, 116);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(93, 145);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(6, 115);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(196, 23);
            txtCompanyName.TabIndex = 6;
            txtCompanyName.Text = "  ";
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(6, 161);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(196, 23);
            txtContactName.TabIndex = 7;
            txtContactName.Text = "  ";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(6, 248);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(196, 23);
            txtAddress.TabIndex = 9;
            txtAddress.Text = "  ";
            // 
            // txtContactTitle
            // 
            txtContactTitle.Location = new Point(6, 206);
            txtContactTitle.Name = "txtContactTitle";
            txtContactTitle.Size = new Size(196, 23);
            txtContactTitle.TabIndex = 8;
            txtContactTitle.Text = "  ";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(326, 206);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(196, 23);
            txtPais.TabIndex = 13;
            txtPais.Text = "  ";
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(326, 161);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(196, 23);
            txtPostalCode.TabIndex = 12;
            txtPostalCode.Text = "  ";
            // 
            // txtRegion
            // 
            txtRegion.Location = new Point(326, 115);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(196, 23);
            txtRegion.TabIndex = 11;
            txtRegion.Text = "  ";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(6, 296);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(196, 23);
            txtCity.TabIndex = 10;
            txtCity.Text = "  ";
            // 
            // txtFax
            // 
            txtFax.Location = new Point(326, 296);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(196, 23);
            txtFax.TabIndex = 15;
            txtFax.Text = "  ";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(326, 248);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(196, 23);
            txtTelefono.TabIndex = 14;
            txtTelefono.Text = "  ";
            // 
            // grpDATOS
            // 
            grpDATOS.Controls.Add(txtCustomerID);
            grpDATOS.Controls.Add(lblCustomerID);
            grpDATOS.Controls.Add(lblFax);
            grpDATOS.Controls.Add(lblTelefono);
            grpDATOS.Controls.Add(blPais);
            grpDATOS.Controls.Add(lblCodigoPostal);
            grpDATOS.Controls.Add(label7);
            grpDATOS.Controls.Add(label6);
            grpDATOS.Controls.Add(label5);
            grpDATOS.Controls.Add(label4);
            grpDATOS.Controls.Add(label3);
            grpDATOS.Controls.Add(label2);
            grpDATOS.Controls.Add(txtCompanyName);
            grpDATOS.Controls.Add(txtFax);
            grpDATOS.Controls.Add(txtContactName);
            grpDATOS.Controls.Add(txtTelefono);
            grpDATOS.Controls.Add(txtContactTitle);
            grpDATOS.Controls.Add(txtPais);
            grpDATOS.Controls.Add(txtAddress);
            grpDATOS.Controls.Add(txtPostalCode);
            grpDATOS.Controls.Add(txtCity);
            grpDATOS.Controls.Add(txtRegion);
            grpDATOS.Location = new Point(388, 12);
            grpDATOS.Name = "grpDATOS";
            grpDATOS.Size = new Size(592, 326);
            grpDATOS.TabIndex = 16;
            grpDATOS.TabStop = false;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(11, 46);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(114, 23);
            txtCustomerID.TabIndex = 27;
            txtCustomerID.Validating += txtCustomerID_Validating;
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Location = new Point(6, 28);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(84, 15);
            lblCustomerID.TabIndex = 26;
            lblCustomerID.Text = "CUSTOMERID: ";
            // 
            // lblFax
            // 
            lblFax.AutoSize = true;
            lblFax.Location = new Point(326, 278);
            lblFax.Name = "lblFax";
            lblFax.Size = new Size(25, 15);
            lblFax.TabIndex = 25;
            lblFax.Text = "Fax";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(326, 230);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 24;
            lblTelefono.Text = "Telefono";
            // 
            // blPais
            // 
            blPais.AutoSize = true;
            blPais.Location = new Point(326, 188);
            blPais.Name = "blPais";
            blPais.Size = new Size(28, 15);
            blPais.TabIndex = 23;
            blPais.Text = "Pais";
            // 
            // lblCodigoPostal
            // 
            lblCodigoPostal.AutoSize = true;
            lblCodigoPostal.Location = new Point(326, 143);
            lblCodigoPostal.Name = "lblCodigoPostal";
            lblCodigoPostal.Size = new Size(81, 15);
            lblCodigoPostal.TabIndex = 22;
            lblCodigoPostal.Text = "Codigo Postal";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(326, 97);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 21;
            label7.Text = "Region";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 278);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 20;
            label6.Text = "Ciudad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 230);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 19;
            label5.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 188);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 18;
            label4.Text = "Titulo de Contacto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 143);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 17;
            label3.Text = "Nombre de Contacto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 97);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 16;
            label2.Text = "Nombre de la Compañia";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(174, 147);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 17;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(255, 147);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FrmApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 594);
            Controls.Add(btnLimpiar);
            Controls.Add(btnInsert);
            Controls.Add(grpDATOS);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dgvDATA);
            Controls.Add(btnSalir);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "FrmApp";
            Text = "PROGRAMACION2";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDATA).EndInit();
            grpDATOS.ResumeLayout(false);
            grpDATOS.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button btnSalir;
        private DataGridView dgvDATA;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtCompanyName;
        private TextBox txtContactName;
        private TextBox txtAddress;
        private TextBox txtContactTitle;
        private TextBox txtPais;
        private TextBox txtPostalCode;
        private TextBox txtRegion;
        private TextBox txtCity;
        private TextBox txtFax;
        private TextBox txtTelefono;
        private GroupBox grpDATOS;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblCustomerID;
        private Label lblFax;
        private Label lblTelefono;
        private Label blPais;
        private Label lblCodigoPostal;
        private Label label7;
        private Button btnInsert;
        private TextBox txtCustomerID;
        private Button btnLimpiar;
    }
}