namespace imss
{
    partial class CustomerDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.customerNameTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addressErrorLabel = new System.Windows.Forms.Label();
            this.statusErrorLabel = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.phoneErrorLabel = new System.Windows.Forms.Label();
            this.customerNameErrorLabel = new System.Windows.Forms.Label();
            this.salesIDTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.salesIDErrorLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.salesIDTxt);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.salesIDErrorLabel);
            this.leftPanel.Controls.Add(this.phoneTxt);
            this.leftPanel.Controls.Add(this.label11);
            this.leftPanel.Controls.Add(this.statusDD);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.emailTxt);
            this.leftPanel.Controls.Add(this.label12);
            this.leftPanel.Controls.Add(this.addressTxt);
            this.leftPanel.Controls.Add(this.label10);
            this.leftPanel.Controls.Add(this.customerNameTxt);
            this.leftPanel.Controls.Add(this.label8);
            this.leftPanel.Controls.Add(this.addressErrorLabel);
            this.leftPanel.Controls.Add(this.statusErrorLabel);
            this.leftPanel.Controls.Add(this.phoneErrorLabel);
            this.leftPanel.Controls.Add(this.customerNameErrorLabel);
            this.leftPanel.Controls.SetChildIndex(this.customerNameErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.phoneErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.addressErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label8, 0);
            this.leftPanel.Controls.SetChildIndex(this.customerNameTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label10, 0);
            this.leftPanel.Controls.SetChildIndex(this.addressTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label12, 0);
            this.leftPanel.Controls.SetChildIndex(this.emailTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.label11, 0);
            this.leftPanel.Controls.SetChildIndex(this.phoneTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.salesIDErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.salesIDTxt, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // statusDD
            // 
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.statusDD.Location = new System.Drawing.Point(10, 439);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(218, 23);
            this.statusDD.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Status";
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(8, 305);
            this.emailTxt.MaxLength = 50;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(218, 23);
            this.emailTxt.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 15);
            this.label12.TabIndex = 29;
            this.label12.Text = "Email";
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(8, 349);
            this.addressTxt.MaxLength = 20;
            this.addressTxt.Multiline = true;
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(218, 64);
            this.addressTxt.TabIndex = 26;
            this.addressTxt.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Address";
            // 
            // customerNameTxt
            // 
            this.customerNameTxt.Location = new System.Drawing.Point(8, 210);
            this.customerNameTxt.MaxLength = 35;
            this.customerNameTxt.Name = "customerNameTxt";
            this.customerNameTxt.Size = new System.Drawing.Size(218, 23);
            this.customerNameTxt.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Customer Name";
            // 
            // addressErrorLabel
            // 
            this.addressErrorLabel.AutoSize = true;
            this.addressErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.addressErrorLabel.Location = new System.Drawing.Point(64, 327);
            this.addressErrorLabel.Name = "addressErrorLabel";
            this.addressErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.addressErrorLabel.TabIndex = 33;
            this.addressErrorLabel.Text = "*";
            // 
            // statusErrorLabel
            // 
            this.statusErrorLabel.AutoSize = true;
            this.statusErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.statusErrorLabel.Location = new System.Drawing.Point(50, 416);
            this.statusErrorLabel.Name = "statusErrorLabel";
            this.statusErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.statusErrorLabel.TabIndex = 37;
            this.statusErrorLabel.Text = "*";
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(8, 260);
            this.phoneTxt.MaxLength = 15;
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(218, 23);
            this.phoneTxt.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 15);
            this.label11.TabIndex = 38;
            this.label11.Text = "Phone(03XX-XXXXXXX)";
            // 
            // phoneErrorLabel
            // 
            this.phoneErrorLabel.AutoSize = true;
            this.phoneErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.phoneErrorLabel.Location = new System.Drawing.Point(138, 236);
            this.phoneErrorLabel.Name = "phoneErrorLabel";
            this.phoneErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.phoneErrorLabel.TabIndex = 40;
            this.phoneErrorLabel.Text = "*";
            // 
            // customerNameErrorLabel
            // 
            this.customerNameErrorLabel.AutoSize = true;
            this.customerNameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.customerNameErrorLabel.Location = new System.Drawing.Point(106, 186);
            this.customerNameErrorLabel.Name = "customerNameErrorLabel";
            this.customerNameErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.customerNameErrorLabel.TabIndex = 41;
            this.customerNameErrorLabel.Text = "*";
            // 
            // salesIDTxt
            // 
            this.salesIDTxt.Location = new System.Drawing.Point(8, 163);
            this.salesIDTxt.MaxLength = 35;
            this.salesIDTxt.Name = "salesIDTxt";
            this.salesIDTxt.Size = new System.Drawing.Size(218, 23);
            this.salesIDTxt.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 42;
            this.label5.Text = "Sales ID";
            // 
            // salesIDErrorLabel
            // 
            this.salesIDErrorLabel.AutoSize = true;
            this.salesIDErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesIDErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.salesIDErrorLabel.Location = new System.Drawing.Point(61, 139);
            this.salesIDErrorLabel.Name = "salesIDErrorLabel";
            this.salesIDErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.salesIDErrorLabel.TabIndex = 44;
            this.salesIDErrorLabel.Text = "*";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGV,
            this.salesIDGV,
            this.customerNameGV,
            this.PhoneGV,
            this.EmailGV,
            this.addressGV,
            this.statusGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(826, 610);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idGV
            // 
            this.idGV.HeaderText = "id";
            this.idGV.Name = "idGV";
            this.idGV.ReadOnly = true;
            this.idGV.Visible = false;
            // 
            // salesIDGV
            // 
            this.salesIDGV.HeaderText = "SalesID";
            this.salesIDGV.Name = "salesIDGV";
            this.salesIDGV.ReadOnly = true;
            // 
            // customerNameGV
            // 
            this.customerNameGV.HeaderText = "Customer Name";
            this.customerNameGV.Name = "customerNameGV";
            this.customerNameGV.ReadOnly = true;
            // 
            // PhoneGV
            // 
            this.PhoneGV.HeaderText = "Phone #";
            this.PhoneGV.Name = "PhoneGV";
            this.PhoneGV.ReadOnly = true;
            // 
            // EmailGV
            // 
            this.EmailGV.HeaderText = "Email";
            this.EmailGV.Name = "EmailGV";
            this.EmailGV.ReadOnly = true;
            // 
            // addressGV
            // 
            this.addressGV.HeaderText = "Address";
            this.addressGV.Name = "addressGV";
            this.addressGV.ReadOnly = true;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // CustomerDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 770);
            this.Name = "CustomerDetail";
            this.Text = "Customer Detail";
            this.Load += new System.EventHandler(this.CustomerDetail_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox statusDD;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox emailTxt;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox addressTxt;
        public System.Windows.Forms.Label label10;
        protected System.Windows.Forms.TextBox customerNameTxt;
        protected System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label addressErrorLabel;
        public System.Windows.Forms.Label statusErrorLabel;
        protected System.Windows.Forms.TextBox salesIDTxt;
        protected System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label salesIDErrorLabel;
        public System.Windows.Forms.TextBox phoneTxt;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label phoneErrorLabel;
        public System.Windows.Forms.Label customerNameErrorLabel;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
    }
}