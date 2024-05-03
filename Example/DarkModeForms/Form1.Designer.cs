
using BlueMystic;

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
			button4 = new Button();
			button5 = new Button();
			button3 = new Button();
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
			contextMenuStrip1 = new ContextMenuStrip(components);
			contex01ToolStripMenuItem = new ToolStripMenuItem();
			contex02ToolStripMenuItem = new ToolStripMenuItem();
			context03ToolStripMenuItem = new ToolStripMenuItem();
			listView1 = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			imageList1 = new ImageList(components);
			textBox2 = new TextBox();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			dataGridView1 = new DataGridView();
			flatComboBox1 = new FlatComboBox();
			statusStrip1 = new StatusStrip();
			toolStripStatusLabel1 = new ToolStripStatusLabel();
			toolStripDropDownButton2 = new ToolStripDropDownButton();
			test2ToolStripMenuItem = new ToolStripMenuItem();
			test1ToolStripMenuItem = new ToolStripMenuItem();
			groupBox1 = new GroupBox();
			label5 = new Label();
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			tabPage2 = new TabPage();
			textBox3 = new TextBox();
			linkLabel1 = new LinkLabel();
			label6 = new Label();
			checkBox1 = new CheckBox();
			radioButton1 = new RadioButton();
			flatTabControl1 = new FlatTabControl();
			tabPage3 = new TabPage();
			tabPage4 = new TabPage();
			propertyGrid1 = new PropertyGrid();
			imageList2 = new ImageList(components);
			panel1.SuspendLayout();
			toolStrip1.SuspendLayout();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			statusStrip1.SuspendLayout();
			groupBox1.SuspendLayout();
			tabControl1.SuspendLayout();
			tabPage2.SuspendLayout();
			flatTabControl1.SuspendLayout();
			tabPage3.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(button4);
			panel1.Controls.Add(button5);
			panel1.Controls.Add(button3);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(button2);
			panel1.Dock = DockStyle.Bottom;
			panel1.Location = new Point(0, 618);
			panel1.Margin = new Padding(4, 3, 4, 3);
			panel1.Name = "panel1";
			panel1.Size = new Size(680, 54);
			panel1.TabIndex = 0;
			// 
			// button4
			// 
			button4.Location = new Point(591, 3);
			button4.Name = "button4";
			button4.Size = new Size(75, 48);
			button4.TabIndex = 5;
			button4.Text = "Password Input";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button5
			// 
			button5.Location = new Point(434, 3);
			button5.Name = "button5";
			button5.Size = new Size(75, 48);
			button5.TabIndex = 4;
			button5.Text = "Custom MsgBox";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// button3
			// 
			button3.Location = new Point(514, 3);
			button3.Name = "button3";
			button3.Size = new Size(75, 48);
			button3.TabIndex = 3;
			button3.Text = "Custom InputBox";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button1
			// 
			button1.Location = new Point(229, 14);
			button1.Margin = new Padding(4, 3, 4, 3);
			button1.Name = "button1";
			button1.Size = new Size(100, 27);
			button1.TabIndex = 2;
			button1.Text = "CreateControl";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(337, 14);
			button2.Margin = new Padding(4, 3, 4, 3);
			button2.Name = "button2";
			button2.Size = new Size(88, 27);
			button2.TabIndex = 1;
			button2.Text = "MsgBox";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
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
			label1.Location = new Point(240, 72);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(100, 15);
			label1.TabIndex = 2;
			label1.Text = "Custom Controls:";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(7, 25);
			textBox1.Margin = new Padding(4, 3, 4, 3);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(177, 23);
			textBox1.TabIndex = 3;
			textBox1.Text = "ASDFG";
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" });
			comboBox1.Location = new Point(7, 57);
			comboBox1.Margin = new Padding(4, 3, 4, 3);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(177, 23);
			comboBox1.TabIndex = 4;
			comboBox1.Text = "8";
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(7, 89);
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
			listBox1.Location = new Point(6, 118);
			listBox1.Margin = new Padding(4, 3, 4, 3);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(177, 109);
			listBox1.TabIndex = 6;
			// 
			// treeView1
			// 
			treeView1.ContextMenuStrip = contextMenuStrip1;
			treeView1.HideSelection = false;
			treeView1.ImageIndex = 0;
			treeView1.ImageList = imageList2;
			treeView1.Location = new Point(229, 186);
			treeView1.Margin = new Padding(4, 3, 4, 3);
			treeView1.Name = "treeView1";
			treeNode1.ImageKey = "forward_16x16.png";
			treeNode1.Name = "Nodo1";
			treeNode1.Text = "Nodo1";
			treeNode2.Name = "Nodo5";
			treeNode2.Text = "Nodo5";
			treeNode3.Name = "Nodo2";
			treeNode3.Text = "Nodo2";
			treeNode4.ImageKey = "font_16x16.png";
			treeNode4.Name = "Nodo3";
			treeNode4.Text = "Nodo3";
			treeNode5.Name = "Nodo0";
			treeNode5.Text = "Nodo0";
			treeNode6.Name = "Nodo4";
			treeNode6.Text = "Nodo4";
			treeView1.Nodes.AddRange(new TreeNode[] { treeNode5, treeNode6 });
			treeView1.SelectedImageIndex = 0;
			treeView1.Size = new Size(140, 108);
			treeView1.TabIndex = 9;
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.BackColor = SystemColors.Control;
			contextMenuStrip1.Items.AddRange(new ToolStripItem[] { contex01ToolStripMenuItem, contex02ToolStripMenuItem, context03ToolStripMenuItem });
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(132, 70);
			// 
			// contex01ToolStripMenuItem
			// 
			contex01ToolStripMenuItem.Name = "contex01ToolStripMenuItem";
			contex01ToolStripMenuItem.Size = new Size(131, 22);
			contex01ToolStripMenuItem.Text = "Context 01";
			// 
			// contex02ToolStripMenuItem
			// 
			contex02ToolStripMenuItem.Name = "contex02ToolStripMenuItem";
			contex02ToolStripMenuItem.Size = new Size(131, 22);
			contex02ToolStripMenuItem.Text = "Context 02";
			// 
			// context03ToolStripMenuItem
			// 
			context03ToolStripMenuItem.Name = "context03ToolStripMenuItem";
			context03ToolStripMenuItem.Size = new Size(131, 22);
			context03ToolStripMenuItem.Text = "Context 03";
			// 
			// listView1
			// 
			listView1.BackColor = SystemColors.Window;
			listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
			listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
			listView1.LargeImageList = imageList1;
			listView1.Location = new Point(397, 72);
			listView1.Margin = new Padding(4, 3, 4, 3);
			listView1.Name = "listView1";
			listView1.Size = new Size(269, 145);
			listView1.TabIndex = 10;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = View.Details;
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
			textBox2.Location = new Point(229, 121);
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
			label2.Location = new Point(434, 49);
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
			label4.ForeColor = Color.FromArgb(255, 128, 0);
			label4.Location = new Point(229, 168);
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
			dataGridView1.Size = new Size(360, 117);
			dataGridView1.TabIndex = 16;
			// 
			// flatComboBox1
			// 
			flatComboBox1.FormattingEnabled = true;
			flatComboBox1.Items.AddRange(new object[] { "AA", "AB", "AC", "BA", "BB", "BC", "CA", "CB", "CC" });
			flatComboBox1.Location = new Point(229, 90);
			flatComboBox1.Name = "flatComboBox1";
			flatComboBox1.Size = new Size(140, 23);
			flatComboBox1.TabIndex = 17;
			flatComboBox1.Text = "BA";
			// 
			// statusStrip1
			// 
			statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripDropDownButton2 });
			statusStrip1.Location = new Point(0, 672);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(680, 22);
			statusStrip1.TabIndex = 18;
			statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			toolStripStatusLabel1.Size = new Size(39, 17);
			toolStripStatusLabel1.Text = "Status";
			// 
			// toolStripDropDownButton2
			// 
			toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { test2ToolStripMenuItem, test1ToolStripMenuItem });
			toolStripDropDownButton2.Image = Properties.Resources.all_borders_16x16;
			toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
			toolStripDropDownButton2.Name = "toolStripDropDownButton2";
			toolStripDropDownButton2.Size = new Size(29, 20);
			toolStripDropDownButton2.Text = "toolStripDropDownButton2";
			// 
			// test2ToolStripMenuItem
			// 
			test2ToolStripMenuItem.Image = Properties.Resources.font_16x16;
			test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
			test2ToolStripMenuItem.Size = new Size(103, 22);
			test2ToolStripMenuItem.Text = "Test 2";
			// 
			// test1ToolStripMenuItem
			// 
			test1ToolStripMenuItem.Image = Properties.Resources.customization_16x16;
			test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
			test1ToolStripMenuItem.Size = new Size(103, 22);
			test1ToolStripMenuItem.Text = "Test 1";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(textBox1);
			groupBox1.Controls.Add(comboBox1);
			groupBox1.Controls.Add(numericUpDown1);
			groupBox1.Controls.Add(listBox1);
			groupBox1.Location = new Point(12, 64);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(199, 239);
			groupBox1.TabIndex = 19;
			groupBox1.TabStop = false;
			groupBox1.Text = "Common Controls";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(229, 297);
			label5.Name = "label5";
			label5.Size = new Size(133, 30);
			label5.TabIndex = 20;
			label5.Text = "↑  Right Click on Nodes \r\n    for Context Menu.";
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Location = new Point(16, 466);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(266, 146);
			tabControl1.TabIndex = 21;
			// 
			// tabPage1
			// 
			tabPage1.BackColor = Color.Transparent;
			tabPage1.Location = new Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Size = new Size(258, 118);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "tabPage1";
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(textBox3);
			tabPage2.Controls.Add(linkLabel1);
			tabPage2.Controls.Add(label6);
			tabPage2.Location = new Point(4, 24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(258, 118);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "tabPage2";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(74, 22);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(100, 23);
			textBox3.TabIndex = 6;
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Location = new Point(125, 82);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(60, 15);
			linkLabel1.TabIndex = 5;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "linkLabel1";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(74, 79);
			label6.Name = "label6";
			label6.Size = new Size(38, 15);
			label6.TabIndex = 4;
			label6.Text = "label6";
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Checked = true;
			checkBox1.CheckState = CheckState.Checked;
			checkBox1.Location = new Point(73, 61);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(83, 19);
			checkBox1.TabIndex = 22;
			checkBox1.Text = "checkBox1";
			checkBox1.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Checked = true;
			radioButton1.Location = new Point(73, 36);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(94, 19);
			radioButton1.TabIndex = 23;
			radioButton1.TabStop = true;
			radioButton1.Text = "radioButton1";
			radioButton1.UseVisualStyleBackColor = true;
			// 
			// flatTabControl1
			// 
			flatTabControl1.Appearance = TabAppearance.Buttons;
			flatTabControl1.BorderColor = SystemColors.ControlDark;
			flatTabControl1.Controls.Add(tabPage3);
			flatTabControl1.Controls.Add(tabPage4);
			flatTabControl1.LineColor = SystemColors.ControlLight;
			flatTabControl1.Location = new Point(288, 459);
			flatTabControl1.Name = "flatTabControl1";
			flatTabControl1.SelectedForeColor = SystemColors.ControlText;
			flatTabControl1.SelectedIndex = 0;
			flatTabControl1.SelectTabColor = SystemColors.Control;
			flatTabControl1.Size = new Size(278, 153);
			flatTabControl1.SizeMode = TabSizeMode.Fixed;
			flatTabControl1.TabColor = SystemColors.ControlLight;
			flatTabControl1.TabIndex = 24;
			// 
			// tabPage3
			// 
			tabPage3.BackColor = SystemColors.ControlLight;
			tabPage3.Controls.Add(radioButton1);
			tabPage3.Controls.Add(checkBox1);
			tabPage3.Location = new Point(4, 27);
			tabPage3.Name = "tabPage3";
			tabPage3.Padding = new Padding(3);
			tabPage3.Size = new Size(270, 122);
			tabPage3.TabIndex = 0;
			tabPage3.Text = "tabPage3";
			// 
			// tabPage4
			// 
			tabPage4.BackColor = SystemColors.ControlLight;
			tabPage4.Location = new Point(4, 27);
			tabPage4.Name = "tabPage4";
			tabPage4.Padding = new Padding(3);
			tabPage4.Size = new Size(270, 122);
			tabPage4.TabIndex = 1;
			tabPage4.Text = "tabPage4";
			// 
			// propertyGrid1
			// 
			propertyGrid1.Location = new Point(397, 223);
			propertyGrid1.Name = "propertyGrid1";
			propertyGrid1.SelectedObject = dataGridView1;
			propertyGrid1.Size = new Size(269, 230);
			propertyGrid1.TabIndex = 25;
			// 
			// imageList2
			// 
			imageList2.ColorDepth = ColorDepth.Depth8Bit;
			imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
			imageList2.TransparentColor = Color.Transparent;
			imageList2.Images.SetKeyName(0, "customization_16x16.png");
			imageList2.Images.SetKeyName(1, "font_16x16.png");
			imageList2.Images.SetKeyName(2, "forward_16x16.png");
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(680, 694);
			Controls.Add(propertyGrid1);
			Controls.Add(flatTabControl1);
			Controls.Add(tabControl1);
			Controls.Add(label5);
			Controls.Add(groupBox1);
			Controls.Add(flatComboBox1);
			Controls.Add(dataGridView1);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(textBox2);
			Controls.Add(listView1);
			Controls.Add(treeView1);
			Controls.Add(label1);
			Controls.Add(toolStrip1);
			Controls.Add(panel1);
			Controls.Add(menuStrip1);
			Controls.Add(statusStrip1);
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
			contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			tabControl1.ResumeLayout(false);
			tabPage2.ResumeLayout(false);
			tabPage2.PerformLayout();
			flatTabControl1.ResumeLayout(false);
			tabPage3.ResumeLayout(false);
			tabPage3.PerformLayout();
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
		private FlatComboBox flatComboBox1;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private ToolStripDropDownButton toolStripDropDownButton2;
		private ToolStripMenuItem test2ToolStripMenuItem;
		private ToolStripMenuItem test1ToolStripMenuItem;
		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem contex01ToolStripMenuItem;
		private ToolStripMenuItem contex02ToolStripMenuItem;
		private ToolStripMenuItem context03ToolStripMenuItem;
		private GroupBox groupBox1;
		private Label label5;
		private Button button3;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private CheckBox checkBox1;
		private RadioButton radioButton1;
		private Button button5;
		private FlatTabControl flatTabControl1;
		private TabPage tabPage3;
		private TabPage tabPage4;
		private TextBox textBox3;
		private LinkLabel linkLabel1;
		private Label label6;
		private Button button4;
		private PropertyGrid propertyGrid1;
		private ImageList imageList2;
	}
}