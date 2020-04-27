namespace Controls
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
			if(disposing && (components != null))
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
			this._pnlPlayerControl = new System.Windows.Forms.Panel();
			this._pnlSettingsControl = new System.Windows.Forms.Panel();
			this._pnlLogControl = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// _pnlPlayerControl
			// 
			this._pnlPlayerControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this._pnlPlayerControl.Location = new System.Drawing.Point(12, 12);
			this._pnlPlayerControl.Name = "_pnlPlayerControl";
			this._pnlPlayerControl.Size = new System.Drawing.Size(200, 350);
			this._pnlPlayerControl.TabIndex = 0;
			// 
			// _pnlSettingsControl
			// 
			this._pnlSettingsControl.BackColor = System.Drawing.Color.Transparent;
			this._pnlSettingsControl.Location = new System.Drawing.Point(218, 12);
			this._pnlSettingsControl.Name = "_pnlSettingsControl";
			this._pnlSettingsControl.Size = new System.Drawing.Size(200, 350);
			this._pnlSettingsControl.TabIndex = 1;
			// 
			// _pnlLogControl
			// 
			this._pnlLogControl.BackColor = System.Drawing.Color.Transparent;
			this._pnlLogControl.Location = new System.Drawing.Point(424, 12);
			this._pnlLogControl.Name = "_pnlLogControl";
			this._pnlLogControl.Size = new System.Drawing.Size(200, 350);
			this._pnlLogControl.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(639, 374);
			this.Controls.Add(this._pnlLogControl);
			this.Controls.Add(this._pnlSettingsControl);
			this.Controls.Add(this._pnlPlayerControl);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel _pnlPlayerControl;
		private System.Windows.Forms.Panel _pnlSettingsControl;
		private System.Windows.Forms.Panel _pnlLogControl;
	}
}

