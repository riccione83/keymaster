using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chiavi
{
    public partial class frmFreeKeys : Form
    {
        public Form1 mainFrm;
        private Users users = new Users();
        public frmFreeKeys()
        {
            InitializeComponent();
        }

        private void frmFreeKeys_Load(object sender, EventArgs e)
        {
            users.keys.loadFreeKey();

            foreach (Key key in users.keys.keys)
            {
                dgFreeKeys.Rows.Add();
                dgFreeKeys.Rows[dgFreeKeys.Rows.Count-1].Cells["KeyNumber"].Value = key.KeyNumber;
                dgFreeKeys.Rows[dgFreeKeys.Rows.Count-1].Cells["Description"].Value = key.Description;
                dgFreeKeys.Rows[dgFreeKeys.Rows.Count-1].Cells["ExpirationDate"].Value = key.ExpiryDate;
            }
        }

        private void dgFreeKeys_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string key_num = dgFreeKeys.Rows[e.RowIndex].Cells["KeyNumber"].Value.ToString();
            Key keySel = users.keys.current(key_num);
            mainFrm.setCurrentKey(keySel);
            this.Close();
        }
    }
}
