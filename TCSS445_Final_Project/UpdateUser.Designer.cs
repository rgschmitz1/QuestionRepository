namespace TCSS445_Final_Project
{
    partial class UpdateUser
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
            this.admin = new System.Windows.Forms.CheckBox();
            this.deactivate = new System.Windows.Forms.CheckBox();
            this.submit = new System.Windows.Forms.Button();
            this.users = new System.Windows.Forms.ComboBox();
            this.password = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mismatch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select User";
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Location = new System.Drawing.Point(15, 120);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(55, 17);
            this.admin.TabIndex = 2;
            this.admin.Text = "Admin";
            this.admin.UseVisualStyleBackColor = true;
            // 
            // deactivate
            // 
            this.deactivate.AutoSize = true;
            this.deactivate.Location = new System.Drawing.Point(159, 120);
            this.deactivate.Name = "deactivate";
            this.deactivate.Size = new System.Drawing.Size(78, 17);
            this.deactivate.TabIndex = 3;
            this.deactivate.Text = "Deactivate";
            this.deactivate.UseVisualStyleBackColor = true;
            // 
            // submit
            // 
            this.submit.Enabled = false;
            this.submit.Location = new System.Drawing.Point(95, 145);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 4;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // users
            // 
            this.users.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.users.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.users.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.users.FormattingEnabled = true;
            this.users.Location = new System.Drawing.Point(95, 12);
            this.users.MaxDropDownItems = 100;
            this.users.MaxLength = 20;
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(148, 21);
            this.users.Sorted = true;
            this.users.TabIndex = 5;
            this.users.SelectedIndexChanged += new System.EventHandler(this.users_SelectedIndexChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(116, 39);
            this.password.MaxLength = 255;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 6;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(116, 65);
            this.confirm.MaxLength = 255;
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(100, 20);
            this.confirm.TabIndex = 7;
            this.confirm.TextChanged += new System.EventHandler(this.confirm_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Confirm Password";
            // 
            // mismatch
            // 
            this.mismatch.AutoSize = true;
            this.mismatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mismatch.ForeColor = System.Drawing.Color.Red;
            this.mismatch.Location = new System.Drawing.Point(67, 88);
            this.mismatch.Name = "mismatch";
            this.mismatch.Size = new System.Drawing.Size(118, 13);
            this.mismatch.TabIndex = 10;
            this.mismatch.Text = "Password Mismatch";
            this.mismatch.Visible = false;
            // 
            // UpdateUser
            // 
            this.AcceptButton = this.submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 180);
            this.Controls.Add(this.mismatch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.password);
            this.Controls.Add(this.users);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.deactivate);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UpdateUser";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Update User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox admin;
        private System.Windows.Forms.CheckBox deactivate;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ComboBox users;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox confirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mismatch;
    }
}