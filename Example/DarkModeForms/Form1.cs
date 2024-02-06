using System;
using System.Collections.Generic;
using System.ComponentModel;
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
	}

	class ExampleDataSource
	{
		public int Sequence { get; set; }
		public string Name { get; set; }
		public bool IsAlive { get; set; }
		public decimal Points { get; set; }
		public string Observations { get; set; }
	}
}
