using System;
using System.Windows.Forms;

namespace DarkModeCoreTestApp;

internal static class Program
{
	/// <summary>
	/// Punto de entrada principal para la aplicación.
	/// </summary>
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run(new Form1());
	}
}