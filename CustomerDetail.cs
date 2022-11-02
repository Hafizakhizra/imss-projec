using System;
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
    public partial class CustomerDetail : Sample2
    {
        int edit = 0;//This 0 is an indication of save operation and 1 is an indication to update operation
        int salesID;
        short stat;
        public CustomerDetail()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
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
            if (salesIDTxt.Text == "") { salesIDErrorLabel.Visible = true; } else { salesIDErrorLabel.Visible = false; }
            if (customerNameTxt.Text == "") { customerNameErrorLabel.Visible = true; } else { customerNameErrorLabel.Visible = false; }
            if (phoneTxt.Text == "") { phoneErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }
            //if (emailTxt.Text == "") { emailErrorLabel.Visible = true; } else { emailErrorLabel.Visible = false; }
            if (addressTxt.Text == "") { addressErrorLabel.Visible = true; } else { addressErrorLabel.Visible = false; }
            if (statusDD.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { phoneErrorLabel.Visible = false; }
            if (salesIDErrorLabel.Visible||customerNameErrorLabel.Visible || phoneErrorLabel.Visible || addressErrorLabel.Visible || statusErrorLabel.Visible)
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

                    i.insertcustomerDetail(Convert.ToInt32(salesIDTxt.Text), customerNameTxt.Text, phoneTxt.Text, emailTxt.Text, addressTxt.Text, stat);
                    r.showcustomerDetail(dataGridView1,salesIDGV, customerNameGV, PhoneGV, EmailGV, addressGV, statusGV);
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

                        u.updatecustomerDetail(salesIDTxt.Text, customerNameTxt.Text, phoneTxt.Text,emailTxt.Text, addressTxt.Text, stat);
                        r.showcustomerDetail(dataGridView1,salesIDGV, customerNameGV, PhoneGV, EmailGV, addressGV, statusGV);
                        MainClass.disable_reset(leftPanel);
                    }

                }
            }
        }

        private void CustomerDetail_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showcustomerDetail(dataGridView1, salesIDGV, customerNameGV, PhoneGV, EmailGV, addressGV, statusGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                salesIDTxt.Text = row.Cells["salesIDGV"].Value.ToString();
                customerNameTxt.Text = row.Cells["customerNameGV"].Value.ToString();
                phoneTxt.Text = row.Cells["phoneGV"].Value.ToString();
                emailTxt.Text = row.Cells["EmailGV"].Value.ToString();
                addressTxt.Text = row.Cells["addressGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
        }
        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure , you want to delete record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    deletion d = new deletion();
                    d.delete(salesID, "st_customerDetailDelete", "@id");
                    r.showcustomerDetail(dataGridView1, salesIDGV, customerNameGV, PhoneGV, EmailGV, addressGV, statusGV);
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Refresh();
        }
    }
}
