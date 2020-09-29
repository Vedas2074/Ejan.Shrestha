using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text;
using System.Threading;
using System.IO;
namespace DHAF
{
	/// <summary>
	/// Summary description for frmWizard.
	/// </summary>
	public class frmExtract: System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog2;
		private System.Windows.Forms.Button button7;
		private AxWMPLib.AxWindowsMediaPlayer WMP;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.TextBox txtInputAudioFile;
		private System.Windows.Forms.TextBox txtVerify;
		private System.Windows.Forms.TextBox txtKeyFile;
		private System.Windows.Forms.TextBox txtOutputTextFile;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.TextBox txtExtractedMessage;
		private System.Windows.Forms.Label label2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmExtract()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmExtract));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
			this.button2 = new System.Windows.Forms.Button();
			this.txtInputAudioFile = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button9 = new System.Windows.Forms.Button();
			this.txtOutputTextFile = new System.Windows.Forms.TextBox();
			this.button10 = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button7 = new System.Windows.Forms.Button();
			this.txtKeyFile = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.txtVerify = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.txtExtractedMessage = new System.Windows.Forms.TextBox();
			this.button6 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.WMP);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.txtInputAudioFile);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(200, 20);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(472, 283);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Step 1 of 6";
			// 
			// WMP
			// 
			this.WMP.ContainingControl = this;
			this.WMP.Enabled = true;
			this.WMP.Location = new System.Drawing.Point(16, 48);
			this.WMP.Name = "WMP";
			this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
			this.WMP.Size = new System.Drawing.Size(440, 160);
			this.WMP.TabIndex = 6;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(320, 248);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(136, 24);
			this.button2.TabIndex = 5;
			this.button2.Text = "Select Audio File";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// txtInputAudioFile
			// 
			this.txtInputAudioFile.Location = new System.Drawing.Point(16, 248);
			this.txtInputAudioFile.Name = "txtInputAudioFile";
			this.txtInputAudioFile.ReadOnly = true;
			this.txtInputAudioFile.Size = new System.Drawing.Size(304, 20);
			this.txtInputAudioFile.TabIndex = 4;
			this.txtInputAudioFile.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(16, 224);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(440, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Play Audio";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.pictureBox1.Location = new System.Drawing.Point(16, 48);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(440, 160);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(440, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Audio Preview";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button5.Location = new System.Drawing.Point(616, 328);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(64, 24);
			this.button5.TabIndex = 8;
			this.button5.Text = "Cancel";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button4.Location = new System.Drawing.Point(544, 328);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(64, 24);
			this.button4.TabIndex = 7;
			this.button4.Text = "Next";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.Location = new System.Drawing.Point(472, 328);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(64, 24);
			this.button3.TabIndex = 6;
			this.button3.Text = "Back";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.SystemColors.Info;
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listBox1.Location = new System.Drawing.Point(8, 16);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(176, 303);
			this.listBox1.TabIndex = 1;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.button9);
			this.groupBox2.Controls.Add(this.txtOutputTextFile);
			this.groupBox2.Controls.Add(this.button10);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(200, 24);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(480, 300);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Step 2 of 6";
			this.groupBox2.Visible = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(24, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(472, 23);
			this.label2.TabIndex = 12;
			this.label2.Text = "The Hidden Message Will be Saved in this File";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(256, 244);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(200, 20);
			this.button9.TabIndex = 11;
			this.button9.Text = "Select New Text File";
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// txtOutputTextFile
			// 
			this.txtOutputTextFile.AutoSize = false;
			this.txtOutputTextFile.Location = new System.Drawing.Point(16, 244);
			this.txtOutputTextFile.Name = "txtOutputTextFile";
			this.txtOutputTextFile.ReadOnly = true;
			this.txtOutputTextFile.Size = new System.Drawing.Size(224, 20);
			this.txtOutputTextFile.TabIndex = 10;
			this.txtOutputTextFile.Text = "";
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(480, 176);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(75, 24);
			this.button10.TabIndex = 8;
			this.button10.Text = "button3";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button7);
			this.groupBox3.Controls.Add(this.txtKeyFile);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(200, 24);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(472, 296);
			this.groupBox3.TabIndex = 11;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Step 3 of 6";
			this.groupBox3.Visible = false;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(320, 32);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(136, 24);
			this.button7.TabIndex = 9;
			this.button7.Text = "Select Key File";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// txtKeyFile
			// 
			this.txtKeyFile.Location = new System.Drawing.Point(16, 32);
			this.txtKeyFile.Name = "txtKeyFile";
			this.txtKeyFile.ReadOnly = true;
			this.txtKeyFile.Size = new System.Drawing.Size(304, 20);
			this.txtKeyFile.TabIndex = 8;
			this.txtKeyFile.Text = "";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.txtVerify);
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(200, 24);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(480, 296);
			this.groupBox4.TabIndex = 12;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Step 4 of 6";
			this.groupBox4.Visible = false;
			// 
			// txtVerify
			// 
			this.txtVerify.Location = new System.Drawing.Point(24, 24);
			this.txtVerify.Multiline = true;
			this.txtVerify.Name = "txtVerify";
			this.txtVerify.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtVerify.Size = new System.Drawing.Size(440, 208);
			this.txtVerify.TabIndex = 26;
			this.txtVerify.Text = "";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 248);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(400, 24);
			this.label4.TabIndex = 25;
			this.label4.Text = "Click Next to start the Embeded Process";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.textBox6);
			this.groupBox5.Controls.Add(this.label5);
			this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox5.Location = new System.Drawing.Point(200, 20);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(480, 300);
			this.groupBox5.TabIndex = 13;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Step 5 of 6";
			this.groupBox5.Visible = false;
			// 
			// textBox6
			// 
			this.textBox6.AutoSize = false;
			this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox6.Location = new System.Drawing.Point(24, 72);
			this.textBox6.Multiline = true;
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(432, 192);
			this.textBox6.TabIndex = 1;
			this.textBox6.Text = "";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(24, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(416, 40);
			this.label5.TabIndex = 0;
			this.label5.Text = "Actions:";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.txtExtractedMessage);
			this.groupBox6.Controls.Add(this.button6);
			this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox6.Location = new System.Drawing.Point(200, 20);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(480, 300);
			this.groupBox6.TabIndex = 14;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Step 6 of 6";
			this.groupBox6.Visible = false;
			// 
			// txtExtractedMessage
			// 
			this.txtExtractedMessage.Location = new System.Drawing.Point(8, 16);
			this.txtExtractedMessage.Multiline = true;
			this.txtExtractedMessage.Name = "txtExtractedMessage";
			this.txtExtractedMessage.Size = new System.Drawing.Size(456, 232);
			this.txtExtractedMessage.TabIndex = 9;
			this.txtExtractedMessage.Text = "";
			this.txtExtractedMessage.TextChanged += new System.EventHandler(this.txtExtractedMessage_TextChanged);
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button6.Location = new System.Drawing.Point(24, 256);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(440, 24);
			this.button6.TabIndex = 8;
			this.button6.Text = "View Message Text File";
			this.button6.Click += new System.EventHandler(this.button6_Click_1);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "Wave Files (*.wav) | *.wav";
			this.openFileDialog1.InitialDirectory = "c:\\";
			this.openFileDialog1.ShowHelp = true;
			this.openFileDialog1.ShowReadOnly = true;
			this.openFileDialog1.Title = "Open Audio File";
			// 
			// openFileDialog2
			// 
			this.openFileDialog2.Filter = "Text Files (*.txt) | *.txt";
			this.openFileDialog2.InitialDirectory = "c:\\";
			this.openFileDialog2.ShowHelp = true;
			this.openFileDialog2.ShowReadOnly = true;
			this.openFileDialog2.Title = "Open Text File";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "Text Files (*.txt) | *.txt";
			this.saveFileDialog1.Title = "Output Audio File";
			// 
			// frmExtract
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.LightCyan;
			this.ClientSize = new System.Drawing.Size(692, 362);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Name = "frmExtract";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Extract Steps";
			this.Load += new System.EventHandler(this.frmWizard1_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		clsExtract obj1;
		private void frmWizard1_Load(object sender, System.EventArgs e)
		{
			listBox1.Items.Add("1.Select encrypted audio file.");
			listBox1.Items.Add("2.Enter New Text File.");
			listBox1.Items.Add("3.Enter Key File.");
			listBox1.Items.Add("4.Verify options.");
			listBox1.Items.Add("5.Extracting data from the audio.");
			listBox1.Items.Add("6.View output text file.");
			listBox1.SelectedIndex=0;

			obj1=new clsExtract();
			
			//	a.

		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			if(button4.Text =="Finish") 
			{
				this.Close ();
				return;
			}
			if (obj1.PropEmbedStep ==0 &&  txtInputAudioFile.Text=="")
			{
				MessageBox.Show("Please Select Audio FileName");
				return ;
			}
			else if(obj1.PropEmbedStep ==1 &&  txtOutputTextFile.Text=="")
			{
				MessageBox.Show("Please Select Output Text File");
				return;
			}
			else if(obj1.PropEmbedStep ==2 &&  txtKeyFile.Text=="")
			{
				MessageBox.Show("Please Select Key Text File");
				return;
			}
			else
				showNextStep();
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if(openFileDialog1.ShowDialog() ==DialogResult.OK)
			{
				obj1.PropAudioFileName=openFileDialog1.FileName;			
				txtInputAudioFile.Text=obj1.PropAudioFileName;
			}
		}

		private void showNextStep()
		{
			
			obj1.PropEmbedStep+=1;
			
			if (listBox1.SelectedIndex<6)
			{
				listBox1.SelectedIndex+=1;
			}
			WMP.URL="";
			groupBox1.Visible=false;
			groupBox2.Visible=false;
			groupBox3.Visible=false;
			groupBox4.Visible=false;
			groupBox5.Visible=false;
			groupBox6.Visible=false;
		
			switch(obj1.PropEmbedStep)
			{
				case 1:
					groupBox2.Visible=true;
					button3.Enabled=true;
					break;
				case 2:
					groupBox3.Visible=true;
					
					break;
				case 3:
					groupBox4.Visible=true;
					System.Text.StringBuilder s=new System.Text.StringBuilder ("");
					s.Append ("Audio File:" + txtInputAudioFile.Text  +"\r\n");
					s.Append ("New Text File:" + txtOutputTextFile.Text   +"\r\n");
					obj1.PropKeyFileName =txtKeyFile.Text ;
					s.Append ("Key File :" + obj1.PropKeyFileName  + "\r\n");
					txtVerify.Text =s.ToString ();
					break;
				case 4:
					groupBox5.Visible=true;
					ExtractData();
					break;
				case 5:
					groupBox6.Visible=true;
					button4.Text="Finish";
					break;
			}
		}

		private void showPrevStep()
		{
			obj1.PropEmbedStep-=1;
			if (listBox1.SelectedIndex>0)
			{
				listBox1.SelectedIndex-=1;
			}
			groupBox1.Visible=false;
			groupBox2.Visible=false;
			groupBox3.Visible=false;
			groupBox4.Visible=false;
			groupBox5.Visible=false;
			groupBox6.Visible=false;
			
			switch(obj1.PropEmbedStep)
			{
				case 0:
					groupBox1.Visible=true;
					button3.Enabled=false;
					break;
				case 1:
					groupBox2.Visible=true;
					break;
				case 2:
					groupBox3.Visible=true;
					break;
				case 3:
					groupBox4.Visible=true;
					break;
				case 4:
					groupBox5.Visible=true;
					break;
				case 5:
					groupBox6.Visible=true;
					button4.Enabled=true;
					break;
			}
		

		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			showPrevStep();
		}

		private void button9_Click(object sender, System.EventArgs e)
		{
			saveFileDialog1.Title ="New Text File";
			if(saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				txtOutputTextFile.Text =saveFileDialog1.FileName;
				obj1.PropOutputTextFile=txtOutputTextFile.Text ;
			}
		}

		private void txtEmbedMessage_TextChanged(object sender, System.EventArgs e)
		{
		
		}

//		private void button6_Click(object sender, System.EventArgs e)
//		{
//			openFileDialog1.Filter ="Text Files (*.wav) | *.wav";
//			if(openFileDialog2.ShowDialog() ==DialogResult.OK)
//			{
//				obj1.PropEmbedTextFileName=openFileDialog2.FileName;			
//				txtEmbedTextFile.Text=obj1.PropEmbedTextFileName;
//			}
//		}

		

		private void button7_Click(object sender, System.EventArgs e)
		{
openFileDialog1.Title ="Open Text File";
			openFileDialog1.Filter ="Text Files (*.txt) | *.txt";
			if(openFileDialog1.ShowDialog() ==DialogResult.OK)
			{
				
				obj1.PropKeyFileName=openFileDialog1.FileName;			
				txtKeyFile.Text=obj1.PropKeyFileName;
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			//WMP.newMedia (txtInputAudioFile.Text );
			//WMP.launchURL (txtInputAudioFile.Text );
			WMP.URL =txtInputAudioFile.Text;
			
			//WMP.openPlayer (txtInputAudioFile.Text);
			//
			//WMP.openPlayer (txtInputAudioFile.Text );
			//System.Diagnostics.Process.Start (txtInputAudioFile.Text );
		}

//		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
//		{
//			if(radioButton1.Checked==true)
//			{
//				button6.Enabled =true;
//				txtEmbedMessage.Enabled =false;
//				obj1.PropEmbedDataType ="File";
//				
//			}
//		}

//		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
//		{
//			if(radioButton2.Checked==true)
//			{
//				txtEmbedMessage.Enabled =true;
//				button6.Enabled =false;
//				obj1.PropEmbedDataType ="Text";
//			}
//
//		}
		/// <summary>
		/// Extracting Data
		/// </summary>
		public void ExtractData()
		{
		
			this.Cursor = Cursors.WaitCursor;
			
			FileStream sourceStream = null;
			WaveStream audioStream = null;
			//create an empty stream to receive the extracted message
			MemoryStream messageStream = new MemoryStream();
			//open the key file
			Stream keyStream = new FileStream(txtKeyFile.Text, FileMode.Open);
			textBox6.Text ="Key File Opened...\r\n";
			try 
			{
				//open the carrier file
				sourceStream = new FileStream(txtInputAudioFile.Text, FileMode.Open);
				textBox6.Text +="Audio File Opened...\r\n";
				audioStream = new WaveStream(sourceStream);
				WaveUtility utility = new WaveUtility(audioStream);
			
				//exctract the message from the carrier wave
				textBox6.Text +="Start Extracting ...\r\n";
				utility.Extract(messageStream, keyStream);
				textBox6.Text +="Finished Extracting ...\r\n";
				messageStream.Seek(0, SeekOrigin.Begin);
				 //save result to a file
					FileStream fs = new FileStream(txtOutputTextFile.Text, FileMode.Create);
						
					byte[] buffer = new byte[messageStream.Length];
					messageStream.Read(buffer, 0, buffer.Length);
messageStream.Seek (0, System.IO.SeekOrigin.Begin );
					txtExtractedMessage.Text = new StreamReader(messageStream).ReadToEnd();					
					fs.Write(buffer, 0, buffer.Length);
					fs.Close();
				//}
				//else
				//{ //display result
					//txtExtractedMessage.Text = new StreamReader(messageStream).ReadToEnd();					
				//}
			}
			catch(Exception ex) 
			{
				this.Cursor = Cursors.Default;
				MessageBox.Show(ex.Message);
			}
			finally
			{
				if(keyStream != null){ keyStream.Close(); }
				if(messageStream != null){ messageStream.Close(); }
				if(audioStream != null){ audioStream.Close(); }
				if(sourceStream != null){ sourceStream.Close(); }
				this.Cursor = Cursors.Default;
			}
		}
//
//		/// <summary>Write length an content of the message file/text into a stream</summary>
//		/// <returns></returns>
//		private  Stream GetMessageStream()
//		{
//			BinaryWriter messageWriter = new BinaryWriter(new MemoryStream());
//			if( obj1.PropEmbedDataType =="File")
//			{
//				FileStream fs = new FileStream(obj1.PropEmbedTextFileName, FileMode.Open);
//				int fileLength = (int)fs.Length;
//				messageWriter.Write(fileLength);
//				Console.WriteLine (fileLength);
//				byte[] buffer = new byte[fs.Length];
//				fs.Read(buffer, 0, fileLength);
//				messageWriter.Write(buffer);
//				fs.Close();
//				
//			}
//			else
//			{
//				messageWriter.Write(txtEmbedMessage.Text.Length);
//				Console.WriteLine (txtEmbedMessage.Text.Length);
//				messageWriter.Write(Encoding.ASCII.GetBytes(txtEmbedMessage.Text));
//			}
//			
//			messageWriter.Seek(0, SeekOrigin.Begin);
//			return messageWriter.BaseStream;			
//		}

		private void button6_Click_1(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start (txtOutputTextFile.Text );
		}

		private void label2_Click(object sender, System.EventArgs e)
		{
		
		}

		private void txtExtractedMessage_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
