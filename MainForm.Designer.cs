namespace EncoDeco
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.m_inputTextBox = new System.Windows.Forms.TextBox();
			this.m_inputComboBox = new System.Windows.Forms.ComboBox();
			this.m_outputComboBox = new System.Windows.Forms.ComboBox();
			this.m_outputTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Input:";
			// 
			// m_inputTextBox
			// 
			this.m_inputTextBox.Location = new System.Drawing.Point(15, 25);
			this.m_inputTextBox.Name = "m_inputTextBox";
			this.m_inputTextBox.Size = new System.Drawing.Size(194, 20);
			this.m_inputTextBox.TabIndex = 1;
			this.m_inputTextBox.Text = "â€¢";
			this.m_inputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
			// 
			// m_inputComboBox
			// 
			this.m_inputComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.m_inputComboBox.FormattingEnabled = true;
			this.m_inputComboBox.Location = new System.Drawing.Point(215, 25);
			this.m_inputComboBox.Name = "m_inputComboBox";
			this.m_inputComboBox.Size = new System.Drawing.Size(121, 21);
			this.m_inputComboBox.TabIndex = 2;
			this.m_inputComboBox.SelectedIndexChanged += new System.EventHandler(this.InputComboBox_SelectedIndexChanged);
			// 
			// m_outputComboBox
			// 
			this.m_outputComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.m_outputComboBox.FormattingEnabled = true;
			this.m_outputComboBox.Location = new System.Drawing.Point(215, 64);
			this.m_outputComboBox.Name = "m_outputComboBox";
			this.m_outputComboBox.Size = new System.Drawing.Size(121, 21);
			this.m_outputComboBox.TabIndex = 5;
			this.m_outputComboBox.SelectedIndexChanged += new System.EventHandler(this.OutputComboBox_SelectedIndexChanged);
			// 
			// m_outputTextBox
			// 
			this.m_outputTextBox.Location = new System.Drawing.Point(15, 64);
			this.m_outputTextBox.Name = "m_outputTextBox";
			this.m_outputTextBox.ReadOnly = true;
			this.m_outputTextBox.Size = new System.Drawing.Size(194, 20);
			this.m_outputTextBox.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Output:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(351, 102);
			this.Controls.Add(this.m_outputComboBox);
			this.Controls.Add(this.m_outputTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.m_inputComboBox);
			this.Controls.Add(this.m_inputTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "EncoDeco";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox m_inputTextBox;
		private System.Windows.Forms.ComboBox m_inputComboBox;
		private System.Windows.Forms.ComboBox m_outputComboBox;
		private System.Windows.Forms.TextBox m_outputTextBox;
		private System.Windows.Forms.Label label2;
	}
}

