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

        KeyUtility keyUtility = new KeyUtility();
        private Users users = new Users();
        BarCodeReader barcode;
        bool isNew = false;
        bool newCard = false;

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
                updateCardInfo(users.keys.current());
            }
            else
            {
                DialogResult result = MessageBox.Show("La card non esiste. La creo nel database?", "Nuova Card", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if( result == System.Windows.Forms.DialogResult.Yes)
                {
                    Key key = new Key();
                    key.KeyNumber = text;
                    key.Description = "";
                    key.ExpiryDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    users.keys.newKey(key);
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
            keyUtility.refreshPositions(users.keys);
            string txt = keyUtility.searchFreeBoxSpace();
            MessageBox.Show("Preleva la busta e controlla che sia perfettamente integra. Verifica che il codice della busta sia " + users.keys.current().KeyNumber + ". Premi ok per il passo successivo");
            MessageBox.Show("Posiziona la busta nell'armadio nella posizione " + txt + ". Premi ok quando completato");
            int[] position = keyUtility.getFreeBoxSpace();
            keyUtility.setInBoxSpace(position[0], position[1], position[0]);
            users.keys.current().Position = position[0] + "-" + position[1] + "-" + position[2];
            users.keys.updateKey(users.keys.current());
        }

        private void button2_Click(object sender, EventArgs e)  //save
        {
            isNew = true;
            txtUserFirstName.Text = "";
            txtUserSurname.Text = "";
            txtUserAddress.Text = "";
            txtUserCity.Text = "";
            txtUserNote.Text = "";
            txtUserPassword.Text = "";
            txtUserSurname.Text = "";
            txtUserEmail.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Options opt = new Options();
            if(opt.UseSerialPort)
                barcode = new BarCodeReader(this,opt.ComPort,opt.BaudSpeed);

            if (users.current() != null)
            {
                selectUser(users.current());

                listUsers.Items.Clear();
                foreach (User user in users.users)
                {
                    listUsers.Items.Add(user.Surname + " " + user.Name);
                }
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
            User user;

            if (!isNew)
                user = users.current();
            else
                user = new User();
            
            user.Name = txtUserFirstName.Text;
            user.Surname = txtUserSurname.Text;
            user.Address = txtUserAddress.Text;
            user.City = txtUserCity.Text;
            user.EmailAddress = txtUserEmail.Text;
            user.Note = txtUserNote.Text;
            user.UserPassword = txtUserPassword.Text;
            if (isNew)
            {
                users.newUser(user);
                Mail mail = new Mail();
                string message = "Complimenti. Il suo conto KeyService è stato attivato. Potrà accedere dal nostro sito per verificare lo stato delle sue chiavi e verificare i pagamenti.\r\nI suoi dati per l'accesso sono:\r\nEmail: " + user.EmailAddress + "\r\nPassword:" + user.UserPassword + "\r\n\r\nLa ringraziamo per la preferenza accordataci. Cordiali Saluti.\r\nIl team KeyService";
                mail.sendMail(user.EmailAddress, "Attivazione conto KeyService", message);
            }
            else
            {
                users.saveUser(user);
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
            newCard = true;
            txtKeyNumber.Text = "";
            txtKeyDescription.Text = "";
            dateKeyExpiration.Value = DateTime.Now;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            updateCardInfo(users.keys.prev());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            updateCardInfo(users.keys.next());
        }

        private void printAssociatedKey(User user)
        {
            List<Key> keysForUser = users.getAssociatedKeys();
            dataKeyView.Rows.Clear();
            int index = 0;
            foreach (Key key in keysForUser)
            {
                dataKeyView.Rows.Add();
                dataKeyView.Rows[index].Cells["KeyNumber"].Value = key.KeyNumber;
                dataKeyView.Rows[index].Cells["Description"].Value = key.Description;
                dataKeyView.Rows[index].Cells["ExpirationDate"].Value = key.ExpiryDate;
                index++;
            }
        }

        private void selectUser(User user)
        {
            users.setCurrent(user);
            txtUserFirstName.Text = user.Name;
            txtUserSurname.Text = user.Surname;
            txtUserAddress.Text = user.Address;
            txtUserCity.Text = user.City;
            txtUserEmail.Text = user.EmailAddress;
            txtUserNote.Text = user.Note;
            txtUserPassword.Text = user.UserPassword;
            printAssociatedKey(user);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string question = "Sicuro di voler separate la CARD n." + users.keys.current().KeyNumber + " con il cliente " + users.current().Surname + " " + users.current().Name + "?";
            DialogResult result = MessageBox.Show(question, "Disassociare?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
                users.keys.deassociateFromUser(users.current().ID, users.keys.current());
        }

        private void fillPaymentsGrid(string UserID="", string KeyNumber="")
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (newCard)
            {
                if (users.keys.KeyExist(txtKeyNumber.Text) == 0)
                {
                    newCard = false;
                    Key key = new Key();
                    key.KeyNumber = txtKeyNumber.Text;
                    key.Description = txtKeyDescription.Text;
                    key.ExpiryDate = dateKeyExpiration.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    users.keys.newKey(key);
                }
                else
                {
                    MessageBox.Show("Chiave già presente in archivio", "Attenzione");
                }
            }
            else
            {
                Key key = users.keys.current();
                key.Description = txtKeyDescription.Text;
                key.ExpiryDate = dateKeyExpiration.Value.ToString("yyyy-MM-dd HH:mm:ss");
                users.keys.updateKey(key);
            }
        }

        private void dataKeyView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataKeyView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dataKeyView.SelectedRows[0];
                if (row.Cells["KeyNumber"].Value != null)
                {
                    string keyNumber = row.Cells["KeyNumber"].Value.ToString();
                    updateCardInfo(users.keys.current(keyNumber));
                }
            }
        }

        private void updateCardInfo(Key key)
        {
            if (key.KeyNumber != null)
            {
                txtKeyNumber.Text = key.KeyNumber;
                txtKeyDescription.Text = key.Description;
                dateKeyExpiration.Value = DateTime.Parse(key.ExpiryDate);
                txtKeyPosition.Text = "Posizione: " + key.readablePosition();
            }
            else
            {
                txtKeyNumber.Text = "";
                txtKeyDescription.Text = "";
                dateKeyExpiration.Value = DateTime.Now;
                txtKeyPosition.Text = "Posizione: Nessuna";
            }
        }

        private void dataKeyView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataKeyView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dataKeyView.SelectedRows[0];
                if (row.Cells["KeyNumber"].Value != null)
                {
                    string keyNumber = row.Cells["KeyNumber"].Value.ToString();
                    updateCardInfo(users.keys.current(keyNumber));
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            fillPaymentsGrid(users.current().ID);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            fillPaymentsGrid("",users.keys.current().KeyNumber);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La busta sta per essere asportata. Assicurarsi di prendere la busta dalla posizione:" + users.keys.current().readablePosition() + ". Verifica inoltre che la busta abbia il codice: " + users.keys.current().KeyNumber + ". Premi OK quando pronto.");
            users.keys.current().Position = "";
            users.keys.updateKey(users.keys.current());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            frmQuadro frm = new frmQuadro();
            frm.Show();
        }

        private void listUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listUsers.SelectedIndex;
            if (index >= 0)
            {
                selectUser(users.users[index]);
            }
        }

        private void ckOnlyNotAssociated_CheckedChanged(object sender, EventArgs e)
        {
            if (ckOnlyNotAssociated.Checked)
            {
                users.keys.loadFreeKey();
            }
            else
            {
                users.keys.loadAllKey();
            }
            updateCardInfo(users.keys.current());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Mail mail = new Mail();
            mail.sendTestMail();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            frmOptions opzioni = new frmOptions();
            DialogResult res = opzioni.ShowDialog(this);
            if (res != null)
            {
                Options opt = new Options();
                if (opt.UseSerialPort)
                {
                    if(barcode != null)
                    {
                        barcode = null;
                    }
                        
                    barcode = new BarCodeReader(this, opt.ComPort, opt.BaudSpeed);
                }
            }
        }
    }
}
