namespace FirstApp1
{
    partial class Form1
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
            this.grpMood = new System.Windows.Forms.GroupBox();
            this.rdoHappy = new System.Windows.Forms.RadioButton();
            this.rdoSad = new System.Windows.Forms.RadioButton();
            this.picSad = new System.Windows.Forms.PictureBox();
            this.picHappy = new System.Windows.Forms.PictureBox();
            this.grpMood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHappy)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMood
            // 
            this.grpMood.Controls.Add(this.rdoSad);
            this.grpMood.Controls.Add(this.rdoHappy);
            this.grpMood.Location = new System.Drawing.Point(599, 31);
            this.grpMood.Name = "grpMood";
            this.grpMood.Size = new System.Drawing.Size(172, 145);
            this.grpMood.TabIndex = 0;
            this.grpMood.TabStop = false;
            this.grpMood.Text = "Mood";
            // 
            // rdoHappy
            // 
            this.rdoHappy.AutoSize = true;
            this.rdoHappy.Location = new System.Drawing.Point(29, 34);
            this.rdoHappy.Name = "rdoHappy";
            this.rdoHappy.Size = new System.Drawing.Size(56, 17);
            this.rdoHappy.TabIndex = 0;
            this.rdoHappy.TabStop = true;
            this.rdoHappy.Text = "Happy";
            this.rdoHappy.UseVisualStyleBackColor = true;
            this.rdoHappy.CheckedChanged += new System.EventHandler(this.radioButtonHappy_CheckedChanged);
            // 
            // rdoSad
            // 
            this.rdoSad.AutoSize = true;
            this.rdoSad.Location = new System.Drawing.Point(29, 81);
            this.rdoSad.Name = "rdoSad";
            this.rdoSad.Size = new System.Drawing.Size(44, 17);
            this.rdoSad.TabIndex = 1;
            this.rdoSad.TabStop = true;
            this.rdoSad.Text = "Sad";
            this.rdoSad.UseVisualStyleBackColor = true;
            this.rdoSad.CheckedChanged += new System.EventHandler(this.radioButtonSad_CheckedChanged);
            // 
            // picSad
            // 
            this.picSad.BackgroundImage = global::FirstApp1.Properties.Resources.wagon;
            this.picSad.Location = new System.Drawing.Point(613, 257);
            this.picSad.Name = "picSad";
            this.picSad.Size = new System.Drawing.Size(158, 99);
            this.picSad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSad.TabIndex = 2;
            this.picSad.TabStop = false;
            // 
            // picHappy
            // 
            this.picHappy.Image = global::FirstApp1.Properties.Resources.ball;
            this.picHappy.Location = new System.Drawing.Point(705, 182);
            this.picHappy.Name = "picHappy";
            this.picHappy.Size = new System.Drawing.Size(66, 69);
            this.picHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHappy.TabIndex = 1;
            this.picHappy.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picSad);
            this.Controls.Add(this.picHappy);
            this.Controls.Add(this.grpMood);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpMood.ResumeLayout(false);
            this.grpMood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHappy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMood;
        private System.Windows.Forms.RadioButton rdoSad;
        private System.Windows.Forms.RadioButton rdoHappy;
        private System.Windows.Forms.PictureBox picHappy;
        private System.Windows.Forms.PictureBox picSad;
    }
}

