namespace Chiavi
{
    partial class frmOptions
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumOfBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumOfRow = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumOfBoxPerRow = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtComSpeed = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComPort = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ckUseComPort = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNumOfKeyPerBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Chiavi.Properties.Resources.Immagine;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 459);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero di ante:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNumOfBox
            // 
            this.txtNumOfBox.Location = new System.Drawing.Point(613, 34);
            this.txtNumOfBox.Name = "txtNumOfBox";
            this.txtNumOfBox.Size = new System.Drawing.Size(90, 20);
            this.txtNumOfBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero di moduli (dall\'alto verso il basso):";
            // 
            // txtNumOfRow
            // 
            this.txtNumOfRow.Location = new System.Drawing.Point(613, 151);
            this.txtNumOfRow.Name = "txtNumOfRow";
            this.txtNumOfRow.Size = new System.Drawing.Size(90, 20);
            this.txtNumOfRow.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numero di cassettini per ogni modulo:";
            // 
            // txtNumOfBoxPerRow
            // 
            this.txtNumOfBoxPerRow.Location = new System.Drawing.Point(613, 205);
            this.txtNumOfBoxPerRow.Name = "txtNumOfBoxPerRow";
            this.txtNumOfBoxPerRow.Size = new System.Drawing.Size(90, 20);
            this.txtNumOfBoxPerRow.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtComSpeed);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtComPort);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ckUseComPort);
            this.groupBox1.Location = new System.Drawing.Point(433, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 132);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lettore codici a barre";
            // 
            // txtComSpeed
            // 
            this.txtComSpeed.FormattingEnabled = true;
            this.txtComSpeed.Items.AddRange(new object[] {
            "300",
            "1200",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.txtComSpeed.Location = new System.Drawing.Point(117, 86);
            this.txtComSpeed.Name = "txtComSpeed";
            this.txtComSpeed.Size = new System.Drawing.Size(147, 21);
            this.txtComSpeed.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Velocità:";
            // 
            // txtComPort
            // 
            this.txtComPort.FormattingEnabled = true;
            this.txtComPort.Location = new System.Drawing.Point(117, 51);
            this.txtComPort.Name = "txtComPort";
            this.txtComPort.Size = new System.Drawing.Size(147, 21);
            this.txtComPort.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Porta seriale:";
            // 
            // ckUseComPort
            // 
            this.ckUseComPort.AutoSize = true;
            this.ckUseComPort.Location = new System.Drawing.Point(38, 19);
            this.ckUseComPort.Name = "ckUseComPort";
            this.ckUseComPort.Size = new System.Drawing.Size(68, 17);
            this.ckUseComPort.TabIndex = 0;
            this.ckUseComPort.Text = "Presente";
            this.ckUseComPort.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(628, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Salva";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(547, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Annulla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNumOfKeyPerBox
            // 
            this.txtNumOfKeyPerBox.Location = new System.Drawing.Point(613, 97);
            this.txtNumOfKeyPerBox.Name = "txtNumOfKeyPerBox";
            this.txtNumOfKeyPerBox.Size = new System.Drawing.Size(90, 20);
            this.txtNumOfKeyPerBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Numero di facce per ogni anta:";
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(715, 484);
            this.Controls.Add(this.txtNumOfKeyPerBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNumOfBoxPerRow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumOfRow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumOfBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmOptions";
            this.Text = "Opzioni";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumOfBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumOfRow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumOfBoxPerRow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtComSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtComPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckUseComPort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNumOfKeyPerBox;
        private System.Windows.Forms.Label label6;
    }
}