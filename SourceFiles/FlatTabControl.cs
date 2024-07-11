using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DarkModeForms
{
	public class FlatTabControl : TabControl
	{
		#region Public Properties

		[Description("Color for a decorative line"), Category("Appearance")]
		public Color LineColor { get; set; } = SystemColors.Highlight;

		[Description("Color for all Borders"), Category("Appearance")]
		public Color BorderColor { get; set; } = SystemColors.ControlDark;

		[Description("Back color for selected Tab"), Category("Appearance")]
		public Color SelectTabColor { get; set; } = SystemColors.ControlLight;

		[Description("Fore Color for Selected Tab"), Category("Appearance")]
		public Color SelectedForeColor { get; set; } = SystemColors.HighlightText;

		[Description("Back Color for un-selected tabs"), Category("Appearance")]
		public Color TabColor { get; set; } = SystemColors.ControlLight;

		[Description("Background color for the whole control"), Category("Appearance"), Browsable(true)]
		public override Color BackColor { get; set; } = SystemColors.Control;

		[Description("Fore Color for all Texts"), Category("Appearance")]
		public override Color ForeColor { get; set; } = SystemColors.ControlText;

		#endregion Public Properties

		public FlatTabControl()
		{
			try
			{
				Appearance = TabAppearance.Buttons;
				DrawMode = TabDrawMode.Normal;
				ItemSize = new Size(0, 0);
				SizeMode = TabSizeMode.Fixed;
			}
			catch { }
		}

		protected override void InitLayout()
		{
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			SetStyle(ControlStyles.DoubleBuffer, true);
			SetStyle(ControlStyles.ResizeRedraw, true);
			SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			SetStyle(ControlStyles.UserPaint, true);
			base.InitLayout();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			DrawControl(e.Graphics);
		}

		internal void DrawControl(Graphics g)
		{
			try
			{
				if (!Visible)
				{
					return;
				}

				Rectangle clientRectangle = ClientRectangle;
				clientRectangle.Inflate(2, 2);

				// Whole Control Background:
				using (Brush bBackColor = new SolidBrush(BackColor))
				{
					g.FillRectangle(bBackColor, ClientRectangle);
				}

				Region region = g.Clip;

				for (int i = 0; i < TabCount; i++)
				{
					DrawTab(g, TabPages[i], i);
					TabPages[i].BackColor = TabColor;
				}

				g.Clip = region;

				using (Pen border = new Pen(BorderColor))
				{
					g.DrawRectangle(border, clientRectangle);

					if (SelectedTab != null)
					{
						clientRectangle.Offset(1, 1);
						clientRectangle.Width -= 2;
						clientRectangle.Height -= 2;
						g.DrawRectangle(border, clientRectangle);
						clientRectangle.Width -= 1;
						clientRectangle.Height -= 1;
						g.DrawRectangle(border, clientRectangle);
					}
				}

				// a decorative line on top of pages:
				//using (Brush bLineColor = new SolidBrush(LineColor))
				//{
				//  Rectangle rectangle = ClientRectangle;
				//  rectangle.Height = 1;
				//  rectangle.Y = 25;
				//  g.FillRectangle(bLineColor, rectangle);

				//  rectangle = ClientRectangle;
				//  rectangle.Height = 1;
				//  rectangle.Y = 26;
				//  g.FillRectangle(bLineColor, rectangle);
				//}
			}
			catch { }
		}

		internal void DrawTab(Graphics g, TabPage customTabPage, int nIndex)
		{
			Rectangle tabRect = GetTabRect(nIndex);
			Rectangle tabTextRect = GetTabRect(nIndex);
			bool isSelected = (SelectedIndex == nIndex);
			Point[] points;

			if (Alignment == TabAlignment.Top)
			{
				points = new[]
				{
					new Point(tabRect.Left+3, tabRect.Bottom),
					new Point(tabRect.Left+3, tabRect.Top + 0),
					new Point(tabRect.Left + 0, tabRect.Top),
					new Point(tabRect.Right - 0, tabRect.Top),
					new Point(tabRect.Right, tabRect.Top + 0),
					new Point(tabRect.Right, tabRect.Bottom),
					new Point(tabRect.Left+3, tabRect.Bottom)
				};
			}
			else
			{
				points = new[]
				{
					new Point(tabRect.Left, tabRect.Top),
					new Point(tabRect.Right, tabRect.Top),
					new Point(tabRect.Right, tabRect.Bottom - 0),
					new Point(tabRect.Right - 0, tabRect.Bottom),
					new Point(tabRect.Left + 0, tabRect.Bottom),
					new Point(tabRect.Left, tabRect.Bottom - 0),
					new Point(tabRect.Left, tabRect.Top)
				};
			}

			// Draws the Tab Header:
			Color HeaderColor = isSelected ? SelectTabColor : BackColor;
			using (Brush brush = new SolidBrush(HeaderColor))
			{
				g.FillPolygon(brush, points);
				g.DrawPolygon(new Pen(HeaderColor), points);

				if (isSelected)
				{
					g.DrawLine(new Pen(BackColor),
						new Point(tabRect.Left, tabRect.Top), new Point(tabRect.Left + 3, tabRect.Top));
					g.DrawLine(new Pen(Color.DodgerBlue),
						new Point(tabRect.Left + 3, tabRect.Top), new Point(tabRect.Left + tabRect.Width, tabRect.Top));
				}
			}

			Rectangle rectangleF = tabTextRect;
			rectangleF.Y += 2;

			TextRenderer.DrawText(g, customTabPage.Text, Font, rectangleF, isSelected ? SelectedForeColor : ForeColor);
		}
	}
}
