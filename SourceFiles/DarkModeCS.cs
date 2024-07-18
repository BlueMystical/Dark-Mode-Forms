﻿using Microsoft.Win32;
using System.Drawing;
using System;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;

namespace DarkModeForms
{
	/// <summary>This tries to automatically apply Windows Dark Mode (if enabled) to a Form.
	/// <para>Author: BlueMystic (bluemystic.play@gmail.com)  2024</para></summary>
	public class DarkModeCS
	{
		#region Win32 API Declarations

		public struct DWMCOLORIZATIONcolors
		{
			public uint ColorizationColor,
				ColorizationAfterglow,
				ColorizationColorBalance,
				ColorizationAfterglowBalance,
				ColorizationBlurBalance,
				ColorizationGlassReflectionIntensity,
				ColorizationOpaqueBlend;
		}

		[Flags]
		public enum DWMWINDOWATTRIBUTE : uint
		{
			/// <summary>
			/// Use with DwmGetWindowAttribute. Discovers whether non-client rendering is enabled. The retrieved value is of type BOOL. TRUE if non-client rendering is enabled; otherwise, FALSE.
			/// </summary>
			DWMWA_NCRENDERING_ENABLED = 1,

			/// <summary>
			/// Use with DwmSetWindowAttribute. Sets the non-client rendering policy. The pvAttribute parameter points to a value from the DWMNCRENDERINGPOLICY enumeration.
			/// </summary>
			DWMWA_NCRENDERING_POLICY,

			/// <summary>
			/// Use with DwmSetWindowAttribute. Enables or forcibly disables DWM transitions. The pvAttribute parameter points to a value of type BOOL. TRUE to disable transitions, or FALSE to enable transitions.
			/// </summary>
			DWMWA_TRANSITIONS_FORCEDISABLED,

			/// <summary>
			/// Use with DwmSetWindowAttribute. Enables content rendered in the non-client area to be visible on the frame drawn by DWM. The pvAttribute parameter points to a value of type BOOL. TRUE to enable content rendered in the non-client area to be visible on the frame; otherwise, FALSE.
			/// </summary>
			DWMWA_ALLOW_NCPAINT,

			/// <summary>
			/// Use with DwmGetWindowAttribute. Retrieves the bounds of the caption button area in the window-relative space. The retrieved value is of type RECT. If the window is minimized or otherwise not visible to the user, then the value of the RECT retrieved is undefined. You should check whether the retrieved RECT contains a boundary that you can work with, and if it doesn't then you can conclude that the window is minimized or otherwise not visible.
			/// </summary>
			DWMWA_CAPTION_BUTTON_BOUNDS,

			/// <summary>
			/// Use with DwmSetWindowAttribute. Specifies whether non-client content is right-to-left (RTL) mirrored. The pvAttribute parameter points to a value of type BOOL. TRUE if the non-client content is right-to-left (RTL) mirrored; otherwise, FALSE.
			/// </summary>
			DWMWA_NONCLIENT_RTL_LAYOUT,

			/// <summary>
			/// Use with DwmSetWindowAttribute. Forces the window to display an iconic thumbnail or peek representation (a static bitmap), even if a live or snapshot representation of the window is available. This value is normally set during a window's creation, and not changed throughout the window's lifetime. Some scenarios, however, might require the value to change over time. The pvAttribute parameter points to a value of type BOOL. TRUE to require a iconic thumbnail or peek representation; otherwise, FALSE.
			/// </summary>
			DWMWA_FORCE_ICONIC_REPRESENTATION,

			/// <summary>
			/// Use with DwmSetWindowAttribute. Sets how Flip3D treats the window. The pvAttribute parameter points to a value from the DWMFLIP3DWINDOWPOLICY enumeration.
			/// </summary>
			DWMWA_FLIP3D_POLICY,

			/// <summary>
			/// Use with DwmGetWindowAttribute. Retrieves the extended frame bounds rectangle in screen space. The retrieved value is of type RECT.
			/// </summary>
			DWMWA_EXTENDED_FRAME_BOUNDS,

			/// <summary>
			/// Use with DwmSetWindowAttribute. The window will provide a bitmap for use by DWM as an iconic thumbnail or peek representation (a static bitmap) for the window. DWMWA_HAS_ICONIC_BITMAP can be specified with DWMWA_FORCE_ICONIC_REPRESENTATION. DWMWA_HAS_ICONIC_BITMAP normally is set during a window's creation and not changed throughout the window's lifetime. Some scenarios, however, might require the value to change over time. The pvAttribute parameter points to a value of type BOOL. TRUE to inform DWM that the window will provide an iconic thumbnail or peek representation; otherwise, FALSE. Windows Vista and earlier: This value is not supported.
			/// </summary>
			DWMWA_HAS_ICONIC_BITMAP,

			/// <summary>
			/// Use with DwmSetWindowAttribute. Do not show peek preview for the window. The peek view shows a full-sized preview of the window when the mouse hovers over the window's thumbnail in the taskbar. If this attribute is set, hovering the mouse pointer over the window's thumbnail dismisses peek (in case another window in the group has a peek preview showing). The pvAttribute parameter points to a value of type BOOL. TRUE to prevent peek functionality, or FALSE to allow it. Windows Vista and earlier: This value is not supported.
			/// </summary>
			DWMWA_DISALLOW_PEEK,

			/// <summary>
			/// Use with DwmSetWindowAttribute. Prevents a window from fading to a glass sheet when peek is invoked. The pvAttribute parameter points to a value of type BOOL. TRUE to prevent the window from fading during another window's peek, or FALSE for normal behavior. Windows Vista and earlier: This value is not supported.
			/// </summary>
			DWMWA_EXCLUDED_FROM_PEEK,

			/// <summary>
			/// Use with DwmSetWindowAttribute. Cloaks the window such that it is not visible to the user. The window is still composed by DWM. Using with DirectComposition: Use the DWMWA_CLOAK flag to cloak the layered child window when animating a representation of the window's content via a DirectComposition visual that has been associated with the layered child window. For more details on this usage case, see How to animate the bitmap of a layered child window. Windows 7 and earlier: This value is not supported.
			/// </summary>
			DWMWA_CLOAK,

			/// <summary>
			/// Use with DwmGetWindowAttribute. If the window is cloaked, provides one of the following values explaining why. DWM_CLOAKED_APP (value 0x0000001). The window was cloaked by its owner application. DWM_CLOAKED_SHELL(value 0x0000002). The window was cloaked by the Shell. DWM_CLOAKED_INHERITED(value 0x0000004). The cloak value was inherited from its owner window. Windows 7 and earlier: This value is not supported.
			/// </summary>
			DWMWA_CLOAKED,

			/// <summary>
			/// Use with DwmSetWindowAttribute. Freeze the window's thumbnail image with its current visuals. Do no further live updates on the thumbnail image to match the window's contents. Windows 7 and earlier: This value is not supported.
			/// </summary>
			DWMWA_FREEZE_REPRESENTATION,

			/// <summary>
			/// Use with DwmSetWindowAttribute. Enables a non-UWP window to use host backdrop brushes. If this flag is set, then a Win32 app that calls Windows::UI::Composition APIs can build transparency effects using the host backdrop brush (see Compositor.CreateHostBackdropBrush). The pvAttribute parameter points to a value of type BOOL. TRUE to enable host backdrop brushes for the window, or FALSE to disable it. This value is supported starting with Windows 11 Build 22000.
			/// </summary>
			DWMWA_USE_HOSTBACKDROPBRUSH,

			/// <summary>
			/// Use with DwmSetWindowAttribute. Allows the window frame for this window to be drawn in dark mode colors when the dark mode system setting is enabled. For compatibility reasons, all windows default to light mode regardless of the system setting. The pvAttribute parameter points to a value of type BOOL. TRUE to honor dark mode for the window, FALSE to always use light mode. This value is supported starting with Windows 10 Build 17763.
			/// </summary>
			DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1 = 19,

			/// <summary>
			/// Use with DwmSetWindowAttribute. Allows the window frame for this window to be drawn in dark mode colors when the dark mode system setting is enabled. For compatibility reasons, all windows default to light mode regardless of the system setting. The pvAttribute parameter points to a value of type BOOL. TRUE to honor dark mode for the window, FALSE to always use light mode. This value is supported starting with Windows 11 Build 22000.
			/// </summary>
			DWMWA_USE_IMMERSIVE_DARK_MODE = 20,

			/// <summary>
			/// Use with DwmSetWindowAttribute. Specifies the rounded corner preference for a window. The pvAttribute parameter points to a value of type DWM_WINDOW_CORNER_PREFERENCE. This value is supported starting with Windows 11 Build 22000.
			/// </summary>
			DWMWA_WINDOW_CORNER_PREFERENCE = 33,

			/// <summary>
			/// Use with DwmSetWindowAttribute. Specifies the color of the window border. The pvAttribute parameter points to a value of type COLORREF. The app is responsible for changing the border color according to state changes, such as a change in window activation. This value is supported starting with Windows 11 Build 22000.
			/// </summary>
			DWMWA_BORDER_COLOR,

			/// <summary>
			/// Use with DwmSetWindowAttribute. Specifies the color of the caption. The pvAttribute parameter points to a value of type COLORREF. This value is supported starting with Windows 11 Build 22000.
			/// </summary>
			DWMWA_CAPTION_COLOR,

			/// <summary>
			/// Use with DwmSetWindowAttribute. Specifies the color of the caption text. The pvAttribute parameter points to a value of type COLORREF. This value is supported starting with Windows 11 Build 22000.
			/// </summary>
			DWMWA_TEXT_COLOR,

			/// <summary>
			/// Use with DwmGetWindowAttribute. Retrieves the width of the outer border that the DWM would draw around this window. The value can vary depending on the DPI of the window. The pvAttribute parameter points to a value of type UINT. This value is supported starting with Windows 11 Build 22000.
			/// </summary>
			DWMWA_VISIBLE_FRAME_BORDER_THICKNESS,

			/// <summary>
			/// The maximum recognized DWMWINDOWATTRIBUTE value, used for validation purposes.
			/// </summary>
			DWMWA_LAST,
		}

		[Flags]
		public enum DWM_WINDOW_CORNER_PREFERENCE
		{
			DWMWCP_DEFAULT = 0,
			DWMWCP_DONOTROUND = 1,
			DWMWCP_ROUND = 2,
			DWMWCP_ROUNDSMALL = 3
		}

		[Serializable, StructLayout(LayoutKind.Sequential)]
		public struct RECT
		{
			public int Left;
			public int Top;
			public int Right;
			public int Bottom;

			public Rectangle ToRectangle()
			{
				return Rectangle.FromLTRB(Left, Top, Right, Bottom);
			}
		}

		public const int EM_SETCUEBANNER = 5377;

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

		[DllImport("DwmApi")]
		public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

		[DllImport("dwmapi.dll")]
		public static extern int DwmGetWindowAttribute(IntPtr hwnd, int dwAttribute, out RECT pvAttribute, int cbAttribute);

		[DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
		private static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

		[DllImport("dwmapi.dll", EntryPoint = "#127")]
		public static extern void DwmGetColorizationParameters(ref DWMCOLORIZATIONcolors colors);

		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn
		(
			int nLeftRect,     // x-coordinate of upper-left corner
			int nTopRect,      // y-coordinate of upper-left corner
			int nRightRect,    // x-coordinate of lower-right corner
			int nBottomRect,   // y-coordinate of lower-right corner
			int nWidthEllipse, // height of ellipse
			int nHeightEllipse // width of ellipse
		);

		[DllImport("user32")]
		private static extern IntPtr GetDC(IntPtr hwnd);

		[DllImport("user32")]
		private static extern IntPtr ReleaseDC(IntPtr hwnd, IntPtr hdc);

		public static IntPtr GetHeaderControl(ListView list)
		{
			const int LVM_GETHEADER = 0x1000 + 31;
			return SendMessage(list.Handle, LVM_GETHEADER, IntPtr.Zero, "");
		}

		#endregion Win32 API Declarations

		#region Public Members

		/// <summary>'true' if Dark Mode Color is set in Windows's Settings.</summary>
		public bool IsDarkMode { get; set; } = false;

		/// <summary>Option to re-colorize all Icons in Toolbars and Menus.</summary>
		public bool ColorizeIcons { get; set; } = true;

		/// <summary>Option to make all Panels Borders Rounded</summary>
		public bool RoundedPanels { get; set; } = false;

		/// <summary>The PArent form for them all.</summary>
		public Form OwnerForm { get; set; }

		/// <summary>Windows Colors. Can be customized.</summary>
		public OSThemeColors OScolors { get; set; }

		#endregion Public Members

		#region Constructors

		/// <summary>This tries to automatically apply Windows Dark Mode (if enabled) to a Form.</summary>
		/// <param name="_Form">The Form to become Dark</param>
		/// <param name="_ColorizeIcons">[OPTIONAL] re-colorize all Icons in Toolbars and Menus.</param>
		/// <param name="_RoundedPanels">[OPTIONAL] make all Panels Borders Rounded</param>
		public DarkModeCS(Form _Form, bool _ColorizeIcons = true, bool _RoundedPanels = false)
		{
			//Sets the Properties:
			OwnerForm = _Form;
			ColorizeIcons = _ColorizeIcons;
			RoundedPanels = _RoundedPanels;
			IsDarkMode = GetWindowsColorMode() <= 0 ? true : false;
			OScolors = GetSystemColors(OwnerForm);

			if (IsDarkMode && OScolors != null)
			{
				if (OwnerForm != null && OwnerForm.Controls != null)
				{
					foreach (Control _control in OwnerForm.Controls)
					{
						ThemeControl(_control);
					}
					OwnerForm.ControlAdded += (object sender, ControlEventArgs e) => {
						ThemeControl(e.Control);
					};
				}
			}
		}

		#endregion Constructors

		#region Public Methods

		/// <summary>Recursively apply the Colors from 'OScolors' to the Control and all its childs.</summary>
		/// <param name="control">Can be a Form or any Winforms Control.</param>
		public void ThemeControl(Control control)
		{
			BorderStyle BStyle = (IsDarkMode ? BorderStyle.FixedSingle : BorderStyle.Fixed3D);
			FlatStyle FStyle = (IsDarkMode ? FlatStyle.Flat : FlatStyle.Standard);

			//Change the Colors only if its the default ones, this allows the user to set own colors:
			if (control.BackColor == SystemColors.Control || control.BackColor == SystemColors.Window)
			{
				control.GetType().GetProperty("BackColor")?.SetValue(control, OScolors.Control);
			}
			if (control.ForeColor == SystemColors.ControlText || control.ForeColor == SystemColors.WindowText)
			{
				control.GetType().GetProperty("ForeColor")?.SetValue(control, OScolors.TextActive);
			}
			//control.GetType().GetProperty("BorderStyle")?.SetValue(control, BStyle);

			control.HandleCreated += (object sender, EventArgs e) => {
				ApplySystemDarkTheme(control);
			};
			control.ControlAdded += (object sender, ControlEventArgs e) => {
				ThemeControl(e.Control);
			};

			if (control is TextBox tb)
			{
				//SetRoundBorders(tb, 4, OScolors.SurfaceDark, 1);
			}
			if (control is FlowLayoutPanel flow)
			{
				// Process the panel within the container
				flow.BackColor = flow.Parent.BackColor;
			}
			else if (control is TableLayoutPanel table)
			{
				// Process the panel within the container
				table.BackColor = table.Parent.BackColor;
			}
			else if (control is GroupBox group)
			{
				group.BackColor = group.Parent.BackColor;
				group.ForeColor = OScolors.TextInactive;
			}
			else if (control is Panel panel)
			{
				// Process the panel within the container
				panel.BackColor = OScolors.Surface;
				panel.BorderStyle = BorderStyle.None;

				if (!(panel.Parent is TabControl) || !(panel.Parent is TableLayoutPanel))
				{
					if (RoundedPanels)
					{
						SetRoundBorders(panel, 6, OScolors.SurfaceDark, 1);
					}
				}
			}
			if (control is TabControl tab)
			{
				tab.Appearance = TabAppearance.Normal;
				tab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
				tab.DrawItem += (object sender, DrawItemEventArgs e) => {
					//Draw the background of the main control
					using (SolidBrush backColor = new SolidBrush(tab.Parent.BackColor))
					{
						e.Graphics.FillRectangle(backColor, tab.ClientRectangle);
					}

					using (Brush tabBack = new SolidBrush(OScolors.Surface))
					{
						for (int i = 0; i < tab.TabPages.Count; i++)
						{
							TabPage tabPage = tab.TabPages[i];
							tabPage.BackColor = OScolors.Surface;
							tabPage.BorderStyle = BorderStyle.FixedSingle;
							tabPage.ControlAdded += (object _s, ControlEventArgs _e) => {
								ThemeControl(_e.Control);
							};

							var tBounds = e.Bounds;
							//tBounds.Inflate(100, 100);

							bool IsSelected = (tab.SelectedIndex == i);
							if (IsSelected)
							{
								e.Graphics.FillRectangle(tabBack, tBounds);
								TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font, e.Bounds, OScolors.TextActive);
							}
							else
							{
								TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font, tab.GetTabRect(i), OScolors.TextInactive);
							}
						}
					}
				};
			}
			if (control is PictureBox pic)
			{
				pic.BorderStyle = BorderStyle.None;
				pic.BackColor = pic.Parent.BackColor;
			}
			if (control is ListView lView)
			{
				if (lView.View == View.Details)
				{
					lView.OwnerDraw = true;
					lView.DrawColumnHeader += (object sender, DrawListViewColumnHeaderEventArgs e) => {
						//e.DrawDefault = true;
						//e.DrawBackground();
						//e.DrawText();

						using (SolidBrush backBrush = new SolidBrush(OScolors.ControlLight))
						{
							using (SolidBrush foreBrush = new SolidBrush(OScolors.TextActive))
							{
								using (var sf = new StringFormat())
								{
									sf.Alignment = StringAlignment.Center;
									e.Graphics.FillRectangle(backBrush, e.Bounds);
									e.Graphics.DrawString(e.Header.Text, lView.Font, foreBrush, e.Bounds, sf);
								}
							}
						}
					};
					lView.DrawItem += (sender, e) => { e.DrawDefault = true; };
					lView.DrawSubItem += (sender, e) => {
						e.DrawDefault = true;
						/*
            IntPtr headerControl = GetHeaderControl(lView);
            IntPtr hdc = GetDC(headerControl);
            Rectangle rc = new Rectangle(
              e.Bounds.Right, //<- Right instead of Left - offsets the rectangle
              e.Bounds.Top,
              e.Bounds.Width,
              e.Bounds.Height
            );
            rc.Width += 200;

            using (SolidBrush backBrush = new SolidBrush(OScolors.ControlLight))
            {
              e.Graphics.FillRectangle(backBrush, rc);
            }

            ReleaseDC(headerControl, hdc);
            */
					};
				}
			}
			if (control is Button button)
			{
				button.FlatStyle = FStyle;
				button.FlatAppearance.CheckedBackColor = OScolors.Accent;
				button.BackColor = OScolors.Control;
				button.FlatAppearance.BorderColor = (OwnerForm.AcceptButton == button) ?
					OScolors.Accent : OScolors.Control;
				//SetRoundBorders(button, 4, OScolors.SurfaceDark, 1);
			}
			if (control is Label label)
			{
				label.BorderStyle = BorderStyle.None;
			}
			if (control is LinkLabel link)
			{
				link.LinkColor = OScolors.AccentLight;
				link.VisitedLinkColor = OScolors.Primary;
			}
			if (control is CheckBox chk)
			{
				chk.BackColor = chk.Parent.BackColor;
			}
			if (control is RadioButton opt)
			{
				opt.BackColor = opt.Parent.BackColor;
			}
			if (control is ComboBox combo)
			{
				combo.FlatStyle = FStyle;
				combo.BackColor = OScolors.Control;
				control.GetType().GetProperty("ButtonColor")?.SetValue(control, OScolors.Surface);
				combo.Invalidate();
			}
			if (control is MenuStrip menu)
			{
				menu.RenderMode = ToolStripRenderMode.Professional;
				menu.Renderer = new MyRenderer(new CustomColorTable(OScolors), ColorizeIcons)
				{
					MyColors = OScolors
				};
			}
			if (control is ToolStrip toolBar)
			{
				toolBar.GripStyle = ToolStripGripStyle.Hidden;
				toolBar.RenderMode = ToolStripRenderMode.Professional;
				toolBar.Renderer = new MyRenderer(new CustomColorTable(OScolors), ColorizeIcons) { MyColors = OScolors };
			}
			if (control is ContextMenuStrip cMenu)
			{
				cMenu.RenderMode = ToolStripRenderMode.Professional;
				cMenu.Renderer = new MyRenderer(new CustomColorTable(OScolors), ColorizeIcons) { MyColors = OScolors };
			}
			if (control is DataGridView grid)
			{
				grid.EnableHeadersVisualStyles = false;
				grid.BorderStyle = BorderStyle.FixedSingle;
				grid.BackgroundColor = OScolors.Control;
				grid.GridColor = OScolors.Control;

				grid.DefaultCellStyle.BackColor = OScolors.Surface;
				grid.DefaultCellStyle.ForeColor = OScolors.TextActive;

				grid.ColumnHeadersDefaultCellStyle.BackColor = OScolors.Surface;
				grid.ColumnHeadersDefaultCellStyle.ForeColor = OScolors.TextActive;
				grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = OScolors.AccentOpaque;
				grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
				grid.ColumnHeadersHeight = 140;

				grid.RowHeadersDefaultCellStyle.BackColor = OScolors.Surface;
				grid.RowHeadersDefaultCellStyle.ForeColor = OScolors.TextActive;
				grid.RowHeadersDefaultCellStyle.SelectionBackColor = OScolors.AccentOpaque;
				grid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			}
			if (control is PropertyGrid pGrid)
			{
				pGrid.BackColor = OScolors.Control;
				pGrid.ViewBackColor = OScolors.Control;
				pGrid.LineColor = OScolors.Surface;
				pGrid.ViewForeColor = OScolors.TextActive;
				pGrid.ViewBorderColor = OScolors.ControlDark;
				pGrid.CategoryForeColor = OScolors.TextActive;
				pGrid.CategorySplitterColor = OScolors.ControlLight;
			}
			if (control is TreeView tree)
			{
				tree.BorderStyle = BorderStyle.None;
				tree.BackColor = OScolors.Surface;
				/*
        tree.DrawNode += (object? sender, DrawTreeNodeEventArgs e) =>
        {
          if (e.Node.ImageIndex != -1)
          {
            Image image = tree.ImageList.Images[e.Node.ImageIndex];
            using (Graphics g = Graphics.FromImage(image))
            {
              g.InterpolationMode = InterpolationMode.HighQualityBilinear;
              g.CompositingQuality = CompositingQuality.HighQuality;
              g.SmoothingMode = SmoothingMode.HighQuality;

              g.DrawImage(DarkModeCS.ChangeToColor(image, OScolors.TextInactive), new Point(0,0));
            }
            tree.ImageList.Images[e.Node.ImageIndex] = image;
          }
          tree.Invalidate();
        };
        */
			}
			if (control is TrackBar slider)
			{
				slider.BackColor = control.Parent.BackColor;
			}

			if (control.ContextMenuStrip != null)
				ThemeControl(control.ContextMenuStrip);

			foreach (Control childControl in control.Controls)
			{
				// Recursively process its children
				ThemeControl(childControl);
			}
		}

		private void Tree_DrawNode(object sender, DrawTreeNodeEventArgs e)
		{
			throw new NotImplementedException();
		}

		/// <summary>Returns Windows Color Mode for Applications.
		/// <para>0=dark theme, 1=light theme</para>
		/// </summary>
		public static int GetWindowsColorMode(bool GetSystemColorModeInstead = false)
		{
			try
			{
				return (int)Microsoft.Win32.Registry.GetValue(
					@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize",
					GetSystemColorModeInstead ? "SystemUsesLightTheme" : "AppsUseLightTheme",
					-1);
			}
			catch
			{
				return 1;
			}
		}

		/// <summary>Returns the Accent Color used by Windows.</summary>
		/// <returns>a Color</returns>
		public static Color GetWindowsAccentColor()
		{
			DWMCOLORIZATIONcolors colors = new DWMCOLORIZATIONcolors();
			DwmGetColorizationParameters(ref colors);

			//get the theme --> only if Windows 10 or newer
			if (IsWindows10orGreater())
			{
				var color = colors.ColorizationColor;

				var colorValue = long.Parse(color.ToString(), System.Globalization.NumberStyles.HexNumber);

				var transparency = (colorValue >> 24) & 0xFF;
				var red = (colorValue >> 16) & 0xFF;
				var green = (colorValue >> 8) & 0xFF;
				var blue = (colorValue >> 0) & 0xFF;

				return Color.FromArgb((int)transparency, (int)red, (int)green, (int)blue);
			}
			else
			{
				return Color.CadetBlue;
			}
		}

		/// <summary>Returns the Accent Color used by Windows.</summary>
		/// <returns>an opaque Color</returns>
		public static Color GetWindowsAccentOpaqueColor()
		{
			DWMCOLORIZATIONcolors colors = new DWMCOLORIZATIONcolors();
			DwmGetColorizationParameters(ref colors);

			//get the theme --> only if Windows 10 or newer
			if (IsWindows10orGreater())
			{
				var color = colors.ColorizationColor;

				var colorValue = long.Parse(color.ToString(), System.Globalization.NumberStyles.HexNumber);

				var red = (colorValue >> 16) & 0xFF;
				var green = (colorValue >> 8) & 0xFF;
				var blue = (colorValue >> 0) & 0xFF;

				return Color.FromArgb(255, (int)red, (int)green, (int)blue);
			}
			else
			{
				return Color.CadetBlue;
			}
		}

		/// <summary>Returns Windows's System Colors for UI components following Google Material Design concepts.</summary>
		/// <param name="Window">[OPTIONAL] Applies DarkMode (if set) to this Window Title and Background.</param>
		/// <returns>List of Colors:  Background, OnBackground, Surface, OnSurface, Primary, OnPrimary, Secondary, OnSecondary</returns>
		public static OSThemeColors GetSystemColors(Form Window = null)
		{
			OSThemeColors _ret = new OSThemeColors();

			bool IsDarkMode = (GetWindowsColorMode() <= 0); //<- O: DarkMode, 1: LightMode
			if (IsDarkMode)
			{
				_ret.Background = Color.FromArgb(32, 32, 32);   //<- Negro Claro
				_ret.BackgroundDark = Color.FromArgb(18, 18, 18);
				_ret.BackgroundLight = ControlPaint.Light(_ret.Background);

				_ret.Surface = Color.FromArgb(43, 43, 43);      //<- Gris Oscuro
				_ret.SurfaceLight = Color.FromArgb(50, 50, 50);
				_ret.SurfaceDark = Color.FromArgb(29, 29, 29);

				_ret.TextActive = Color.White;
				_ret.TextInactive = Color.FromArgb(176, 176, 176);  //<- Blanco Palido
				_ret.TextInAccent = GetReadableColor(_ret.Accent);

				_ret.Control = Color.FromArgb(55, 55, 55);       //<- Gris Oscuro
				_ret.ControlDark = ControlPaint.Dark(_ret.Control);
				_ret.ControlLight = Color.FromArgb(67, 67, 67);

				_ret.Primary = Color.FromArgb(3, 218, 198);   //<- Verde Pastel
				_ret.Secondary = Color.MediumSlateBlue;         //<- Magenta Claro

				//Apply Window's Dark Mode to the Form's Title bar
				if (Window != null)
				{
					//SetWin32ApiTheme(Window);
					ApplySystemDarkTheme(Window);

					Window.BackColor = _ret.Background;
					Window.ForeColor = _ret.TextInactive;
				}
			}

			return _ret;
		}

		/// <summary>Apply Round Corners to the indicated Control or Form.</summary>
		/// <param name="_Control">the one who will have rounded Corners. Set BorderStyle = None.</param>
		/// <param name="Radius">Radious for the Corners</param>
		/// <param name="borderColor">Color for the Border</param>
		/// <param name="borderSize">Size in pixels of the border line</param>
		/// <param name="underlinedStyle"></param>
		public static void SetRoundBorders(Control _Control, int Radius = 10, Color? borderColor = null, int borderSize = 2, bool underlinedStyle = false)
		{
			try
			{
				borderColor = borderColor ?? Color.MediumSlateBlue;

				if (_Control != null)
				{
					_Control.GetType().GetProperty("BorderStyle")?.SetValue(_Control, BorderStyle.None);
					_Control.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, _Control.Width, _Control.Height, Radius, Radius));
					_Control.Paint += (object sender, PaintEventArgs e) => {
						//base.OnPaint(e);
						Graphics graph = e.Graphics;

						if (Radius > 1)//Rounded TextBox
						{
							//-Fields
							var rectBorderSmooth = _Control.ClientRectangle;
							var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
							int smoothSize = borderSize > 0 ? borderSize : 1;

							using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, Radius))
							using (GraphicsPath pathBorder = GetFigurePath(rectBorder, Radius - borderSize))
							using (Pen penBorderSmooth = new Pen(_Control.Parent.BackColor, smoothSize))
							using (Pen penBorder = new Pen((Color)borderColor, borderSize))
							{
								//-Drawing
								_Control.Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
								if (Radius > 15) //Set the rounded region of TextBox component
								{
									using (GraphicsPath pathTxt = GetFigurePath(_Control.ClientRectangle, borderSize * 2))
									{
										_Control.Region = new Region(pathTxt);
									}
								}
								graph.SmoothingMode = SmoothingMode.AntiAlias;
								penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
								//if (isFocused) penBorder.Color = borderFocusColor;

								if (underlinedStyle) //Line Style
								{
									//Draw border smoothing
									graph.DrawPath(penBorderSmooth, pathBorderSmooth);
									//Draw border
									graph.SmoothingMode = SmoothingMode.None;
									graph.DrawLine(penBorder, 0, _Control.Height - 1, _Control.Width, _Control.Height - 1);
								}
								else //Normal Style
								{
									//Draw border smoothing
									graph.DrawPath(penBorderSmooth, pathBorderSmooth);
									//Draw border
									graph.DrawPath(penBorder, pathBorder);
								}
							}
						}
					};
				}
			}
			catch { throw; }
		}

		/// <summary>Colorea una imagen usando una Matrix de Color.</summary>
		/// <param name="bmp">Imagen a Colorear</param>
		/// <param name="c">Color a Utilizar</param>
		public static Bitmap ChangeToColor(Bitmap bmp, Color c)
		{
			Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
			using (Graphics g = Graphics.FromImage(bmp2))
			{
				g.InterpolationMode = InterpolationMode.HighQualityBilinear;
				g.CompositingQuality = CompositingQuality.HighQuality;
				g.SmoothingMode = SmoothingMode.HighQuality;

				float tR = c.R / 255f;
				float tG = c.G / 255f;
				float tB = c.B / 255f;

				//System.Drawing.Imaging.ColorMatrix colorMatrix = new System.Drawing.Imaging.ColorMatrix(new float[][]
				//{
				//  new float[] { 0,    0,  0,  0,  0 },
				//  new float[] { 0,    0,  0,  0,  0 },
				//  new float[] { 0,    0,  0,  0,  0 },
				//  new float[] { 0,    0,  0,  1,  0 },  //<- not changing alpha
				//  new float[] { tR,   tG, tB, 0,  1 }
				//});
				System.Drawing.Imaging.ColorMatrix colorMatrix = new System.Drawing.Imaging.ColorMatrix(new float[][]
				{
				new float[] { 1,    0,  0,  0,  0 },
				new float[] { 0,    1,  0,  0,  0 },
				new float[] { 0,    0,  1,  0,  0 },
				new float[] { 0,    0,  0,  1,  0 },  //<- not changing alpha
        new float[] { tR,   tG, tB, 0,  1 }
				});

				System.Drawing.Imaging.ImageAttributes attributes = new System.Drawing.Imaging.ImageAttributes();
				attributes.SetColorMatrix(colorMatrix);

				g.DrawImage(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height),
					0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, attributes);
			}
			return bmp2;
		}

		public static Image ChangeToColor(Image bmp, Color c) => (Image)ChangeToColor((Bitmap)bmp, c);

		#endregion Public Methods

		#region Private Methods

		/// <summary>Attemps to apply Window's Dark Style to the Control and all its childs.</summary>
		/// <param name="control"></param>
		private static void ApplySystemDarkTheme(Control control = null)
		{
			/*
        DWMWA_USE_IMMERSIVE_DARK_MODE:   https://learn.microsoft.com/en-us/windows/win32/api/dwmapi/ne-dwmapi-dwmwindowattribute

        Use with DwmSetWindowAttribute. Allows the window frame for this window to be drawn in dark mode colors when the dark mode system setting is enabled.
        For compatibility reasons, all windows default to light mode regardless of the system setting.
        The pvAttribute parameter points to a value of type BOOL. TRUE to honor dark mode for the window, FALSE to always use light mode.

        This value is supported starting with Windows 11 Build 22000.

        SetWindowTheme:     https://learn.microsoft.com/en-us/windows/win32/api/uxtheme/nf-uxtheme-setwindowtheme
        Causes a window to use a different set of visual style information than its class normally uses.
       */
			int[] DarkModeOn = new[] { 0x01 }; //<- 1=True, 0=False

			SetWindowTheme(control.Handle, "DarkMode_Explorer", null);

			if (DwmSetWindowAttribute(control.Handle, (int)DWMWINDOWATTRIBUTE.DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1, DarkModeOn, 4) != 0)
				DwmSetWindowAttribute(control.Handle, (int)DWMWINDOWATTRIBUTE.DWMWA_USE_IMMERSIVE_DARK_MODE, DarkModeOn, 4);

			foreach (Control child in control.Controls)
			{
				if (child.Controls.Count != 0)
					ApplySystemDarkTheme(child);
			}
		}

		private static bool IsWindows10orGreater()
		{
			if (WindowsVersion() >= 10)
				return true;
			else
				return false;
		}

		private static int WindowsVersion()
		{
			//for .Net4.8 and Minor
			int result;
			try
			{
				var reg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");
				string[] productName = reg.GetValue("ProductName").ToString().Split((char)32);
				int.TryParse(productName[1], out result);
			}
			catch (Exception)
			{
				OperatingSystem os = Environment.OSVersion;
				result = os.Version.Major;
			}

			return result;

			//fixed .Net6
			//return System.Environment.OSVersion.Version.Major;
		}

		private static Color GetReadableColor(Color backgroundColor)
		{
			// Calculate the relative luminance of the background color.
			// Normalize values to 0-1 range first.
			double normalizedR = backgroundColor.R / 255.0;
			double normalizedG = backgroundColor.G / 255.0;
			double normalizedB = backgroundColor.B / 255.0;
			double luminance = 0.299 * normalizedR + 0.587 * normalizedG + 0.114 * normalizedB;

			// Choose a contrasting foreground color based on the luminance,
			// with a slight bias towards lighter colors for better readability.
			return luminance < 0.5 ? Color.FromArgb(182, 180, 215) : Color.FromArgb(34, 34, 34); // Dark gray for light backgrounds
		}

		// For Rounded Corners:
		private static GraphicsPath GetFigurePath(Rectangle rect, int radius)
		{
			GraphicsPath path = new GraphicsPath();
			float curveSize = radius * 2F;

			path.StartFigure();
			path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
			path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
			path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
			path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
			path.CloseFigure();
			return path;
		}

		#endregion Private Methods
	}

	/// <summary>Windows 10+ System Colors for Clear Color Mode.</summary>
	public class OSThemeColors
	{
		public OSThemeColors()
		{
		}

		/// <summary>For the very back of the Window</summary>
		public System.Drawing.Color Background { get; set; } = SystemColors.Control;

		/// <summary>For Borders around the Background</summary>
		public System.Drawing.Color BackgroundDark { get; set; } = SystemColors.ControlDark;

		/// <summary>For hightlights over the Background</summary>
		public System.Drawing.Color BackgroundLight { get; set; } = SystemColors.ControlLight;

		/// <summary>For Container above the Background</summary>
		public System.Drawing.Color Surface { get; set; } = SystemColors.ControlLightLight;

		/// <summary>For Borders around the Surface</summary>
		public System.Drawing.Color SurfaceDark { get; set; } = SystemColors.ControlLight;

		/// <summary>For Highligh over the Surface</summary>
		public System.Drawing.Color SurfaceLight { get; set; } = Color.White;

		/// <summary>For Main Texts</summary>
		public System.Drawing.Color TextActive { get; set; } = SystemColors.ControlText;

		/// <summary>For Inactive Texts</summary>
		public System.Drawing.Color TextInactive { get; set; } = SystemColors.GrayText;

		/// <summary>For Hightligh Texts</summary>
		public System.Drawing.Color TextInAccent { get; set; } = SystemColors.HighlightText;

		/// <summary>For the background of any Control</summary>
		public System.Drawing.Color Control { get; set; } = SystemColors.ButtonFace;

		/// <summary>For Bordes of any Control</summary>
		public System.Drawing.Color ControlDark { get; set; } = SystemColors.ButtonShadow;

		/// <summary>For Highlight elements in a Control</summary>
		public System.Drawing.Color ControlLight { get; set; } = SystemColors.ButtonHighlight;

		/// <summary>Windows 10+ Chosen Accent Color</summary>
		public System.Drawing.Color Accent { get; set; } = DarkModeCS.GetWindowsAccentColor();

		public System.Drawing.Color AccentOpaque { get; set; } = DarkModeCS.GetWindowsAccentOpaqueColor();

		public System.Drawing.Color AccentDark { get { return ControlPaint.Dark(Accent); } }

		public System.Drawing.Color AccentLight { get { return ControlPaint.Light(Accent); } }

		/// <summary>the color displayed most frequently across your app's screens and components.</summary>
		public System.Drawing.Color Primary { get; set; } = SystemColors.Highlight;

		public System.Drawing.Color PrimaryDark { get { return ControlPaint.Dark(Primary); } }

		public System.Drawing.Color PrimaryLight { get { return ControlPaint.Light(Primary); } }

		/// <summary>to accent select parts of your UI.</summary>
		public System.Drawing.Color Secondary { get; set; } = SystemColors.HotTrack;

		public System.Drawing.Color SecondaryDark { get { return ControlPaint.Dark(Secondary); } }

		public System.Drawing.Color SecondaryLight { get { return ControlPaint.Light(Secondary); } }
	}

	/* Custom Renderers for Menus and ToolBars */
	public class MyRenderer : ToolStripProfessionalRenderer
	{
		public bool ColorizeIcons { get; set; } = true;
		public OSThemeColors MyColors { get; set; } //<- Your Custom Colors Colection

		public MyRenderer(ProfessionalColorTable table, bool pColorizeIcons = true) : base(table)
		{
			ColorizeIcons = pColorizeIcons;
		}

		private void DrawTitleBar(Graphics g, Rectangle rect)
		{
			// Assign the image for the grip.
			//Image titlebarGrip = titleBarGripBmp;

			// Fill the titlebar.
			// This produces the gradient and the rounded-corner effect.
			//g.DrawLine(new Pen(titlebarColor1), rect.X, rect.Y, rect.X + rect.Width, rect.Y);
			//g.DrawLine(new Pen(titlebarColor2), rect.X, rect.Y + 1, rect.X + rect.Width, rect.Y + 1);
			//g.DrawLine(new Pen(titlebarColor3), rect.X, rect.Y + 2, rect.X + rect.Width, rect.Y + 2);
			//g.DrawLine(new Pen(titlebarColor4), rect.X, rect.Y + 3, rect.X + rect.Width, rect.Y + 3);
			//g.DrawLine(new Pen(titlebarColor5), rect.X, rect.Y + 4, rect.X + rect.Width, rect.Y + 4);
			//g.DrawLine(new Pen(titlebarColor6), rect.X, rect.Y + 5, rect.X + rect.Width, rect.Y + 5);
			//g.DrawLine(new Pen(titlebarColor7), rect.X, rect.Y + 6, rect.X + rect.Width, rect.Y + 6);

			// Center the titlebar grip.
			//g.DrawImage(
			//  titlebarGrip,
			//  new Point(rect.X + ((rect.Width / 2) - (titlebarGrip.Width / 2)),
			//  rect.Y + 1));
		}

		// This method handles the RenderGrip event.
		protected override void OnRenderGrip(ToolStripGripRenderEventArgs e)
		{
			DrawTitleBar(
				e.Graphics,
				new Rectangle(0, 0, e.ToolStrip.Width, 7));
		}

		// This method handles the RenderToolStripBorder event.
		protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
		{
			DrawTitleBar(
				e.Graphics,
				new Rectangle(0, 0, e.ToolStrip.Width, 7));
		}

		// Background of the whole ToolBar Or MenuBar:
		protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
		{
			e.ToolStrip.BackColor = MyColors.Background;
			base.OnRenderToolStripBackground(e);
		}

		// For Normal Buttons on a ToolBar:
		protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
		{
			Graphics g = e.Graphics;
			Rectangle bounds = new Rectangle(Point.Empty, e.Item.Size);

			Color gradientBegin = MyColors.Background; // Color.FromArgb(203, 225, 252);
			Color gradientEnd = MyColors.Background;

			Pen BordersPencil = new Pen(MyColors.Background);

			ToolStripButton button = e.Item as ToolStripButton;
			if (button.Pressed || button.Checked)
			{
				gradientBegin = MyColors.Control;
				gradientEnd = MyColors.Control;
			}
			else if (button.Selected)
			{
				gradientBegin = MyColors.Accent;
				gradientEnd = MyColors.Accent;
			}

			using (Brush b = new LinearGradientBrush(
				bounds,
				gradientBegin,
				gradientEnd,
				LinearGradientMode.Vertical))
			{
				g.FillRectangle(b, bounds);
			}

			e.Graphics.DrawRectangle(
				BordersPencil,
				bounds);

			g.DrawLine(
				BordersPencil,
				bounds.X,
				bounds.Y,
				bounds.Width - 1,
				bounds.Y);

			g.DrawLine(
				BordersPencil,
				bounds.X,
				bounds.Y,
				bounds.X,
				bounds.Height - 1);

			ToolStrip toolStrip = button.Owner;

			if (!(button.Owner.GetItemAt(button.Bounds.X, button.Bounds.Bottom + 1) is ToolStripButton nextItem))
			{
				g.DrawLine(
					BordersPencil,
					bounds.X,
					bounds.Height - 1,
					bounds.X + bounds.Width - 1,
					bounds.Height - 1);
			}
		}

		// For DropDown Buttons on a ToolBar:
		protected override void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs e)
		{
			Graphics g = e.Graphics;
			Rectangle bounds = new Rectangle(Point.Empty, e.Item.Size);
			Color gradientBegin = MyColors.Background; // Color.FromArgb(203, 225, 252);
			Color gradientEnd = MyColors.Background;

			Pen BordersPencil = new Pen(MyColors.Background);

			//1. Determine the colors to use:
			if (e.Item.Pressed)
			{
				gradientBegin = MyColors.Control;
				gradientEnd = MyColors.Control;
			}
			else if (e.Item.Selected)
			{
				gradientBegin = MyColors.Accent;
				gradientEnd = MyColors.Accent;
			}

			//2. Draw the Box around the Control
			using (Brush b = new LinearGradientBrush(
				bounds,
				gradientBegin,
				gradientEnd,
				LinearGradientMode.Vertical))
			{
				e.Graphics.FillRectangle(b, bounds);
			}

			//3. Draws the Chevron:

			#region Chevron

			//int Padding = 2; //<- From the right side
			//Size cSize = new Size(8, 4); //<- Size of the Chevron: 8x4 px
			//Pen ChevronPen = new Pen(MyColors.TextInactive, 2); //<- Color and Border Width
			//Point P1 = new Point(bounds.Width - (cSize.Width + Padding), (bounds.Height / 2) - (cSize.Height / 2));
			//Point P2 = new Point(bounds.Width - Padding, (bounds.Height / 2) - (cSize.Height / 2));
			//Point P3 = new Point(bounds.Width - (cSize.Width / 2 + Padding), (bounds.Height / 2) + (cSize.Height / 2));

			//e.Graphics.DrawLine(ChevronPen, P1, P3);
			//e.Graphics.DrawLine(ChevronPen, P2, P3);

			#endregion Chevron
		}

		// For SplitButtons on a ToolBar:
		protected override void OnRenderSplitButtonBackground(ToolStripItemRenderEventArgs e)
		{
			Rectangle bounds = new Rectangle(Point.Empty, e.Item.Size);
			Color gradientBegin = MyColors.Background; // Color.FromArgb(203, 225, 252);
			Color gradientEnd = MyColors.Background;

			//1. Determine the colors to use:
			if (e.Item.Pressed)
			{
				gradientBegin = MyColors.Control;
				gradientEnd = MyColors.Control;
			}
			else if (e.Item.Selected)
			{
				gradientBegin = MyColors.Accent;
				gradientEnd = MyColors.Accent;
			}

			//2. Draw the Box around the Control
			using (Brush b = new LinearGradientBrush(
				bounds,
				gradientBegin,
				gradientEnd,
				LinearGradientMode.Vertical))
			{
				e.Graphics.FillRectangle(b, bounds);
			}

			//3. Draws the Chevron:

			#region Chevron

			int Padding = 2; //<- From the right side
			Size cSize = new Size(8, 4); //<- Size of the Chevron: 8x4 px
			Pen ChevronPen = new Pen(MyColors.TextInactive, 2); //<- Color and Border Width
			Point P1 = new Point(bounds.Width - (cSize.Width + Padding), (bounds.Height / 2) - (cSize.Height / 2));
			Point P2 = new Point(bounds.Width - Padding, (bounds.Height / 2) - (cSize.Height / 2));
			Point P3 = new Point(bounds.Width - (cSize.Width / 2 + Padding), (bounds.Height / 2) + (cSize.Height / 2));

			e.Graphics.DrawLine(ChevronPen, P1, P3);
			e.Graphics.DrawLine(ChevronPen, P2, P3);

			#endregion Chevron
		}

		// For the Text Color of all Items:
		protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
		{
			if (e.Item.Enabled)
			{
				e.TextColor = MyColors.TextActive;
			}
			else
			{
				e.TextColor = MyColors.TextInactive;
			}
			base.OnRenderItemText(e);
		}

		protected override void OnRenderItemBackground(ToolStripItemRenderEventArgs e)
		{
			base.OnRenderItemBackground(e);

			// Only draw border for ComboBox items
			if (e.Item is ComboBox)
			{
				Rectangle rect = new Rectangle(Point.Empty, e.Item.Size);
				e.Graphics.DrawRectangle(new Pen(MyColors.ControlLight, 1), rect);
			}
		}

		// For Menu Items BackColor:
		protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
		{
			Graphics g = e.Graphics;
			Rectangle bounds = new Rectangle(Point.Empty, e.Item.Size);

			Color gradientBegin = MyColors.Background; // Color.FromArgb(203, 225, 252);
			Color gradientEnd = MyColors.Background; // Color.FromArgb(125, 165, 224);

			bool DrawIt = false;
			var _menu = e.Item as ToolStripItem;
			if (_menu.Pressed)
			{
				gradientBegin = MyColors.Control; // Color.FromArgb(254, 128, 62);
				gradientEnd = MyColors.Control; // Color.FromArgb(255, 223, 154);
				DrawIt = true;
			}
			else if (_menu.Selected)
			{
				gradientBegin = MyColors.Accent;// Color.FromArgb(255, 255, 222);
				gradientEnd = MyColors.Accent; // Color.FromArgb(255, 203, 136);
				DrawIt = true;
			}

			if (DrawIt)
			{
				using (Brush b = new LinearGradientBrush(
				bounds,
				gradientBegin,
				gradientEnd,
				LinearGradientMode.Vertical))
				{
					g.FillRectangle(b, bounds);
				}
			}
		}

		// Re-Colors the Icon Images to a Clear color:
		protected override void OnRenderItemImage(ToolStripItemImageRenderEventArgs e)
		{
			if (ColorizeIcons && e.Image != null)
			{
				// Get the current icon
				Image image = e.Image;
				Color _ClearColor = e.Item.Enabled ? MyColors.TextInactive : MyColors.SurfaceDark;

				// Create a new image with the desired color adjustments
				using (Image adjustedImage = DarkModeCS.ChangeToColor(image, _ClearColor))
				{
					e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
					e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
					e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
					e.Graphics.DrawImage(adjustedImage, e.ImageRectangle);
				}
			}
			else
			{
				base.OnRenderItemImage(e);
			}
		}
	}

	public class CustomColorTable : ProfessionalColorTable
	{
		public OSThemeColors Colors { get; set; }

		public CustomColorTable(OSThemeColors _Colors)
		{
			Colors = _Colors;
			base.UseSystemColors = false;
		}

		public override Color ImageMarginGradientBegin
		{
			get { return Colors.Control; }
		}

		public override Color ImageMarginGradientMiddle
		{
			get { return Colors.Control; }
		}

		public override Color ImageMarginGradientEnd
		{
			get { return Colors.Control; }
		}
	}
}