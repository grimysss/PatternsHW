namespace Controls
{
	partial class SettingsControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._btnOpenFIle = new System.Windows.Forms.Button();
			this._btnOpenFolder = new System.Windows.Forms.Button();
			this._btnStart = new System.Windows.Forms.Button();
			this._btnPause = new System.Windows.Forms.Button();
			this._btnStop = new System.Windows.Forms.Button();
			this._btnGoLeft = new System.Windows.Forms.Button();
			this._btnGoRight = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _btnOpenFIle
			// 
			this._btnOpenFIle.Location = new System.Drawing.Point(41, 29);
			this._btnOpenFIle.Name = "_btnOpenFIle";
			this._btnOpenFIle.Size = new System.Drawing.Size(119, 23);
			this._btnOpenFIle.TabIndex = 0;
			this._btnOpenFIle.Text = "Открыть файл";
			this._btnOpenFIle.UseVisualStyleBackColor = true;
			// 
			// _btnOpenFolder
			// 
			this._btnOpenFolder.Location = new System.Drawing.Point(41, 74);
			this._btnOpenFolder.Name = "_btnOpenFolder";
			this._btnOpenFolder.Size = new System.Drawing.Size(119, 23);
			this._btnOpenFolder.TabIndex = 1;
			this._btnOpenFolder.Text = "Открыть папку";
			this._btnOpenFolder.UseVisualStyleBackColor = true;
			// 
			// _btnStart
			// 
			this._btnStart.Cursor = System.Windows.Forms.Cursors.Arrow;
			this._btnStart.Location = new System.Drawing.Point(41, 119);
			this._btnStart.Name = "_btnStart";
			this._btnStart.Size = new System.Drawing.Size(119, 23);
			this._btnStart.TabIndex = 2;
			this._btnStart.Text = "Старт";
			this._btnStart.UseVisualStyleBackColor = true;
			// 
			// _btnPause
			// 
			this._btnPause.Location = new System.Drawing.Point(41, 164);
			this._btnPause.Name = "_btnPause";
			this._btnPause.Size = new System.Drawing.Size(119, 23);
			this._btnPause.TabIndex = 3;
			this._btnPause.Text = "Пауза";
			this._btnPause.UseVisualStyleBackColor = true;
			// 
			// _btnStop
			// 
			this._btnStop.Location = new System.Drawing.Point(41, 209);
			this._btnStop.Name = "_btnStop";
			this._btnStop.Size = new System.Drawing.Size(119, 23);
			this._btnStop.TabIndex = 4;
			this._btnStop.Text = "Стоп";
			this._btnStop.UseVisualStyleBackColor = true;
			// 
			// _btnGoLeft
			// 
			this._btnGoLeft.Location = new System.Drawing.Point(41, 254);
			this._btnGoLeft.Name = "_btnGoLeft";
			this._btnGoLeft.Size = new System.Drawing.Size(119, 23);
			this._btnGoLeft.TabIndex = 5;
			this._btnGoLeft.Text = "<<";
			this._btnGoLeft.UseVisualStyleBackColor = true;
			// 
			// _btnGoRight
			// 
			this._btnGoRight.Location = new System.Drawing.Point(41, 299);
			this._btnGoRight.Name = "_btnGoRight";
			this._btnGoRight.Size = new System.Drawing.Size(119, 23);
			this._btnGoRight.TabIndex = 6;
			this._btnGoRight.Text = ">>";
			this._btnGoRight.UseVisualStyleBackColor = true;
			// 
			// SettingsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._btnGoRight);
			this.Controls.Add(this._btnGoLeft);
			this.Controls.Add(this._btnStop);
			this.Controls.Add(this._btnPause);
			this.Controls.Add(this._btnStart);
			this.Controls.Add(this._btnOpenFolder);
			this.Controls.Add(this._btnOpenFIle);
			this.Name = "SettingsControl";
			this.Size = new System.Drawing.Size(200, 350);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button _btnOpenFIle;
		private System.Windows.Forms.Button _btnOpenFolder;
		private System.Windows.Forms.Button _btnStart;
		private System.Windows.Forms.Button _btnPause;
		private System.Windows.Forms.Button _btnStop;
		private System.Windows.Forms.Button _btnGoLeft;
		private System.Windows.Forms.Button _btnGoRight;
	}
}
