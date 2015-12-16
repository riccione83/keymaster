namespace Chiavi
{
    partial class frmPagamenti
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
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.paymentData = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuPagamenti = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentData)).BeginInit();
            this.menuPagamenti.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.paymentData);
            this.groupBox3.Location = new System.Drawing.Point(3, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(823, 326);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pagamenti";
            // 
            // paymentData
            // 
            this.paymentData.AllowUserToAddRows = false;
            this.paymentData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CreatedAt,
            this.PaymentID,
            this.Hash,
            this.Complete,
            this.KeyNum});
            this.paymentData.ContextMenuStrip = this.menuPagamenti;
            this.paymentData.Location = new System.Drawing.Point(6, 19);
            this.paymentData.Name = "paymentData";
            this.paymentData.ReadOnly = true;
            this.paymentData.Size = new System.Drawing.Size(811, 301);
            this.paymentData.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.FillWeight = 30F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 30;
            // 
            // CreatedAt
            // 
            this.CreatedAt.HeaderText = "Eseguito il";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            // 
            // PaymentID
            // 
            this.PaymentID.FillWeight = 200F;
            this.PaymentID.HeaderText = "ID Pagamento";
            this.PaymentID.Name = "PaymentID";
            this.PaymentID.ReadOnly = true;
            this.PaymentID.Width = 200;
            // 
            // Hash
            // 
            this.Hash.HeaderText = "Hash";
            this.Hash.Name = "Hash";
            this.Hash.ReadOnly = true;
            // 
            // Complete
            // 
            this.Complete.FillWeight = 70F;
            this.Complete.HeaderText = "Pagamento Completato";
            this.Complete.Name = "Complete";
            this.Complete.ReadOnly = true;
            this.Complete.Width = 70;
            // 
            // KeyNum
            // 
            this.KeyNum.FillWeight = 50F;
            this.KeyNum.HeaderText = "Numero Key";
            this.KeyNum.Name = "KeyNum";
            this.KeyNum.ReadOnly = true;
            this.KeyNum.Width = 50;
            // 
            // menuPagamenti
            // 
            this.menuPagamenti.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuPagamenti.Name = "menuPagamenti";
            this.menuPagamenti.Size = new System.Drawing.Size(114, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Esporta";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // exportFileDialog
            // 
            this.exportFileDialog.DefaultExt = "txt";
            this.exportFileDialog.Filter = "File Testo|*.txt";
            this.exportFileDialog.Title = "Esporta file";
            // 
            // frmPagamenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 337);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmPagamenti";
            this.Text = "frmPagamenti";
            this.Load += new System.EventHandler(this.frmPagamenti_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentData)).EndInit();
            this.menuPagamenti.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView paymentData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hash;
        private System.Windows.Forms.DataGridViewTextBoxColumn Complete;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyNum;
        private System.Windows.Forms.ContextMenuStrip menuPagamenti;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog exportFileDialog;
    }
}