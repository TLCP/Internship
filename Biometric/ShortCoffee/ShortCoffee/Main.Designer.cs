namespace ShortCoffee
{
    partial class Main
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
            this.ViewLog_Button = new System.Windows.Forms.Button();
            this.Monitor_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.ManageUsers_Button = new System.Windows.Forms.Button();
            this.Main_Label = new System.Windows.Forms.Label();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewLog_Button
            // 
            this.ViewLog_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.ViewLog_Button.Location = new System.Drawing.Point(117, 240);
            this.ViewLog_Button.Name = "ViewLog_Button";
            this.ViewLog_Button.Size = new System.Drawing.Size(150, 35);
            this.ViewLog_Button.TabIndex = 1;
            this.ViewLog_Button.Text = "View Log";
            this.ViewLog_Button.UseVisualStyleBackColor = true;
            // 
            // Monitor_Button
            // 
            this.Monitor_Button.Location = new System.Drawing.Point(117, 338);
            this.Monitor_Button.Name = "Monitor_Button";
            this.Monitor_Button.Size = new System.Drawing.Size(150, 35);
            this.Monitor_Button.TabIndex = 2;
            this.Monitor_Button.Text = "Monitor";
            this.Monitor_Button.UseVisualStyleBackColor = true;
            this.Monitor_Button.Click += new System.EventHandler(this.Monitor_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btn_LogOut);
            this.panel1.Controls.Add(this.Exit_Button);
            this.panel1.Location = new System.Drawing.Point(-45, 477);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 94);
            this.panel1.TabIndex = 3;
            // 
            // Exit_Button
            // 
            this.Exit_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit_Button.Location = new System.Drawing.Point(67, 22);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(75, 35);
            this.Exit_Button.TabIndex = 4;
            this.Exit_Button.Text = "EXIT";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // ManageUsers_Button
            // 
            this.ManageUsers_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.ManageUsers_Button.Location = new System.Drawing.Point(117, 136);
            this.ManageUsers_Button.Name = "ManageUsers_Button";
            this.ManageUsers_Button.Size = new System.Drawing.Size(150, 35);
            this.ManageUsers_Button.TabIndex = 5;
            this.ManageUsers_Button.Text = "Manage Users";
            this.ManageUsers_Button.UseVisualStyleBackColor = true;
            this.ManageUsers_Button.Click += new System.EventHandler(this.ManageUsers_Button_Click);
            // 
            // Main_Label
            // 
            this.Main_Label.AutoSize = true;
            this.Main_Label.Font = new System.Drawing.Font("Algerian", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Label.Location = new System.Drawing.Point(71, 30);
            this.Main_Label.Name = "Main_Label";
            this.Main_Label.Size = new System.Drawing.Size(253, 48);
            this.Main_Label.TabIndex = 5;
            this.Main_Label.Text = "Main Menu";
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Location = new System.Drawing.Point(307, 22);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(75, 35);
            this.btn_LogOut.TabIndex = 5;
            this.btn_LogOut.Text = "Log Out";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(382, 553);
            this.Controls.Add(this.ManageUsers_Button);
            this.Controls.Add(this.Main_Label);
            this.Controls.Add(this.Monitor_Button);
            this.Controls.Add(this.ViewLog_Button);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ViewLog_Button;
        private System.Windows.Forms.Button Monitor_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Button ManageUsers_Button;
        private System.Windows.Forms.Label Main_Label;
        private System.Windows.Forms.Button btn_LogOut;
    }
}