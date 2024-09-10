using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DarkModeForms
{
	public partial class Form1 : Form
	{
		private DarkModeCS DM = null;
		private bool IsDarkMode = false;
		private bool mCloseAutorized = false;

		private BindingList<ExampleDataSource> DS = null;

		public Form1()
		{
			InitializeComponent();
			DM = new DarkModeCS(this);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			IsDarkMode = DM.IsDarkMode;

			// Prepare a Datasource for the GridView control
			DS = new BindingList<ExampleDataSource>
			{
				new ExampleDataSource()
				{
					Sequence = 1,
					Name = "Philip J. Fry",
					IsAlive = true,
					Points = 20000,
					Observations = "Missing in Action"
				},
				new ExampleDataSource()
				{
					Sequence = 2,
					Name = "Turanga Leela",
					IsAlive = true,
					Points = 23000,
					Observations = "on Duty"
				},
				new ExampleDataSource()
				{
					Sequence = 3,
					Name = "Prof. Hubert Farnsworth",
					IsAlive = false,
					Points = 0,
					Observations = "RIP"
				},
				new ExampleDataSource()
				{
					Sequence = 4,
					Name = "Zapp Brannigan",
					IsAlive = true,
					Points = 7000,
					Observations = "on Duty"
				},
			};
			dataGridView1.AutoGenerateColumns = true;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.DataSource = DS;
			if (dataGridView1.Rows.Count > 0)
			{
				dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[1];
			}

			treeView1.Nodes[0].Expand();
			tabControl1.SelectTab(1);

			//Manually Re-Coloring Images on the ListView Control, or any other Control
			treeView1.ImageList = null;
			int index = 0;
			foreach (Image image in imageList2.Images)
			{
				var coloredImage = DarkModeCS.ChangeToColor(image, DM.OScolors.TextInactive);
				imageList2.Images.RemoveAt(index);
				imageList2.Images.Add(coloredImage);
				index++;
			}
			treeView1.ImageList = imageList2;
		}
		
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			//Al intentar cerrar la ventana se minimiza en la bandeja 'SysTray'
			if (e.CloseReason == CloseReason.UserClosing)
			{
				if (!this.mCloseAutorized)
				{
					e.Cancel = true;
					base.WindowState = FormWindowState.Minimized;
				}
			}
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			//Al Cerrar definitivamente el Formulario elimina el icono del SysTray
			this.notifyIcon1.Dispose();
		}
		private void Form1_Resize(object sender, EventArgs e)
		{
			//Al Minimizar la Ventana, se oculta y se minimiza en la bandeja 'SysTray'
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.Hide();

				//Muestra una Notificacion en la Bandeja del Sistema:
				this.notifyIcon1.Visible = true;
				this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
				this.notifyIcon1.BalloonTipTitle = "DarkMode Forms";
				this.notifyIcon1.BalloonTipText = "The App will be running hidden";
				this.notifyIcon1.ShowBalloonTip(5000); //<- Ocultar tras 5 segundos.
			}
		}
		private void notifyIcon1_DoubleClick(object sender, EventArgs e)
		{
			//Doble Click en el Icono del SysTray para Mostrar la Ventana
			this.Show();
			base.WindowState = FormWindowState.Normal;
			this.BringToFront();
		}

		private int CtrlCounter = 0;

		// Adds a new Control to the Form, to test if Darkmode is applied to dynamically added controls, it does!
		private void button1_Click(object sender, EventArgs e)
		{
			var newT = new TextBox()
			{
				Name = "",
				Text = "New TextBox",
				Location = new Point((this.ClientSize.Width / 2) + CtrlCounter, (this.ClientSize.Height / 2) + CtrlCounter)
			};
			this.Controls.Add(newT);
			newT.BringToFront();
			newT.Focus();
			CtrlCounter = CtrlCounter + 10;
		}

		// Default MessageBox, for comparing, and Custom Error showing
		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				MessageBox.Show("Sadly its not possible to change\r\nthe default MessageBoxes :(", "Hello World!", 
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				throw new Exception("Hello!");
			}
			catch (Exception ex)
			{
				Messenger.MessageBox(ex);
			}			
		}

		// Example of the Custom InputBox
		private void button3_Click(object sender, EventArgs e)
		{
			// Definition of a Single Field:
			var BooleanControl = new KeyValue("Boolean", "true", KeyValue.ValueTypes.Boolean);

			// Can Validate User Inputs on each Field:
			BooleanControl.Validate += (object _control, KeyValue.ValidateEventArgs _e) =>
			{
				string OldValue = _e.OldValue;
				if (_e.NewValue == "False")
				{
					//_e.Cancel = true; //<- CAN CANCEL THE MODIFICATION
					_e.ErrorText = "No puede ser Falso!";
				}
			};

			// Custom Types for 'Dynamic' Fields:
			List<KeyValue> Dtypes = new List<KeyValue>
			  {
				new KeyValue("RichText Format", "0"),
				new KeyValue("Plain Text",      "1"),
				new KeyValue("AccountManager",  "2")
			  };

			// Definition of Multiple Fields:
			List<KeyValue> _Fields = new List<KeyValue>
			  {
				new KeyValue("String",  "String",   KeyValue.ValueTypes.String),
				new KeyValue("Password","Password", KeyValue.ValueTypes.Password),
				new KeyValue("Integer", "1000",     KeyValue.ValueTypes.Integer),
				new KeyValue("Decimal", "3,141638", KeyValue.ValueTypes.Decimal),
				BooleanControl,
				new KeyValue("Dynamic", "1",        KeyValue.ValueTypes.Dynamic, Dtypes),
			  };

			// Dialog Show:
			if (Messenger.InputBox("Custom InputBox", "Please Fill the Form:", ref _Fields,
							MsgIcon.Edit, MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				Debug.WriteLine(string.Format("The New Password is: '{0}'", _Fields[1].Value));
			}
		}

		// Example of a Login Form with Password Validation:
		private void button4_Click(object sender, EventArgs e)
		{			
			List<KeyValue> _Fields = new List<KeyValue>
			{
				new KeyValue("User Name", "user", KeyValue.ValueTypes.String),
				new KeyValue("Password",  string.Empty, KeyValue.ValueTypes.Password)
			};

			// Validate All Controls before Closing the Dialog:
			Messenger.ValidateControls += (object Sender, KeyValue.ValidateEventArgs E) =>
			{
				string _userName = _Fields[0].Value;
				string _password = _Fields[1].Value;
				bool _isValid = false;

				//TODO: Here you should send the User/Password to your BackEnd for Validation
				_isValid = _password == "password";
				if (_isValid)
				{
					_Fields[1].ErrorText = "Incorrect Password!";
					E.Cancel = true; //<- Prevents the Dialog to be closed until is valid
				}
			};

			// Dialog Show:
			if (Messenger.InputBox("Login", "Please Input your Credentials:", ref _Fields,
									MsgIcon.Lock, MessageBoxButtons.OKCancel) == DialogResult.OK)
			{

				Messenger.MessageBox(string.Format("The User '{0}' is Logged!", _Fields[0].Value), "Login Correct!",
									MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Example of the Custom MessageBox
		private void button5_Click(object sender, EventArgs e)
		{
			if (Messenger.MessageBox("Hello World!", "You got a Message:",
			  MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
			{
				//Do Something here.
			}
		}
		
		private void button6_Click(object sender, EventArgs e)
		{
			IsDarkMode = !IsDarkMode;
			DM.ApplyTheme(IsDarkMode);
		}

		private void mnuSalir_Click(object sender, EventArgs e)
		{
			//Esta es la forma correcta de Cerrar la Aplicacion, aparte de Apagar el PC
			if (Messenger.MessageBox("Desea Cerrar este programa?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.mCloseAutorized = true;
				this.Close();
			}
		}
	}

	internal class ExampleDataSource
	{
		public int Sequence { get; set; } = 0;
		public string Name { get; set; } = string.Empty;
		public bool IsAlive { get; set; } = false;
		public decimal Points { get; set; } = 0;
		public string Observations { get; set; } = string.Empty;
	}
}
