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
    public partial class frmSinottico    : Form
    {
        KeyUtility utils = new KeyUtility();
        Users users;
        public frmSinottico()
        {
            InitializeComponent();
        }

        private void fillKeyPosition()
        {
            Options opt = new Options();

            foreach (Key key in users.keys.keys)
            {
                string[] currentKey = key.Position.Split('-');
                if (currentKey.Length >= 3)
                {
                    int x = int.Parse(currentKey[0]);
                    int y = int.Parse(currentKey[1]);
                    int z = int.Parse(currentKey[2]);

                    DataGridView dgView = (DataGridView)(tabControl1.TabPages[x].Controls.Find("grid" + x, true)[0]);
                    dgView.Columns[z].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dgView.Columns[z].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
                    dgView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    if (dgView.Rows[y].Cells[z].Value != null)
                        dgView.Rows[y].Cells[z].Value += Environment.NewLine + key.KeyNumber;
                    else
                        dgView.Rows[y].Cells[z].Value = key.KeyNumber;

                    string[] tmp = dgView.Rows[y].Cells[z].Value.ToString().Split('\n');
                    if (tmp.Length < opt.numOfKeyPerBox && tmp.Length >= 1)
                        dgView.Rows[y].Cells[z].Style.BackColor = Color.Yellow;
                    else if (tmp.Length == opt.numOfKeyPerBox)
                        dgView.Rows[y].Cells[z].Style.BackColor = Color.Red;   
                }
            }
        }

        private void frmQuadro_Load(object sender, EventArgs e)
        {

        }

        private void frmQuadro_Shown(object sender, EventArgs e)
        {
            users = new Users();

            for (int i = 0; i < utils.getNumOfBox() * 2; i++)
            {
                string title = utils.getFace(i);
                TabPage myTabPage = new TabPage(title);
                DataGridView dgView = new DataGridView();
                myTabPage.Size = tabControl1.Size;
                dgView.Size = myTabPage.Size;
                dgView.Name = "grid" + i;
                for (int y = 0; y < utils.getNumOfCols(); y++)
                {
                    DataGridViewColumn col = new DataGridViewTextBoxColumn();
                    col.HeaderText = y.ToString();
                    int colIndex = dgView.Columns.Add(col);
                }

                dgView.Rows.Add(utils.getNumOfRows());

                for (int z = 0; z < utils.getNumOfRows(); z++)
                    dgView.Rows[z].HeaderCell.Value = z.ToString();

                myTabPage.Controls.Add(dgView);
                tabControl1.TabPages.Add(myTabPage);
            }

            fillKeyPosition();
        }
    }
}
