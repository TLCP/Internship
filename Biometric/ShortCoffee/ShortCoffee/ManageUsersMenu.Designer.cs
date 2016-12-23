namespace ShortCoffee
{
    partial class ManageUsersMenu
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
            this.AddUser_Button = new System.Windows.Forms.Button();
            this.DeleteUser_Button = new System.Windows.Forms.Button();
            this.ViewUsers_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.lbl_ManageUsers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddUser_Button
            // 
            this.AddUser_Button.Location = new System.Drawing.Point(119, 166);
            this.AddUser_Button.Name = "AddUser_Button";
            this.AddUser_Button.Size = new System.Drawing.Size(129, 23);
            this.AddUser_Button.TabIndex = 0;
            this.AddUser_Button.Text = "Add User";
            this.AddUser_Button.UseVisualStyleBackColor = true;
            this.AddUser_Button.Click += new System.EventHandler(this.AddUser_Button_Click);
            // 
            // DeleteUser_Button
            // 
            this.DeleteUser_Button.Location = new System.Drawing.Point(119, 250);
            this.DeleteUser_Button.Name = "DeleteUser_Button";
            this.DeleteUser_Button.Size = new System.Drawing.Size(129, 23);
            this.DeleteUser_Button.TabIndex = 1;
            this.DeleteUser_Button.Text = "Delete User";
            this.DeleteUser_Button.UseVisualStyleBackColor = true;
            // 
            // ViewUsers_Button
            // 
            this.ViewUsers_Button.Location = new System.Drawing.Point(119, 321);
            this.ViewUsers_Button.Name = "ViewUsers_Button";
            this.ViewUsers_Button.Size = new System.Drawing.Size(129, 23);
            this.ViewUsers_Button.TabIndex = 2;
            this.ViewUsers_Button.Text = "View Users";
            this.ViewUsers_Button.UseVisualStyleBackColor = true;
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(12, 470);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(75, 23);
            this.Exit_Button.TabIndex = 3;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(12, 12);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(75, 23);
            this.Back_Button.TabIndex = 4;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // lbl_ManageUsers
            // 
            this.lbl_ManageUsers.AutoSize = true;
            this.lbl_ManageUsers.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageUsers.Location = new System.Drawing.Point(74, 72);
            this.lbl_ManageUsers.Name = "lbl_ManageUsers";
            this.lbl_ManageUsers.Size = new System.Drawing.Size(220, 31);
            this.lbl_ManageUsers.TabIndex = 5;
            this.lbl_ManageUsers.Text = "Manage Users";
            // 
            // ManageUsersMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 553);
            this.Controls.Add(this.lbl_ManageUsers);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.ViewUsers_Button);
            this.Controls.Add(this.DeleteUser_Button);
            this.Controls.Add(this.AddUser_Button);
            this.Name = "ManageUsersMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUsersMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddUser_Button;
        private System.Windows.Forms.Button DeleteUser_Button;
        private System.Windows.Forms.Button ViewUsers_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Label lbl_ManageUsers;
    }
}