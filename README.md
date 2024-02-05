# Dark-Mode-Forms
Apply Dark Mode to all Controls in a Form [WinForms]

![Preview](Screenshots/DarkModeForms_01.png)

Just 2 Lines to implement it:

	public partial class Form1 : Form
	{
		DarkModeCS DM = null;
    ....
  		public Form1()
		{
			InitializeComponent();
			DM = new DarkModeCS(this);
		}
