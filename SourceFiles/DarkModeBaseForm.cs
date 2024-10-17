using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DarkModeForms
{
	public class DarkModeBaseForm : Form
	{
		protected DarkModeCS dm;

		private const int WM_SETTINGSCHANGE = 0x001A;

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == WM_SETTINGSCHANGE)
			{
				var stringLParam = Marshal.PtrToStringAuto(m.LParam);
				if (!string.IsNullOrEmpty(stringLParam))
				{
					if (stringLParam == "ImmersiveColorSet")
					{
						if (null != dm)
						{
							int colorMode = DarkModeCS.GetWindowsColorMode();
							if (DarkModePolicy.FollowSystemTheme == dm.DarkModePolicy)
							{
								switch (colorMode)
								{
									case 0:
										dm.IsDarkMode = true;
										dm.forceProcessing = true;
										dm.ApplyTheme(true);
										dm.forceProcessing = false;
										break;
									case 1:
										dm.IsDarkMode = false;
										dm.forceProcessing = true;
										dm.ApplyTheme(false);
										dm.forceProcessing = false;
										break;
								}
							}
						}
					}
				}
			}

			base.WndProc(ref m);
		}
	}
}