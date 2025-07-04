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

		[Description("Shows a Close Button on each tab"), Category("Appearance")]
		public bool ShowTabCloseButton { get; set; } = true;

		[Description("Color for the Close Button on each tab"), Category("Appearance")]
		public Color TabCloseColor { get; set; }

		#endregion Public Properties


		public FlatTabControl()
		{
			try
			{
				Appearance = TabAppearance.Buttons;
				DrawMode = TabDrawMode.Normal;
				ItemSize = new Size(0, 0);
				SizeMode = TabSizeMode.Fixed;

				PreRemoveTabPage = null;
				this.DrawMode = TabDrawMode.OwnerDrawFixed;
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

			TabCloseColor = this.ForeColor;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			DrawControl(e.Graphics);
		}


		private delegate bool PreRemoveTab(int indx);
		private PreRemoveTab PreRemoveTabPage;
		private bool OverCloseTab = false;

		protected override void OnMouseClick(MouseEventArgs e)
		{
			// Reacts to the Click on the Close Tab Button:
			if (ShowTabCloseButton)
			{
				Point p = e.Location;
				for (int i = 0; i < TabCount; i++)
				{
					Rectangle r = GetTabRect(i);
					r.Offset(6, 8);
					r.Width = 12;
					r.Height = 12;
					if (r.Contains(p))
					{
						CloseTab(i);
					}
				}
			}			
		}
		protected override void OnMouseMove(MouseEventArgs e)
		{
			/* Hightlighs the Close Button when the Mouse is over it  */
			if (ShowTabCloseButton)
			{
				Point p = e.Location;
				for (int i = 0; i < TabCount; i++)
				{
					Rectangle r = GetTabRect(i);
					r.Offset(6, 8);
					r.Width = 12;
					r.Height = 12;

					OverCloseTab = r.Contains(p); //<- Mouse is over the Close button

					if (OverCloseTab)
					{
						DrawTab(this.CreateGraphics(), this.TabPages[i], i);
					}
					else
					{
						if (TabCloseColor == Color.Red)
						{
							DrawTab(this.CreateGraphics(), this.TabPages[i], i);
						}
					}
				}
			}
			//base.OnMouseMove(e);
		}
		private void CloseTab(int i)
		{
			if (PreRemoveTabPage != null)
			{
				bool closeIt = PreRemoveTabPage(i);
				if (!closeIt)
					return;
			}
			TabPages.Remove(TabPages[i]);
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

			// Draws a Close Button:
			if (ShowTabCloseButton)
			{
				Rectangle r = tabTextRect;
				r = GetTabRect(nIndex);
				r.Offset(6, 8); //Vertically Centered
				r.Height = 5;
				r.Width = 5;

				// If Mouse is over the CloseButton, it Draws it in Red, otherwise uses default Color:
				TabCloseColor = OverCloseTab ? Color.Red : this.ForeColor;
				Brush b = new SolidBrush(TabCloseColor);
				Pen p = new Pen(b);

				// Draws an X:
				g.DrawLine(p, r.X, r.Y, r.X + r.Width, r.Y + r.Height);
				g.DrawLine(p, r.X + r.Width, r.Y, r.X, r.Y + r.Height);
			}			

			// Draws the Title of the Tab:
			Rectangle rectangleF = tabTextRect;
			rectangleF.Y += 2; // Horizontally Centered
			TextRenderer.DrawText(g, customTabPage.Text, Font, rectangleF, isSelected ? SelectedForeColor : ForeColor);
		}
	}
}
