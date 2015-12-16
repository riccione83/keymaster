using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chiavi
{
    public partial class frmPagamenti : Form
    {
        public string KeyNumber = "";
        public string UserID = "";

        public frmPagamenti()
        {
            InitializeComponent();
        }

        private void frmPagamenti_Load(object sender, EventArgs e)
        {
            fillPaymentsGrid(UserID,KeyNumber);
        }

        private void fillPaymentsGrid(string UserID = "", string KeyNumber = "")
        {
            if (UserID == "" && KeyNumber == "") return;
            string sql = "";
            DBConnect database = new DBConnect();
            if (UserID != "")
                sql = "SELECT * FROM Payments WHERE USER_ID = '" + UserID + "'";
            else if (KeyNumber != "")
                sql = "SELECT * FROM Payments WHERE key_number = '" + KeyNumber + "'";

            List<Dictionary<string, object>> returnedData = database.SelectMultiple(sql);
            int index = 0;
            paymentData.Rows.Clear();
            foreach (var payment in returnedData)
            {
                paymentData.Rows.Add();
                paymentData.Rows[index].Cells["ID"].Value = payment["id"].ToString();
                paymentData.Rows[index].Cells["PaymentID"].Value = payment["payment_id"].ToString();
                paymentData.Rows[index].Cells["Hash"].Value = payment["hash"].ToString();
                paymentData.Rows[index].Cells["Complete"].Value = payment["complete"].ToString() == "1" ? "Si" : "No";
                paymentData.Rows[index].Cells["KeyNum"].Value = payment["key_number"].ToString();
                paymentData.Rows[index].Cells["CreatedAt"].Value = payment["CreatedAt"].ToString();
                index++;
            }
        }

        private string exportPaymentData()
        {
            int numOfPayments = paymentData.Rows.Count;
            string paymentList = "";
            for (int i = 0; i < numOfPayments; i++)
            {
                string txt = "Chiave n. " + paymentData.Rows[i].Cells["KeyNum"].Value;
                txt += Environment.NewLine + "Pagamento n. " + paymentData.Rows[i].Cells["ID"].Value.ToString() + " del " + paymentData.Rows[i].Cells["CreatedAt"].Value;
                txt += Environment.NewLine + "Paypal ID: " + paymentData.Rows[i].Cells["PaymentID"].Value;
                txt += Environment.NewLine + "Pagamento completato: " + paymentData.Rows[i].Cells["Complete"].Value;
                txt += Environment.NewLine + Environment.NewLine;
                paymentList += txt;
            }
            return paymentList;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (exportFileDialog.ShowDialog() == DialogResult.OK)
            {
                string text = exportPaymentData();
                StreamWriter wr = new StreamWriter(exportFileDialog.FileName);
                wr.Write(text);
                wr.Flush();
                wr.Close();
            }
        }

    }
}
