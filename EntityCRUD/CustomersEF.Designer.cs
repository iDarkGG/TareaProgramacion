namespace EntityCRUD
{
    partial class CustomersEF
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvDATA = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactTitle = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.grpDATOS = new System.Windows.Forms.GroupBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.blPais = new System.Windows.Forms.Label();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDATA)).BeginInit();
            this.grpDATOS.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "CARGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "POR FAVOR SELECCIONE UNA OPCION";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(223, 116);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvDATA
            // 
            this.dgvDATA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDATA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDATA.Location = new System.Drawing.Point(0, 444);
            this.dgvDATA.Name = "dgvDATA";
            this.dgvDATA.RowTemplate.Height = 25;
            this.dgvDATA.Size = new System.Drawing.Size(1011, 150);
            this.dgvDATA.TabIndex = 3;
            this.dgvDATA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDATA_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(93, 116);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(93, 145);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(6, 115);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(196, 23);
            this.txtCompanyName.TabIndex = 6;
            this.txtCompanyName.Text = "  ";
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(6, 161);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(196, 23);
            this.txtContactName.TabIndex = 7;
            this.txtContactName.Text = "  ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(6, 248);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(196, 23);
            this.txtAddress.TabIndex = 9;
            this.txtAddress.Text = "  ";
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.Location = new System.Drawing.Point(6, 206);
            this.txtContactTitle.Name = "txtContactTitle";
            this.txtContactTitle.Size = new System.Drawing.Size(196, 23);
            this.txtContactTitle.TabIndex = 8;
            this.txtContactTitle.Text = "  ";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(326, 206);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(196, 23);
            this.txtPais.TabIndex = 13;
            this.txtPais.Text = "  ";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(326, 161);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(196, 23);
            this.txtPostalCode.TabIndex = 12;
            this.txtPostalCode.Text = "  ";
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(326, 115);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(196, 23);
            this.txtRegion.TabIndex = 11;
            this.txtRegion.Text = "  ";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(6, 296);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(196, 23);
            this.txtCity.TabIndex = 10;
            this.txtCity.Text = "  ";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(326, 296);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(196, 23);
            this.txtFax.TabIndex = 15;
            this.txtFax.Text = "  ";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(326, 248);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(196, 23);
            this.txtTelefono.TabIndex = 14;
            this.txtTelefono.Text = "  ";
            // 
            // grpDATOS
            // 
            this.grpDATOS.Controls.Add(this.txtCustomerID);
            this.grpDATOS.Controls.Add(this.lblCustomerID);
            this.grpDATOS.Controls.Add(this.lblFax);
            this.grpDATOS.Controls.Add(this.lblTelefono);
            this.grpDATOS.Controls.Add(this.blPais);
            this.grpDATOS.Controls.Add(this.lblCodigoPostal);
            this.grpDATOS.Controls.Add(this.label7);
            this.grpDATOS.Controls.Add(this.label6);
            this.grpDATOS.Controls.Add(this.label5);
            this.grpDATOS.Controls.Add(this.label4);
            this.grpDATOS.Controls.Add(this.label3);
            this.grpDATOS.Controls.Add(this.label2);
            this.grpDATOS.Controls.Add(this.txtCompanyName);
            this.grpDATOS.Controls.Add(this.txtFax);
            this.grpDATOS.Controls.Add(this.txtContactName);
            this.grpDATOS.Controls.Add(this.txtTelefono);
            this.grpDATOS.Controls.Add(this.txtContactTitle);
            this.grpDATOS.Controls.Add(this.txtPais);
            this.grpDATOS.Controls.Add(this.txtAddress);
            this.grpDATOS.Controls.Add(this.txtPostalCode);
            this.grpDATOS.Controls.Add(this.txtCity);
            this.grpDATOS.Controls.Add(this.txtRegion);
            this.grpDATOS.Location = new System.Drawing.Point(388, 12);
            this.grpDATOS.Name = "grpDATOS";
            this.grpDATOS.Size = new System.Drawing.Size(592, 326);
            this.grpDATOS.TabIndex = 16;
            this.grpDATOS.TabStop = false;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(11, 46);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(114, 23);
            this.txtCustomerID.TabIndex = 27;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(6, 28);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(84, 15);
            this.lblCustomerID.TabIndex = 26;
            this.lblCustomerID.Text = "CUSTOMERID: ";
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(326, 278);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(25, 15);
            this.lblFax.TabIndex = 25;
            this.lblFax.Text = "Fax";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(326, 230);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 15);
            this.lblTelefono.TabIndex = 24;
            this.lblTelefono.Text = "Telefono";
            // 
            // blPais
            // 
            this.blPais.AutoSize = true;
            this.blPais.Location = new System.Drawing.Point(326, 188);
            this.blPais.Name = "blPais";
            this.blPais.Size = new System.Drawing.Size(28, 15);
            this.blPais.TabIndex = 23;
            this.blPais.Text = "Pais";
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Location = new System.Drawing.Point(326, 143);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(81, 15);
            this.lblCodigoPostal.TabIndex = 22;
            this.lblCodigoPostal.Text = "Codigo Postal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Region";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ciudad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Titulo de Contacto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre de Contacto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre de la Compañia";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(174, 147);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(255, 147);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 594);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.grpDATOS);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvDATA);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROGRAMACION2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDATA)).EndInit();
            this.grpDATOS.ResumeLayout(false);
            this.grpDATOS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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