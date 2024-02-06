using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DarkModeForms
{
	/// <summary>This tries to automatically apply Windows Dark Mode (if enabled) to a Form.
	/// <para>Author: Blue Mystic - 2024</para></summary>
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
		public struct Rect
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
		public extern static IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

		[DllImport("DwmApi")] //System.Runtime.InteropServices
		public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

		[DllImport("dwmapi.dll")]
		public static extern int DwmGetWindowAttribute(IntPtr hwnd, int dwAttribute, out Rect pvAttribute, int cbAttribute);

		[DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
		private extern static int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

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

		#endregion

		#region Public Members

		public bool IsDarkMode { get; set; } = false;
		public bool ColorizeIcons { get; set; } = true;
		public Form1 TheForm { get; set; }

		/// <summary>Windows Colors.</summary>
		public OSThemeColors OScolors { get; set; }

		#endregion

		#region Constructors

		/// <summary>This tries to automatically apply Windows Dark Mode (if enabled) to a Form.</summary>
		/// <param name="_Form">The Form to become Dark</param>
		public DarkModeCS(Form1 _Form)
		{
			TheForm = _Form;
			IsDarkMode = GetWindowsColorMode() <= 0 ? true : false;
			OScolors = GetSystemColors(TheForm);
			if (IsDarkMode && OScolors != null)
			{
				if (TheForm != null && TheForm.Controls != null)
				{
					foreach (Control _control in TheForm.Controls)
					{
						ProcessControlsRecursively(_control);
					}
				}
			}
		}

		#endregion

		#region Public Methods

		public static bool IsWindows10orGreater()
		{
			if (WindowsVersion() >= 10)
				return true;
			else
				return false;
		}

		public static int WindowsVersion()
		{
			//for .Net4.8 and Minor
			int result = 10;
			var reg = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");
			string[] productName = reg.GetValue("ProductName").ToString().Split((char)32);
			int.TryParse(productName[1], out result);
			return result;

			//fixed .Net6
			//return System.Environment.OSVersion.Version.Major;
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
				var opaque = true;
				var color = (int)colors.ColorizationColor;

				return Color.FromArgb((byte)(opaque ? 255 : (color >> 24) & 0xff),
										(byte)((color >> 16) & 0xff),
										(byte)((color >> 8) & 0xff),
										(byte)(color) & 0xff);
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
				_ret.TextInAccent = _ret.Accent;

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

					//Window.
					//protected override void CreateHandle()
					//{
					//	base.CreateHandle();
					//	SetWindowTheme(this.Handle, "explorer", null);
					//}

					Window.BackColor = _ret.Background;
					Window.ForeColor = _ret.TextInactive;
				}
			}

			return _ret;
		}

		/// <summary>Attemps to apply Window's Dark Style to the Control and all its childs.</summary>
		/// <param name="control"></param>
		public static void ApplySystemDarkTheme(Control control = null)
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
					_Control.Paint += (object sender, PaintEventArgs e) =>
					{
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

		#endregion

		#region Private Methods

		private void ProcessControlsRecursively(Control control)
		{
			BorderStyle BStyle = (IsDarkMode ? BorderStyle.FixedSingle : BorderStyle.Fixed3D);
			FlatStyle FStyle = (IsDarkMode ? FlatStyle.Flat : FlatStyle.Standard);

			control.GetType().GetProperty("BackColor")?.SetValue(control, OScolors.Control);
			control.GetType().GetProperty("ForeColor")?.SetValue(control, OScolors.TextActive);
			control.GetType().GetProperty("BorderStyle")?.SetValue(control, BStyle);

			control.HandleCreated += (object sender, EventArgs e) =>
			{
				//SetWin32ApiTheme(control);
				ApplySystemDarkTheme(control);
			};

			if (control is Panel panel)
			{
				// Process the panel within the container
				panel.BackColor = OScolors.Surface;
				panel.BorderStyle = BorderStyle.None;
				SetRoundBorders(panel, 6, OScolors.SurfaceDark, 1);
			}
			if (control is Button button)
			{
				button.FlatStyle = (IsDarkMode ? FlatStyle.Flat : FlatStyle.Standard);
				button.FlatAppearance.BorderColor = OScolors.ControlLight;
				button.BackColor = OScolors.Control;

				if (TheForm.AcceptButton == button)
				{
					button.FlatAppearance.BorderColor = OScolors.Accent;
				}
			}
			if (control is Label label)
			{
				label.BackColor = Color.Transparent;
				label.BorderStyle = BorderStyle.None;
			}
			if (control is TextBox textBox)
			{
				//textBox.BorderStyle = BorderStyle.Fixed3D;
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
				grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = OScolors.Accent;
				grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
				grid.ColumnHeadersHeight = 140;

				grid.RowHeadersDefaultCellStyle.BackColor = OScolors.Surface;
				grid.RowHeadersDefaultCellStyle.ForeColor = OScolors.TextActive;
				grid.RowHeadersDefaultCellStyle.SelectionBackColor = OScolors.Accent;
				grid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			}
			if (control is ProgressBar pBar)
			{
				pBar.BackColor = OScolors.Control;
			}

			foreach (Control childControl in control.Controls)
			{
				// Recursively process its children
				ProcessControlsRecursively(childControl);
			}
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

		#endregion
	}

	/// <summary>Windows 10+ System Colors for Clear Color Mode.</summary>
	public class OSThemeColors
	{
		public OSThemeColors() { }

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
		public System.Drawing.Color TextInAccent { get; set; } = SystemColors.HotTrack;

		/// <summary>For the background of any Control</summary>
		public System.Drawing.Color Control { get; set; } = SystemColors.ButtonFace;
		/// <summary>For Bordes of any Control</summary>
		public System.Drawing.Color ControlDark { get; set; } = SystemColors.ButtonShadow;
		/// <summary>For Highlight elements in a Control</summary>
		public System.Drawing.Color ControlLight { get; set; } = SystemColors.ButtonHighlight;

		/// <summary>Windows 10+ Chosen Accent Color</summary>
		public System.Drawing.Color Accent { get; set; } = DarkModeCS.GetWindowsAccentColor();
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
		public OSThemeColors? MyColors { get; set; } //<- Your Custom Colors Colection

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
			//	titlebarGrip,
			//	new Point(rect.X + ((rect.Width / 2) - (titlebarGrip.Width / 2)),
			//	rect.Y + 1));
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

			ToolStripButton? button = e.Item as ToolStripButton;
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

			if (button.Owner.GetItemAt(
				button.Bounds.X,
				button.Bounds.Bottom + 1) is not ToolStripButton nextItem)
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

			#endregion
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

			#endregion
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
				using (Image adjustedImage =
					AdjustImageColors(image, targetColor: _ClearColor, preserveAlpha: true))
				{
					e.Graphics.DrawImage(adjustedImage, e.ImageRectangle);
				}
			}
		}

		public Image AdjustImageColors(Image image, Color targetColor, bool preserveAlpha)
		{
			Bitmap adjustedImage = null;
			if (image != null)
			{
				// Create a new Bitmap with the same dimensions and format as the original image
				adjustedImage = new Bitmap(image.Width, image.Height, image.PixelFormat);

				// Iterate through each pixel and adjust its color
				for (int x = 0; x < image.Width; x++)
				{
					for (int y = 0; y < image.Height; y++)
					{
						Color originalColor = ((Bitmap)image).GetPixel(x, y);
						Color adjustedColor = AdjustColor(originalColor, targetColor, preserveAlpha);
						adjustedImage.SetPixel(x, y, adjustedColor);
					}
				}
			}
			return adjustedImage;
		}

		private Color AdjustColor(Color originalColor, Color targetColor, bool preserveAlpha)
		{
			if (preserveAlpha)
			{
				return Color.FromArgb(originalColor.A, targetColor.R, targetColor.G, targetColor.B);
			}
			else
			{
				// Implement your desired color adjustment logic here
				// For example, you could average the colors, apply a tint, etc.
				return Color.FromArgb(targetColor.A,
									   (originalColor.R + targetColor.R) / 2,
									   (originalColor.G + targetColor.G) / 2,
									   (originalColor.B + targetColor.B) / 2);
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

	// https://github.com/r-aghaei/FlatComboExample/tree/master
	public class FlatComboBox : ComboBox
	{
		private Color borderColor = Color.Gray;
		[DefaultValue(typeof(Color), "Gray")]
		public Color BorderColor
		{
			get { return borderColor; }
			set
			{
				if (borderColor != value)
				{
					borderColor = value;
					Invalidate();
				}
			}
		}
		private Color buttonColor = Color.LightGray;
		[DefaultValue(typeof(Color), "LightGray")]
		public Color ButtonColor
		{
			get { return buttonColor; }
			set
			{
				if (buttonColor != value)
				{
					buttonColor = value;
					Invalidate();
				}
			}
		}
		
		protected override void WndProc(ref Message m)
		{
			if (m.Msg == WM_PAINT && DropDownStyle != ComboBoxStyle.Simple)
			{
				var clientRect = ClientRectangle;
				var dropDownButtonWidth = SystemInformation.HorizontalScrollBarArrowWidth;
				var outerBorder = new Rectangle(clientRect.Location,
					new Size(clientRect.Width - 1, clientRect.Height - 1));
				var innerBorder = new Rectangle(outerBorder.X + 1, outerBorder.Y + 1,
					outerBorder.Width - dropDownButtonWidth - 2, outerBorder.Height - 2);
				var innerInnerBorder = new Rectangle(innerBorder.X + 1, innerBorder.Y + 1,
					innerBorder.Width - 2, innerBorder.Height - 2);
				var dropDownRect = new Rectangle(innerBorder.Right + 1, innerBorder.Y,
					dropDownButtonWidth, innerBorder.Height + 1);
				if (RightToLeft == RightToLeft.Yes)
				{
					innerBorder.X = clientRect.Width - innerBorder.Right;
					innerInnerBorder.X = clientRect.Width - innerInnerBorder.Right;
					dropDownRect.X = clientRect.Width - dropDownRect.Right;
					dropDownRect.Width += 1;
				}
				var innerBorderColor = Enabled ? BackColor : SystemColors.Control;
				var outerBorderColor = Enabled ? BorderColor : SystemColors.ControlDark;
				var buttonColor = Enabled ? ButtonColor : SystemColors.Control;
				var middle = new Point(dropDownRect.Left + dropDownRect.Width / 2,
					dropDownRect.Top + dropDownRect.Height / 2);
				var arrow = new Point[]
				{
					new Point(middle.X - 3, middle.Y - 2),
					new Point(middle.X + 4, middle.Y - 2),
					new Point(middle.X, middle.Y + 2)
				};
				var ps = new PAINTSTRUCT();
				bool shoulEndPaint = false;
				IntPtr dc;
				if (m.WParam == IntPtr.Zero)
				{
					dc = BeginPaint(Handle, ref ps);
					m.WParam = dc;
					shoulEndPaint = true;
				}
				else
				{
					dc = m.WParam;
				}
				var rgn = CreateRectRgn(innerInnerBorder.Left, innerInnerBorder.Top,
					innerInnerBorder.Right, innerInnerBorder.Bottom);
				SelectClipRgn(dc, rgn);
				DefWndProc(ref m);
				DeleteObject(rgn);
				rgn = CreateRectRgn(clientRect.Left, clientRect.Top,
					clientRect.Right, clientRect.Bottom);
				SelectClipRgn(dc, rgn);
				using (var g = Graphics.FromHdc(dc))
				{
					g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
					g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
					g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

					#region DropDown Button

					using (var b = new SolidBrush(buttonColor))
					{
						g.FillRectangle(b, dropDownRect);
					}

					#endregion

					#region Chevron

					Size cSize = new Size(8, 4); //<- Size of the Chevron: 8x4 px
					var chevron = new Point[]
					{
						new Point(middle.X - (cSize.Width / 2), middle.Y - (cSize.Height / 2)),
						new Point(middle.X + (cSize.Width / 2), middle.Y - (cSize.Height / 2)),
						new Point(middle.X, middle.Y + (cSize.Height / 2))
					};
					using (var chevronPen = new Pen(BorderColor, 2.5f)) //<- Color and Border Width
					{
						g.DrawLine(chevronPen, chevron[0], chevron[2]);
						g.DrawLine(chevronPen, chevron[1], chevron[2]);
					}

					//Replaced 'arrow' triangle with a Chevron
					//using (var b = new SolidBrush(outerBorderColor))
					//{
					//	g.FillPolygon(b, arrow);
					//}

					#endregion

					#region Borders

					using (var p = new Pen(innerBorderColor))
					{
						g.DrawRectangle(p, innerBorder);
						g.DrawRectangle(p, innerInnerBorder);
					}
					using (var p = new Pen(outerBorderColor))
					{
						g.DrawRectangle(p, outerBorder);
					}

					#endregion

				}
				if (shoulEndPaint)
					EndPaint(Handle, ref ps);
				DeleteObject(rgn);
			}
			else
				base.WndProc(ref m);
		}

		private const int WM_PAINT = 0xF;
		[StructLayout(LayoutKind.Sequential)]
		public struct RECT
		{
			public int L, T, R, B;
		}
		[StructLayout(LayoutKind.Sequential)]
		public struct PAINTSTRUCT
		{
			public IntPtr hdc;
			public bool fErase;
			public int rcPaint_left;
			public int rcPaint_top;
			public int rcPaint_right;
			public int rcPaint_bottom;
			public bool fRestore;
			public bool fIncUpdate;
			public int reserved1;
			public int reserved2;
			public int reserved3;
			public int reserved4;
			public int reserved5;
			public int reserved6;
			public int reserved7;
			public int reserved8;
		}
		[DllImport("user32.dll")]
		private static extern IntPtr BeginPaint(IntPtr hWnd,
			[In, Out] ref PAINTSTRUCT lpPaint);

		[DllImport("user32.dll")]
		private static extern bool EndPaint(IntPtr hWnd, ref PAINTSTRUCT lpPaint);

		[DllImport("gdi32.dll")]
		public static extern int SelectClipRgn(IntPtr hDC, IntPtr hRgn);

		[DllImport("user32.dll")]
		public static extern int GetUpdateRgn(IntPtr hwnd, IntPtr hrgn, bool fErase);
		public enum RegionFlags
		{
			ERROR = 0,
			NULLREGION = 1,
			SIMPLEREGION = 2,
			COMPLEXREGION = 3,
		}
		[DllImport("gdi32.dll")]
		internal static extern bool DeleteObject(IntPtr hObject);

		[DllImport("gdi32.dll")]
		private static extern IntPtr CreateRectRgn(int x1, int y1, int x2, int y2);
	}


	
}