using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EncoDeco
{
	public partial class MainForm : Form
	{
		private class ComboBoxItem
		{
			public int Value { get; set; }
			public String Display { get; set; }
		}

		public MainForm()
		{
			InitializeComponent();
			this.Font = System.Drawing.SystemFonts.IconTitleFont;

			IList<ComboBoxItem> encodings = new List<ComboBoxItem>(9);
			encodings.Add(new ComboBoxItem { Display = "UTF-7", Value = 65000 });
			encodings.Add(new ComboBoxItem { Display = "UTF-8", Value = 65001 });
			encodings.Add(new ComboBoxItem { Display = "UTF-16 LE", Value = 1200 });
			encodings.Add(new ComboBoxItem { Display = "UTF-16 BE", Value = 1201 });
			encodings.Add(new ComboBoxItem { Display = "UTF-32 LE", Value = 12000 });
			encodings.Add(new ComboBoxItem { Display = "UTF-32 BE", Value = 12001 });
			encodings.Add(new ComboBoxItem { Display = "ASCII", Value = 20127 });
			encodings.Add(new ComboBoxItem { Display = "Windows-1252", Value = 1252 });
			encodings.Add(new ComboBoxItem { Display = "ISO-8859-1", Value = 28591 });

			m_inputComboBox.DisplayMember = "Display";
			m_inputComboBox.ValueMember = "Value";
			m_inputComboBox.DataSource = encodings;
			
			m_outputComboBox.DisplayMember = "Display";
			m_outputComboBox.ValueMember = "Value";
			m_outputComboBox.DataSource = new List<ComboBoxItem>(encodings);
		}

		private void InputComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			EncodeDecode();
		}

		private void InputTextBox_TextChanged(object sender, EventArgs e)
		{
			EncodeDecode();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			m_inputComboBox.SelectedValue = 1252;
			m_outputComboBox.SelectedValue = 65001;
		}

		private void OutputComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			EncodeDecode();
		}

		private void EncodeDecode()
		{
			if (m_inputComboBox.SelectedIndex != -1 && m_outputComboBox.SelectedIndex != -1)
			{
				System.Text.Encoding encodingIn = System.Text.Encoding.GetEncoding(Convert.ToInt32(m_inputComboBox.SelectedValue));
				Byte[] bytesIn = encodingIn.GetBytes(m_inputTextBox.Text);

				System.Text.Encoding encodingOut = System.Text.Encoding.GetEncoding(Convert.ToInt32(m_outputComboBox.SelectedValue));
				m_outputTextBox.Text = encodingOut.GetString(bytesIn);
			}
		}
	}
}
