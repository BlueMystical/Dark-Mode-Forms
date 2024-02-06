
namespace DarkModeForms
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
			components = new System.ComponentModel.Container();
			TreeNode treeNode1 = new TreeNode("Nodo1");
			TreeNode treeNode2 = new TreeNode("Nodo5");
			TreeNode treeNode3 = new TreeNode("Nodo2", new TreeNode[] { treeNode2 });
			TreeNode treeNode4 = new TreeNode("Nodo3");
			TreeNode treeNode5 = new TreeNode("Nodo0", new TreeNode[] { treeNode1, treeNode3, treeNode4 });
			TreeNode treeNode6 = new TreeNode("Nodo4");
			ListViewItem listViewItem1 = new ListViewItem(new string[] { "AA", "xx" }, 0);
			ListViewItem listViewItem2 = new ListViewItem("BB", 2);
			ListViewItem listViewItem3 = new ListViewItem("CC", 1);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			panel1 = new Panel();
			button1 = new Button();
			button2 = new Button();
			toolStrip1 = new ToolStrip();
			toolStripButton1 = new ToolStripButton();
			toolStripButton3 = new ToolStripButton();
			toolStripButton2 = new ToolStripButton();
			toolStripSplitButton1 = new ToolStripSplitButton();
			asssToolStripMenuItem = new ToolStripMenuItem();
			jhgjhgToolStripMenuItem = new ToolStripMenuItem();
			toolStripDropDownButton1 = new ToolStripDropDownButton();
			xxxToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1 = new MenuStrip();
			assToolStripMenuItem = new ToolStripMenuItem();
			titsToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator1 = new ToolStripSeparator();
			assToolStripMenuItem1 = new ToolStripMenuItem();
			hjhfjfToolStripMenuItem = new ToolStripMenuItem();
			kjlkToolStripMenuItem = new ToolStripMenuItem();
			asssToolStripMenuItem1 = new ToolStripMenuItem();
			label1 = new Label();
			textBox1 = new TextBox();
			comboBox1 = new ComboBox();
			numericUpDown1 = new NumericUpDown();
			listBox1 = new ListBox();
			treeView1 = new TreeView();
			listView1 = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			imageList1 = new ImageList(components);
			textBox2 = new TextBox();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			dataGridView1 = new DataGridView();
			panel1.SuspendLayout();
			toolStrip1.SuspendLayout();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(button1);
			panel1.Controls.Add(button2);
			panel1.Dock = DockStyle.Bottom;
			panel1.Location = new Point(0, 460);
			panel1.Margin = new Padding(4, 3, 4, 3);
			panel1.Name = "panel1";
			panel1.Size = new Size(680, 54);
			panel1.TabIndex = 0;
			// 
			// button1
			// 
			button1.Location = new Point(455, 14);
			button1.Margin = new Padding(4, 3, 4, 3);
			button1.Name = "button1";
			button1.Size = new Size(88, 27);
			button1.TabIndex = 2;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.FlatStyle = FlatStyle.Flat;
			button2.Location = new Point(562, 14);
			button2.Margin = new Padding(4, 3, 4, 3);
			button2.Name = "button2";
			button2.Size = new Size(88, 27);
			button2.TabIndex = 1;
			button2.Text = "button2";
			button2.UseVisualStyleBackColor = true;
			// 
			// toolStrip1
			// 
			toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
			toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton3, toolStripButton2, toolStripSplitButton1, toolStripDropDownButton1 });
			toolStrip1.Location = new Point(0, 24);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(680, 25);
			toolStrip1.TabIndex = 0;
			toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButton1.Image = Properties.Resources.forward_16x16;
			toolStripButton1.ImageTransparentColor = Color.Magenta;
			toolStripButton1.Name = "toolStripButton1";
			toolStripButton1.Size = new Size(23, 22);
			toolStripButton1.Text = "toolStripButton1";
			// 
			// toolStripButton3
			// 
			toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButton3.Image = Properties.Resources.all_borders_16x16;
			toolStripButton3.ImageTransparentColor = Color.Magenta;
			toolStripButton3.Name = "toolStripButton3";
			toolStripButton3.Size = new Size(23, 22);
			toolStripButton3.Text = "toolStripButton3";
			// 
			// toolStripButton2
			// 
			toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButton2.Image = Properties.Resources.customization_16x16;
			toolStripButton2.ImageTransparentColor = Color.Magenta;
			toolStripButton2.Name = "toolStripButton2";
			toolStripButton2.Size = new Size(23, 22);
			toolStripButton2.Text = "toolStripButton2";
			// 
			// toolStripSplitButton1
			// 
			toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { asssToolStripMenuItem, jhgjhgToolStripMenuItem });
			toolStripSplitButton1.Image = Properties.Resources.forward_16x16;
			toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
			toolStripSplitButton1.Name = "toolStripSplitButton1";
			toolStripSplitButton1.Size = new Size(91, 22);
			toolStripSplitButton1.Text = "toolMenu";
			// 
			// asssToolStripMenuItem
			// 
			asssToolStripMenuItem.Image = Properties.Resources.font_16x16;
			asssToolStripMenuItem.Name = "asssToolStripMenuItem";
			asssToolStripMenuItem.Size = new Size(108, 22);
			asssToolStripMenuItem.Text = "asss";
			// 
			// jhgjhgToolStripMenuItem
			// 
			jhgjhgToolStripMenuItem.Image = Properties.Resources.customization_16x16;
			jhgjhgToolStripMenuItem.Name = "jhgjhgToolStripMenuItem";
			jhgjhgToolStripMenuItem.Size = new Size(108, 22);
			jhgjhgToolStripMenuItem.Text = "jhgjhg";
			// 
			// toolStripDropDownButton1
			// 
			toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { xxxToolStripMenuItem });
			toolStripDropDownButton1.Image = Properties.Resources.font_16x16;
			toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
			toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			toolStripDropDownButton1.Size = new Size(29, 22);
			toolStripDropDownButton1.Text = "toolStripDropDownButton1";
			// 
			// xxxToolStripMenuItem
			// 
			xxxToolStripMenuItem.Image = Properties.Resources.forward_16x16;
			xxxToolStripMenuItem.Name = "xxxToolStripMenuItem";
			xxxToolStripMenuItem.Size = new Size(92, 22);
			xxxToolStripMenuItem.Text = "xxx";
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { assToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new Padding(7, 2, 0, 2);
			menuStrip1.Size = new Size(680, 24);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// assToolStripMenuItem
			// 
			assToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { titsToolStripMenuItem, toolStripSeparator1, assToolStripMenuItem1 });
			assToolStripMenuItem.Name = "assToolStripMenuItem";
			assToolStripMenuItem.Size = new Size(71, 20);
			assToolStripMenuItem.Text = "&File Menu";
			// 
			// titsToolStripMenuItem
			// 
			titsToolStripMenuItem.Image = Properties.Resources.font_16x16;
			titsToolStripMenuItem.Name = "titsToolStripMenuItem";
			titsToolStripMenuItem.Size = new Size(137, 22);
			titsToolStripMenuItem.Text = "Sub Menu 1";
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(134, 6);
			// 
			// assToolStripMenuItem1
			// 
			assToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { hjhfjfToolStripMenuItem, kjlkToolStripMenuItem, asssToolStripMenuItem1 });
			assToolStripMenuItem1.Image = Properties.Resources.customization_16x16;
			assToolStripMenuItem1.Name = "assToolStripMenuItem1";
			assToolStripMenuItem1.Size = new Size(137, 22);
			assToolStripMenuItem1.Text = "Sub Menu 2";
			// 
			// hjhfjfToolStripMenuItem
			// 
			hjhfjfToolStripMenuItem.Checked = true;
			hjhfjfToolStripMenuItem.CheckState = CheckState.Checked;
			hjhfjfToolStripMenuItem.Name = "hjhfjfToolStripMenuItem";
			hjhfjfToolStripMenuItem.Size = new Size(102, 22);
			hjhfjfToolStripMenuItem.Text = "hjhfjf";
			// 
			// kjlkToolStripMenuItem
			// 
			kjlkToolStripMenuItem.Enabled = false;
			kjlkToolStripMenuItem.Image = Properties.Resources.all_borders_16x16;
			kjlkToolStripMenuItem.Name = "kjlkToolStripMenuItem";
			kjlkToolStripMenuItem.Size = new Size(102, 22);
			kjlkToolStripMenuItem.Text = "kjlk";
			// 
			// asssToolStripMenuItem1
			// 
			asssToolStripMenuItem1.Image = Properties.Resources.forward_16x16;
			asssToolStripMenuItem1.Name = "asssToolStripMenuItem1";
			asssToolStripMenuItem1.Size = new Size(102, 22);
			asssToolStripMenuItem1.Text = "asss";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(158, 56);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(109, 15);
			label1.TabIndex = 2;
			label1.Text = "Common Controls:";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(29, 90);
			textBox1.Margin = new Padding(4, 3, 4, 3);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(177, 23);
			textBox1.TabIndex = 3;
			textBox1.Text = "Ass";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" });
			comboBox1.Location = new Point(29, 122);
			comboBox1.Margin = new Padding(4, 3, 4, 3);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(177, 23);
			comboBox1.TabIndex = 4;
			comboBox1.Text = "8";
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(29, 154);
			numericUpDown1.Margin = new Padding(4, 3, 4, 3);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(177, 23);
			numericUpDown1.TabIndex = 5;
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" });
			listBox1.Location = new Point(29, 186);
			listBox1.Margin = new Padding(4, 3, 4, 3);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(177, 109);
			listBox1.TabIndex = 6;
			// 
			// treeView1
			// 
			treeView1.HideSelection = false;
			treeView1.Location = new Point(229, 154);
			treeView1.Margin = new Padding(4, 3, 4, 3);
			treeView1.Name = "treeView1";
			treeNode1.Name = "Nodo1";
			treeNode1.Text = "Nodo1";
			treeNode2.Name = "Nodo5";
			treeNode2.Text = "Nodo5";
			treeNode3.Name = "Nodo2";
			treeNode3.Text = "Nodo2";
			treeNode4.Name = "Nodo3";
			treeNode4.Text = "Nodo3";
			treeNode5.Name = "Nodo0";
			treeNode5.Text = "Nodo0";
			treeNode6.Name = "Nodo4";
			treeNode6.Text = "Nodo4";
			treeView1.Nodes.AddRange(new TreeNode[] { treeNode5, treeNode6 });
			treeView1.Size = new Size(140, 140);
			treeView1.TabIndex = 9;
			// 
			// listView1
			// 
			listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
			listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
			listView1.LargeImageList = imageList1;
			listView1.Location = new Point(390, 90);
			listView1.Margin = new Padding(4, 3, 4, 3);
			listView1.Name = "listView1";
			listView1.Size = new Size(276, 205);
			listView1.TabIndex = 10;
			listView1.UseCompatibleStateImageBehavior = false;
			// 
			// imageList1
			// 
			imageList1.ColorDepth = ColorDepth.Depth32Bit;
			imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
			imageList1.TransparentColor = Color.Transparent;
			imageList1.Images.SetKeyName(0, "add-circle.png");
			imageList1.Images.SetKeyName(1, "cancel.png");
			imageList1.Images.SetKeyName(2, "success-tick.png");
			// 
			// textBox2
			// 
			textBox2.Location = new Point(229, 90);
			textBox2.Margin = new Padding(4, 3, 4, 3);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(140, 23);
			textBox2.TabIndex = 11;
			textBox2.Text = "1234567890";
			textBox2.TextAlign = HorizontalAlignment.Center;
			textBox2.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(434, 72);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(155, 15);
			label2.TabIndex = 13;
			label2.Text = "ListView - Large Icons Mode";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(29, 317);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(84, 15);
			label3.TabIndex = 14;
			label3.Text = "DataGrid View:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(229, 133);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(53, 15);
			label4.TabIndex = 15;
			label4.Text = "TreeView";
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(31, 336);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(635, 117);
			dataGridView1.TabIndex = 16;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(680, 514);
			Controls.Add(dataGridView1);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(textBox2);
			Controls.Add(listView1);
			Controls.Add(treeView1);
			Controls.Add(listBox1);
			Controls.Add(numericUpDown1);
			Controls.Add(comboBox1);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Controls.Add(toolStrip1);
			Controls.Add(panel1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Margin = new Padding(4, 3, 4, 3);
			Name = "Form1";
			Text = "DarkModeForms - Form1";
			Load += Form1_Load;
			panel1.ResumeLayout(false);
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private ToolStrip toolStrip1;
		private ToolStripButton toolStripButton1;
		private ToolStripSplitButton toolStripSplitButton1;
		private ToolStripMenuItem asssToolStripMenuItem;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem assToolStripMenuItem;
		private ToolStripMenuItem titsToolStripMenuItem;
		private Label label1;
		private TextBox textBox1;
		private ComboBox comboBox1;
		private NumericUpDown numericUpDown1;
		private ListBox listBox1;
		private TreeView treeView1;
		private ToolStripMenuItem assToolStripMenuItem1;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem hjhfjfToolStripMenuItem;
		private ToolStripMenuItem kjlkToolStripMenuItem;
		private Button button2;
		private Button button1;
		private ToolStripMenuItem jhgjhgToolStripMenuItem;
		private ListView listView1;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ImageList imageList1;
		private ToolStripButton toolStripButton3;
		private ToolStripButton toolStripButton2;
		private ToolStripDropDownButton toolStripDropDownButton1;
		private ToolStripMenuItem xxxToolStripMenuItem;
		private ToolStripMenuItem asssToolStripMenuItem1;
		private TextBox textBox2;
		private Label label2;
		private Label label3;
		private Label label4;
		private DataGridView dataGridView1;
	}
}