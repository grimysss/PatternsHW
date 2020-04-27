namespace Controls
{
	partial class PlayerControl
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
			this._imgPepeHype = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this._imgPepeHype)).BeginInit();
			this.SuspendLayout();
			// 
			// _imgPepeHype
			// 
			this._imgPepeHype.Image = global::Controls.Properties.Resources._2299436;
			this._imgPepeHype.Location = new System.Drawing.Point(0, 0);
			this._imgPepeHype.Name = "_imgPepeHype";
			this._imgPepeHype.Size = new System.Drawing.Size(200, 350);
			this._imgPepeHype.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this._imgPepeHype.TabIndex = 0;
			this._imgPepeHype.TabStop = false;
			this._imgPepeHype.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// PlayerControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._imgPepeHype);
			this.Name = "PlayerControl";
			this.Size = new System.Drawing.Size(200, 350);
			this.Load += new System.EventHandler(this.PlayerControl_Load);
			((System.ComponentModel.ISupportInitialize)(this._imgPepeHype)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox _imgPepeHype;
	}
}
