namespace ShortCoffee
{
    partial class AddUserMenu
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
            this.EnterUserID_BOX = new System.Windows.Forms.TextBox();
            this.EnterLastName_BOX = new System.Windows.Forms.TextBox();
            this.EnterFirstName_BOX = new System.Windows.Forms.TextBox();
            this.EnterPhoneNumber_BOX = new System.Windows.Forms.TextBox();
            this.CreateAPassword_BOX = new System.Windows.Forms.TextBox();
            this.AddUser_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Back_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterUserID_BOX
            // 
            this.EnterUserID_BOX.Location = new System.Drawing.Point(188, 99);
            this.EnterUserID_BOX.Name = "EnterUserID_BOX";
            this.EnterUserID_BOX.Size = new System.Drawing.Size(175, 22);
            this.EnterUserID_BOX.TabIndex = 0;
            // 
            // EnterLastName_BOX
            // 
            this.EnterLastName_BOX.Location = new System.Drawing.Point(188, 151);
            this.EnterLastName_BOX.Name = "EnterLastName_BOX";
            this.EnterLastName_BOX.Size = new System.Drawing.Size(175, 22);
            this.EnterLastName_BOX.TabIndex = 1;
            // 
            // EnterFirstName_BOX
            // 
            this.EnterFirstName_BOX.Location = new System.Drawing.Point(188, 199);
            this.EnterFirstName_BOX.Name = "EnterFirstName_BOX";
            this.EnterFirstName_BOX.Size = new System.Drawing.Size(175, 22);
            this.EnterFirstName_BOX.TabIndex = 2;
            // 
            // EnterPhoneNumber_BOX
            // 
            this.EnterPhoneNumber_BOX.Location = new System.Drawing.Point(188, 253);
            this.EnterPhoneNumber_BOX.Name = "EnterPhoneNumber_BOX";
            this.EnterPhoneNumber_BOX.Size = new System.Drawing.Size(175, 22);
            this.EnterPhoneNumber_BOX.TabIndex = 3;
            // 
            // CreateAPassword_BOX
            // 
            this.CreateAPassword_BOX.Location = new System.Drawing.Point(188, 304);
            this.CreateAPassword_BOX.Name = "CreateAPassword_BOX";
            this.CreateAPassword_BOX.Size = new System.Drawing.Size(175, 22);
            this.CreateAPassword_BOX.TabIndex = 4;
            // 
            // AddUser_Button
            // 
            this.AddUser_Button.Location = new System.Drawing.Point(104, 396);
            this.AddUser_Button.Name = "AddUser_Button";
            this.AddUser_Button.Size = new System.Drawing.Size(175, 53);
            this.AddUser_Button.TabIndex = 5;
            this.AddUser_Button.Text = "Add User";
            this.AddUser_Button.UseVisualStyleBackColor = true;
            this.AddUser_Button.Click += new System.EventHandler(this.AddUser_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "FIrst Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Create A Password";
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(25, 25);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(75, 23);
            this.Back_Button.TabIndex = 11;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // AddUserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 553);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddUser_Button);
            this.Controls.Add(this.CreateAPassword_BOX);
            this.Controls.Add(this.EnterPhoneNumber_BOX);
            this.Controls.Add(this.EnterFirstName_BOX);
            this.Controls.Add(this.EnterLastName_BOX);
            this.Controls.Add(this.EnterUserID_BOX);
            this.Name = "AddUserMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUserMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnterUserID_BOX;
        private System.Windows.Forms.TextBox EnterLastName_BOX;
        private System.Windows.Forms.TextBox EnterFirstName_BOX;
        private System.Windows.Forms.TextBox EnterPhoneNumber_BOX;
        private System.Windows.Forms.TextBox CreateAPassword_BOX;
        private System.Windows.Forms.Button AddUser_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Back_Button;
    }
}