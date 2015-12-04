using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Chiavi
{
    public partial class Form1 : Form
    {
        delegate void SetTextCallback(string text);

        KeyUtility key = new KeyUtility();
        Users users = new Users();
        BarCodeReader barcode;
        bool isNew = false;

        public void barcodeData(string barCodeDataText)
        {
            if (barCodeDataText != "")
            {
                this.BeginInvoke(new SetTextCallback(SetText), new object[] { barCodeDataText });// txtKeyNumber.Text = barCodeDataText;
            }
        }

        private void SetText(string text)
        {
            if(users.keys.KeyExist(text)>0)
            {
               // MessageBox.Show("La card esiste. Carico il cliente");
                User cardUser = users.keys.getUserForKey(text);
                selectUser(cardUser);
            }
            else
            {
                DialogResult result = MessageBox.Show("La card non esiste. La creo nel database?", "Nuova Card", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if( result == System.Windows.Forms.DialogResult.Yes)
                {
                    users.keys.newKey(text);
                    MessageBox.Show("Card creata con successo");
                }

            }
            this.txtKeyNumber.Text = text;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = key.searchFreeBoxSpace();
        }

        private void button2_Click(object sender, EventArgs e)  //save
        {
            isNew = true;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {          
            barcode = new BarCodeReader(this);
            if (users.current() != null)
            {
                selectUser(users.current());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            isNew = false;
            users.next();
            selectUser(users.current());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isNew = false;
            users.prev();
            selectUser(users.current());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!isNew)
            {
                User user = users.current();
                user.Name = textBox1.Text;
                user.Surname = textBox2.Text;
            }
            else
            {
                 User user = new User();
                 user.Name = textBox1.Text;
                 user.Surname = textBox2.Text;
                 users.newUser(user);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string question = "Sicuro di voler associare la CARD n."+users.keys.current().KeyNumber+" con il cliente "+users.current().Surname+" "+users.current().Name+"?";
            DialogResult result = MessageBox.Show(question, "Associare?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == System.Windows.Forms.DialogResult.Yes)
                users.keys.associateToUser(users.current().ID,users.keys.current());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            users.keys.newKey(txtKeyNumber.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            users.keys.prev();
            txtKeyNumber.Text = users.keys.current().KeyNumber;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            users.keys.next();
            txtKeyNumber.Text = users.keys.current().KeyNumber;
        }

        private void printAssociatedKey(User user)
        {
            List<Key> keysForUser = users.getAssociatedKeys();
            listBox1.Items.Clear();
            listBox1.Items.Add("Key for selected user:");
            foreach (Key key in keysForUser)
            {
                listBox1.Items.Add(key.KeyNumber);
            }
        }

        private void selectUser(User user)
        {
            users.setCurrent(user);
            textBox1.Text = user.Name;
            textBox2.Text = user.Surname;
            printAssociatedKey(user);
            fillPaymentsGrid();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string question = "Sicuro di voler separate la CARD n." + users.keys.current().KeyNumber + " con il cliente " + users.current().Surname + " " + users.current().Name + "?";
            DialogResult result = MessageBox.Show(question, "Disassociare?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
                users.keys.deassociateFromUser(users.current().ID, users.keys.current());
        }

        private void fillPaymentsGrid()
        {
            DBConnect database = new DBConnect();
            string sql = "SELECT * FROM Payments";
            List<Dictionary<string, object>> returnedData = database.SelectMultiple(sql);
            int index = 0;
            foreach (var payment in returnedData)
            {
                paymentData.Rows.Add();
                paymentData.Rows[index].Cells[0].Value = payment["id"].ToString();
                paymentData.Rows[index].Cells[1].Value = payment["txnid"].ToString();
                paymentData.Rows[index].Cells[2].Value = payment["payment_amount"].ToString();
                paymentData.Rows[index].Cells[3].Value = payment["payment_status"].ToString();
                paymentData.Rows[index].Cells[4].Value = payment["itemid"].ToString();
                paymentData.Rows[index].Cells[5].Value = payment["createdtime"].ToString();
                index++;
            }
        }
    }
}


/*
	id	int(6)			No	None	AUTO_INCREMENT	Change Change	Drop Drop	
	2	txnid	varchar(20)	latin1_swedish_ci		No	None		Change Change	Drop Drop	
	3	payment_amount	decimal(7,2)			No	None		Change Change	Drop Drop	
	4	payment_status	varchar(25)	latin1_swedish_ci		No	None		Change Change	Drop Drop	
	5	itemid	int(10)			No	None		Change Change	Drop Drop	
  6	userid	int(10)			No	None		Change Change	Drop Drop	
	7	createdtime*/