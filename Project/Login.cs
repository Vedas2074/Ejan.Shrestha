using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DHAF
{
	/// <summary>
	/// Summary description for Login.
	/// </summary>
	public class Login : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.GroupBox GroupBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Login()
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
			this.Button2 = new System.Windows.Forms.Button();
			this.Button1 = new System.Windows.Forms.Button();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Button2
			// 
			this.Button2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(128)));
			this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Button2.Location = new System.Drawing.Point(159, 104);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(75, 32);
			this.Button2.TabIndex = 5;
			this.Button2.Text = "Exit";
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// Button1
			// 
			this.Button1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(128)));
			this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Button1.Location = new System.Drawing.Point(55, 104);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(75, 32);
			this.Button1.TabIndex = 4;
			this.Button1.Text = "Login";
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// TextBox2
			// 
			this.TextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.TextBox2.Location = new System.Drawing.Point(158, 62);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.PasswordChar = '*';
			this.TextBox2.TabIndex = 3;
			this.TextBox2.Text = "admin";
			// 
			// TextBox1
			// 
			this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.TextBox1.Location = new System.Drawing.Point(158, 24);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.TabIndex = 2;
			this.TextBox1.Text = "admin";
			this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
			// 
			// Label2
			// 
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label2.ForeColor = System.Drawing.Color.Blue;
			this.Label2.Location = new System.Drawing.Point(30, 64);
			this.Label2.Name = "Label2";
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Password";
			this.Label2.Click += new System.EventHandler(this.Label2_Click);
			// 
			// Label1
			// 
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label1.ForeColor = System.Drawing.Color.Blue;
			this.Label1.Location = new System.Drawing.Point(30, 24);
			this.Label1.Name = "Label1";
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Username";
			this.Label1.Click += new System.EventHandler(this.Label1_Click);
			// 
			// GroupBox1
			// 
			this.GroupBox1.BackColor = System.Drawing.SystemColors.Info;
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.TextBox2);
			this.GroupBox1.Controls.Add(this.TextBox1);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Location = new System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(288, 160);
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			// 
			// Login
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 162);
			this.ControlBox = false;
			this.Controls.Add(this.GroupBox1);
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Login_Load);
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
public bool loginvalidate;
		private void Button1_Click(object sender, System.EventArgs e)
		{
            SqlConnection con = new SqlConnection("Data Source=APTTECH3;Initial Catalog=Texthiding;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("select * from login where u_name = '" + TextBox1 .Text + "'", con);
            SqlDataReader dr ;
            dr= com.ExecuteReader ();
            if(dr.Read())
			//if (TextBox1.Text == "admin" && TextBox2.Text == "admin")
			{
				loginvalidate = true;
				this.Close();
			}
			else
			{
				 MessageBox.Show("Invalid Username or Password");
        	}
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
	Application.Exit();


		}

		private void Login_Load(object sender, System.EventArgs e)
		{
		
		}

		private void Label1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void Label2_Click(object sender, System.EventArgs e)
		{
		
		}

		private void TextBox1_TextChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}


