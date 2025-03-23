﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BlueMystical.Forms.DarkModeCore
{
	// *** CREDITS:  https://github.com/r-aghaei/FlatComboExample/tree/master

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
				var dropDownRect = new Rectangle(innerBorder.Right + 1, innerBorder.Y - 1,
					dropDownButtonWidth, innerBorder.Height + 2);
				if (RightToLeft == RightToLeft.Yes)
				{
					innerBorder.X = clientRect.Width - innerBorder.Right;
					innerInnerBorder.X = clientRect.Width - innerInnerBorder.Right;
					dropDownRect.X = clientRect.Width - dropDownRect.Right;
					dropDownRect.Width += 1;
				}
				var innerBorderColor = Enabled ? BackColor : SystemColors.Control;
				var outerBorderColor = Enabled ? BorderColor : SystemColors.ControlDark;
				var buttonColor1 = Enabled ? ButtonColor : SystemColors.Control; //renamed from buttonColor so that it cannot be confused with the field of the same name
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

					using (var b = new SolidBrush(buttonColor1))
					{
						g.FillRectangle(b, dropDownRect);
					}

					#endregion DropDown Button

					#region Chevron

					//Replaced 'arrow' triangle with a Windows 11's Chevron:
					//using (var b = new SolidBrush(outerBorderColor))
					//{
					//  g.FillPolygon(b, arrow);
					//}

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

					#endregion Chevron

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

					#endregion Borders
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
