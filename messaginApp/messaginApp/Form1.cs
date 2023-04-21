using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
//using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace messaginApp
{
    public partial class Form1 : Form
    {

        /// <summary>
        ///           Constructor. Constructs an instance of the form  
        /// </summary>
                      //Properties:
        public string CurrentTab { get; set; }
        public string RootDir { get; set; }
        // Constructor:
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        ///   **************************  Helper methods:   *********************************
        /// </summary>

        /// <summary>
        ///              Method to load received messages MMS and SMS to listBox
        /// </summary>
        private void LoadIboxMessages()
        {
            CurrentTab = "R";
            string sql = "";

            if(rbSMS.Checked)
            {
                sql = "Select * From Messages Where Status = '" + CurrentTab + "' And MMS = '" + 0 + "'";

                var smsInfo = Data.GetData<SMS>(sql, CommandType.Text);
                clb1.Items.Clear();
                clb1.DisplayMember = "Text";
                clb1.ValueMember = "Value";
          //      groupBox2.Enabled = false;

                if (smsInfo != null)
                {
                    foreach(var sms in smsInfo)
                    {
                        clb1.Items.Add(new ListBoxItems {Text = sms.Recipient + ": "
                            + sms.Text, Value = sms.ID.ToString() });
                    }
                }
            }
            else
            {
                sql = "Select * From Messages Where Status = '" + CurrentTab + "' And MMS = '" + 1 + "'";

                var mmsInfo = Data.GetData<MMS>(sql, CommandType.Text);
                clb1.Items.Clear();
                clb1.DisplayMember = "Text";
                clb1.ValueMember = "Value";

                if (mmsInfo != null)
                {
                    foreach (var mms in mmsInfo)
                    {
                        clb1.Items.Add(new ListBoxItems
                        {
                            Text = mms.Recipient + ": "
                            + mms.Text,
                            Value = mms.ID.ToString()
                        });
                    }
                }
            }

        }

        /// <summary>
        ///              Method to load sent messages MMS and SMS to listBox
        /// </summary>
        private void LoadOutboxMessages()
        {
            CurrentTab = "S";
            string sql = "";

            if (rbSMS.Checked)
            {
                sql = "Select * From Messages Where Status = '" + CurrentTab + "' And MMS = '" + 0 + "'";

                var smsInfo = Data.GetData<SMS>(sql, CommandType.Text);
                clb2.Items.Clear();
                clb2.DisplayMember = "Text";
                clb2.ValueMember = "Value";

                if (smsInfo != null)
                {
                    foreach (var sms in smsInfo)
                    {
                        clb2.Items.Add(new ListBoxItems
                        {
                            Text = sms.Recipient + ": "
                            + sms.Text,
                            Value = sms.ID.ToString()
                        });
                    }
                }
            }
            else
            {
                sql = "Select * From Messages Where Status = '" + CurrentTab + "' And MMS = '" + 1 + "'";

                var mmsInfo = Data.GetData<MMS>(sql, CommandType.Text);
                clb2.Items.Clear();
                clb2.DisplayMember = "Text";
                clb2.ValueMember = "Value";

                if (mmsInfo != null)
                {
                    foreach (var mms in mmsInfo)
                    {
                        clb2.Items.Add(new ListBoxItems
                        {
                            Text = mms.Recipient + ": "
                            + mms.Text,
                            Value = mms.ID.ToString()
                        });
                    }
                }
            }

        }
        /// <summary>
        ///              Method to load received and sent   MMS or SMS to listBox depends what chosen
        /// </summary>
        private void LoadListBox()
        {
            if (tbc1.SelectedIndex == 0)
            {
                LoadIboxMessages();
            }
            else
            {
                LoadOutboxMessages();
            }
        }
        /// <summary>
        ///             Displaying MMS or SMS details
        /// </summary>
        private void LoadSelectedMessages()
        {
            string id = "";
            string recipient = "";
            string text = "";
            bool isGrp = false;
            int media = 0;
            string fileName = "";

            id = GetSelectedId();

            string sql = "Select * From Messages Where ID = '" + id + "'";
            if(rbSMS.Checked)
            {
                var smsInfo = Data.GetData<SMS>(sql, CommandType.Text);
               // SMS S = new SMS();


                if (smsInfo.Count > 0 )
                {
                    var sms  = smsInfo[0];

                    SMS S = new SMS(sms.ID,  sms.Status, sms.Text, sms.IsGroupMessage, sms.Sender, sms.Recipient, sms.MMS);
                    recipient = S.Recipient;
                    text = S.Text;
                    if(S.IsGroupMessage)
                    {
                        isGrp = true;
                    }
                 //**************************  Another method of code  *******************************               
                    //S.ID = sms.ID;
                    //S.Text = sms.Text;
                    //S.Sender = sms.Sender;
                    //S.Recipient = sms.Recipient;
                    //S.Status = sms.Status;
                    //S.IsGroupMessage =  sms.IsGroupMessage;
                    //S.MMS = sms.MMS;
                 //**********************************************************************************
                }
            }
            else
            {
                var mmsInfo = Data.GetData<MMS>(sql, CommandType.Text);
               // MMS M = new MMS();


                if (mmsInfo.Count > 0)
                {
                    var mms = mmsInfo[0];
                    MMS M = new MMS(mms.ID, mms.Status, mms.Text, mms.IsGroupMessage, mms.Sender, mms.Recipient,
                        mms.MMS, mms.Picture, mms.Audio, mms.Video, mms.FileName);
                    recipient = M.Recipient;
                    text = M.Text;
                    if (M.IsGroupMessage)
                    {
                        isGrp = true;
                    }
                    if (M.Picture)
                        media = 1;
                    else if (M.Audio)
                        media = 2;
                    else if (M.Video)
                        media = 3;
                    else
                        media = 0;
                    fileName = M.FileName;

                }
              
            }
            textBox3.Text = recipient;
            textBox2.Text = text;
            cbxGroup.Checked = isGrp;
            if (media == 1)
            {
               
              //  MediaPlayer.Visible = false;
                //btnPlay.Enabled = false;
                //btnStop.Enabled = false;  
                txtFile.Text = fileName;
                rbtP.Checked = true;

                // show the picture
                LoadPic();

            }
            else if (media == 2)
            {
               // MediaPlayer.Visible = true;
                //btnShow.Enabled = false;
                //btnPlay.Enabled = true;
                //btnStop.Enabled = true;
                rbtA.Checked = true;
                txtFile.Text = fileName;
            }
            else if (media == 3)
            {
               // MediaPlayer.Visible = true;
                //btnShow.Enabled = false;
                //btnPlay.Enabled = true;
                //btnStop.Enabled = true;
               
                rbtV.Checked = true;
                txtFile.Text = fileName;
            }
            else
            {
               
                rbtP.Checked = true;
               
                txtFile.Text = "";
            }

        }
        /// <summary>
        ///         Method to select (tick) message from inbox or sent lists  depends which one is open
        /// </summary>
        
        private string GetSelectedId()
        {
            string id = "";

            if(CurrentTab == "R")
            {
                foreach(var itemSelected in clb1.CheckedItems)
                {
                    var msg = (ListBoxItems)itemSelected;
                    id = msg.Value;
                }
            }
            else
            {
                foreach (var itemSelected in clb2.CheckedItems)
                {
                    var msg = (ListBoxItems)itemSelected;
                    id = msg.Value;
                }

            }

            return id;
        }
        /// <summary>
        ///              Method to  open file directory
        /// </summary>
        private void GetFileDirectory()
        {
            // get the directory of the project/assembly root folder

            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;

            // once we have that path we can extract the directory path from it excluding the executable file name
               var d = System.IO.Path.GetDirectoryName(path);

            var dir = d.Replace("\\bin\\Debug","");


                      RootDir = dir;
        }

        /// <summary>
        ///      Method to  show picture
        /// </summary>
        private void LoadPic()
        {
            pictureBox1.Visible = true;
            string filePath = RootDir + "\\Images\\" + txtFile.Text;
           
            pictureBox1.Image = new Bitmap(filePath);
           
        }

        // Events:

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadIboxMessages();
           
            GetFileDirectory();
           

        }

        private void rbSMS_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListBox();
           
        }

        private void rbMMS_CheckedChanged(object sender, EventArgs e)
        {
            LoadListBox();
            if(rbMMS.Checked)
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
                MediaPlayer.Visible = false;
                pictureBox1.Enabled = false;
            }
            


        }

        private void textBox2_TextChanged(object sender, EventArgs e)                  
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            pictureBox1.Visible = false;
            MediaPlayer.Visible = false;
            LoadListBox();
        }

  
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }  


        private void MessageListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedMessages();
        }

     

        private void MessageListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
           
            CheckedListBox items = (CheckedListBox)sender;

        // ******** Prevent user selecting an other message if one is already selected *********
            //if (e.NewValue ==CheckState.Checked && items.CheckedItems.Count >= 1)
            //{
            //    e.NewValue = CheckState.Unchecked;
            //    MessageBox.Show("Only one message can be selected.", "Attention", MessageBoxButtons.OK,
            //    MessageBoxIcon.Exclamation);    
            
            // Unchecked any previously checked items if the user checks another one.

            if (e.NewValue == CheckState.Checked)
            {
               for(int i = 0; i < items.Items.Count; i++)
                {
                    if (e.Index != i)
                        items.SetItemChecked(i, false);
                }
            }
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog dlg =new OpenFileDialog())
            {
                string folder = RootDir;
                if(rbtP.Checked)
                {
                    folder += "\\Images\\";
                    dlg.Title = "Open Image";
                    dlg.Filter = "Image files|*.PNG;*.JPEG;*.GIF;*.BMP;*.JFIF";

                   // label3.Text = folder;
                }
                else if(rbtV.Checked)
                {
                    folder += "\\Video\\";
                    dlg.Title = "Open Image";
                    dlg.Filter = "Video files|*.WMV;*.AVI;*.MKV;*.WEBM;*.HTML5;*.FLV;*.F4V;*.SWF;*.AVCHD;*.MOV;*.MP4";

                    label3.Text = folder;
                }
                else if (rbtA.Checked)
                {
                    folder += "\\Audio\\";
                    dlg.Title = "Open Audio";
                    dlg.Filter = "Video files|*.MP3;*.AAC;*.FLAC;*.ALAC;*.WAV;*.AIFF;*.DSD;*.PCM;*.WMA";

                    label3.Text = folder;
                }

                dlg.InitialDirectory = folder;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string theFile = dlg.FileName.Replace(folder, "");
                    txtFile.Text = theFile;
                }
             

            }
        }

        private void btnMediaPlay_Click(object sender, EventArgs e)
        {
            
            if(rbtA.Checked && txtFile.Text.Length > 0)
            {
                MediaPlayer.URL = RootDir + "\\Audio\\" + txtFile.Text;
            }
            else if (rbtV.Checked && txtFile.Text.Length > 0)
            {
                MediaPlayer.URL = RootDir + "\\Video\\" + txtFile.Text;
            }
           
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            MediaPlayer.Ctlcontrols.stop();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = "";
            string sql = "";
            int res = 0;


            id = GetSelectedId();

            sql = "Delete From Messages Where ID = '" + id + "'";

            res = Data.ExecuteSqlNonQuery(sql, CommandType.Text);

            if (res > 0)
            {
                MessageBox.Show(" Delete Message? ");
                ;
            }
            else
            {
                MessageBox.Show(" That did not work ");
            }
            textBox2.Text = "";
            textBox3.Text = "";
            txtFile.Text = "";
            pictureBox1.Visible = false;
            MediaPlayer.Visible = false;
            LoadListBox();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            btnSend.Enabled = false;

            // ************** insert your message  to DB  ***************************
            //string id = "";
            //string sql = "";
            int res = 0;
            string sql = "Insert Into Messages(Status, Recipient, Text, IsGroupMessage, MMS, Picture, Audio, Video, FileName) Values('S', '";
            string recipient = "";
            int group = 0;
            string fileName = "";
            string text = "";
            int media = 0;

            if(textBox3.Text.Length > 0 && textBox2.TextLength > 0)
            {
                if (cbxGroup.Checked)
                {
                    group = 1;
                }
                recipient = textBox3.Text;
                text = textBox2.Text;

                sql += recipient + "', '" + text + "', '" + group + "', '";

                if(rbMMS.Checked && (rbtP.Checked || rbtA.Checked || rbtV.Checked) && txtFile.Text.Length > 0)
                {
                    sql += "1', '";       // MMS

                    if (rbtP.Checked)
                        sql += "1', '";
                    else
                        sql += "0', '";


                    if (rbtA.Checked)
                        sql += "1', '";
                    else
                        sql += "0', '";


                    if(rbtV.Checked)
                        sql += "1', '";
                    else
                        sql += "0', '";


                    fileName = txtFile.Text;
                    sql += fileName + "')";

                } 
                else
                {
                    sql += "0', '0', '0', '0', '')"; 
                }

                res = Data.ExecuteSqlNonQuery(sql, CommandType.Text);

                if (res > 0)
                {
                    MessageBox.Show(" Message sent ");
                }
                else
                {
                    MessageBox.Show(" Could not set message ");
                }
                LoadListBox();
                btnSend.Enabled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCompose_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
             txtFile.Text = "";
            pictureBox1.Visible = false;
            MediaPlayer.Visible = false;
            LoadListBox();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            if(txtFile.Text.Length > 0)
            {
                LoadPic();
            }
            else
            {
                MessageBox.Show("Please choose the picture file!");

            }
            

        }

        private void rbtP_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            MediaPlayer.Visible = false;
           
            btnPlay.Enabled = false;
            btnStop.Enabled = false;
            btnShow.Enabled = true;
        }

        private void rbtV_CheckedChanged(object sender, EventArgs e)
        {
            MediaPlayer.Visible = true;
            pictureBox1.Visible = false;
            btnShow.Enabled = false;
            btnPlay.Enabled = true;
            btnStop.Enabled = true;
           
        }

        private void rbtA_CheckedChanged(object sender, EventArgs e)
        {
           MediaPlayer.Visible = true ;
            pictureBox1.Visible = false;
            btnShow.Enabled = false;
            btnPlay.Enabled = true;
            btnStop.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHelp_Click(object sender, EventArgs e)
        {

        }
         
        private void lblHelp_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
                      // ****************  Get the control that is requesting help.*******
            Control requestingControl = (Control)sender;
                   //***********  Display the help description in lblHelp. **************
            lblHelp.Text = (string)requestingControl.Tag;
            //  *    *     *    Let the event know that this has been handled  ** 
            hlpevent.Handled = true;                        

        }

        private void btnDel_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            // ****************  Get the control that is requesting help.*******
            Control requestingControl = (Control)sender;
            //***********  Display the help description in lblHelp. **************
            lblHelp.Text = (string)requestingControl.Tag;
            //  *    *     *    Let the event know that this has been handled  ** 
            hlpevent.Handled = true;
        }

        private void btnSend_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            // ****************  Get the control that is requesting help.*******
            Control requestingControl = (Control)sender;
            //***********  Display the help description in lblHelp. **************
            lblHelp.Text = (string)requestingControl.Tag;
            //  *    *     *    Let the event know that this has been handled  ** 
            hlpevent.Handled = true;
        }

        private void tbc1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            // ****************  Get the control that is requesting help.*******
            Control requestingControl = (Control)sender;
            //***********  Display the help description in lblHelp. **************
            lblHelp.Text = (string)requestingControl.Tag;
            //  *    *     *    Let the event know that this has been handled  ** 
            hlpevent.Handled = true;
        }

        private void textBox3_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            // ****************  Get the control that is requesting help.*******
            Control requestingControl = (Control)sender;
            //***********  Display the help description in lblHelp. **************
            lblHelp.Text = (string)requestingControl.Tag;
            //  *    *     *    Let the event know that this has been handled  ** 
            hlpevent.Handled = true;
        }

        private void rbMMS_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            // ****************  Get the control that is requesting help.*******
            Control requestingControl = (Control)sender;
            //***********  Display the help description in lblHelp. **************
            lblHelp.Text = (string)requestingControl.Tag;
            //  *    *     *    Let the event know that this has been handled  ** 
            hlpevent.Handled = true;
        }

        private void btnCompose_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            // ****************  Get the control that is requesting help.*******
            Control requestingControl = (Control)sender;
            //***********  Display the help description in lblHelp. **************
            lblHelp.Text = (string)requestingControl.Tag;
            //  *    *     *    Let the event know that this has been handled  ** 
            hlpevent.Handled = true;
        }

        private void btnClear_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            // ****************  Get the control that is requesting help.*******
            Control requestingControl = (Control)sender;
            //***********  Display the help description in lblHelp. **************
            lblHelp.Text = (string)requestingControl.Tag;
            //  *    *     *    Let the event know that this has been handled  ** 
            hlpevent.Handled = true;
        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            // ****************  Get the control that is requesting help.*******
            Control requestingControl = (Control)sender;
            //***********  Display the help description in lblHelp. **************
            lblHelp.Text = (string)requestingControl.Tag;
            //  *    *     *    Let the event know that this has been handled  ** 
            hlpevent.Handled = true;
        }

        private void btnPlay_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            // ****************  Get the control that is requesting help.*******
            Control requestingControl = (Control)sender;
            //***********  Display the help description in lblHelp. **************
            lblHelp.Text = (string)requestingControl.Tag;
            //  *    *     *    Let the event know that this has been handled  ** 
            hlpevent.Handled = true;
        }

        private void btnStop_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            // ****************  Get the control that is requesting help.*******
            Control requestingControl = (Control)sender;
            //***********  Display the help description in lblHelp. **************
            lblHelp.Text = (string)requestingControl.Tag;
            //  *    *     *    Let the event know that this has been handled  ** 
            hlpevent.Handled = true;
        }

        private void btnShow_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            // ****************  Get the control that is requesting help.*******
            Control requestingControl = (Control)sender;
            //***********  Display the help description in lblHelp. **************
            lblHelp.Text = (string)requestingControl.Tag;
            //  *    *     *    Let the event know that this has been handled  ** 
            hlpevent.Handled = true;
        }

        private void txtFile_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            // ****************  Get the control that is requesting help.*******
            Control requestingControl = (Control)sender;
            //***********  Display the help description in lblHelp. **************
            lblHelp.Text = (string)requestingControl.Tag;
            //  *    *     *    Let the event know that this has been handled  ** 
            hlpevent.Handled = true;
        }
    }
}
