namespace FirstApp1
{
    partial class Form2
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
            this.tbxColour = new System.Windows.Forms.TextBox();
            this.HsbRed = new System.Windows.Forms.HScrollBar();
            this.HsbBlue = new System.Windows.Forms.HScrollBar();
            this.HsbGreen = new System.Windows.Forms.HScrollBar();
            this.LblRed = new System.Windows.Forms.Label();
            this.LblBlue = new System.Windows.Forms.Label();
            this.LblGreen = new System.Windows.Forms.Label();
            this.TxtRedValue = new System.Windows.Forms.TextBox();
            this.TxtBlueValue = new System.Windows.Forms.TextBox();
            this.TxtGreenValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxColour
            // 
            this.tbxColour.Location = new System.Drawing.Point(34, 22);
            this.tbxColour.Multiline = true;
            this.tbxColour.Name = "tbxColour";
            this.tbxColour.Size = new System.Drawing.Size(742, 325);
            this.tbxColour.TabIndex = 0;
            this.tbxColour.TextChanged += new System.EventHandler(this.tbxColour_TextChanged);
            // 
            // HsbRed
            // 
            this.HsbRed.LargeChange = 1;
            this.HsbRed.Location = new System.Drawing.Point(232, 380);
            this.HsbRed.Maximum = 255;
            this.HsbRed.Name = "HsbRed";
            this.HsbRed.Size = new System.Drawing.Size(395, 17);
            this.HsbRed.TabIndex = 1;
            this.HsbRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HsbRed_Scroll);
            // 
            // HsbBlue
            // 
            this.HsbBlue.LargeChange = 1;
            this.HsbBlue.Location = new System.Drawing.Point(232, 411);
            this.HsbBlue.Maximum = 255;
            this.HsbBlue.Name = "HsbBlue";
            this.HsbBlue.Size = new System.Drawing.Size(395, 17);
            this.HsbBlue.TabIndex = 2;
            this.HsbBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HsbBlue_Scroll);
            // 
            // HsbGreen
            // 
            this.HsbGreen.LargeChange = 1;
            this.HsbGreen.Location = new System.Drawing.Point(232, 448);
            this.HsbGreen.Maximum = 255;
            this.HsbGreen.Name = "HsbGreen";
            this.HsbGreen.Size = new System.Drawing.Size(395, 17);
            this.HsbGreen.TabIndex = 3;
            this.HsbGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HsbGreen_Scroll);
            // 
            // LblRed
            // 
            this.LblRed.AutoSize = true;
            this.LblRed.Location = new System.Drawing.Point(149, 380);
            this.LblRed.Name = "LblRed";
            this.LblRed.Size = new System.Drawing.Size(27, 13);
            this.LblRed.TabIndex = 4;
            this.LblRed.Text = "Red";
            // 
            // LblBlue
            // 
            this.LblBlue.AutoSize = true;
            this.LblBlue.Location = new System.Drawing.Point(149, 415);
            this.LblBlue.Name = "LblBlue";
            this.LblBlue.Size = new System.Drawing.Size(28, 13);
            this.LblBlue.TabIndex = 5;
            this.LblBlue.Text = "Blue";
            // 
            // LblGreen
            // 
            this.LblGreen.AutoSize = true;
            this.LblGreen.Location = new System.Drawing.Point(152, 448);
            this.LblGreen.Name = "LblGreen";
            this.LblGreen.Size = new System.Drawing.Size(36, 13);
            this.LblGreen.TabIndex = 6;
            this.LblGreen.Text = "Green";
            // 
            // TxtRedValue
            // 
            this.TxtRedValue.Location = new System.Drawing.Point(656, 380);
            this.TxtRedValue.MaxLength = 3;
            this.TxtRedValue.Name = "TxtRedValue";
            this.TxtRedValue.Size = new System.Drawing.Size(100, 20);
            this.TxtRedValue.TabIndex = 7;
            this.TxtRedValue.WordWrap = false;
            this.TxtRedValue.TextChanged += new System.EventHandler(this.TxtRedValue_TextChanged);
            this.TxtRedValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRedValue_KeyPress);
            // 
            // TxtBlueValue
            // 
            this.TxtBlueValue.Location = new System.Drawing.Point(656, 411);
            this.TxtBlueValue.MaxLength = 3;
            this.TxtBlueValue.Name = "TxtBlueValue";
            this.TxtBlueValue.Size = new System.Drawing.Size(100, 20);
            this.TxtBlueValue.TabIndex = 8;
            this.TxtBlueValue.TextChanged += new System.EventHandler(this.TxtBlueValue_TextChanged);
            this.TxtBlueValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBlueValue_KeyPress);
            // 
            // TxtGreenValue
            // 
            this.TxtGreenValue.Location = new System.Drawing.Point(656, 445);
            this.TxtGreenValue.MaxLength = 3;
            this.TxtGreenValue.Name = "TxtGreenValue";
            this.TxtGreenValue.Size = new System.Drawing.Size(100, 20);
            this.TxtGreenValue.TabIndex = 9;
            this.TxtGreenValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtGreenValue_KeyPress);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.TxtGreenValue);
            this.Controls.Add(this.TxtBlueValue);
            this.Controls.Add(this.TxtRedValue);
            this.Controls.Add(this.LblGreen);
            this.Controls.Add(this.LblBlue);
            this.Controls.Add(this.LblRed);
            this.Controls.Add(this.HsbGreen);
            this.Controls.Add(this.HsbBlue);
            this.Controls.Add(this.HsbRed);
            this.Controls.Add(this.tbxColour);
            this.Name = "Form2";
            this.Text = "RGB Colour Maker";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxColour;
        private System.Windows.Forms.HScrollBar HsbRed;
        private System.Windows.Forms.HScrollBar HsbBlue;
        private System.Windows.Forms.HScrollBar HsbGreen;
        private System.Windows.Forms.Label LblRed;
        private System.Windows.Forms.Label LblBlue;
        private System.Windows.Forms.Label LblGreen;
        private System.Windows.Forms.TextBox TxtBlueValue;
        private System.Windows.Forms.TextBox TxtGreenValue;
        private System.Windows.Forms.TextBox TxtRedValue;
    }
}