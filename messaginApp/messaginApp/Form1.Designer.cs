namespace messaginApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbc1 = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.clb1 = new System.Windows.Forms.CheckedListBox();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.clb2 = new System.Windows.Forms.CheckedListBox();
            this.Ebtn = new System.Windows.Forms.Button();
            this.rbSMS = new System.Windows.Forms.RadioButton();
            this.rbMMS = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCompose = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.rbtP = new System.Windows.Forms.RadioButton();
            this.rbtV = new System.Windows.Forms.RadioButton();
            this.rbtA = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxGroup = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblHelp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbc1.SuspendLayout();
            this.tp1.SuspendLayout();
            this.tp2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0868002800";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Number:";
            // 
            // tbc1
            // 
            this.tbc1.Controls.Add(this.tp1);
            this.tbc1.Controls.Add(this.tp2);
            this.tbc1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbc1.Location = new System.Drawing.Point(12, 42);
            this.tbc1.Name = "tbc1";
            this.tbc1.SelectedIndex = 0;
            this.tbc1.Size = new System.Drawing.Size(438, 576);
            this.tbc1.TabIndex = 2;
            this.tbc1.Tag = "Select the \'Inbox\' tab to see your received messages. Select the \'Sent\' tab to se" +
    "e your received messages.";
            this.tbc1.SelectedIndexChanged += new System.EventHandler(this.rbSMS_SelectedIndexChanged);
            this.tbc1.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.tbc1_HelpRequested);
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.clb1);
            this.tp1.Location = new System.Drawing.Point(4, 22);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(430, 550);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "Inbox";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // clb1
            // 
            this.clb1.BackColor = System.Drawing.Color.LightCyan;
            this.clb1.CheckOnClick = true;
            this.clb1.ColumnWidth = 400;
            this.clb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clb1.FormattingEnabled = true;
            this.clb1.Location = new System.Drawing.Point(3, 3);
            this.clb1.MultiColumn = true;
            this.clb1.Name = "clb1";
            this.clb1.Size = new System.Drawing.Size(424, 544);
            this.clb1.TabIndex = 0;
            this.clb1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.MessageListBox_ItemCheck);
            this.clb1.SelectedIndexChanged += new System.EventHandler(this.MessageListBox_SelectedIndexChanged);
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.clb2);
            this.tp2.Location = new System.Drawing.Point(4, 22);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(3);
            this.tp2.Size = new System.Drawing.Size(430, 550);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "Sent";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // clb2
            // 
            this.clb2.BackColor = System.Drawing.Color.SeaShell;
            this.clb2.CheckOnClick = true;
            this.clb2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clb2.FormattingEnabled = true;
            this.clb2.Location = new System.Drawing.Point(3, 3);
            this.clb2.MultiColumn = true;
            this.clb2.Name = "clb2";
            this.clb2.Size = new System.Drawing.Size(424, 544);
            this.clb2.TabIndex = 0;
            this.clb2.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.MessageListBox_ItemCheck);
            this.clb2.SelectedIndexChanged += new System.EventHandler(this.MessageListBox_SelectedIndexChanged);
            // 
            // Ebtn
            // 
            this.Ebtn.BackColor = System.Drawing.Color.Green;
            this.Ebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ebtn.Location = new System.Drawing.Point(1053, 662);
            this.Ebtn.Name = "Ebtn";
            this.Ebtn.Size = new System.Drawing.Size(82, 32);
            this.Ebtn.TabIndex = 4;
            this.Ebtn.Text = "Exit";
            this.Ebtn.UseVisualStyleBackColor = false;
            this.Ebtn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // rbSMS
            // 
            this.rbSMS.AutoSize = true;
            this.rbSMS.Checked = true;
            this.rbSMS.Location = new System.Drawing.Point(476, 103);
            this.rbSMS.Name = "rbSMS";
            this.rbSMS.Size = new System.Drawing.Size(48, 17);
            this.rbSMS.TabIndex = 1;
            this.rbSMS.TabStop = true;
            this.rbSMS.Text = "SMS";
            this.rbSMS.UseVisualStyleBackColor = true;
            this.rbSMS.CheckedChanged += new System.EventHandler(this.rbMMS_CheckedChanged);
            // 
            // rbMMS
            // 
            this.rbMMS.AutoSize = true;
            this.rbMMS.Location = new System.Drawing.Point(549, 103);
            this.rbMMS.Name = "rbMMS";
            this.rbMMS.Size = new System.Drawing.Size(50, 17);
            this.rbMMS.TabIndex = 2;
            this.rbMMS.Tag = "Please select for Multy Media Messages";
            this.rbMMS.Text = "MMS";
            this.rbMMS.UseVisualStyleBackColor = true;
            this.rbMMS.CheckedChanged += new System.EventHandler(this.rbMMS_CheckedChanged);
            this.rbMMS.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.rbMMS_HelpRequested);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(771, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(298, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Tag = "Enter recipient mobile phone number ";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.textBox3_HelpRequested);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(690, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reciepient";
            // 
            // btnCompose
            // 
            this.btnCompose.BackColor = System.Drawing.Color.SeaShell;
            this.btnCompose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompose.Location = new System.Drawing.Point(449, 165);
            this.btnCompose.Name = "btnCompose";
            this.btnCompose.Size = new System.Drawing.Size(75, 32);
            this.btnCompose.TabIndex = 1;
            this.btnCompose.Tag = "Please press Compose button  to create SMS  or  MMS";
            this.btnCompose.Text = "Compose";
            this.btnCompose.UseVisualStyleBackColor = false;
            this.btnCompose.Click += new System.EventHandler(this.btnCompose_Click);
            this.btnCompose.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnCompose_HelpRequested);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Brown;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(449, 245);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(78, 35);
            this.btnDel.TabIndex = 2;
            this.btnDel.Tag = "Press \'Delete\' button to delete checked message";
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            this.btnDel.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnDel_HelpRequested);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Linen;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(547, 165);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 32);
            this.btnClear.TabIndex = 5;
            this.btnClear.Tag = "Clear button clears all entered text and recipient number";
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnClear_HelpRequested);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Green;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(547, 245);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 35);
            this.btnSend.TabIndex = 6;
            this.btnSend.Tag = "Send button to send created SMS or MMS ";
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            this.btnSend.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnSend_HelpRequested);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.SeaShell;
            this.textBox2.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(0, 6);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(507, 212);
            this.textBox2.TabIndex = 0;
            this.textBox2.Tag = "In this field you can enter the sms or mms text when creating new message ";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.textBox3_HelpRequested);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(628, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 252);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.MediaPlayer);
            this.groupBox2.Controls.Add(this.txtFile);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnShow);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.btnPlay);
            this.groupBox2.Controls.Add(this.rbtP);
            this.groupBox2.Controls.Add(this.rbtV);
            this.groupBox2.Controls.Add(this.rbtA);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(452, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(683, 328);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(6, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 29);
            this.button2.TabIndex = 11;
            this.button2.Tag = " The MMS button has to be sellected .Click on folder image to open file explorer " +
    "Picture / Video /audio  depends on what is selected ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.openFile_Click);
            this.button2.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.button2_HelpRequested);
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(176, 9);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(507, 311);
            this.MediaPlayer.TabIndex = 9;
            this.MediaPlayer.Visible = false;
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(44, 111);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(126, 20);
            this.txtFile.TabIndex = 10;
            this.txtFile.Tag = "In this field Multy Media file name is displayed ";
            this.txtFile.TextChanged += new System.EventHandler(this.txtFile_TextChanged);
            this.txtFile.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.txtFile_HelpRequested);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Orange;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(44, 273);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(77, 25);
            this.btnShow.TabIndex = 6;
            this.btnShow.Tag = "Button to show picture  in picture viewer when file is selected from picture fold" +
    "er ";
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            this.btnShow.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnShow_HelpRequested);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.OrangeRed;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(44, 240);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(77, 27);
            this.btnStop.TabIndex = 5;
            this.btnStop.Tag = "Button to stop playing Video or Audio";
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            this.btnStop.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnStop_HelpRequested);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(44, 206);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 28);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Tag = "Button to start playing Video or Audio";
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnMediaPlay_Click);
            this.btnPlay.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnPlay_HelpRequested);
            // 
            // rbtP
            // 
            this.rbtP.AutoSize = true;
            this.rbtP.Checked = true;
            this.rbtP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtP.Location = new System.Drawing.Point(51, 19);
            this.rbtP.Name = "rbtP";
            this.rbtP.Size = new System.Drawing.Size(70, 21);
            this.rbtP.TabIndex = 3;
            this.rbtP.TabStop = true;
            this.rbtP.Text = "Picture";
            this.rbtP.UseVisualStyleBackColor = true;
            this.rbtP.CheckedChanged += new System.EventHandler(this.rbtP_CheckedChanged);
            // 
            // rbtV
            // 
            this.rbtV.AutoSize = true;
            this.rbtV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtV.Location = new System.Drawing.Point(51, 46);
            this.rbtV.Name = "rbtV";
            this.rbtV.Size = new System.Drawing.Size(62, 21);
            this.rbtV.TabIndex = 2;
            this.rbtV.Text = "Video";
            this.rbtV.UseVisualStyleBackColor = true;
            this.rbtV.CheckedChanged += new System.EventHandler(this.rbtV_CheckedChanged);
            // 
            // rbtA
            // 
            this.rbtA.AutoSize = true;
            this.rbtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtA.Location = new System.Drawing.Point(51, 73);
            this.rbtA.Name = "rbtA";
            this.rbtA.Size = new System.Drawing.Size(62, 21);
            this.rbtA.TabIndex = 1;
            this.rbtA.Text = "Audio\r\n";
            this.rbtA.UseVisualStyleBackColor = true;
            this.rbtA.CheckedChanged += new System.EventHandler(this.rbtA_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(176, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 312);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cbxGroup
            // 
            this.cbxGroup.AutoSize = true;
            this.cbxGroup.Location = new System.Drawing.Point(476, 64);
            this.cbxGroup.Name = "cbxGroup";
            this.cbxGroup.Size = new System.Drawing.Size(105, 17);
            this.cbxGroup.TabIndex = 8;
            this.cbxGroup.Text = "Group messages";
            this.cbxGroup.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblHelp
            // 
            this.lblHelp.Font = new System.Drawing.Font("Courier New", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblHelp.Location = new System.Drawing.Point(12, 621);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(1035, 87);
            this.lblHelp.TabIndex = 9;
            this.lblHelp.Text = resources.GetString("lblHelp.Text");
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            this.lblHelp.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.lblHelp_HelpRequested);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 717);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.cbxGroup);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCompose);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rbSMS);
            this.Controls.Add(this.rbMMS);
            this.Controls.Add(this.Ebtn);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.tbc1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Messaging App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbc1.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.tp2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbc1;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.CheckedListBox clb1;
        private System.Windows.Forms.TabPage tp2;
        private System.Windows.Forms.CheckedListBox clb2;
        private System.Windows.Forms.RadioButton rbMMS;
        private System.Windows.Forms.RadioButton rbSMS;
        private System.Windows.Forms.Button Ebtn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCompose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtV;
        private System.Windows.Forms.RadioButton rbtA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.RadioButton rbtP;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.CheckBox cbxGroup;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label label3;
    }
}

