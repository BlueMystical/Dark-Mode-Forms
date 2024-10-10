using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static DarkModeForms.KeyValue;
using Timer = System.Windows.Forms.Timer;

namespace DarkModeForms
{
	/* Author: BlueMystic (bluemystic.play@gmail.com)  2024 */
	public static class Messenger
	{
		#region Events

		/// <summary>Manejador de Eventos para los Click en Botones</summary>
		private static Action<object, ValidateEventArgs> ValidateControlsHandler;

		/// <summary>Validates all Controls and allows to Cancel the changes.</summary>
		public static event Action<object, ValidateEventArgs> ValidateControls
		{
			add => ValidateControlsHandler += value;
			remove => ValidateControlsHandler -= value;
		}

		/// <summary>Previene multiples invocaciones entre llamadas a la misma instancia del evento</summary>
		private static void ResetEvents()
		{
			ValidateControlsHandler = null;
		}

		#endregion Events

		#region MessageBox

		public static DialogResult MessageBox(string Message)
			=> MessageBox(Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

		/// <summary>Shows an Error Message.</summary>
		/// <param name="ex">an Exception error to show</param>
		/// <param name="ShowTrace"></param>
		/// <returns></returns>
		public static DialogResult MessageBox(Exception ex, bool ShowTrace = true) =>
			MessageBox(ex.Message + (ShowTrace ? "\r\n" + ex.StackTrace : ""), "Error!", icon: MessageBoxIcon.Error);

		/// <summary>Displays a message window, also known as a dialog box, which presents a message to the user.</summary>
		/// <param name="Message">The text to display in the message box.</param>
		/// <param name="title">The text to display in the title bar of the message box.</param>
		/// <param name="buttons">One of the MessageBoxButtons values that specifies which buttons to display in the message box.</param>
		/// <param name="icon">One of the 'Base64Icons.MsgIcon' values that specifies which icon to display in the message box.</param>
		/// <returns>It is a modal window, blocking other actions in the application until the user closes it.</returns>
		public static DialogResult MessageBox(
			string Message, string title, MessageBoxButtons buttons = MessageBoxButtons.OK,
			MessageBoxIcon icon = MessageBoxIcon.Information, bool pIsDarkMode = true)
		{
			Debug.WriteLine(icon.ToString());

			MsgIcon Icon = MsgIcon.None;

			/*
			"..In current implementations there are ONLY four unique symbols with multiple values assigned to them."
			https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.messageboxicon?view=netframework-4.8
			*/
			switch (icon)
			{
				case MessageBoxIcon.Information: Icon = MsgIcon.Info; break;
				case MessageBoxIcon.Exclamation: Icon = MsgIcon.Warning; break;
				case MessageBoxIcon.Question: Icon = MsgIcon.Question; break;
				case MessageBoxIcon.Error: Icon = MsgIcon.Error; break;
				case MessageBoxIcon.None:
				default:
					break;
			}

			return MessageBox(Message, title, Icon, buttons, pIsDarkMode);
		}

		public static DialogResult MessageBox(string Message, string title, MessageBoxButtons buttons = MessageBoxButtons.OK,
											  MsgIcon icon = MsgIcon.None, bool pIsDarkMode = true)
		{
			return MessageBox(Message, title, icon, buttons, pIsDarkMode);
		}

		/// <summary>Displays a message window, also known as a dialog box, which presents a message to the user.</summary>
		/// <param name="Message">The text to display in the message box.</param>
		/// <param name="title">The text to display in the title bar of the message box.</param>
		/// <param name="Icon">One of the 'Base64Icons.MsgIcon' values that specifies which icon to display in the message box.</param>
		/// <param name="buttons">One of the MessageBoxButtons values that specifies which buttons to display in the message box.</param>
		/// <returns>It is a modal window, blocking other actions in the application until the user closes it.</returns>
		public static DialogResult MessageBox(
			string Message, string title, MsgIcon Icon,
			MessageBoxButtons buttons = MessageBoxButtons.OK, bool pIsDarkMode = true)
		{
			Form form = new Form
			{
				FormBorderStyle = FormBorderStyle.FixedDialog,
				StartPosition = FormStartPosition.CenterParent,
				MaximizeBox = false,
				MinimizeBox = false,
				Text = title,
				Width = 340,
				Height = 170
			};

			DarkModeCS DMode = new DarkModeCS(form);
			DMode.ApplyTheme(pIsDarkMode);

			Base64Icons _Icons = new Base64Icons();

			Font systemFont = SystemFonts.DefaultFont;
			int fontHeight = systemFont.Height;

			#region Bottom Panel & Buttons

			Panel bottomPanel = new Panel
			{
				Dock = DockStyle.Bottom,
				Height = 48,
				BackColor = DMode.OScolors.Surface,
				ForeColor = DMode.OScolors.TextActive
			};
			form.Controls.Add(bottomPanel);

			string CurrentLanguage = GetCurrentLanguage();
			var ButtonTranslations = GetButtonTranslations(CurrentLanguage); //<- "OK|Cancel|Yes|No|Continue|Retry|Abort"

			List<Button> CmdButtons = new List<Button>();
			switch (buttons)
			{
				case MessageBoxButtons.OK:
					CmdButtons.Add(new Button
					{
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.OK,
						Text = ButtonTranslations["OK"],
						Height = fontHeight + 10,
					});
					form.AcceptButton = CmdButtons[0];
					break;

				case MessageBoxButtons.OKCancel:
					CmdButtons.Add(new Button
					{
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.OK,
						Text = ButtonTranslations["OK"],
						Height = fontHeight + 10,
					});
					var xx = CmdButtons[CmdButtons.Count - 1].Height;
					CmdButtons.Add(new Button
					{
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.Cancel,
						Text = ButtonTranslations["Cancel"]
					});
					form.AcceptButton = CmdButtons[0];
					form.CancelButton = CmdButtons[1];
					break;

				case MessageBoxButtons.AbortRetryIgnore:
					CmdButtons.Add(new Button
					{
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.Retry,
						Text = ButtonTranslations["Retry"]
					});
					CmdButtons.Add(new Button
					{
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.Abort,
						Text = ButtonTranslations["Abort"]
					});
					form.AcceptButton = CmdButtons[0];
					form.CancelButton = CmdButtons[1];
					break;

				case MessageBoxButtons.YesNoCancel:
					CmdButtons.Add(new Button
					{
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.Yes,
						Text = ButtonTranslations["Yes"]
					});
					CmdButtons.Add(new Button
					{
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.No,
						Text = ButtonTranslations["No"]
					});
					CmdButtons.Add(new Button
					{
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.Cancel,
						Text = ButtonTranslations["Cancel"]
					});
					form.AcceptButton = CmdButtons[0];
					form.CancelButton = CmdButtons[2];
					break;

				case MessageBoxButtons.YesNo:
					CmdButtons.Add(new Button
					{
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.Yes,
						Text = ButtonTranslations["Yes"]
					});
					CmdButtons.Add(new Button
					{
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.No,
						Text = ButtonTranslations["No"]
					});
					form.AcceptButton = CmdButtons[0];
					form.CancelButton = CmdButtons[1];
					break;

				case MessageBoxButtons.RetryCancel:
					CmdButtons.Add(new Button
					{
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.Retry,
						Text = ButtonTranslations["Retry"]
					});
					CmdButtons.Add(new Button
					{
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.Cancel,
						Text = ButtonTranslations["Cancel"]
					});
					form.AcceptButton = CmdButtons[0];
					form.CancelButton = CmdButtons[1];
					break;
					/*
					case MessageBoxButtons.CancelTryContinue:
					  CmdButtons.Add(new Button()
					  {
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.Cancel,
						Text = ButtonTranslations["Cancel"]
					  });
					  CmdButtons.Add(new Button()
					  {
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.Continue,
						Text = ButtonTranslations["Continue"]
					  });
					  form.AcceptButton = CmdButtons[0];
					  form.CancelButton = CmdButtons[1];
					  break;
					*/
			}

			int Padding = 4;
			int LastPos = form.ClientSize.Width;

			systemFont = SystemFonts.MessageBoxFont;
			

			foreach (var _button in CmdButtons)
			{
				_button.FlatAppearance.BorderColor = (form.AcceptButton == _button) ? DMode.OScolors.Accent : DMode.OScolors.Control;
				bottomPanel.Controls.Add(_button);

				_button.Font = systemFont;

				// Measure the width of the button text
				using (Graphics g = form.CreateGraphics())
				{
					SizeF textSize = g.MeasureString(_button.Text, systemFont);
					_button.Size = new Size((int)textSize.Width + 20, systemFont.Height + 10); // Adding some padding
				}

				_button.Location = new Point(LastPos - (_button.Width + Padding), (bottomPanel.Height - _button.Height) / 2);
				LastPos = _button.Left;
			}

			#endregion Bottom Panel & Buttons

			#region Icon

			Rectangle picBox = new Rectangle(2, 10, 0, 0);
			if (Icon != MsgIcon.None)
			{
				PictureBox picIcon = new PictureBox { SizeMode = PictureBoxSizeMode.Zoom, Size = new Size(64, 64) };
				picIcon.Image = _Icons.GetIcon(Icon);
				form.Controls.Add(picIcon);

				picBox.Size = new Size(64, 64);
				picIcon.SetBounds(picBox.X, picBox.Y, picBox.Width, picBox.Height);
				picIcon.BringToFront();
			}

			#endregion Icon

			#region Prompt Text

			Label lblPrompt = new Label
			{
				Text = Message,
				AutoSize = true,
				//BackColor = Color.Fuchsia,
				ForeColor = DMode.OScolors.TextActive,
				TextAlign = ContentAlignment.MiddleCenter,
				Location = new Point(picBox.X + picBox.Width + 4, picBox.Y),
				MaximumSize = new Size(form.ClientSize.Width - (picBox.X + picBox.Width) + 8, 0),
				MinimumSize = new Size(form.ClientSize.Width - (picBox.X + picBox.Width) + 8, 64)
			};
			lblPrompt.BringToFront();
			form.Controls.Add(lblPrompt);

			#endregion Prompt Text

			form.ClientSize = new Size(340,
				bottomPanel.Height +
				lblPrompt.Height +
				20
			);

			return form.ShowDialog();
		}

		#endregion MessageBox

		#region InputBox

		/// <summary>Muestra un mensaje en un cuadro de diálogo, solicitando al usuario el ingreso de datos varios.</summary>
		/// <example>Modo de Uso del <see cref="InputBox"/> method.
		/// <code>
		///  List<KeyValue> props = new List<KeyValue>
		///  {
		///    new KeyValue("[FieldName]", "[Default Value]", KeyValue.ValueTypes.String),
		///  };
		/// if (Util.InputBox("[WindowTitle]", "[Prompt]", ref props, Base64Icons.MsgIcon.Edit) == DialogResult.OK)
		/// {
		///    Console.WriteLine(props[0].Value);
		/// }
		/// </code>
		/// </example>
		/// <param name="title">Expresión de tipo String que se muestra en la barra de título del cuadro de diálogo.</param>
		/// <param name="promptText">Expresión de tipo String que se muestra como mensaje en el cuadro de diálogo.</param>
		/// <param name="Fields">[REFERENCIA] Campos de tipo 'KeyValue' que el usuario puede cambiar.</param>
		/// <param name="Icon">Icon to Show in the lower left corner</param>
		/// <param name="buttons">[OPTIONAL] Texts for Buttons. Used for Translations. Default: 'OK|Cancel|Yes|No|Continue'</param>
		/// <returns>OK si el usuario acepta. By BlueMystic @2024</returns>
		public static DialogResult InputBox(
			string title, string promptText, ref List<KeyValue> Fields,
			MsgIcon Icon = 0, MessageBoxButtons buttons = MessageBoxButtons.OK, bool pIsDarkMode = true)
		{
			Form form = new Form
			{
				FormBorderStyle = FormBorderStyle.FixedDialog,
				StartPosition = FormStartPosition.CenterParent,
				MaximizeBox = false,
				MinimizeBox = false,
				Text = title,
				Width = 340,
				Height = 170
			};

			DarkModeCS DMode = new DarkModeCS(form);
			DMode.ApplyTheme(pIsDarkMode);

			// Error Management & Icon Library:
			ErrorProvider Err = new ErrorProvider();
			Base64Icons _Icons = new Base64Icons();

			#region Bottom Panel

			Panel bottomPanel = new Panel
			{
				Dock = DockStyle.Bottom,
				Height = 48,
				BackColor = DMode.OScolors.Surface,
				ForeColor = DMode.OScolors.TextActive
			};
			form.Controls.Add(bottomPanel);

			#endregion Bottom Panel

			#region Icon

			if (Icon != MsgIcon.None)
			{
				PictureBox picIcon = new PictureBox { SizeMode = PictureBoxSizeMode.Zoom, Size = new Size(48, 48) };
				picIcon.Image = _Icons.GetIcon(Icon);
				bottomPanel.Controls.Add(picIcon);

				picIcon.SetBounds(0, 2, 48, 48);
				picIcon.BringToFront();
			}

			#endregion Icon

			#region Buttons

			string CurrentLanguage = GetCurrentLanguage();
			var ButtonTranslations = GetButtonTranslations(CurrentLanguage); //<- "OK|Cancel|Yes|No|Continue|Retry|Abort"

			List<Button> CmdButtons = new List<Button>();
			switch (buttons)
			{
				case MessageBoxButtons.OK:
					CmdButtons.Add(new Button
					{
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.OK,
						Text = ButtonTranslations["OK"]
					});
					form.AcceptButton = CmdButtons[0];
					break;

				case MessageBoxButtons.OKCancel:
					CmdButtons.Add(new Button
					{
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.OK,
						Text = ButtonTranslations["OK"]
					});
					CmdButtons.Add(new Button
					{
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.Cancel,
						Text = ButtonTranslations["Cancel"]
					});
					form.AcceptButton = CmdButtons[0];
					form.CancelButton = CmdButtons[1];
					break;

				case MessageBoxButtons.AbortRetryIgnore:
					CmdButtons.Add(new Button
					{
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.Retry,
						Text = ButtonTranslations["Retry"]
					});
					CmdButtons.Add(new Button
					{
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.Abort,
						Text = ButtonTranslations["Abort"]
					});
					form.AcceptButton = CmdButtons[0];
					form.CancelButton = CmdButtons[1];
					break;

				case MessageBoxButtons.YesNoCancel:
					CmdButtons.Add(new Button
					{
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.Yes,
						Text = ButtonTranslations["Yes"]
					});
					CmdButtons.Add(new Button
					{
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.No,
						Text = ButtonTranslations["No"]
					});
					CmdButtons.Add(new Button
					{
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.Cancel,
						Text = ButtonTranslations["Cancel"]
					});
					form.AcceptButton = CmdButtons[0];
					form.CancelButton = CmdButtons[2];
					break;

				case MessageBoxButtons.YesNo:
					CmdButtons.Add(new Button
					{
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.Yes,
						Text = ButtonTranslations["Yes"]
					});
					CmdButtons.Add(new Button
					{
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.No,
						Text = ButtonTranslations["No"]
					});
					form.AcceptButton = CmdButtons[0];
					form.CancelButton = CmdButtons[1];
					break;

				case MessageBoxButtons.RetryCancel:
					CmdButtons.Add(new Button
					{
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.Retry,
						Text = ButtonTranslations["Retry"]
					});
					CmdButtons.Add(new Button
					{
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.Cancel,
						Text = ButtonTranslations["Cancel"]
					});
					form.AcceptButton = CmdButtons[0];
					form.CancelButton = CmdButtons[1];
					break;
					/*
					case MessageBoxButtons.CancelTryContinue:
					  CmdButtons.Add(new Button()
					  {
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.Cancel,
						Text = ButtonTranslations["Cancel"]
					  });
					  CmdButtons.Add(new Button()
					  {
						Anchor = AnchorStyles.Top | AnchorStyles.Right,
						DialogResult = DialogResult.Continue,
						Text = ButtonTranslations["Continue"]
					  });
					  form.AcceptButton = CmdButtons[0];
					  form.CancelButton = CmdButtons[1];
					  break;
					*/
			}

			int Padding = 4;
			int LastPos = form.ClientSize.Width;

			foreach (var _button in CmdButtons)
			{
				_button.FlatAppearance.BorderColor = (form.AcceptButton == _button) ? DMode.OScolors.Accent : DMode.OScolors.Control;
				bottomPanel.Controls.Add(_button);

				_button.Location = new Point(LastPos - (_button.Width + Padding), (bottomPanel.Height - _button.Height) / 2);
				LastPos = _button.Left;

				//if (_button == form.AcceptButton)
				//{
				//_button.Click += (s, e) =>
				//{
				//  CancelEventArgs args = new CancelEventArgs();
				//  ValidateControls(null, args);

				//  //2.  If the Client cancelled the change, revert to the previous value:
				//  if (args.Cancel) {  }
				//};
				//}
			}

			#endregion Buttons

			#region Prompt Text
			
			Label lblPrompt = new Label();
			if (!string.IsNullOrWhiteSpace(promptText))
			{
				lblPrompt.Dock = DockStyle.Top;
				lblPrompt.Text = promptText; //Font = new Font(form.Font, FontStyle.Bold),
				lblPrompt.AutoSize = false;
				lblPrompt.Height = 24;
				lblPrompt.TextAlign = ContentAlignment.MiddleCenter;
			}
			else
			{
				lblPrompt.Location = new Point(0, 0);
				lblPrompt.Width = 0;
				lblPrompt.Height = 0;
			}
			form.Controls.Add(lblPrompt);

			#endregion Prompt Text

			#region Controls for KeyValues

			TableLayoutPanel Contenedor = new TableLayoutPanel
			{
				Size = new Size(form.ClientSize.Width - 20, 50),
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				BackColor = DMode.OScolors.Background,
				AutoSize = true,
				ColumnCount = 2,
				Location = new Point(10, lblPrompt.Location.Y + lblPrompt.Height + 4)
			};
			form.Controls.Add(Contenedor);
			Contenedor.ColumnStyles.Clear();
			Contenedor.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			Contenedor.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
			Contenedor.ColumnStyles[1].Width = form.ClientSize.Width - 120;
			Contenedor.RowStyles.Clear();

			int ChangeDelayMS = 1000; //<- Delay for Change event in Miliseconds
			int currentRow = 0;
			foreach (KeyValue field in Fields)
			{
				// Create Label and TextBox controls
				Label field_label = new Label
				{
					Text = field.Key,
					AutoSize = false,
					Dock = DockStyle.Fill,
					TextAlign = ContentAlignment.MiddleCenter
				};
				Control field_Control = null;

				BorderStyle BStyle = (DMode.IsDarkMode ? BorderStyle.FixedSingle : BorderStyle.Fixed3D);

				if (field.ValueType == ValueTypes.String)
				{
					field_Control = new TextBox
					{
						Text = field.Value,
						Dock = DockStyle.Fill,
						TextAlign = HorizontalAlignment.Center
					};
					((TextBox)field_Control).TextChanged += (sender, args) =>
					{
						AddTextChangedDelay((TextBox)field_Control, ChangeDelayMS, text =>
						{
							field.Value = ((TextBox)sender).Text;

							//aqui 'KeyValue' valida el nuevo valor y puede cancelarlo
							((TextBox)sender).Text = Convert.ToString(field.Value);
							Err.SetError(field_Control, field.ErrorText);
						});
					};
				}
				if (field.ValueType == ValueTypes.Multiline)
				{
					field_Control = new TextBox
					{
						Text = field.Value,
						Dock = DockStyle.Fill,
						TextAlign = HorizontalAlignment.Left,
						Multiline = true,
						ScrollBars = ScrollBars.Vertical
					};
					((TextBox)field_Control).TextChanged += (sender, args) =>
					{
						AddTextChangedDelay((TextBox)field_Control, ChangeDelayMS, text =>
						{
							field.Value = ((TextBox)sender).Text;

							//aqui 'KeyValue' valida el nuevo valor y puede cancelarlo
							((TextBox)sender).Text = Convert.ToString(field.Value);
							Err.SetError(field_Control, field.ErrorText);
						});
					};
				}
				if (field.ValueType == ValueTypes.Password)
				{
					field_Control = new TextBox
					{
						Text = field.Value,
						Dock = DockStyle.Fill,
						UseSystemPasswordChar = true,
						TextAlign = HorizontalAlignment.Center
					};
					((TextBox)field_Control).TextChanged += (sender, args) =>
					{
						AddTextChangedDelay((TextBox)field_Control, ChangeDelayMS, text =>
						{
							field.Value = ((TextBox)sender).Text;

							//aqui 'KeyValue' valida el nuevo valor y puede cancelarlo
							((TextBox)sender).Text = Convert.ToString(field.Value);
							Err.SetError(field_Control, field.ErrorText);
						});
					};
				}
				if (field.ValueType == ValueTypes.Integer)
				{
					field_Control = new NumericUpDown
					{
						Minimum = int.MinValue,
						Maximum = int.MaxValue,
						TextAlign = HorizontalAlignment.Center,
						Value = Convert.ToInt32(field.Value),
						ThousandsSeparator = true,
						Dock = DockStyle.Fill,
						DecimalPlaces = 0
					};
					((NumericUpDown)field_Control).ValueChanged += (sender, args) =>
					{
						AddTextChangedDelay((NumericUpDown)field_Control, ChangeDelayMS, text =>
						{
							field.Value = ((NumericUpDown)sender).Value.ToString();

							//aqui 'KeyValue' valida el nuevo valor y puede cancelarlo
							((NumericUpDown)sender).Value = Convert.ToInt32(field.Value);
							Err.SetError(field_Control, field.ErrorText);
						});
					};
				}
				if (field.ValueType == ValueTypes.Decimal)
				{
					field_Control = new NumericUpDown
					{
						Minimum = int.MinValue,
						Maximum = int.MaxValue,
						TextAlign = HorizontalAlignment.Center,
						Value = Convert.ToDecimal(field.Value),
						ThousandsSeparator = false,
						Dock = DockStyle.Fill,
						DecimalPlaces = 2
					};
					((NumericUpDown)field_Control).ValueChanged += (sender, args) =>
					{
						AddTextChangedDelay((NumericUpDown)field_Control, ChangeDelayMS, text =>
						{
							field.Value = ((NumericUpDown)sender).Value.ToString();

							//aqui 'KeyValue' valida el nuevo valor y puede cancelarlo
							((NumericUpDown)sender).Value = Convert.ToDecimal(field.Value);
							Err.SetError(field_Control, field.ErrorText);
						});
					};
				}
				if (field.ValueType == ValueTypes.Date)
				{
					field_Control = new DateTimePicker
					{
						Value = Convert.ToDateTime(field.Value),
						Dock = DockStyle.Fill,
						Format = DateTimePickerFormat.Short,

						CalendarForeColor = DMode.OScolors.TextActive,
						CalendarMonthBackground = DMode.OScolors.Control,
						CalendarTitleBackColor = DMode.OScolors.Surface,
						CalendarTitleForeColor = DMode.OScolors.TextActive
					};
					((DateTimePicker)field_Control).ValueChanged += (sender, args) =>
					{
						field.Value = ((DateTimePicker)sender).Value.ToString();
						//aqui 'KeyValue' valida el nuevo valor y puede cancelarlo
						((DateTimePicker)sender).Value = Convert.ToDateTime(field.Value);
						Err.SetError(field_Control, field.ErrorText);
						Err.SetIconAlignment(field_Control, ErrorIconAlignment.MiddleLeft);
					};
				}
				if (field.ValueType == ValueTypes.Time)
				{
					field_Control = new DateTimePicker
					{
						Value = Convert.ToDateTime(field.Value),
						Dock = DockStyle.Fill,
						Format = DateTimePickerFormat.Time
					};
					((DateTimePicker)field_Control).ValueChanged += (sender, args) =>
					{
						field.Value = ((DateTimePicker)sender).Value.ToString();
						//aqui 'KeyValue' valida el nuevo valor y puede cancelarlo
						((DateTimePicker)sender).Value = Convert.ToDateTime(field.Value);
						Err.SetError(field_Control, field.ErrorText);
						Err.SetIconAlignment(field_Control, ErrorIconAlignment.MiddleLeft);
					};
				}
				if (field.ValueType == ValueTypes.Boolean)
				{
					field_Control = new CheckBox
					{
						Checked = Convert.ToBoolean(field.Value),
						Dock = DockStyle.Fill,
						Text = field.Key
					};
					((CheckBox)field_Control).CheckedChanged += (sender, args) =>
					{
						field.Value = ((CheckBox)sender).Checked.ToString();
						//aqui 'KeyValue' valida el nuevo valor y puede cancelarlo

						((CheckBox)sender).Checked = Convert.ToBoolean(field.Value);
						Err.SetError(field_Control, field.ErrorText);
					};
				}
				if (field.ValueType == ValueTypes.Dynamic)
				{
					field_Control = new FlatComboBox
					{
						DataSource = field.DataSet,
						ValueMember = "Value",
						DisplayMember = "Key",
						Dock = DockStyle.Fill,
						BackColor = DMode.OScolors.Control,
						ButtonColor = DMode.OScolors.Surface,
						ForeColor = DMode.OScolors.TextActive,
						SelectedValue = field.Value,
						DropDownStyle = ComboBoxStyle.DropDownList,
						FlatStyle = (DMode.IsDarkMode ? FlatStyle.Flat : FlatStyle.Standard)
					};

					((ComboBox)field_Control).SelectedValueChanged += (sender, args) =>
					{
						field.Value = ((ComboBox)sender).SelectedValue.ToString();

						//aqui 'KeyValue' valida el nuevo valor y puede cancelarlo, o mostrar error
						((ComboBox)sender).SelectedValue = Convert.ToString(field.Value);
						Err.SetError(field_Control, field.ErrorText);
					};
				}

				// Add controls to appropriate cells:
				Contenedor.Controls.Add(field_label, 0, currentRow); // Column 0 for labels
				if (field.ValueType == ValueTypes.Multiline)
				{
					Contenedor.Controls.Add(field_Control, 1, currentRow);
					const int spanRow = 6;
					for (int i = 0; i < spanRow; i++)
					{
						currentRow++;
						Contenedor.RowCount++;
						Contenedor.RowStyles.Add(new RowStyle(SizeType.Absolute, field_Control.Height));
					}
					Contenedor.SetRowSpan(field_Control, spanRow);
				}
				else
				{
					Contenedor.Controls.Add(field_Control, 1, currentRow); // Column 1 for text boxes
				}

				Err.SetIconAlignment(field_Control, ErrorIconAlignment.MiddleLeft);

				//Fix for ComboBox Null SelectedValue:
				if (field_Control is ComboBox)
				{
					((ComboBox)field_Control).CreateControl();
					((ComboBox)field_Control).SelectedValue = field.Value;
				}

				field_Control.TabIndex = currentRow;

				// Increment row index for the next pair
				currentRow++;
			}

			Contenedor.Width = form.ClientSize.Width - 20;

			#endregion Controls for KeyValues

			form.ClientSize = new Size(340,
				bottomPanel.Height +
				lblPrompt.Height +
				Contenedor.Height +
				20
			);
			form.FormClosing += (sender, e) =>
			{
				//Control Validations
				if (form.ActiveControl == form.AcceptButton)
				{
					ValidateEventArgs cArgs = new ValidateEventArgs(null);

					ValidateControlsHandler?.Invoke(form, cArgs); //<- Dispara el Evento

					e.Cancel = cArgs.Cancel;
					if (!e.Cancel)
					{
						form.DialogResult = form.AcceptButton.DialogResult;
					}
					//ResetEvents(); //<- Previene multiples llamadas
				}
			};

			return form.ShowDialog();
		}

		#endregion InputBox

		#region Private Stuff

		private static Dictionary<Control, Timer> timers;

		private static void AddTextChangedDelay<TControl>(TControl control, int milliseconds, Action<TControl> action) where TControl : Control
		{
			if (timers == null)
			{
				timers = new Dictionary<Control, Timer>();
			}

			if (timers.ContainsKey(control))
			{
				timers[control].Stop();
				timers.Remove(control);
			}

			var timer = new Timer();
			timer.Interval = milliseconds;
			timer.Tick += (sender, e) =>
			{
				timer.Stop();
				timers.Remove(control);
				action(control);
			};
			timer.Start();
			timers.Add(control, timer);
		}

		/// <summary>Returns the Current Language ID of the PC.</summary>
		/// <param name="pDefault">Default to return if Current lang is not supported.</param>
		public static string GetCurrentLanguage(string pDefault = "en")
		{
			string _ret = pDefault;
			string CurrentLanguage = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
			if (IsCurrentLanguageSupported(new List<string> { "en", "es", "fr", "de", "ru", "ko" }, CurrentLanguage))
			{
				_ret = CurrentLanguage;
			}
			if (CurrentLanguage.ToLowerInvariant().Equals("zh"))
			{
				var LangVariable = CultureInfo.CurrentCulture.Name;
				if (string.Equals(LangVariable, "zh-CN") || string.Equals(LangVariable, "zh-SG") || string.Equals(LangVariable, "zh-Hans"))
				{
					_ret = "zh-Hans";
				}
				else if (string.Equals(LangVariable, "zh-TW") || string.Equals(LangVariable, "zh-HK") || string.Equals(LangVariable, "zh-MO") || string.Equals(LangVariable, "zh-Hant"))
				{
					_ret = "zh-Hant";
				}
				else
				{
					_ret = "zh-Hans";
				}
			}
			return _ret;
		}

		/// <summary>Return the Translations for the desired language (if supported).</summary>
		/// <param name="pLanguage">Supported Languages: [en, es, fr, de, ru, ko]</param>
		/// <returns>Keys: OK, Cancel, Yes, No, Continue, Retry, Abort</returns>
		private static Dictionary<string, string> GetButtonTranslations(string pLanguage)
		{
			Dictionary<string, string> _ret = null;

			Dictionary<string, string> ButtonTranslations = new Dictionary<string, string> {
				{ "en", "OK|Cancel|Yes|No|Continue|Retry|Abort|Ignore" },
				{ "es", "Aceptar|Cancelar|Sí|No|Continuar|Reintentar|Abortar|Ignorar" },
				{ "fr", "Accepter|Annuler|Oui|Non|Continuer|Réessayer|Abandonner|Ignorer" },
				{ "de", "Akzeptieren|Abbrechen|Ja|Nein|Weiter|Wiederholen|Abbrechen|Ignorieren"},
				{ "ru", "Принять|Отменить|Да|Нет|Продолжить|Повторить|Прервать|Игнорировать" },
				{ "ko", "확인|취소|예|아니오|계속|다시 시도|중단|무시" },
				{ "zh-Hans", "确定|取消|是|否|继续|重试|中止|忽略" },
				{ "zh-Hant", "確定|取消|是|否|繼續|重試|中止|忽略" }
				/* Add here you own language button translations */
			  };

			string raw = ButtonTranslations[pLanguage];
			if (!string.IsNullOrEmpty(raw))
			{
				var Words = raw.Split('|').ToList();

				_ret = new Dictionary<string, string> {
					{ "OK", Words[0] },
					{ "Cancel", Words[1] },
					{ "Yes", Words[2] },
					{ "No", Words[3] },
					{ "Continue", Words[4] },
					{ "Retry", Words[5] },
					{ "Abort", Words[6] },
					{ "Ignore", Words[7] }
				};
			}

			return _ret;
		}

		private static bool IsCurrentLanguageSupported(List<string> languages, string currentLanguage)
		{
			if (languages == null || currentLanguage == null)
			{
				throw new ArgumentNullException(languages == null ? nameof(languages) : nameof(currentLanguage));
			}

			// Convert both languages to lowercase for case-insensitive comparison
			currentLanguage = currentLanguage.ToLowerInvariant();

			// Check if the current language is directly present in the list
			if (languages.Contains(currentLanguage))
			{
				return true;
			}

			// Handle alternative language codes (e.g., "pt-BR" for Brazilian Portuguese)
			if (currentLanguage.Length >= 2)
			{
				string baseLanguage = currentLanguage.Substring(0, 2);
				return languages.Contains(baseLanguage);
			}

			return false;
		}

		#endregion Private Stuff
	}

	/// <summary>Constants for the Default Icons.</summary>
	public enum MsgIcon
	{
		None = 0,
		Info,
		Success,
		Warning,
		Error,
		Question,
		Lock,
		User,
		Forbidden,
		AddNew,
		Cancel,
		Edit,
		List
	}

	/// <summary>Stores Data for Dynamic Fields on the InputBox Dialog.</summary>
	public class KeyValue
	{
		#region Private Members

		private string _value;

		#endregion Private Members

		#region Contructors

		public KeyValue()
		{
		}

		public KeyValue(string pKey, string pValue, ValueTypes pType = 0, List<KeyValue> pDataSet = null)
		{
			Key = pKey;
			Value = pValue;
			ValueType = pType;
			DataSet = pDataSet;
		}

		#endregion Contructors

		#region Public Properties

		/// <summary>Types of Data acepted by this class.</summary>
		public enum ValueTypes
		{
			String = 0,
			Integer = 1,
			Decimal = 2,
			Date = 3,
			Time,
			Boolean,
			Dynamic,
			Password,
			Multiline
		}

		public string Key { get; set; }

		public string Value
		{
			get => _value;
			set
			{
				var newValue = value;

				//1. We Raize the 'Validate' Event to the Client informing both the
				//   New and Old Values for Client Side Validation:
				OnValidate(ref newValue); //<- Validate can Cancel the new Value

				if (_value != newValue)
				{
					_value = newValue;
				}
			}
		}

		/// <summary>Tipo de datos para el Control.</summary>
		public ValueTypes ValueType { get; set; } = ValueTypes.String;

		/// <summary>[OPTIONAL] Data for when 'ValueType' is 'Dynamic'.</summary>
		public List<KeyValue> DataSet { get; set; }

		/// <summary>[OPTIONAL] If this is not Empty, an Error icon will show next to the control.</summary>
		public string ErrorText { get; set; } = string.Empty;

		#endregion Public Properties

		#region Public Events

		public class ValidateEventArgs : EventArgs
		{
			public ValidateEventArgs(string newValue)
			{
				NewValue = newValue;
				Cancel = false;
			}

			public string NewValue { get; }
			public string OldValue { get; set; }

			public bool Cancel { get; set; }
			public string ErrorText { get; set; } = string.Empty;
		}

		/// <summary>Permite Validar el Valor del Control:
		/// <para>- Puede Cancelar el Cambio.</para>
		/// <para>- Puede Mostrar un Mensaje de error.</para>
		/// </summary>
		public event EventHandler<ValidateEventArgs> Validate;

		protected virtual void OnValidate(ref string newValue)
		{
			var validateHandler = Validate;
			if (validateHandler != null)
			{
				//1. We Raize the 'Validate' Event to the Client informing both the
				//   New and Old Values for Client Side Validation:
				var args = new ValidateEventArgs(newValue) { OldValue = _value };
				validateHandler(this, args);

				//2.  If the Client cancelled the change, revert to the previous value:
				if (args.Cancel) { newValue = _value; }

				//3. The Client may chose to show an Error Text:
				ErrorText = args.ErrorText;
			}
		}

		#endregion Public Events

		#region Public Methods

		public override string ToString()
		{
			return string.Format("{0} - {1}", Key, Value);
		}

		#endregion Public Methods
	}

	/// <summary>For Images in Base64 format</summary>
	public class Base64Image
	{
		public Base64Image()
		{
		}

		public Base64Image(string pName, string pBase64Data)
		{
			Name = pName;
			Base64Data = pBase64Data;
		}

		public string Name { get; set; }
		public string Base64Data { get; set; }

		public Image Image
		{
			get
			{
				if (string.IsNullOrEmpty(Base64Data)) return null;
				return Image.FromStream(new MemoryStream(Convert.FromBase64String(Base64Data)));
			}
		}
	}

	/// <summary>Collection of Static Icons for General Purposes.
	/// Default Image size is 64x64 px.</summary>
	public class Base64Icons
	{
		private List<Base64Image> _Icons = new List<Base64Image> {
		new Base64Image("Info", "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"),
		new Base64Image("Success", "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"),
		new Base64Image("Warning", "iVBORw0KGgoAAAANSUhEUgAAAEAAAABACAYAAACqaXHeAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsIAAA7CARUoSoAAAARTSURBVHhe7Zs9TBRBGIZn9uRHMFlPw18kEWmwNNpQERIaadTERipMIAehEUq10UJaYgPchYaKRgtssDFa0oil2qAmJB4Q5c6IwsHt+O3xzXHL3e7tz8zcEvdp9vt2yXHzvu/Ozi4LiYiI+K+huFVOevxCj8aMXsJID3yLDYOxtb/759euLH7L4Y8oQakAX4Yv1zc1/LpFKRuCtv5obxkrdXtsMb6Y3cVeKhpuldDckJ2AwQ9DaTd4k8GDRjq9M6w3Yy8VZQnYSpyfhN82gK0b1iEJj2QnQUkC0on4oMfBm3QfNtIJrKUhXQDzvNdI4Zy3Yx23ZTBC+jZH9W5spSBdgLMNGdP9OLbHMLKVJ2ykNZl5sLun34U9748OWKEx6iReYKQKcOQ+NQd3klyesocdyeyW2ZiXPhBhGspKaeiVmQKpAti5DzPvCh88xxQB1gJL2FqQmQJpAji5b8TqXmJtoT2VXYWN0hRIE8DJ/bbZ7R1sy1CdAikC+HGfozoFUgTw6z5HZQqECxDEfY7KFAgXIKj7HFUpECqACPc5qlIgVABR7nNUpECYAH7c/z6md22P6f3g6DXcZUFFCoQJ4NX9dEK/EyPkIyP0LTj6AfpJPGRBdgqECODHfY3RGRhGI7ZEo3Rmc6KlHdsislMgRACv7hcGqpEubIto+dxVLC3ITEFgAfy4b+RzRefdIDMFgQUQPfPbISsFgQQQed2vhqwUBBJAlfscGSnwLYBK9zkyUuBbANXuc0SnwJcAtXCfIzoFvgSolfsckSnwLEAt3eeITIFnAWrtPkdUCjwJIMr9jmT2KyFsD9tj2Jk0VlURlQJPAoh0nxI6j2UBZpB3Lakfn7B1hYgUuBZA9LnfksxM5Q06xAh7CgOZ+pPTB/GQa0SkAMxzB9yv34Zb1lFsi8AHLMNgFrBVDnyvXvhej7EtZbU1mXmGtS2uEhCGmd+OoClwJYCsmT+diI9vJ/Ql82kQiOzpFrmUIHNBVQFkub81ps9plM0xSu+ZT4Oa6rMreMgzQVJQVQCJ1/37uC1ANdK/nbhY8YmQG/ymwFGAMJ/7J/GbAkcBZK76RKwDTuInBY4CUEpvYlmKEPdFrANO4piCiZYyI01s1wFmbEC559gWqfV1vxp26wIQeQEEWsa2iG0CDKp1YmmFxV5jFUoKKWDE8vqNCYhyCUsLtgJomlGHpYXf++fKPjyElM9PrPLbqbYCMBrbwNICTIzXsQwlhXOdkh5sizBCK47HVoD2+Z+fGSFlr6nCxDi5mYjfwDZUFOat/METbK0YxhpWFmwnQRMf7/eGE5gTWlOZEewsOF4GmcFewUbp+/syMAh9gWUZjgK0LWTX4To9i+3phJE37akd2/sMx1OAszmmD8DKreLf70POSmsy42igKwFM4Ealk9A8rNxIH+4KL4zABE6X2lI7FV/ALsW1ABzzPzkOG4nrh46qMWL1GyqfTkdERERERJxaCPkHHh0ri7CaA0wAAAAASUVORK5CYII="),
		new Base64Image("Error", "iVBORw0KGgoAAAANSUhEUgAAAEAAAABACAYAAACqaXHeAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAALKSURBVHhe7Zq/b9QwFMftWJX6J9zYqsDc/4Bjazc6AdvdVka2MsHGSidua5lgq9hgY+wGGyCoujJ27HCxea95lq700vjX8w19HymKfZHO+X5ix5eLlSAIgiAIgiAIgnAH0bSP5lypdWvMgXLuIVQvrdaH99v2c3eUn19ra9vG2icQYOSc+3LP2o90qA5nTfPtzBj33/aODrMCbR8safsDHY6ioX0Uf5pmX2m9TdVF9uFEjqjMAnz/a2j7DVUXefrbmMdUDiZJgNZ6RMVlTLgkXIVX6lVXuwmEweEYRZIAGPeXVOqjuISh8IiDexEVg0kS0Fg7g8b+UrWPYhJCw5u2fU/VYJIEbCp1AQ1OA4xnSwgJf4Vzz+G8flItmORpEIGbzg58wQls6/RRH8dbbTulcjCh4WEanMI0eEzVKLIEIFwSaoRHsgUgpSXUCo8UEYCUklAzPFJMAJIroXZ4pKgAJFXCKsIjxQUgsRJWFR5hEYAES3Due89zxTU4wiNsApCInnArXOERVgFIrgTO8Ai7ACRVAnd4pIoAJFZCjfBINQEI3O3xwWjS1W7Bua9b1j6iGitp/wckQFPdcHhE6zHJYqdKDwid55cQ9OyQA7uAjPAeVgmsAgqE97BJYLsHRIR/W+OfpT5YBISGx6kOruwLELC3KgnFh0BM+MV5PuJ3QtHhUFRAanjPKiQUE5Ab3lNbQhEBpcJ7akrIFlA6vKeWhCwBXOE9NSQkT4P4ihp2bOERXG8QMUUmvZpP6gHnSm20xvwYujI54RcJ7QlWqd3YRRpJPcAaM6kVHgntCXBOlV6PD1AyvCdiOESR1gOUOqXiDTjCe4YkWK0/UTGYJAE0zmZdrQNO6gLCP+MK7yEJu7BdX5/g3MsH83nvhekDhk06cHMag8Exlpu2nW0OL5ooBq5Sm0P72rmRsfY0ZW2AIAiCIAiCINxZlPoHSyjC0mAXZloAAAAASUVORK5CYII="),
		new Base64Image("Question", "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"),
		new Base64Image("Lock", "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"),
		new Base64Image("User", "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"),
		new Base64Image("Forbidden", "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"),
		new Base64Image("AddNew", "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"),
		new Base64Image("Cancel", "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"),
		new Base64Image("Edit", "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"),
		new Base64Image("List", "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")
	};

		public List<Base64Image> Icons
		{
			get
			{
				return this._Icons;
			}
			set
			{
				this._Icons = value;
			}
		}

		/// <summary>Returns the Image of the desired Icon, if exists in the Colection.</summary>
		/// <param name="pName">Name of the Icon to look for.</param>
		public Image GetIcon(string pName)
		{
			Image _ret = null;
			if (_Icons != null && _Icons.Count > 0)
			{
				var Found = _Icons.Find(x => x.Name == pName);
				if (Found != null)
				{
					_ret = Found.Image;
				}
			}
			return _ret;
		}

		public Image GetIcon(MsgIcon pIcon) => GetIcon(pIcon.ToString());

		/// <summary>Adds a new Image to the Collection.</summary>
		/// <param name="pName">NAme of the Image</param>
		/// <param name="pFilePath">Full path to the Image File.</param>
		/// <returns>'true' if succes. No Size restrictions for the image.</returns>
		public bool AddIcon(string pName, string pFilePath)
		{
			bool _ret = false;
			if (!string.IsNullOrEmpty(pFilePath) && File.Exists(pFilePath))
			{
				var _icon = File.ReadAllBytes(pFilePath);
				if (_icon != null)
				{
					if (_Icons is null) _Icons = new List<Base64Image>();
					_Icons.Add(new Base64Image(pName, Convert.ToBase64String(_icon)));
					_ret = true;
				}
			}
			return _ret;
		}
	}
}
