namespace ShortCoffee
{
    partial class Monitor
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Unlock_Button = new System.Windows.Forms.Button();
            this.Capture_Button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(110, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 140);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Unlock_Button
            // 
            this.Unlock_Button.Location = new System.Drawing.Point(131, 298);
            this.Unlock_Button.Name = "Unlock_Button";
            this.Unlock_Button.Size = new System.Drawing.Size(135, 23);
            this.Unlock_Button.TabIndex = 1;
            this.Unlock_Button.Text = "Unlock";
            this.Unlock_Button.UseVisualStyleBackColor = true;
            // 
            // Capture_Button
            // 
            this.Capture_Button.Location = new System.Drawing.Point(131, 411);
            this.Capture_Button.Name = "Capture_Button";
            this.Capture_Button.Size = new System.Drawing.Size(135, 23);
            this.Capture_Button.TabIndex = 2;
            this.Capture_Button.Text = "Capture Picture";
            this.Capture_Button.UseVisualStyleBackColor = true;
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(12, 12);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(81, 23);
            this.Back_Button.TabIndex = 3;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 553);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Capture_Button);
            this.Controls.Add(this.Unlock_Button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Monitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Unlock_Button;
        private System.Windows.Forms.Button Capture_Button;
        private System.Windows.Forms.Button Back_Button;
    }
}