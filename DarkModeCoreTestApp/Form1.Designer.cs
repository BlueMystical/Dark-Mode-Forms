using BlueMystical.Forms.DarkModeCore;
using System.Windows.Forms;

namespace DarkModeCoreTestApp
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
			TreeNode treeNode7 = new TreeNode("Nodo1");
			TreeNode treeNode8 = new TreeNode("Nodo5");
			TreeNode treeNode9 = new TreeNode("Nodo2", new TreeNode[] { treeNode8 });
			TreeNode treeNode10 = new TreeNode("Nodo3");
			TreeNode treeNode11 = new TreeNode("Nodo0", new TreeNode[] { treeNode7, treeNode9, treeNode10 });
			TreeNode treeNode12 = new TreeNode("Nodo4");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			ListViewItem listViewItem4 = new ListViewItem(new string[] { "AA", "xx" }, 0);
			ListViewItem listViewItem5 = new ListViewItem("BB", 2);
			ListViewItem listViewItem6 = new ListViewItem("CC", 1);
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			panel1 = new Panel();
			panel2 = new Panel();
			radioButtonLight = new RadioButton();
			radioButtonDark = new RadioButton();
			radioButtonSystem = new RadioButton();
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
			textBox1 = new TextBox();
			comboBox1 = new ComboBox();
			numericUpDown1 = new NumericUpDown();
			listBox1 = new ListBox();
			treeView1 = new TreeView();
			contextMenuStrip1 = new ContextMenuStrip(components);
			contex01ToolStripMenuItem = new ToolStripMenuItem();
			contex02ToolStripMenuItem = new ToolStripMenuItem();
			context03ToolStripMenuItem = new ToolStripMenuItem();
			toolStripMenuItem1 = new ToolStripSeparator();
			mnuSalir = new ToolStripMenuItem();
			imageList2 = new ImageList(components);
			listView1 = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			imageList1 = new ImageList(components);
			textBox2 = new TextBox();
			label2 = new Label();
			label3 = new Label();
			dataGridView1 = new DataGridView();
			statusStrip1 = new StatusStrip();
			toolStripStatusLabel1 = new ToolStripStatusLabel();
			toolStripDropDownButton2 = new ToolStripDropDownButton();
			test2ToolStripMenuItem = new ToolStripMenuItem();
			test1ToolStripMenuItem = new ToolStripMenuItem();
			groupBox1 = new GroupBox();
			comboBox2 = new ComboBox();
			label5 = new Label();
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			tabPage2 = new TabPage();
			textBox3 = new TextBox();
			linkLabel1 = new LinkLabel();
			label8 = new Label();
			label6 = new Label();
			propertyGrid1 = new PropertyGrid();
			notifyIcon1 = new NotifyIcon(components);
			groupBox2 = new GroupBox();
			label10 = new Label();
			label9 = new Label();
			checkBox3 = new CheckBox();
			radioButton3 = new RadioButton();
			radioButton2 = new RadioButton();
			label1 = new Label();
			label4 = new Label();
			checkBox2 = new CheckBox();
			button7 = new Button();
			listView2 = new ListView();
			label7 = new Label();
			groupBox3 = new GroupBox();
			flatTabControl1 = new FlatTabControl();
			tabPage3 = new TabPage();
			tabPage4 = new TabPage();
			label13 = new Label();
			label12 = new Label();
			flatComboBox1 = new FlatComboBox();
			label11 = new Label();
			newProgressBar1 = new FlatProgressBar();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			toolStrip1.SuspendLayout();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			statusStrip1.SuspendLayout();
			groupBox1.SuspendLayout();
			tabControl1.SuspendLayout();
			tabPage2.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			flatTabControl1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(panel2);
			panel1.Controls.Add(button4);
			panel1.Controls.Add(button5);
			panel1.Controls.Add(button3);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(button2);
			panel1.Dock = DockStyle.Bottom;
			panel1.Location = new System.Drawing.Point(0, 602);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(957, 47);
			panel1.TabIndex = 0;
			// 
			// panel2
			// 
			panel2.Controls.Add(radioButtonLight);
			panel2.Controls.Add(radioButtonDark);
			panel2.Controls.Add(radioButtonSystem);
			panel2.Location = new System.Drawing.Point(394, 3);
			panel2.Margin = new Padding(2);
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size(326, 40);
			panel2.TabIndex = 6;
			// 
			// radioButtonLight
			// 
			radioButtonLight.AutoSize = true;
			radioButtonLight.Location = new System.Drawing.Point(206, 6);
			radioButtonLight.Margin = new Padding(2);
			radioButtonLight.Name = "radioButtonLight";
			radioButtonLight.Size = new System.Drawing.Size(92, 19);
			radioButtonLight.TabIndex = 2;
			radioButtonLight.TabStop = true;
			radioButtonLight.Text = "Light Theme";
			radioButtonLight.UseVisualStyleBackColor = true;
			radioButtonLight.CheckedChanged += radioButtonSystem_CheckedChanged;
			// 
			// radioButtonDark
			// 
			radioButtonDark.AutoSize = true;
			radioButtonDark.Location = new System.Drawing.Point(108, 7);
			radioButtonDark.Margin = new Padding(2);
			radioButtonDark.Name = "radioButtonDark";
			radioButtonDark.Size = new System.Drawing.Size(89, 19);
			radioButtonDark.TabIndex = 1;
			radioButtonDark.TabStop = true;
			radioButtonDark.Text = "Dark Theme";
			radioButtonDark.UseVisualStyleBackColor = true;
			radioButtonDark.CheckedChanged += radioButtonSystem_CheckedChanged;
			// 
			// radioButtonSystem
			// 
			radioButtonSystem.AutoSize = true;
			radioButtonSystem.Checked = true;
			radioButtonSystem.Location = new System.Drawing.Point(10, 7);
			radioButtonSystem.Margin = new Padding(2);
			radioButtonSystem.Name = "radioButtonSystem";
			radioButtonSystem.Size = new System.Drawing.Size(101, 19);
			radioButtonSystem.TabIndex = 0;
			radioButtonSystem.TabStop = true;
			radioButtonSystem.Text = "Follow System";
			radioButtonSystem.UseVisualStyleBackColor = true;
			radioButtonSystem.CheckedChanged += radioButtonSystem_CheckedChanged;
			// 
			// button4
			// 
			button4.Location = new System.Drawing.Point(324, 2);
			button4.Name = "button4";
			button4.Size = new System.Drawing.Size(64, 42);
			button4.TabIndex = 5;
			button4.Text = "Password Input";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button5
			// 
			button5.Location = new System.Drawing.Point(189, 2);
			button5.Name = "button5";
			button5.Size = new System.Drawing.Size(64, 42);
			button5.TabIndex = 4;
			button5.Text = "Custom MsgBox";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// button3
			// 
			button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 128, 0);
			button3.FlatStyle = FlatStyle.System;
			button3.Location = new System.Drawing.Point(258, 2);
			button3.Name = "button3";
			button3.Size = new System.Drawing.Size(64, 42);
			button3.TabIndex = 3;
			button3.Text = "Custom InputBox";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button1
			// 
			button1.Location = new System.Drawing.Point(13, 10);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(86, 23);
			button1.TabIndex = 2;
			button1.Text = "CreateControl";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new System.Drawing.Point(106, 10);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(75, 23);
			button2.TabIndex = 1;
			button2.Text = "MsgBox";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// toolStrip1
			// 
			toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
			toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton3, toolStripButton2, toolStripSplitButton1, toolStripDropDownButton1 });
			toolStrip1.Location = new System.Drawing.Point(0, 24);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new System.Drawing.Size(957, 25);
			toolStrip1.TabIndex = 0;
			toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			toolStripButton1.Name = "toolStripButton1";
			toolStripButton1.Size = new System.Drawing.Size(23, 22);
			toolStripButton1.Text = "toolStripButton1";
			// 
			// toolStripButton3
			// 
			toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			toolStripButton3.Name = "toolStripButton3";
			toolStripButton3.Size = new System.Drawing.Size(23, 22);
			toolStripButton3.Text = "toolStripButton3";
			// 
			// toolStripButton2
			// 
			toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			toolStripButton2.Name = "toolStripButton2";
			toolStripButton2.Size = new System.Drawing.Size(23, 22);
			toolStripButton2.Text = "toolStripButton2";
			// 
			// toolStripSplitButton1
			// 
			toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { asssToolStripMenuItem, jhgjhgToolStripMenuItem });
			toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			toolStripSplitButton1.Name = "toolStripSplitButton1";
			toolStripSplitButton1.Size = new System.Drawing.Size(75, 22);
			toolStripSplitButton1.Text = "toolMenu";
			// 
			// asssToolStripMenuItem
			// 
			asssToolStripMenuItem.Name = "asssToolStripMenuItem";
			asssToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			asssToolStripMenuItem.Text = "asss";
			// 
			// jhgjhgToolStripMenuItem
			// 
			jhgjhgToolStripMenuItem.Name = "jhgjhgToolStripMenuItem";
			jhgjhgToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			jhgjhgToolStripMenuItem.Text = "jhgjhg";
			// 
			// toolStripDropDownButton1
			// 
			toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { xxxToolStripMenuItem });
			toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			toolStripDropDownButton1.Size = new System.Drawing.Size(13, 22);
			toolStripDropDownButton1.Text = "toolStripDropDownButton1";
			// 
			// xxxToolStripMenuItem
			// 
			xxxToolStripMenuItem.Name = "xxxToolStripMenuItem";
			xxxToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
			xxxToolStripMenuItem.Text = "xxx";
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { assToolStripMenuItem });
			menuStrip1.Location = new System.Drawing.Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new Padding(5, 2, 0, 2);
			menuStrip1.Size = new System.Drawing.Size(957, 24);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// assToolStripMenuItem
			// 
			assToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { titsToolStripMenuItem, toolStripSeparator1, assToolStripMenuItem1 });
			assToolStripMenuItem.Name = "assToolStripMenuItem";
			assToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			assToolStripMenuItem.Text = "&File Menu";
			// 
			// titsToolStripMenuItem
			// 
			titsToolStripMenuItem.Name = "titsToolStripMenuItem";
			titsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			titsToolStripMenuItem.Text = "Sub Menu 1";
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new System.Drawing.Size(134, 6);
			// 
			// assToolStripMenuItem1
			// 
			assToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { hjhfjfToolStripMenuItem, kjlkToolStripMenuItem, asssToolStripMenuItem1 });
			assToolStripMenuItem1.Name = "assToolStripMenuItem1";
			assToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
			assToolStripMenuItem1.Text = "Sub Menu 2";
			// 
			// hjhfjfToolStripMenuItem
			// 
			hjhfjfToolStripMenuItem.Checked = true;
			hjhfjfToolStripMenuItem.CheckState = CheckState.Checked;
			hjhfjfToolStripMenuItem.Name = "hjhfjfToolStripMenuItem";
			hjhfjfToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
			hjhfjfToolStripMenuItem.Text = "hjhfjf";
			// 
			// kjlkToolStripMenuItem
			// 
			kjlkToolStripMenuItem.Enabled = false;
			kjlkToolStripMenuItem.Name = "kjlkToolStripMenuItem";
			kjlkToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
			kjlkToolStripMenuItem.Text = "kjlk";
			// 
			// asssToolStripMenuItem1
			// 
			asssToolStripMenuItem1.Name = "asssToolStripMenuItem1";
			asssToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
			asssToolStripMenuItem1.Text = "asss";
			// 
			// textBox1
			// 
			textBox1.Location = new System.Drawing.Point(6, 22);
			textBox1.Name = "textBox1";
			textBox1.Size = new System.Drawing.Size(152, 23);
			textBox1.TabIndex = 3;
			textBox1.Text = "ASDFG";
			// 
			// comboBox1
			// 
			comboBox1.Enabled = false;
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" });
			comboBox1.Location = new System.Drawing.Point(6, 49);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new System.Drawing.Size(152, 23);
			comboBox1.TabIndex = 4;
			comboBox1.Text = "8";
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new System.Drawing.Point(6, 103);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new System.Drawing.Size(152, 23);
			numericUpDown1.TabIndex = 5;
			// 
			// listBox1
			// 
			listBox1.Enabled = false;
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" });
			listBox1.Location = new System.Drawing.Point(5, 128);
			listBox1.Name = "listBox1";
			listBox1.Size = new System.Drawing.Size(152, 49);
			listBox1.TabIndex = 6;
			// 
			// treeView1
			// 
			treeView1.ContextMenuStrip = contextMenuStrip1;
			treeView1.HideSelection = false;
			treeView1.ImageIndex = 0;
			treeView1.ImageList = imageList2;
			treeView1.Location = new System.Drawing.Point(196, 104);
			treeView1.Name = "treeView1";
			treeNode7.ImageKey = "forward_16x16.png";
			treeNode7.Name = "Nodo1";
			treeNode7.Text = "Nodo1";
			treeNode8.Name = "Nodo5";
			treeNode8.Text = "Nodo5";
			treeNode9.Name = "Nodo2";
			treeNode9.Text = "Nodo2";
			treeNode10.ImageKey = "font_16x16.png";
			treeNode10.Name = "Nodo3";
			treeNode10.Text = "Nodo3";
			treeNode11.Name = "Nodo0";
			treeNode11.Text = "Nodo0";
			treeNode12.Name = "Nodo4";
			treeNode12.Text = "Nodo4";
			treeView1.Nodes.AddRange(new TreeNode[] { treeNode11, treeNode12 });
			treeView1.SelectedImageIndex = 0;
			treeView1.Size = new System.Drawing.Size(121, 151);
			treeView1.TabIndex = 9;
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.BackColor = System.Drawing.SystemColors.Control;
			contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			contextMenuStrip1.Items.AddRange(new ToolStripItem[] { contex01ToolStripMenuItem, contex02ToolStripMenuItem, context03ToolStripMenuItem, toolStripMenuItem1, mnuSalir });
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new System.Drawing.Size(131, 98);
			// 
			// contex01ToolStripMenuItem
			// 
			contex01ToolStripMenuItem.Name = "contex01ToolStripMenuItem";
			contex01ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			contex01ToolStripMenuItem.Text = "Context 01";
			// 
			// contex02ToolStripMenuItem
			// 
			contex02ToolStripMenuItem.Name = "contex02ToolStripMenuItem";
			contex02ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			contex02ToolStripMenuItem.Text = "Context 02";
			// 
			// context03ToolStripMenuItem
			// 
			context03ToolStripMenuItem.Name = "context03ToolStripMenuItem";
			context03ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			context03ToolStripMenuItem.Text = "Context 03";
			// 
			// toolStripMenuItem1
			// 
			toolStripMenuItem1.Name = "toolStripMenuItem1";
			toolStripMenuItem1.Size = new System.Drawing.Size(127, 6);
			// 
			// mnuSalir
			// 
			mnuSalir.Name = "mnuSalir";
			mnuSalir.Size = new System.Drawing.Size(130, 22);
			mnuSalir.Text = "&Exit App";
			mnuSalir.Click += mnuSalir_Click;
			// 
			// imageList2
			// 
			imageList2.ColorDepth = ColorDepth.Depth8Bit;
			imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
			imageList2.TransparentColor = System.Drawing.Color.Transparent;
			imageList2.Images.SetKeyName(0, "customization_16x16.png");
			imageList2.Images.SetKeyName(1, "font_16x16.png");
			imageList2.Images.SetKeyName(2, "forward_16x16.png");
			// 
			// listView1
			// 
			listView1.BackColor = System.Drawing.SystemColors.Window;
			listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
			listView1.Items.AddRange(new ListViewItem[] { listViewItem4, listViewItem5, listViewItem6 });
			listView1.LargeImageList = imageList1;
			listView1.Location = new System.Drawing.Point(340, 62);
			listView1.Name = "listView1";
			listView1.Size = new System.Drawing.Size(344, 97);
			listView1.TabIndex = 10;
			listView1.UseCompatibleStateImageBehavior = false;
			// 
			// imageList1
			// 
			imageList1.ColorDepth = ColorDepth.Depth32Bit;
			imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
			imageList1.TransparentColor = System.Drawing.Color.Transparent;
			imageList1.Images.SetKeyName(0, "add-circle.png");
			imageList1.Images.SetKeyName(1, "cancel.png");
			imageList1.Images.SetKeyName(2, "success-tick.png");
			// 
			// textBox2
			// 
			textBox2.Location = new System.Drawing.Point(196, 78);
			textBox2.Name = "textBox2";
			textBox2.Size = new System.Drawing.Size(121, 23);
			textBox2.TabIndex = 11;
			textBox2.Text = "1234567890";
			textBox2.TextAlign = HorizontalAlignment.Center;
			textBox2.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(372, 42);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(155, 15);
			label2.TabIndex = 13;
			label2.Text = "&ListView - Large Icons Mode";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(25, 275);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(84, 15);
			label3.TabIndex = 14;
			label3.Text = "DataGrid View:";
			// 
			// dataGridView1
			// 
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new System.Drawing.Point(27, 291);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new System.Drawing.Size(454, 166);
			dataGridView1.TabIndex = 16;
			// 
			// statusStrip1
			// 
			statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripDropDownButton2 });
			statusStrip1.Location = new System.Drawing.Point(0, 649);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Padding = new Padding(1, 0, 12, 0);
			statusStrip1.Size = new System.Drawing.Size(957, 22);
			statusStrip1.TabIndex = 18;
			statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
			toolStripStatusLabel1.Text = "Status";
			// 
			// toolStripDropDownButton2
			// 
			toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { test2ToolStripMenuItem, test1ToolStripMenuItem });
			toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			toolStripDropDownButton2.Name = "toolStripDropDownButton2";
			toolStripDropDownButton2.Size = new System.Drawing.Size(13, 20);
			toolStripDropDownButton2.Text = "toolStripDropDownButton2";
			// 
			// test2ToolStripMenuItem
			// 
			test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
			test2ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
			test2ToolStripMenuItem.Text = "Test 2";
			// 
			// test1ToolStripMenuItem
			// 
			test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
			test1ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
			test1ToolStripMenuItem.Text = "Test 1";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(textBox1);
			groupBox1.Controls.Add(comboBox2);
			groupBox1.Controls.Add(comboBox1);
			groupBox1.Controls.Add(numericUpDown1);
			groupBox1.Controls.Add(listBox1);
			groupBox1.Location = new System.Drawing.Point(10, 55);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(171, 207);
			groupBox1.TabIndex = 19;
			groupBox1.TabStop = false;
			groupBox1.Text = "Common Controls";
			// 
			// comboBox2
			// 
			comboBox2.FormattingEnabled = true;
			comboBox2.Location = new System.Drawing.Point(6, 76);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new System.Drawing.Size(152, 23);
			comboBox2.TabIndex = 30;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(196, 257);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(133, 30);
			label5.TabIndex = 20;
			label5.Text = "↑  Right Click on Nodes \r\n    for Context Menu.";
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Location = new System.Drawing.Point(10, 469);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new System.Drawing.Size(471, 127);
			tabControl1.TabIndex = 21;
			// 
			// tabPage1
			// 
			tabPage1.BackColor = System.Drawing.Color.Transparent;
			tabPage1.Location = new System.Drawing.Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Size = new System.Drawing.Size(463, 99);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "tabPage1";
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(textBox3);
			tabPage2.Controls.Add(linkLabel1);
			tabPage2.Controls.Add(label8);
			tabPage2.Controls.Add(label6);
			tabPage2.Location = new System.Drawing.Point(4, 24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new System.Drawing.Size(463, 99);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "tabPage2";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			textBox3.Location = new System.Drawing.Point(63, 20);
			textBox3.Name = "textBox3";
			textBox3.Size = new System.Drawing.Size(86, 23);
			textBox3.TabIndex = 6;
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Location = new System.Drawing.Point(107, 72);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new System.Drawing.Size(60, 15);
			linkLabel1.TabIndex = 5;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "linkLabel1";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Enabled = false;
			label8.Location = new System.Drawing.Point(18, 71);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(79, 15);
			label8.TabIndex = 4;
			label8.Text = "disabled &label";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(19, 54);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(77, 15);
			label6.TabIndex = 4;
			label6.Text = "enabled la&bel";
			// 
			// propertyGrid1
			// 
			propertyGrid1.Location = new System.Drawing.Point(491, 294);
			propertyGrid1.Name = "propertyGrid1";
			propertyGrid1.SelectedObject = dataGridView1;
			propertyGrid1.Size = new System.Drawing.Size(231, 298);
			propertyGrid1.TabIndex = 25;
			// 
			// notifyIcon1
			// 
			notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
			notifyIcon1.ContextMenuStrip = contextMenuStrip1;
			notifyIcon1.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon1.Icon");
			notifyIcon1.Text = "notifyIcon1";
			notifyIcon1.Visible = true;
			notifyIcon1.DoubleClick += notifyIcon1_DoubleClick;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(label10);
			groupBox2.Controls.Add(label9);
			groupBox2.Controls.Add(checkBox3);
			groupBox2.Controls.Add(radioButton3);
			groupBox2.Controls.Add(radioButton2);
			groupBox2.Controls.Add(label1);
			groupBox2.Controls.Add(label4);
			groupBox2.Controls.Add(checkBox2);
			groupBox2.Location = new System.Drawing.Point(340, 166);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new System.Drawing.Size(200, 117);
			groupBox2.TabIndex = 28;
			groupBox2.TabStop = false;
			groupBox2.Text = "GroupBox";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new System.Drawing.Point(106, 17);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(55, 15);
			label10.TabIndex = 6;
			label10.Text = "Disabled:";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new System.Drawing.Point(3, 16);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(52, 15);
			label9.TabIndex = 5;
			label9.Text = "Enabled:";
			// 
			// checkBox3
			// 
			checkBox3.AutoSize = true;
			checkBox3.Enabled = false;
			checkBox3.Location = new System.Drawing.Point(109, 43);
			checkBox3.Name = "checkBox3";
			checkBox3.Size = new System.Drawing.Size(78, 19);
			checkBox3.TabIndex = 4;
			checkBox3.Text = "CheckBox";
			checkBox3.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			radioButton3.AutoSize = true;
			radioButton3.Checked = true;
			radioButton3.Enabled = false;
			radioButton3.Location = new System.Drawing.Point(109, 66);
			radioButton3.Name = "radioButton3";
			radioButton3.Size = new System.Drawing.Size(91, 19);
			radioButton3.TabIndex = 3;
			radioButton3.TabStop = true;
			radioButton3.Text = "RadioButton";
			radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.Location = new System.Drawing.Point(6, 66);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new System.Drawing.Size(91, 19);
			radioButton2.TabIndex = 2;
			radioButton2.Text = "RadioButton";
			radioButton2.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Enabled = false;
			label1.Location = new System.Drawing.Point(106, 86);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(35, 15);
			label1.TabIndex = 1;
			label1.Text = "Label";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(3, 86);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(35, 15);
			label4.TabIndex = 1;
			label4.Text = "Label";
			// 
			// checkBox2
			// 
			checkBox2.AutoSize = true;
			checkBox2.Checked = true;
			checkBox2.CheckState = CheckState.Checked;
			checkBox2.Location = new System.Drawing.Point(6, 43);
			checkBox2.Name = "checkBox2";
			checkBox2.Size = new System.Drawing.Size(78, 19);
			checkBox2.TabIndex = 0;
			checkBox2.Text = "CheckBox";
			checkBox2.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			button7.Enabled = false;
			button7.Location = new System.Drawing.Point(577, 176);
			button7.Name = "button7";
			button7.Size = new System.Drawing.Size(75, 23);
			button7.TabIndex = 29;
			button7.Text = "button7";
			button7.UseVisualStyleBackColor = true;
			// 
			// listView2
			// 
			listView2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			listView2.Location = new System.Drawing.Point(690, 62);
			listView2.Name = "listView2";
			listView2.Size = new System.Drawing.Size(255, 226);
			listView2.TabIndex = 30;
			listView2.UseCompatibleStateImageBehavior = false;
			listView2.View = View.Details;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(746, 46);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(127, 15);
			label7.TabIndex = 31;
			label7.Text = "ListView -Details Mode";
			// 
			// groupBox3
			// 
			groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			groupBox3.Controls.Add(flatTabControl1);
			groupBox3.Controls.Add(label13);
			groupBox3.Controls.Add(label12);
			groupBox3.Controls.Add(flatComboBox1);
			groupBox3.Controls.Add(label11);
			groupBox3.Controls.Add(newProgressBar1);
			groupBox3.Location = new System.Drawing.Point(738, 321);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new System.Drawing.Size(207, 271);
			groupBox3.TabIndex = 32;
			groupBox3.TabStop = false;
			groupBox3.Text = "Custom Controls";
			// 
			// flatTabControl1
			// 
			flatTabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			flatTabControl1.Appearance = TabAppearance.Buttons;
			flatTabControl1.BorderColor = System.Drawing.SystemColors.ControlDark;
			flatTabControl1.Controls.Add(tabPage3);
			flatTabControl1.Controls.Add(tabPage4);
			flatTabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
			flatTabControl1.LineColor = System.Drawing.SystemColors.Highlight;
			flatTabControl1.Location = new System.Drawing.Point(7, 140);
			flatTabControl1.Name = "flatTabControl1";
			flatTabControl1.SelectedForeColor = System.Drawing.SystemColors.HighlightText;
			flatTabControl1.SelectedIndex = 0;
			flatTabControl1.SelectTabColor = System.Drawing.SystemColors.ControlLight;
			flatTabControl1.ShowTabCloseButton = true;
			flatTabControl1.Size = new System.Drawing.Size(194, 100);
			flatTabControl1.SizeMode = TabSizeMode.Fixed;
			flatTabControl1.TabCloseColor = System.Drawing.SystemColors.ControlText;
			flatTabControl1.TabColor = System.Drawing.SystemColors.ControlLight;
			flatTabControl1.TabIndex = 32;
			// 
			// tabPage3
			// 
			tabPage3.BackColor = System.Drawing.SystemColors.ControlLight;
			tabPage3.Location = new System.Drawing.Point(4, 28);
			tabPage3.Name = "tabPage3";
			tabPage3.Padding = new Padding(3);
			tabPage3.Size = new System.Drawing.Size(186, 68);
			tabPage3.TabIndex = 0;
			tabPage3.Text = "tabPage3";
			// 
			// tabPage4
			// 
			tabPage4.BackColor = System.Drawing.SystemColors.ControlLight;
			tabPage4.Location = new System.Drawing.Point(4, 28);
			tabPage4.Name = "tabPage4";
			tabPage4.Padding = new Padding(3);
			tabPage4.Size = new System.Drawing.Size(186, 68);
			tabPage4.TabIndex = 1;
			tabPage4.Text = "tabPage4";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new System.Drawing.Point(6, 123);
			label13.Name = "label13";
			label13.Size = new System.Drawing.Size(85, 15);
			label13.TabIndex = 31;
			label13.Text = "FlatTabControl";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new System.Drawing.Point(6, 69);
			label12.Name = "label12";
			label12.Size = new System.Drawing.Size(85, 15);
			label12.TabIndex = 30;
			label12.Text = "FlatComboBox";
			// 
			// flatComboBox1
			// 
			flatComboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			flatComboBox1.FormattingEnabled = true;
			flatComboBox1.Location = new System.Drawing.Point(6, 85);
			flatComboBox1.Name = "flatComboBox1";
			flatComboBox1.Size = new System.Drawing.Size(195, 23);
			flatComboBox1.TabIndex = 29;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new System.Drawing.Point(6, 16);
			label11.Name = "label11";
			label11.Size = new System.Drawing.Size(91, 15);
			label11.TabIndex = 28;
			label11.Text = "FlatProgressBar:";
			// 
			// newProgressBar1
			// 
			newProgressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			newProgressBar1.Location = new System.Drawing.Point(6, 32);
			newProgressBar1.Name = "newProgressBar1";
			newProgressBar1.ProgressBarColor = System.Drawing.Color.Green;
			newProgressBar1.Size = new System.Drawing.Size(195, 23);
			newProgressBar1.TabIndex = 27;
			newProgressBar1.Value = 65;
			// 
			// Form1
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			BackColor = System.Drawing.SystemColors.Control;
			ClientSize = new System.Drawing.Size(957, 671);
			Controls.Add(groupBox3);
			Controls.Add(label7);
			Controls.Add(listView2);
			Controls.Add(button7);
			Controls.Add(groupBox2);
			Controls.Add(propertyGrid1);
			Controls.Add(tabControl1);
			Controls.Add(label5);
			Controls.Add(groupBox1);
			Controls.Add(dataGridView1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(textBox2);
			Controls.Add(listView1);
			Controls.Add(treeView1);
			Controls.Add(toolStrip1);
			Controls.Add(panel1);
			Controls.Add(menuStrip1);
			Controls.Add(statusStrip1);
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuStrip1;
			Name = "Form1";
			Text = "DarkModeForms - Example Form";
			FormClosing += Form1_FormClosing;
			FormClosed += Form1_FormClosed;
			Load += Form1_Load;
			Resize += Form1_Resize;
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
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
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			flatTabControl1.ResumeLayout(false);
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
		private DataGridView dataGridView1;
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
		private Button button5;
		private TextBox textBox3;
		private LinkLabel linkLabel1;
		private Label label6;
		private Button button4;
		private PropertyGrid propertyGrid1;
		private ImageList imageList2;
		private FlatProgressBar newProgressBar1;
		private NotifyIcon notifyIcon1;
		private GroupBox groupBox2;
		private RadioButton radioButton3;
		private RadioButton radioButton2;
		private Label label4;
		private CheckBox checkBox2;
		private CheckBox checkBox3;
		private Button button7;
		private ToolStripSeparator toolStripMenuItem1;
		private ToolStripMenuItem mnuSalir;
		private ComboBox comboBox2;
		private ListView listView2;
		private Label label7;
		private Panel panel2;
		private RadioButton radioButtonSystem;
		private RadioButton radioButtonDark;
		private RadioButton radioButtonLight;
		private Label label8;
		private GroupBox groupBox3;
		private Label label1;
		private Label label10;
		private Label label9;
		private FlatTabControl flatTabControl1;
		private TabPage tabPage3;
		private TabPage tabPage4;
		private Label label13;
		private Label label12;
		private FlatComboBox flatComboBox1;
		private Label label11;
	}
}
