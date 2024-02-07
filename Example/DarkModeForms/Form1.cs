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

			List<KeyValue> Dtypes = new List<KeyValue>
			{
				new KeyValue("RichText Format", "0"),
				new KeyValue("Plain Text",      "1"),
				new KeyValue("AccountManager",  "2")
			};
			var DarkMode = new KeyValue("Boolean", "true", KeyValue.ValueTypes.Boolean);
			DarkMode.Validate += (object? _control, KeyValue.ValidateEventArgs _e) =>
			{
				string OldValue = _e.OldValue;
				if (_e.NewValue == "False")
				{
					//_e.Cancel = true; //<- CAN CANCEL THE MODIFICATION
					_e.ErrorText = "No puede ser Falso!";
				}
			};

			List<KeyValue> props = new List<KeyValue>
			{
				new KeyValue("String",  "String",   KeyValue.ValueTypes.String),
				new KeyValue("Password","Password", KeyValue.ValueTypes.Password),
				new KeyValue("Integer", "1000",     KeyValue.ValueTypes.Integer),
				new KeyValue("Decimal", "3,141638", KeyValue.ValueTypes.Decimal),
				DarkMode,
				new KeyValue("Dynamic", "1",        KeyValue.ValueTypes.Dynamic, Dtypes),
				//new KeyValue("Time", DateTime.Now.ToShortTimeString(), KeyValue.ValueTypes.Time),
			};

			if (Messenger.InputBox("Custom InputBox", "Please Fill the Form:",
				ref props, Base64Icons.MsgIcon.Edit) == DialogResult.OK)
			{

			}
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
