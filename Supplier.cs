﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imss
{
    public partial class Supplier : Sample2
    {
        public Supplier()
        {
            InitializeComponent();
        }

        int edit = 0;//This 0 is an indication of save operation and 1 is an indication to update operation
        int supplierID;
        short stat;
        retrieval r = new retrieval();
        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Supplier_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
        }
         public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure , you want to delete record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    deletion d = new deletion();
                    d.delete(supplierID, "st_deleteSupplier", "@suppID");
                    r.showSuppliers(dataGridView1, suppIDGV, companyGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, statusGV);
                }

            }
        }
       public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
            edit = 0;
        }
       public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftPanel); 
        }
       public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (supplierCompanyTxt.Text == "") { supNameErrorLabel.Visible = true; } else { supNameErrorLabel.Visible = false; }
            if (personNameTxt.Text == "") { contactPersonErrorLabel.Visible = true; } else { contactPersonErrorLabel.Visible = false; }
            if (phone1Txt.Text == "") { phone1ErrorLabel.Visible = true; } else { phone1ErrorLabel.Visible = false; }
            if (addressTxt.Text == "") { addressErrorLabel.Visible = true; } else { addressErrorLabel.Visible = false; }
            if (statusDD.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }
            if (supNameErrorLabel.Visible || contactPersonErrorLabel.Visible || phone1ErrorLabel.Visible || addressErrorLabel.Visible || statusErrorLabel.Visible)
            {
                MainClass.ShowMSG("fields with * are mendatory", "stop", "Error");// Error is the type of msg
            }
            else
            {

                if (statusDD.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (statusDD.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0)//code for save operation
                {

                    insertion i = new insertion();
                    if (phone2Txt.Text == "" && ntnTxt.Text!= "")
                    {
                        i.insertsupplier(supplierCompanyTxt.Text,personNameTxt.Text,phone1Txt.Text,addressTxt.Text,stat,null,ntnTxt.Text);
                    }
                    else if (phone2Txt.Text != "" && ntnTxt.Text == "")
                    {
                        i.insertsupplier(supplierCompanyTxt.Text, personNameTxt.Text, phone1Txt.Text, addressTxt.Text, stat,phone2Txt.Text,null);
                    }
                    else if (phone2Txt.Text == "" && ntnTxt.Text == "")
                    {
                        i.insertsupplier(supplierCompanyTxt.Text, personNameTxt.Text, phone1Txt.Text, addressTxt.Text, stat, null,null);
                    }
                    else
                    {
                        i.insertsupplier(supplierCompanyTxt.Text, personNameTxt.Text, phone1Txt.Text, addressTxt.Text, stat,phone2Txt.Text,ntnTxt.Text);
                    }

                    r.showSuppliers(dataGridView1,suppIDGV,companyGV,personGV,phone1GV,phone2GV,addressGV,ntnGV,statusGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1)//code for update operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure , you want to update record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();
                        if (statusDD.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (statusDD.SelectedIndex == 1)
                        {
                            stat = 0;
                        }

                        if (phone2Txt.Text == "" && ntnTxt.Text != "")
                        { 
                            u.updatesupplier(supplierID, supplierCompanyTxt.Text, personNameTxt.Text, phone1Txt.Text, addressTxt.Text,stat,null, ntnTxt.Text);
          
                        }
                        else if (phone2Txt.Text != "" && ntnTxt.Text == "")
                        {
                            u.updatesupplier(supplierID, supplierCompanyTxt.Text, personNameTxt.Text, phone1Txt.Text, addressTxt.Text, stat, phone2Txt.Text,null); 
                        }
                        else if (phone2Txt.Text == "" && ntnTxt.Text == "")
                        {
                            u.updatesupplier(supplierID, supplierCompanyTxt.Text, personNameTxt.Text, phone1Txt.Text, addressTxt.Text, stat, null, null);
                        }
                        else
                        {
                            
                        }

                       
                        r.showSuppliers(dataGridView1, suppIDGV, companyGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, statusGV);
                        MainClass.disable_reset(leftPanel);
                    }

                }
            }
        }

       public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

       public override void viewBtn_Click(object sender, EventArgs e)
       {
           r.showSuppliers(dataGridView1, suppIDGV, companyGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, statusGV);
       }

       private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
       {
           if(e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                supplierID = Convert.ToInt32(row.Cells["suppIDGV"].Value.ToString());
                supplierCompanyTxt.Text = row.Cells["companyGV"].Value.ToString();
                personNameTxt.Text = row.Cells["personGV"].Value.ToString();
                phone1Txt.Text = row.Cells["phone1GV"].Value.ToString();
                phone2Txt.Text = row.Cells["phone2GV"].Value.ToString();
                ntnTxt.Text = row.Cells["ntnGV"].Value.ToString();
                addressTxt.Text = row.Cells["addressGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["statusGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
       }
    }
}
