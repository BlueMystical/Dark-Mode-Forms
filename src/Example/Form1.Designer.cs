using DarkModeForms;
using System.Windows.Forms;

namespace Example
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			ListViewItem listViewItem1 = new ListViewItem(new string[] { "AA", "xx" }, 0);
			ListViewItem listViewItem2 = new ListViewItem("BB", 2);
			ListViewItem listViewItem3 = new ListViewItem("CC", 1);
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
			toolStripProgressBar1 = new ToolStripProgressBar();
			toolStripDropDownButton3 = new ToolStripDropDownButton();
			toolStripMenuItem2 = new ToolStripMenuItem();
			toolStripComboBox1 = new ToolStripComboBox();
			toolStripSeparator2 = new ToolStripSeparator();
			toolStripTextBox1 = new ToolStripTextBox();
			toolStripSplitButton2 = new ToolStripSplitButton();
			toolStripMenuItem3 = new ToolStripMenuItem();
			toolStripComboBox2 = new ToolStripComboBox();
			toolStripSeparator3 = new ToolStripSeparator();
			toolStripTextBox2 = new ToolStripTextBox();
			groupBox1 = new GroupBox();
			comboBox2 = new ComboBox();
			label5 = new Label();
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			button8 = new Button();
			button6 = new Button();
			tabPage2 = new TabPage();
			textBox3 = new TextBox();
			linkLabel1 = new LinkLabel();
			label8 = new Label();
			label6 = new Label();
			propertyGrid1 = new PropertyGrid();
			label1 = new Label();
			notifyIcon1 = new NotifyIcon(components);
			groupBox2 = new GroupBox();
			checkBox3 = new CheckBox();
			radioButton3 = new RadioButton();
			radioButton2 = new RadioButton();
			label4 = new Label();
			checkBox2 = new CheckBox();
			btnNewForm = new Button();
			listView2 = new ListView();
			label7 = new Label();
			newProgressBar1 = new FlatProgressBar();
			flowLayoutPanel1 = new FlowLayoutPanel();
			btnColorDialog = new Button();
			btnFolderBrowserDialog1 = new Button();
			btnFontDialog = new Button();
			btnOpenFileDialog = new Button();
			btnSaveFileDialog = new Button();
			btnErrorProvider = new Button();
			label9 = new Label();
			checkedListBox1 = new CheckedListBox();
			colorDialog1 = new ColorDialog();
			dateTimePicker1 = new DateTimePicker();
			domainUpDown1 = new DomainUpDown();
			errorProvider1 = new ErrorProvider(components);
			folderBrowserDialog1 = new FolderBrowserDialog();
			fontDialog1 = new FontDialog();
			openFileDialog1 = new OpenFileDialog();
			saveFileDialog1 = new SaveFileDialog();
			monthCalendar1 = new MonthCalendar();
			toolTip1 = new ToolTip(components);
			linkIssueTableLayoutPanel = new LinkLabel();
			tableLayoutPanel1 = new TableLayoutPanel();
			splitter1 = new Splitter();
			richTextBox1 = new RichTextBox();
			button7 = new Button();
			pictureBox1 = new PictureBox();
			label10 = new Label();
			vScrollBar1 = new VScrollBar();
			hScrollBar1 = new HScrollBar();
			splitContainer1 = new SplitContainer();
			trackBar1 = new TrackBar();
			helpProvider1 = new HelpProvider();
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
			tabPage1.SuspendLayout();
			tabPage2.SuspendLayout();
			groupBox2.SuspendLayout();
			flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
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
			panel1.Location = new Point(0, 598);
			panel1.Name = "panel1";
			panel1.Size = new Size(1220, 47);
			panel1.TabIndex = 0;
			// 
			// panel2
			// 
			panel2.Controls.Add(radioButtonLight);
			panel2.Controls.Add(radioButtonDark);
			panel2.Controls.Add(radioButtonSystem);
			panel2.Location = new Point(394, 3);
			panel2.Margin = new Padding(2);
			panel2.Name = "panel2";
			panel2.Size = new Size(326, 40);
			panel2.TabIndex = 6;
			// 
			// radioButtonLight
			// 
			radioButtonLight.AutoSize = true;
			radioButtonLight.Location = new Point(206, 6);
			radioButtonLight.Margin = new Padding(2);
			radioButtonLight.Name = "radioButtonLight";
			radioButtonLight.Size = new Size(91, 19);
			radioButtonLight.TabIndex = 2;
			radioButtonLight.TabStop = true;
			radioButtonLight.Text = "Light Theme";
			radioButtonLight.UseVisualStyleBackColor = true;
			radioButtonLight.CheckedChanged += radioButtonSystem_CheckedChanged;
			// 
			// radioButtonDark
			// 
			radioButtonDark.AutoSize = true;
			radioButtonDark.Location = new Point(108, 7);
			radioButtonDark.Margin = new Padding(2);
			radioButtonDark.Name = "radioButtonDark";
			radioButtonDark.Size = new Size(88, 19);
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
			radioButtonSystem.Location = new Point(10, 7);
			radioButtonSystem.Margin = new Padding(2);
			radioButtonSystem.Name = "radioButtonSystem";
			radioButtonSystem.Size = new Size(101, 19);
			radioButtonSystem.TabIndex = 0;
			radioButtonSystem.TabStop = true;
			radioButtonSystem.Text = "Follow System";
			radioButtonSystem.UseVisualStyleBackColor = true;
			radioButtonSystem.CheckedChanged += radioButtonSystem_CheckedChanged;
			// 
			// button4
			// 
			button4.Location = new Point(324, 2);
			button4.Name = "button4";
			button4.Size = new Size(64, 42);
			button4.TabIndex = 5;
			button4.Text = "Password Input";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button5
			// 
			button5.Location = new Point(189, 2);
			button5.Name = "button5";
			button5.Size = new Size(64, 42);
			button5.TabIndex = 4;
			button5.Text = "Custom MsgBox";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// button3
			// 
			button3.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
			button3.FlatStyle = FlatStyle.System;
			button3.Location = new Point(258, 2);
			button3.Name = "button3";
			button3.Size = new Size(64, 42);
			button3.TabIndex = 3;
			button3.Text = "Custom InputBox";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button1
			// 
			button1.Location = new Point(13, 10);
			button1.Name = "button1";
			button1.Size = new Size(86, 23);
			button1.TabIndex = 2;
			button1.Text = "CreateControl";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(106, 10);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 1;
			button2.Text = "MsgBox";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// toolStrip1
			// 
			toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
			toolStrip1.ImageScalingSize = new Size(20, 20);
			toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton3, toolStripButton2, toolStripSplitButton1, toolStripDropDownButton1 });
			toolStrip1.Location = new Point(0, 24);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(1220, 27);
			toolStrip1.TabIndex = 0;
			toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButton1.Image = Properties.Resources.forward_16x16;
			toolStripButton1.ImageTransparentColor = Color.Magenta;
			toolStripButton1.Name = "toolStripButton1";
			toolStripButton1.Size = new Size(24, 24);
			toolStripButton1.Text = "toolStripButton1";
			// 
			// toolStripButton3
			// 
			toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButton3.Image = Properties.Resources.all_borders_16x16;
			toolStripButton3.ImageTransparentColor = Color.Magenta;
			toolStripButton3.Name = "toolStripButton3";
			toolStripButton3.Size = new Size(24, 24);
			toolStripButton3.Text = "toolStripButton3";
			// 
			// toolStripButton2
			// 
			toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButton2.Image = Properties.Resources.customization_16x16;
			toolStripButton2.ImageTransparentColor = Color.Magenta;
			toolStripButton2.Name = "toolStripButton2";
			toolStripButton2.Size = new Size(24, 24);
			toolStripButton2.Text = "toolStripButton2";
			// 
			// toolStripSplitButton1
			// 
			toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { asssToolStripMenuItem, jhgjhgToolStripMenuItem });
			toolStripSplitButton1.Image = Properties.Resources.forward_16x16;
			toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
			toolStripSplitButton1.Name = "toolStripSplitButton1";
			toolStripSplitButton1.Size = new Size(95, 24);
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
			toolStripDropDownButton1.Size = new Size(33, 24);
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
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { assToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new Padding(5, 2, 0, 2);
			menuStrip1.Size = new Size(1220, 24);
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
			// textBox1
			// 
			textBox1.Location = new Point(6, 22);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(152, 23);
			textBox1.TabIndex = 3;
			textBox1.Text = "ASDFG";
			// 
			// comboBox1
			// 
			comboBox1.Enabled = false;
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" });
			comboBox1.Location = new Point(6, 49);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(152, 23);
			comboBox1.TabIndex = 4;
			comboBox1.Text = "8";
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(6, 103);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(152, 23);
			numericUpDown1.TabIndex = 5;
			// 
			// listBox1
			// 
			listBox1.Enabled = false;
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" });
			listBox1.Location = new Point(5, 128);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(152, 49);
			listBox1.TabIndex = 6;
			// 
			// treeView1
			// 
			treeView1.ContextMenuStrip = contextMenuStrip1;
			treeView1.HideSelection = false;
			treeView1.ImageIndex = 0;
			treeView1.ImageList = imageList2;
			treeView1.Location = new Point(196, 104);
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
			treeView1.Size = new Size(121, 151);
			treeView1.TabIndex = 9;
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.BackColor = SystemColors.Control;
			contextMenuStrip1.ImageScalingSize = new Size(20, 20);
			contextMenuStrip1.Items.AddRange(new ToolStripItem[] { contex01ToolStripMenuItem, contex02ToolStripMenuItem, context03ToolStripMenuItem, toolStripMenuItem1, mnuSalir });
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(132, 98);
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
			// toolStripMenuItem1
			// 
			toolStripMenuItem1.Name = "toolStripMenuItem1";
			toolStripMenuItem1.Size = new Size(128, 6);
			// 
			// mnuSalir
			// 
			mnuSalir.Name = "mnuSalir";
			mnuSalir.Size = new Size(131, 22);
			mnuSalir.Text = "&Exit App";
			mnuSalir.Click += mnuSalir_Click;
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
			// listView1
			// 
			listView1.BackColor = SystemColors.Window;
			listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
			listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
			listView1.LargeImageList = imageList1;
			listView1.Location = new Point(340, 62);
			listView1.Name = "listView1";
			listView1.Size = new Size(358, 97);
			listView1.TabIndex = 10;
			toolTip1.SetToolTip(listView1, "This is tooltip");
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
			textBox2.Location = new Point(196, 78);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(121, 23);
			textBox2.TabIndex = 11;
			textBox2.Text = "1234567890";
			textBox2.TextAlign = HorizontalAlignment.Center;
			textBox2.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(372, 42);
			label2.Name = "label2";
			label2.Size = new Size(155, 15);
			label2.TabIndex = 13;
			label2.Text = "&ListView - Large Icons Mode";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(25, 275);
			label3.Name = "label3";
			label3.Size = new Size(84, 15);
			label3.TabIndex = 14;
			label3.Text = "DataGrid View:";
			// 
			// dataGridView1
			// 
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = SystemColors.Control;
			dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = Color.Red;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(27, 291);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(454, 166);
			dataGridView1.TabIndex = 16;
			// 
			// statusStrip1
			// 
			statusStrip1.ImageScalingSize = new Size(20, 20);
			statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripDropDownButton2, toolStripProgressBar1, toolStripDropDownButton3, toolStripSplitButton2 });
			statusStrip1.Location = new Point(0, 645);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Padding = new Padding(1, 0, 12, 0);
			statusStrip1.Size = new Size(1220, 26);
			statusStrip1.TabIndex = 18;
			statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			toolStripStatusLabel1.Size = new Size(39, 21);
			toolStripStatusLabel1.Text = "Status";
			// 
			// toolStripDropDownButton2
			// 
			toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { test2ToolStripMenuItem, test1ToolStripMenuItem });
			toolStripDropDownButton2.Image = Properties.Resources.all_borders_16x16;
			toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
			toolStripDropDownButton2.Name = "toolStripDropDownButton2";
			toolStripDropDownButton2.Size = new Size(33, 24);
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
			// toolStripProgressBar1
			// 
			toolStripProgressBar1.Name = "toolStripProgressBar1";
			toolStripProgressBar1.Size = new Size(100, 20);
			toolStripProgressBar1.Value = 40;
			// 
			// toolStripDropDownButton3
			// 
			toolStripDropDownButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripDropDownButton3.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripComboBox1, toolStripSeparator2, toolStripTextBox1 });
			toolStripDropDownButton3.Image = (Image)resources.GetObject("toolStripDropDownButton3.Image");
			toolStripDropDownButton3.ImageTransparentColor = Color.Magenta;
			toolStripDropDownButton3.Name = "toolStripDropDownButton3";
			toolStripDropDownButton3.Size = new Size(33, 24);
			toolStripDropDownButton3.Text = "toolStripDropDownButton3";
			// 
			// toolStripMenuItem2
			// 
			toolStripMenuItem2.Name = "toolStripMenuItem2";
			toolStripMenuItem2.Size = new Size(181, 22);
			toolStripMenuItem2.Text = "toolStripMenuItem2";
			// 
			// toolStripComboBox1
			// 
			toolStripComboBox1.Name = "toolStripComboBox1";
			toolStripComboBox1.Size = new Size(121, 23);
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(178, 6);
			// 
			// toolStripTextBox1
			// 
			toolStripTextBox1.Name = "toolStripTextBox1";
			toolStripTextBox1.Size = new Size(100, 23);
			// 
			// toolStripSplitButton2
			// 
			toolStripSplitButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripSplitButton2.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripComboBox2, toolStripSeparator3, toolStripTextBox2 });
			toolStripSplitButton2.Image = (Image)resources.GetObject("toolStripSplitButton2.Image");
			toolStripSplitButton2.ImageTransparentColor = Color.Magenta;
			toolStripSplitButton2.Name = "toolStripSplitButton2";
			toolStripSplitButton2.Size = new Size(36, 24);
			toolStripSplitButton2.Text = "toolStripSplitButton2";
			// 
			// toolStripMenuItem3
			// 
			toolStripMenuItem3.Name = "toolStripMenuItem3";
			toolStripMenuItem3.Size = new Size(181, 22);
			toolStripMenuItem3.Text = "toolStripMenuItem3";
			// 
			// toolStripComboBox2
			// 
			toolStripComboBox2.Name = "toolStripComboBox2";
			toolStripComboBox2.Size = new Size(121, 23);
			// 
			// toolStripSeparator3
			// 
			toolStripSeparator3.Name = "toolStripSeparator3";
			toolStripSeparator3.Size = new Size(178, 6);
			// 
			// toolStripTextBox2
			// 
			toolStripTextBox2.Name = "toolStripTextBox2";
			toolStripTextBox2.Size = new Size(100, 23);
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(textBox1);
			groupBox1.Controls.Add(comboBox2);
			groupBox1.Controls.Add(comboBox1);
			groupBox1.Controls.Add(numericUpDown1);
			groupBox1.Controls.Add(listBox1);
			groupBox1.Location = new Point(10, 55);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(171, 207);
			groupBox1.TabIndex = 19;
			groupBox1.TabStop = false;
			groupBox1.Text = "Common Controls";
			// 
			// comboBox2
			// 
			comboBox2.FormattingEnabled = true;
			comboBox2.Location = new Point(6, 76);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(152, 23);
			comboBox2.TabIndex = 30;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(196, 257);
			label5.Name = "label5";
			label5.Size = new Size(133, 30);
			label5.TabIndex = 20;
			label5.Text = "↑  Right Click on Nodes \r\n    for Context Menu.";
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Location = new Point(10, 469);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(296, 127);
			tabControl1.TabIndex = 21;
			// 
			// tabPage1
			// 
			tabPage1.BackColor = Color.Transparent;
			tabPage1.Controls.Add(button8);
			tabPage1.Controls.Add(button6);
			tabPage1.Location = new Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Size = new Size(288, 99);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "tabPage1";
			// 
			// button8
			// 
			button8.BackColor = Color.SandyBrown;
			button8.Enabled = false;
			button8.FlatStyle = FlatStyle.Flat;
			button8.Location = new Point(95, 25);
			button8.Name = "button8";
			button8.Size = new Size(75, 23);
			button8.TabIndex = 33;
			button8.Text = "Excluded Btn";
			button8.UseVisualStyleBackColor = false;
			button8.Click += button8_Click;
			// 
			// button6
			// 
			button6.BackColor = Color.SandyBrown;
			button6.FlatStyle = FlatStyle.Flat;
			button6.ForeColor = Color.Black;
			button6.Location = new Point(14, 25);
			button6.Name = "button6";
			button6.Size = new Size(75, 23);
			button6.TabIndex = 32;
			button6.Text = "Excluded Btn";
			button6.UseVisualStyleBackColor = false;
			button6.Click += button6_Click;
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(textBox3);
			tabPage2.Controls.Add(linkLabel1);
			tabPage2.Controls.Add(label8);
			tabPage2.Controls.Add(label6);
			tabPage2.Location = new Point(4, 24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(288, 99);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "tabPage2";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(63, 20);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(86, 23);
			textBox3.TabIndex = 6;
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Location = new Point(107, 72);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(60, 15);
			linkLabel1.TabIndex = 5;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "linkLabel1";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Enabled = false;
			label8.Location = new Point(18, 71);
			label8.Name = "label8";
			label8.Size = new Size(79, 15);
			label8.TabIndex = 4;
			label8.Text = "disabled &label";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(19, 54);
			label6.Name = "label6";
			label6.Size = new Size(77, 15);
			label6.TabIndex = 4;
			label6.Text = "enabled la&bel";
			// 
			// propertyGrid1
			// 
			propertyGrid1.Location = new Point(491, 294);
			propertyGrid1.Name = "propertyGrid1";
			propertyGrid1.SelectedObject = dataGridView1;
			propertyGrid1.Size = new Size(207, 298);
			propertyGrid1.TabIndex = 25;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(206, 62);
			label1.Name = "label1";
			label1.Size = new Size(100, 15);
			label1.TabIndex = 2;
			label1.Text = "&Custom Controls:";
			// 
			// notifyIcon1
			// 
			notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
			notifyIcon1.ContextMenuStrip = contextMenuStrip1;
			notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
			notifyIcon1.Text = "notifyIcon1";
			notifyIcon1.Visible = true;
			notifyIcon1.DoubleClick += notifyIcon1_DoubleClick;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(checkBox3);
			groupBox2.Controls.Add(radioButton3);
			groupBox2.Controls.Add(radioButton2);
			groupBox2.Controls.Add(label4);
			groupBox2.Controls.Add(checkBox2);
			groupBox2.Location = new Point(340, 166);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(200, 89);
			groupBox2.TabIndex = 28;
			groupBox2.TabStop = false;
			groupBox2.Text = "groupBox2";
			// 
			// checkBox3
			// 
			checkBox3.AutoSize = true;
			checkBox3.Enabled = false;
			checkBox3.Location = new Point(114, 43);
			checkBox3.Name = "checkBox3";
			checkBox3.Size = new Size(83, 19);
			checkBox3.TabIndex = 4;
			checkBox3.Text = "checkBox3";
			checkBox3.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			radioButton3.AutoSize = true;
			radioButton3.Checked = true;
			radioButton3.Enabled = false;
			radioButton3.Location = new Point(17, 68);
			radioButton3.Name = "radioButton3";
			radioButton3.Size = new Size(94, 19);
			radioButton3.TabIndex = 3;
			radioButton3.TabStop = true;
			radioButton3.Text = "radioButton3";
			radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.Location = new Point(17, 43);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(94, 19);
			radioButton2.TabIndex = 2;
			radioButton2.Text = "radioButton2";
			radioButton2.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(138, 21);
			label4.Name = "label4";
			label4.Size = new Size(38, 15);
			label4.TabIndex = 1;
			label4.Text = "label4";
			// 
			// checkBox2
			// 
			checkBox2.AutoSize = true;
			checkBox2.Checked = true;
			checkBox2.CheckState = CheckState.Checked;
			checkBox2.Location = new Point(17, 20);
			checkBox2.Name = "checkBox2";
			checkBox2.Size = new Size(83, 19);
			checkBox2.TabIndex = 0;
			checkBox2.Text = "checkBox2";
			checkBox2.UseVisualStyleBackColor = true;
			// 
			// btnNewForm
			// 
			btnNewForm.Enabled = false;
			btnNewForm.Location = new Point(543, 166);
			btnNewForm.Name = "btnNewForm";
			btnNewForm.Size = new Size(113, 23);
			btnNewForm.TabIndex = 29;
			btnNewForm.Text = "disable Button";
			btnNewForm.UseVisualStyleBackColor = true;
			// 
			// listView2
			// 
			listView2.Location = new Point(709, 54);
			listView2.Name = "listView2";
			listView2.Size = new Size(197, 170);
			listView2.TabIndex = 30;
			listView2.UseCompatibleStateImageBehavior = false;
			listView2.View = View.Details;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(746, 46);
			label7.Name = "label7";
			label7.Size = new Size(127, 15);
			label7.TabIndex = 31;
			label7.Text = "ListView -Details Mode";
			// 
			// newProgressBar1
			// 
			newProgressBar1.Location = new Point(340, 262);
			newProgressBar1.Name = "newProgressBar1";
			newProgressBar1.ProgressBarColor = Color.Green;
			newProgressBar1.Size = new Size(358, 23);
			newProgressBar1.TabIndex = 27;
			newProgressBar1.Value = 65;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Controls.Add(btnColorDialog);
			flowLayoutPanel1.Controls.Add(btnFolderBrowserDialog1);
			flowLayoutPanel1.Controls.Add(btnFontDialog);
			flowLayoutPanel1.Controls.Add(btnOpenFileDialog);
			flowLayoutPanel1.Controls.Add(btnSaveFileDialog);
			flowLayoutPanel1.Controls.Add(btnErrorProvider);
			flowLayoutPanel1.Location = new Point(704, 322);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(200, 212);
			flowLayoutPanel1.TabIndex = 32;
			// 
			// btnColorDialog
			// 
			btnColorDialog.Location = new Point(3, 3);
			btnColorDialog.Name = "btnColorDialog";
			btnColorDialog.Size = new Size(110, 32);
			btnColorDialog.TabIndex = 0;
			btnColorDialog.Text = "ColorDialog";
			btnColorDialog.UseVisualStyleBackColor = true;
			btnColorDialog.Click += btnColorDialog_Click;
			// 
			// btnFolderBrowserDialog1
			// 
			btnFolderBrowserDialog1.Location = new Point(3, 41);
			btnFolderBrowserDialog1.Name = "btnFolderBrowserDialog1";
			btnFolderBrowserDialog1.Size = new Size(146, 32);
			btnFolderBrowserDialog1.TabIndex = 1;
			btnFolderBrowserDialog1.Text = "FolderBrowserDialog";
			btnFolderBrowserDialog1.UseVisualStyleBackColor = true;
			btnFolderBrowserDialog1.Click += btnFolderBrowserDialog1_Click;
			// 
			// btnFontDialog
			// 
			btnFontDialog.Location = new Point(3, 79);
			btnFontDialog.Name = "btnFontDialog";
			btnFontDialog.Size = new Size(110, 32);
			btnFontDialog.TabIndex = 3;
			btnFontDialog.Text = "FontDialog";
			btnFontDialog.UseVisualStyleBackColor = true;
			btnFontDialog.Click += btnFontDialog_Click;
			// 
			// btnOpenFileDialog
			// 
			btnOpenFileDialog.Location = new Point(3, 117);
			btnOpenFileDialog.Name = "btnOpenFileDialog";
			btnOpenFileDialog.Size = new Size(110, 32);
			btnOpenFileDialog.TabIndex = 4;
			btnOpenFileDialog.Text = "OpenFileDialog";
			btnOpenFileDialog.UseVisualStyleBackColor = true;
			btnOpenFileDialog.Click += btnOpenFileDialog_Click;
			// 
			// btnSaveFileDialog
			// 
			btnSaveFileDialog.Location = new Point(3, 155);
			btnSaveFileDialog.Name = "btnSaveFileDialog";
			btnSaveFileDialog.Size = new Size(110, 32);
			btnSaveFileDialog.TabIndex = 5;
			btnSaveFileDialog.Text = "SaveFileDialog";
			btnSaveFileDialog.UseVisualStyleBackColor = true;
			btnSaveFileDialog.Click += btnSaveFileDialog_Click;
			// 
			// btnErrorProvider
			// 
			btnErrorProvider.Location = new Point(3, 193);
			btnErrorProvider.Name = "btnErrorProvider";
			btnErrorProvider.Size = new Size(110, 32);
			btnErrorProvider.TabIndex = 2;
			btnErrorProvider.Text = "ErrorProvider";
			btnErrorProvider.UseVisualStyleBackColor = true;
			btnErrorProvider.Click += btnErrorProvider_Click;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(704, 304);
			label9.Name = "label9";
			label9.Size = new Size(202, 15);
			label9.TabIndex = 33;
			label9.Text = "FlowLayoutPanel (Missing Scroolbar)";
			// 
			// checkedListBox1
			// 
			checkedListBox1.FormattingEnabled = true;
			checkedListBox1.Items.AddRange(new object[] { "item 1", "item 2", "item 3", "item 4" });
			checkedListBox1.Location = new Point(324, 480);
			checkedListBox1.Name = "checkedListBox1";
			checkedListBox1.Size = new Size(161, 58);
			checkedListBox1.TabIndex = 34;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(913, 230);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(227, 23);
			dateTimePicker1.TabIndex = 35;
			// 
			// domainUpDown1
			// 
			domainUpDown1.Location = new Point(546, 230);
			domainUpDown1.Name = "domainUpDown1";
			domainUpDown1.Size = new Size(120, 23);
			domainUpDown1.TabIndex = 36;
			domainUpDown1.Text = "domainUpDown1";
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			// 
			// monthCalendar1
			// 
			monthCalendar1.Location = new Point(913, 62);
			monthCalendar1.Name = "monthCalendar1";
			monthCalendar1.TabIndex = 37;
			// 
			// linkIssueTableLayoutPanel
			// 
			linkIssueTableLayoutPanel.AutoSize = true;
			linkIssueTableLayoutPanel.Dock = DockStyle.Fill;
			helpProvider1.SetHelpString(linkIssueTableLayoutPanel, "Helpe me");
			linkIssueTableLayoutPanel.Location = new Point(6, 3);
			linkIssueTableLayoutPanel.Name = "linkIssueTableLayoutPanel";
			helpProvider1.SetShowHelp(linkIssueTableLayoutPanel, true);
			linkIssueTableLayoutPanel.Size = new Size(117, 52);
			linkIssueTableLayoutPanel.TabIndex = 1;
			linkIssueTableLayoutPanel.TabStop = true;
			linkIssueTableLayoutPanel.Text = "Issue TableLayoutPanel";
			toolTip1.SetToolTip(linkIssueTableLayoutPanel, "https://github.com/BlueMystical/Dark-Mode-Forms/issues/112");
			linkIssueTableLayoutPanel.LinkClicked += linkIssueTableLayoutPanel_LinkClicked;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial;
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(linkIssueTableLayoutPanel, 0, 0);
			tableLayoutPanel1.Controls.Add(splitter1, 1, 1);
			tableLayoutPanel1.Location = new Point(913, 294);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Size = new Size(255, 113);
			tableLayoutPanel1.TabIndex = 39;
			toolTip1.SetToolTip(tableLayoutPanel1, "https://github.com/BlueMystical/Dark-Mode-Forms/issues/112");
			// 
			// splitter1
			// 
			splitter1.Location = new Point(132, 61);
			splitter1.Name = "splitter1";
			splitter1.Size = new Size(40, 46);
			splitter1.TabIndex = 2;
			splitter1.TabStop = false;
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new Point(707, 230);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(200, 71);
			richTextBox1.TabIndex = 38;
			richTextBox1.Text = "Rich text box";
			// 
			// button7
			// 
			button7.Location = new Point(543, 195);
			button7.Name = "button7";
			button7.Size = new Size(113, 23);
			button7.TabIndex = 29;
			button7.Text = "Open New Form";
			button7.UseVisualStyleBackColor = true;
			button7.Click += btnNewForm_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.BorderStyle = BorderStyle.FixedSingle;
			pictureBox1.Location = new Point(1053, 439);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(112, 82);
			pictureBox1.TabIndex = 40;
			pictureBox1.TabStop = false;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(1053, 421);
			label10.Name = "label10";
			label10.Size = new Size(64, 15);
			label10.TabIndex = 41;
			label10.Text = "pictureBox";
			// 
			// vScrollBar1
			// 
			vScrollBar1.Location = new Point(1151, 66);
			vScrollBar1.Name = "vScrollBar1";
			vScrollBar1.Size = new Size(17, 152);
			vScrollBar1.TabIndex = 42;
			// 
			// hScrollBar1
			// 
			hScrollBar1.Location = new Point(913, 268);
			hScrollBar1.Name = "hScrollBar1";
			hScrollBar1.Size = new Size(227, 17);
			hScrollBar1.TabIndex = 43;
			// 
			// splitContainer1
			// 
			splitContainer1.BorderStyle = BorderStyle.FixedSingle;
			splitContainer1.Location = new Point(913, 421);
			splitContainer1.Name = "splitContainer1";
			splitContainer1.Size = new Size(134, 100);
			splitContainer1.SplitterDistance = 44;
			splitContainer1.TabIndex = 44;
			// 
			// trackBar1
			// 
			trackBar1.Location = new Point(707, 547);
			trackBar1.Name = "trackBar1";
			trackBar1.Size = new Size(197, 45);
			trackBar1.TabIndex = 45;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			BackColor = SystemColors.Control;
			ClientSize = new Size(1220, 671);
			Controls.Add(trackBar1);
			Controls.Add(splitContainer1);
			Controls.Add(hScrollBar1);
			Controls.Add(vScrollBar1);
			Controls.Add(label10);
			Controls.Add(pictureBox1);
			Controls.Add(tableLayoutPanel1);
			Controls.Add(richTextBox1);
			Controls.Add(monthCalendar1);
			Controls.Add(domainUpDown1);
			Controls.Add(dateTimePicker1);
			Controls.Add(checkedListBox1);
			Controls.Add(label9);
			Controls.Add(flowLayoutPanel1);
			Controls.Add(label7);
			Controls.Add(listView2);
			Controls.Add(button7);
			Controls.Add(btnNewForm);
			Controls.Add(groupBox2);
			Controls.Add(newProgressBar1);
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
			Controls.Add(label1);
			Controls.Add(toolStrip1);
			Controls.Add(panel1);
			Controls.Add(menuStrip1);
			Controls.Add(statusStrip1);
			Icon = (Icon)resources.GetObject("$this.Icon");
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
			tabPage1.ResumeLayout(false);
			tabPage2.ResumeLayout(false);
			tabPage2.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			flowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
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
		private Label label1;
		private NotifyIcon notifyIcon1;
		private GroupBox groupBox2;
		private RadioButton radioButton3;
		private RadioButton radioButton2;
		private Label label4;
		private CheckBox checkBox2;
		private CheckBox checkBox3;
		private Button btnNewForm;
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
		private Button button6;
		private Button button8;
		private FlowLayoutPanel flowLayoutPanel1;
		private Button btnColorDialog;
		private Label label9;
		private CheckedListBox checkedListBox1;
		private ColorDialog colorDialog1;
		private Button btnFolderBrowserDialog1;
		private DateTimePicker dateTimePicker1;
		private Button btnErrorProvider;
		private DomainUpDown domainUpDown1;
		private ErrorProvider errorProvider1;
		private FolderBrowserDialog folderBrowserDialog1;
		private FontDialog fontDialog1;
		private Button btnFontDialog;
		private Button btnOpenFileDialog;
		private Button btnSaveFileDialog;
		private OpenFileDialog openFileDialog1;
		private SaveFileDialog saveFileDialog1;
		private MonthCalendar monthCalendar1;
		private ToolTip toolTip1;
		private ToolStripProgressBar toolStripProgressBar1;
		private ToolStripDropDownButton toolStripDropDownButton3;
		private ToolStripMenuItem toolStripMenuItem2;
		private ToolStripComboBox toolStripComboBox1;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripTextBox toolStripTextBox1;
		private ToolStripSplitButton toolStripSplitButton2;
		private ToolStripMenuItem toolStripMenuItem3;
		private ToolStripComboBox toolStripComboBox2;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripTextBox toolStripTextBox2;
		private TableLayoutPanel tableLayoutPanel1;
		private RichTextBox richTextBox1;
		private LinkLabel linkIssueTableLayoutPanel;
		private Button button7;
		private HScrollBar hScrollBar1;
		private VScrollBar vScrollBar1;
		private Label label10;
		private PictureBox pictureBox1;
		private TrackBar trackBar1;
		private SplitContainer splitContainer1;
		private Splitter splitter1;
		private HelpProvider helpProvider1;
	}
}
