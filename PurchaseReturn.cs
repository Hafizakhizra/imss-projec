using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imss
{
    public partial class PurchaseReturn : Sample2
    {
        public PurchaseReturn()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        deletion d = new deletion();
        Regex rg = new Regex("^[0-9]+$");

      private void loadBtn_Click(object sender, EventArgs e)
        {
             if (purchaseIDTxt.Text != "")
            {
                if (rg.Match(purchaseIDTxt.Text).Success)
                {

                    r.showPurchaseDataViaID(Convert.ToInt64(purchaseIDTxt.Text), dataGridView1, purchaseIDGV, barcodeGV, proIDGV, productGV,
                        quantityGV,perUnitPriceGV,totalAmountGV); 

                    if (dataGridView1.RowCount > 0)
                    {
                        dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[0].Cells["dateGV"].Value);
                        supplierTxt.Text = dataGridView1.Rows[0].Cells["UserGV"].Value.ToString();


                    }
                }
                else
                {
                    purchaseIDTxt.Text = "";
                    purchaseIDTxt.Focus();
                    dateTimePicker1.Value = DateTime.Now;
                    supplierTxt.Text = "";
                }
            }
            else
            {
                dateTimePicker1.Value = DateTime.Now;
                supplierTxt.Text = "";
             
            }
        }


      //insertion i = new insertion();
      //updation u = new updation();

      //public override void saveBtn_Click(object sender, EventArgs e)
      //{

      //    if (refundTxt.Text != "" && ht.Count > 0 && enterPurchaseIDTxt.Text != "")
      //    {
      //        DialogResult dr = MessageBox.Show("Are you sure , You wanted to proceed?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      //        if (dr == DialogResult.Yes)
      //        {
      //            using (TransactionScope sc = new TransactionScope())
      //            {
      //                int x = 0;
      //                foreach (DictionaryEntry de in ht)
      //                {

      //                    x += i.insertReturnRefund(Convert.ToInt64(salesIDTxt.Text), DateTime.Now, retrieval.USER_ID, Convert.ToInt64(de.Key), Convert.ToInt16(de.Value), Convert.ToInt64(amount_refund));
      //                    //  x = i.insertReturnRefund(Convert.ToInt64(salesIDTxt.Text), DateTime.Now, retrieval.USER_ID, Convert.ToInt64(de.Key), Convert.ToInt16(de.Value), Convert.ToInt64(de.Key));
      //                    int currentquantity = (int)r.getProductQuantity(Convert.ToInt64(de.Key));
      //                    int finalquantity = currentquantity + Convert.ToInt16(de.Value);
      //                    // d.delete(Convert.ToInt64(salesIDTxt.Text), "st_Return_Refund", "@id");
      //                    //   d.delete(proIDGV, "st_Return_Refund", "@id");
      //                    u.updateStocks(Convert.ToInt64(de.Key), finalquantity);

      //                }
      //                if (x > 0)
      //                {
      //                    MainClass.ShowMSG("Return and Refund Successfull", "Success", "Success");
      //                    x = 0;
      //                    ht.Clear();

      //                }

      //                sc.Complete();

      //            }

      //        }
      //    }
      //    else
      //    {
      //        MainClass.ShowMSG("Please provide complete details", "Error", "Error");
      //    }

      //}
      //float amount_refund = 0;
      //Hashtable ht = new Hashtable();

      private void enterPurchaseIDTxt_TextChanged(object sender, EventArgs e)
      {

      }

      private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {

          if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
          {
              dataGridView1.CurrentRow.Selected = true;
              string barcode = dataGridView1.Rows[e.RowIndex].Cells["Barcode"].FormattedValue.ToString();
              //var st = (from s in db.imssDB where s.Barcode == int.pro(barcode) select s).First();
              //db.imssDB.DeleteOnSubmit(st);
              //db.SubmitChange();
              MessageBox.Show("Successfully Deleted..");
          }


      }
    }
}
