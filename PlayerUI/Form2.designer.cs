namespace PlayerUI
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_baud = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Com = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.richTextBoxSF = new System.Windows.Forms.RichTextBox();
            this.richTextBoxRADIOFREQUENCY = new System.Windows.Forms.RichTextBox();
            this.richTextBoxGATEWAYCHANNEL = new System.Windows.Forms.RichTextBox();
            this.richTextBoxNWKSKEY = new System.Windows.Forms.RichTextBox();
            this.richTextBoxDEVEUI = new System.Windows.Forms.RichTextBox();
            this.richTextBoxDEVADDR = new System.Windows.Forms.RichTextBox();
            this.richTextBox_APPSKEY = new System.Windows.Forms.RichTextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AppEUI = new System.Windows.Forms.Label();
            this.richTextBox_APPEUI = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_ComportStatus = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.button_Disconnect.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Disconnect.FlatAppearance.BorderSize = 0;
            this.button_Disconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button_Disconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button_Disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Disconnect.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Disconnect.ForeColor = System.Drawing.Color.White;
            this.button_Disconnect.Location = new System.Drawing.Point(0, 0);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(155, 39);
            this.button_Disconnect.TabIndex = 7;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Disconnect.UseVisualStyleBackColor = false;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.button_Connect.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Connect.FlatAppearance.BorderSize = 0;
            this.button_Connect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button_Connect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Connect.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Connect.ForeColor = System.Drawing.Color.Black;
            this.button_Connect.Location = new System.Drawing.Point(155, 0);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(150, 39);
            this.button_Connect.TabIndex = 6;
            this.button_Connect.Text = "Connect";
            this.button_Connect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Connect.UseVisualStyleBackColor = false;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox_baud);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1261, 49);
            this.panel2.TabIndex = 9;
            // 
            // comboBox_baud
            // 
            this.comboBox_baud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.comboBox_baud.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox_baud.FormattingEnabled = true;
            this.comboBox_baud.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.comboBox_baud.Location = new System.Drawing.Point(30, 26);
            this.comboBox_baud.Name = "comboBox_baud";
            this.comboBox_baud.Size = new System.Drawing.Size(121, 20);
            this.comboBox_baud.TabIndex = 9;
            this.comboBox_baud.Text = "115200";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(208, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device Configuration";
            // 
            // listBox_Com
            // 
            this.listBox_Com.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.listBox_Com.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Com.ForeColor = System.Drawing.SystemColors.Menu;
            this.listBox_Com.FormattingEnabled = true;
            this.listBox_Com.ItemHeight = 12;
            this.listBox_Com.Location = new System.Drawing.Point(0, 0);
            this.listBox_Com.Name = "listBox_Com";
            this.listBox_Com.Size = new System.Drawing.Size(181, 858);
            this.listBox_Com.TabIndex = 3;
            this.listBox_Com.SelectedIndexChanged += new System.EventHandler(this.listBox_Com_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.listBox_Com);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1261, 858);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(181, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1080, 819);
            this.panel4.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.richTextBoxSF);
            this.panel6.Controls.Add(this.richTextBoxRADIOFREQUENCY);
            this.panel6.Controls.Add(this.richTextBoxGATEWAYCHANNEL);
            this.panel6.Controls.Add(this.richTextBoxNWKSKEY);
            this.panel6.Controls.Add(this.richTextBoxDEVEUI);
            this.panel6.Controls.Add(this.richTextBoxDEVADDR);
            this.panel6.Controls.Add(this.richTextBox_APPSKEY);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.richTextBox_APPEUI);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(489, 819);
            this.panel6.TabIndex = 2;
            // 
            // richTextBoxSF
            // 
            this.richTextBoxSF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.richTextBoxSF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxSF.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBoxSF.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBoxSF.Location = new System.Drawing.Point(177, 442);
            this.richTextBoxSF.Name = "richTextBoxSF";
            this.richTextBoxSF.Size = new System.Drawing.Size(309, 27);
            this.richTextBoxSF.TabIndex = 13;
            this.richTextBoxSF.Text = "";
            // 
            // richTextBoxRADIOFREQUENCY
            // 
            this.richTextBoxRADIOFREQUENCY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.richTextBoxRADIOFREQUENCY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxRADIOFREQUENCY.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBoxRADIOFREQUENCY.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBoxRADIOFREQUENCY.Location = new System.Drawing.Point(177, 379);
            this.richTextBoxRADIOFREQUENCY.Name = "richTextBoxRADIOFREQUENCY";
            this.richTextBoxRADIOFREQUENCY.Size = new System.Drawing.Size(309, 27);
            this.richTextBoxRADIOFREQUENCY.TabIndex = 12;
            this.richTextBoxRADIOFREQUENCY.Text = "";
            // 
            // richTextBoxGATEWAYCHANNEL
            // 
            this.richTextBoxGATEWAYCHANNEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.richTextBoxGATEWAYCHANNEL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxGATEWAYCHANNEL.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBoxGATEWAYCHANNEL.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBoxGATEWAYCHANNEL.Location = new System.Drawing.Point(177, 321);
            this.richTextBoxGATEWAYCHANNEL.Name = "richTextBoxGATEWAYCHANNEL";
            this.richTextBoxGATEWAYCHANNEL.Size = new System.Drawing.Size(309, 27);
            this.richTextBoxGATEWAYCHANNEL.TabIndex = 10;
            this.richTextBoxGATEWAYCHANNEL.Text = "";
            // 
            // richTextBoxNWKSKEY
            // 
            this.richTextBoxNWKSKEY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.richTextBoxNWKSKEY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxNWKSKEY.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBoxNWKSKEY.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBoxNWKSKEY.Location = new System.Drawing.Point(177, 258);
            this.richTextBoxNWKSKEY.Name = "richTextBoxNWKSKEY";
            this.richTextBoxNWKSKEY.Size = new System.Drawing.Size(309, 27);
            this.richTextBoxNWKSKEY.TabIndex = 9;
            this.richTextBoxNWKSKEY.Text = "";
            // 
            // richTextBoxDEVEUI
            // 
            this.richTextBoxDEVEUI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.richTextBoxDEVEUI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxDEVEUI.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBoxDEVEUI.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBoxDEVEUI.Location = new System.Drawing.Point(177, 195);
            this.richTextBoxDEVEUI.Name = "richTextBoxDEVEUI";
            this.richTextBoxDEVEUI.Size = new System.Drawing.Size(309, 27);
            this.richTextBoxDEVEUI.TabIndex = 8;
            this.richTextBoxDEVEUI.Text = "";
            // 
            // richTextBoxDEVADDR
            // 
            this.richTextBoxDEVADDR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.richTextBoxDEVADDR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxDEVADDR.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBoxDEVADDR.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBoxDEVADDR.Location = new System.Drawing.Point(177, 132);
            this.richTextBoxDEVADDR.Name = "richTextBoxDEVADDR";
            this.richTextBoxDEVADDR.Size = new System.Drawing.Size(309, 27);
            this.richTextBoxDEVADDR.TabIndex = 7;
            this.richTextBoxDEVADDR.Text = "";
            // 
            // richTextBox_APPSKEY
            // 
            this.richTextBox_APPSKEY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.richTextBox_APPSKEY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_APPSKEY.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox_APPSKEY.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBox_APPSKEY.Location = new System.Drawing.Point(177, 69);
            this.richTextBox_APPSKEY.Name = "richTextBox_APPSKEY";
            this.richTextBox_APPSKEY.Size = new System.Drawing.Size(309, 27);
            this.richTextBox_APPSKEY.TabIndex = 6;
            this.richTextBox_APPSKEY.Text = "";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.AppEUI);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(171, 819);
            this.panel8.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.SystemColors.Info;
            this.label9.Location = new System.Drawing.Point(3, 442);
            this.label9.MinimumSize = new System.Drawing.Size(10, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "SF：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(3, 379);
            this.label8.MinimumSize = new System.Drawing.Size(10, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "Radio Frequency：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(-4, 321);
            this.label6.MinimumSize = new System.Drawing.Size(10, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gateway Channel：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(6, 258);
            this.label5.MinimumSize = new System.Drawing.Size(10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "NwksKey：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(6, 195);
            this.label4.MinimumSize = new System.Drawing.Size(10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "DevEUI：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.MinimumSize = new System.Drawing.Size(10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "DevAddr：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.MinimumSize = new System.Drawing.Size(10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "AppsKey：";
            // 
            // AppEUI
            // 
            this.AppEUI.AutoSize = true;
            this.AppEUI.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AppEUI.ForeColor = System.Drawing.SystemColors.Info;
            this.AppEUI.Location = new System.Drawing.Point(6, 14);
            this.AppEUI.MinimumSize = new System.Drawing.Size(10, 0);
            this.AppEUI.Name = "AppEUI";
            this.AppEUI.Size = new System.Drawing.Size(102, 22);
            this.AppEUI.TabIndex = 0;
            this.AppEUI.Text = "AppEUI：";
            // 
            // richTextBox_APPEUI
            // 
            this.richTextBox_APPEUI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.richTextBox_APPEUI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_APPEUI.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox_APPEUI.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBox_APPEUI.Location = new System.Drawing.Point(177, 6);
            this.richTextBox_APPEUI.Name = "richTextBox_APPEUI";
            this.richTextBox_APPEUI.Size = new System.Drawing.Size(309, 27);
            this.richTextBox_APPEUI.TabIndex = 4;
            this.richTextBox_APPEUI.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_ComportStatus);
            this.panel1.Controls.Add(this.button_Connect);
            this.panel1.Controls.Add(this.button_Disconnect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(181, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 39);
            this.panel1.TabIndex = 8;
            // 
            // label_ComportStatus
            // 
            this.label_ComportStatus.AutoSize = true;
            this.label_ComportStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_ComportStatus.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_ComportStatus.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label_ComportStatus.Location = new System.Drawing.Point(305, 0);
            this.label_ComportStatus.Name = "label_ComportStatus";
            this.label_ComportStatus.Size = new System.Drawing.Size(67, 22);
            this.label_ComportStatus.TabIndex = 12;
            this.label_ComportStatus.Text = "Closed";
            this.label_ComportStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1261, 907);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Com;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox_baud;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RichTextBox richTextBoxSF;
        private System.Windows.Forms.RichTextBox richTextBoxRADIOFREQUENCY;
        private System.Windows.Forms.RichTextBox richTextBoxGATEWAYCHANNEL;
        private System.Windows.Forms.RichTextBox richTextBoxNWKSKEY;
        private System.Windows.Forms.RichTextBox richTextBoxDEVEUI;
        private System.Windows.Forms.RichTextBox richTextBoxDEVADDR;
        private System.Windows.Forms.RichTextBox richTextBox_APPSKEY;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AppEUI;
        private System.Windows.Forms.RichTextBox richTextBox_APPEUI;
        private System.Windows.Forms.Label label_ComportStatus;
    }
}