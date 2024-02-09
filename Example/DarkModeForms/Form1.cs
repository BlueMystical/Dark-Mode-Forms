using BlueMystic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;


namespace DarkModeForms
{
	public partial class Form1 : Form
	{
		private DarkModeCS DM = null;

		private BindingList<ExampleDataSource> DS = null;

		public Form1()
		{
			InitializeComponent();
			DM = new DarkModeCS(this);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
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
					Name = "Profesor Hubert Farnsworth",
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
			dataGridView1.DataSource = DS;
			treeView1.Nodes[0].Expand();
			tabControl1.SelectTab(1);
		}

		public void DrawVisualStyleElementMenuChevron1(PaintEventArgs e)
		{
			if (System.Windows.Forms.VisualStyles.VisualStyleRenderer.IsElementDefined(
				System.Windows.Forms.VisualStyles.VisualStyleElement.Menu.Chevron.Normal))
			{
				System.Windows.Forms.VisualStyles.VisualStyleRenderer renderer =
					 new System.Windows.Forms.VisualStyles.VisualStyleRenderer(System.Windows.Forms.VisualStyles.VisualStyleElement.Menu.Chevron.Normal);
				Rectangle rectangle1 = new Rectangle(10, 50, 50, 50);
				renderer.DrawBackground(e.Graphics, rectangle1);
				e.Graphics.DrawString("VisualStyleElement.Menu.Chevron.Normal",
					 this.Font, Brushes.Black, new Point(10, 10));
			}
			else
				e.Graphics.DrawString("This element is not defined in the current visual style.",
					 this.Font, Brushes.Black, new Point(10, 10));
		}

		int CtrlCounter = 0;
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

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Sadly its not possible to change\r\nthe default MessageBoxes :(", "Hello World!", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			/**** USE EXAMPLE FOR THE INPUTBOX  ****/

			// Definition of a Single Field:
			var DarkMode = new KeyValue("Boolean", "true", KeyValue.ValueTypes.Boolean);

			// Can Validate User Inputs on the Field:
			DarkMode.Validate += (object? _control, KeyValue.ValidateEventArgs _e) =>
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
				DarkMode,
				new KeyValue("Dynamic", "1",        KeyValue.ValueTypes.Dynamic, Dtypes),
			};

			// Dialog Show:
			if (Messenger.InputBox("Custom InputBox", "Please Fill the Form:", ref _Fields,
				Base64Icons.MsgIcon.Edit, MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				Debug.WriteLine(string.Format("The New Password is: '{0}'", _Fields[0].Value));
			}
		}
		private void button5_Click(object sender, EventArgs e)
		{

			try
			{
				throw new NotImplementedException();
			}
			catch (Exception ex)
			{
				Messenger.MesageBox(ex);
			}


			if (Messenger.MesageBox("Hello World!", "You got a Message:",
				MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
			{
				//Do Something here.
			}
		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{

		}


	}

	class ExampleDataSource
	{
		public int Sequence { get; set; } = 0;
		public string Name { get; set; } = string.Empty;
		public bool IsAlive { get; set; } = false;
		public decimal Points { get; set; } = 0;
		public string Observations { get; set; } = string.Empty;
	}
}
