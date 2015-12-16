using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Chiavi
{
    public partial class frmSearch : Form
    {
        private Users users = new Users();
        public Form1 mainFrm;
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            doSearch(textBox1.Text);
        }

        private void doSearch(string text)
        {
            List<User> userFinded = new List<User>();
            List<Key> keyFinded = new List<Key>();

            dgSearchUser.Rows.Clear();
            dgSearchKey.Rows.Clear();

            if (text != "")
            {

                foreach (User user in users.users)
                {
                    if (user.Name.ToLower().Contains(text.ToLower()) ||
                        user.Surname.ToLower().Contains(text.ToLower()) ||
                        user.Address.ToLower().Contains(text.ToLower()) ||
                        user.City.ToLower().Contains(text.ToLower()) ||
                        user.Note.ToLower().Contains(text.ToLower())
                      )
                    {
                        userFinded.Add(user);
                    }
                }

                foreach (Key key in users.keys.keys)
                {
                    if (key.Description.ToLower().Contains(text.ToLower()) ||
                       key.KeyNumber.Contains(text.ToLower())
                      )
                    {
                        keyFinded.Add(key);
                    }
                }

                int index = 0;
                foreach (User user in userFinded)
                {
                    dgSearchUser.Rows.Add();
                    dgSearchUser.Rows[index].Cells["Cognome"].Value = user.Surname;
                    dgSearchUser.Rows[index].Cells["Nome"].Value = user.Name;
                    dgSearchUser.Rows[index].Cells["Email"].Value = user.EmailAddress;
                    dgSearchUser.Rows[index].Cells["Address"].Value = user.Address;
                    dgSearchUser.Rows[index].Cells["City"].Value = user.City;
                    dgSearchUser.Rows[index].Cells["Note"].Value = user.Note;
                    dgSearchUser.Rows[index].HeaderCell.Value = user.ID;
                    index++;
                }

                index = 0;
                foreach (Key key in keyFinded)
                {
                    dgSearchKey.Rows.Add();
                    dgSearchKey.Rows[index].Cells["KeyNumber"].Value = key.KeyNumber;
                    dgSearchKey.Rows[index].Cells["Description"].Value = key.Description;
                    dgSearchKey.Rows[index].Cells["ExpirationDate"].Value = key.ExpiryDate;
                    dgSearchKey.Rows[index].HeaderCell.Value = key.ID;
                    index++;
                }
            }
        }

        private void dgSearchUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgSearchUser.Rows[e.RowIndex].HeaderCell.Value.ToString();
            User user = users.searchUserByID(id);
            mainFrm.selectUser(user);
            this.Close();
        }

        private void dgSearchKey_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgSearchUser_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgSearchKey_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgSearchKey.Rows[e.RowIndex].Cells["KeyNumber"].Value.ToString();
            Key key = users.keys.current(id);
            User user = users.keys.getUserForKey(key.KeyNumber);
            mainFrm.selectUser(user);
            mainFrm.updateCardInfo(key);
            this.Close();
        }
    }
}

/*
 * Name
Surname
Email
Password
Address
City
Note
Free
 */

/*
include("db_con.php");
//search all fields
$searchphrase = "banan";
$table = "apa303";
$sql_search = "select * from ".$table." where ";
$sql_search_fields = Array();
$sql = "SHOW COLUMNS FROM ".$table;
$rs = mysql_query($sql);
    while($r = mysql_fetch_array($rs)){
        $colum = $r[0];
        $sql_search_fields[] = $colum." like('%".$searchphrase."%')";
    }

$sql_search .= implode(" OR ", $sql_search_fields);
$rs2 = mysql_query($sql_search);
$out = mysql_num_rows($rs2)."\n";
echo "Number of search hits in $table " . $out;
*/