namespace Chiavi
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUserFirstName = new System.Windows.Forms.TextBox();
            this.txtUserSurname = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtKeyNumber = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtUserNote = new System.Windows.Forms.TextBox();
            this.txtUserCity = new System.Windows.Forms.TextBox();
            this.txtUserAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckOnlyNotAssociated = new System.Windows.Forms.CheckBox();
            this.button14 = new System.Windows.Forms.Button();
            this.txtKeyPosition = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.dateKeyExpiration = new System.Windows.Forms.DateTimePicker();
            this.txtKeyDescription = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.paymentData = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataKeyView = new System.Windows.Forms.DataGridView();
            this.KeyNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button15 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listUsers = new System.Windows.Forms.ListBox();
            this.button16 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button17 = new System.Windows.Forms.Button();
            this.menuPagamenti = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button18 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentData)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKeyView)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Conserva busta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUserFirstName
            // 
            this.txtUserFirstName.Location = new System.Drawing.Point(73, 29);
            this.txtUserFirstName.Name = "txtUserFirstName";
            this.txtUserFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtUserFirstName.TabIndex = 3;
            // 
            // txtUserSurname
            // 
            this.txtUserSurname.Location = new System.Drawing.Point(73, 56);
            this.txtUserSurname.Name = "txtUserSurname";
            this.txtUserSurname.Size = new System.Drawing.Size(100, 20);
            this.txtUserSurname.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(402, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "New";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(323, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(404, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(402, 54);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtKeyNumber
            // 
            this.txtKeyNumber.Location = new System.Drawing.Point(90, 28);
            this.txtKeyNumber.Name = "txtKeyNumber";
            this.txtKeyNumber.Size = new System.Drawing.Size(223, 20);
            this.txtKeyNumber.TabIndex = 9;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(19, 126);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Associate";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(402, 28);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "New Key";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(323, 126);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 12;
            this.button8.Text = "<<";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(402, 126);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 13;
            this.button9.Text = ">>";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.txtUserEmail);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtUserPassword);
            this.groupBox1.Controls.Add(this.txtUserNote);
            this.groupBox1.Controls.Add(this.txtUserCity);
            this.groupBox1.Controls.Add(this.txtUserAddress);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUserFirstName);
            this.groupBox1.Controls.Add(this.txtUserSurname);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Location = new System.Drawing.Point(160, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 189);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Utente selezionato";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(19, 147);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(81, 36);
            this.button12.TabIndex = 23;
            this.button12.Text = "Visualizza Pagamenti";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Location = new System.Drawing.Point(280, 25);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(100, 20);
            this.txtUserEmail.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(214, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Email:";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(280, 56);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(100, 20);
            this.txtUserPassword.TabIndex = 20;
            // 
            // txtUserNote
            // 
            this.txtUserNote.Location = new System.Drawing.Point(280, 86);
            this.txtUserNote.Multiline = true;
            this.txtUserNote.Name = "txtUserNote";
            this.txtUserNote.Size = new System.Drawing.Size(197, 71);
            this.txtUserNote.TabIndex = 18;
            // 
            // txtUserCity
            // 
            this.txtUserCity.Location = new System.Drawing.Point(73, 110);
            this.txtUserCity.Name = "txtUserCity";
            this.txtUserCity.Size = new System.Drawing.Size(100, 20);
            this.txtUserCity.TabIndex = 17;
            // 
            // txtUserAddress
            // 
            this.txtUserAddress.Location = new System.Drawing.Point(73, 83);
            this.txtUserAddress.Name = "txtUserAddress";
            this.txtUserAddress.Size = new System.Drawing.Size(100, 20);
            this.txtUserAddress.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Note:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cognome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckOnlyNotAssociated);
            this.groupBox2.Controls.Add(this.button14);
            this.groupBox2.Controls.Add(this.txtKeyPosition);
            this.groupBox2.Controls.Add(this.button13);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.dateKeyExpiration);
            this.groupBox2.Controls.Add(this.txtKeyDescription);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.txtKeyNumber);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Location = new System.Drawing.Point(651, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 245);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chiave";
            // 
            // ckOnlyNotAssociated
            // 
            this.ckOnlyNotAssociated.AutoSize = true;
            this.ckOnlyNotAssociated.Location = new System.Drawing.Point(49, -1);
            this.ckOnlyNotAssociated.Name = "ckOnlyNotAssociated";
            this.ckOnlyNotAssociated.Size = new System.Drawing.Size(163, 17);
            this.ckOnlyNotAssociated.TabIndex = 23;
            this.ckOnlyNotAssociated.Text = "Visualizza solo non associate";
            this.ckOnlyNotAssociated.UseVisualStyleBackColor = true;
            this.ckOnlyNotAssociated.CheckedChanged += new System.EventHandler(this.ckOnlyNotAssociated_CheckedChanged);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(132, 166);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(107, 23);
            this.button14.TabIndex = 19;
            this.button14.Text = "Libera busta";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // txtKeyPosition
            // 
            this.txtKeyPosition.AutoSize = true;
            this.txtKeyPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyPosition.Location = new System.Drawing.Point(13, 211);
            this.txtKeyPosition.Name = "txtKeyPosition";
            this.txtKeyPosition.Size = new System.Drawing.Size(164, 31);
            this.txtKeyPosition.TabIndex = 22;
            this.txtKeyPosition.Text = "No Position";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(402, 84);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 21;
            this.button13.Text = "Pagamenti";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(402, 54);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 20;
            this.button11.Text = "Save";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // dateKeyExpiration
            // 
            this.dateKeyExpiration.Location = new System.Drawing.Point(90, 89);
            this.dateKeyExpiration.Name = "dateKeyExpiration";
            this.dateKeyExpiration.Size = new System.Drawing.Size(223, 20);
            this.dateKeyExpiration.TabIndex = 19;
            // 
            // txtKeyDescription
            // 
            this.txtKeyDescription.Location = new System.Drawing.Point(90, 60);
            this.txtKeyDescription.Name = "txtKeyDescription";
            this.txtKeyDescription.Size = new System.Drawing.Size(223, 20);
            this.txtKeyDescription.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Expire date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Key Number:";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(148, 126);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 14;
            this.button10.Text = "Deassociate";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.paymentData);
            this.groupBox3.Location = new System.Drawing.Point(160, 400);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(485, 189);
            this.groupBox3.TabIndex = 17;
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
            this.paymentData.Size = new System.Drawing.Size(473, 150);
            this.paymentData.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.FillWeight = 30F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 30;
            // 
            // CreatedAt
            // 
            this.CreatedAt.HeaderText = "Eseguito il";
            this.CreatedAt.Name = "CreatedAt";
            // 
            // PaymentID
            // 
            this.PaymentID.FillWeight = 200F;
            this.PaymentID.HeaderText = "ID Pagamento";
            this.PaymentID.Name = "PaymentID";
            this.PaymentID.Width = 200;
            // 
            // Hash
            // 
            this.Hash.HeaderText = "Hash";
            this.Hash.Name = "Hash";
            // 
            // Complete
            // 
            this.Complete.FillWeight = 70F;
            this.Complete.HeaderText = "Pagamento Completato";
            this.Complete.Name = "Complete";
            this.Complete.Width = 70;
            // 
            // KeyNum
            // 
            this.KeyNum.FillWeight = 50F;
            this.KeyNum.HeaderText = "Numero Key";
            this.KeyNum.Name = "KeyNum";
            this.KeyNum.Width = 50;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataKeyView);
            this.groupBox4.Location = new System.Drawing.Point(160, 205);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(485, 189);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chiavi associate";
            // 
            // dataKeyView
            // 
            this.dataKeyView.AllowUserToAddRows = false;
            this.dataKeyView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataKeyView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKeyView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KeyNumber,
            this.Description,
            this.ExpirationDate});
            this.dataKeyView.Location = new System.Drawing.Point(7, 20);
            this.dataKeyView.MultiSelect = false;
            this.dataKeyView.Name = "dataKeyView";
            this.dataKeyView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataKeyView.Size = new System.Drawing.Size(472, 150);
            this.dataKeyView.TabIndex = 0;
            this.dataKeyView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataKeyView_CellContentClick);
            this.dataKeyView.SelectionChanged += new System.EventHandler(this.dataKeyView_SelectionChanged);
            // 
            // KeyNumber
            // 
            this.KeyNumber.HeaderText = "Number";
            this.KeyNumber.Name = "KeyNumber";
            this.KeyNumber.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.FillWeight = 200F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 200;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.HeaderText = "Expiration Date";
            this.ExpirationDate.Name = "ExpirationDate";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(1061, 290);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 19;
            this.button15.Text = "Partial";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.listUsers);
            this.groupBox5.Controls.Add(this.button16);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Location = new System.Drawing.Point(2, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(141, 589);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            // 
            // listUsers
            // 
            this.listUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listUsers.FormattingEnabled = true;
            this.listUsers.Location = new System.Drawing.Point(7, 68);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(128, 498);
            this.listUsers.TabIndex = 2;
            this.listUsers.SelectedIndexChanged += new System.EventHandler(this.listUsers_SelectedIndexChanged);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(77, 39);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(58, 23);
            this.button16.TabIndex = 1;
            this.button16.Text = "Search";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(1061, 261);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 21;
            this.button17.Text = "Test email";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // menuPagamenti
            // 
            this.menuPagamenti.Name = "menuPagamenti";
            this.menuPagamenti.Size = new System.Drawing.Size(61, 4);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(1061, 320);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 23;
            this.button18.Text = "Opzioni";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 589);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentData)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataKeyView)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUserFirstName;
        private System.Windows.Forms.TextBox txtUserSurname;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtKeyNumber;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView paymentData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.TextBox txtUserNote;
        private System.Windows.Forms.TextBox txtUserCity;
        private System.Windows.Forms.TextBox txtUserAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateKeyExpiration;
        private System.Windows.Forms.TextBox txtKeyDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataKeyView;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationDate;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hash;
        private System.Windows.Forms.DataGridViewTextBoxColumn Complete;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyNum;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label txtKeyPosition;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.CheckBox ckOnlyNotAssociated;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.ContextMenuStrip menuPagamenti;
        private System.Windows.Forms.Button button18;
    }
}

