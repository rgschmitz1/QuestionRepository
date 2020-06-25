namespace TCSS445_Final_Project
{
    partial class AdminForm
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
            this.adduser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Button();
            this.department = new System.Windows.Forms.Button();
            this.course = new System.Windows.Forms.Button();
            this.topic = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.updateuser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adduser
            // 
            this.adduser.Location = new System.Drawing.Point(12, 34);
            this.adduser.Name = "adduser";
            this.adduser.Size = new System.Drawing.Size(75, 23);
            this.adduser.TabIndex = 0;
            this.adduser.Text = "Add User";
            this.adduser.UseVisualStyleBackColor = true;
            this.adduser.Click += new System.EventHandler(this.adduser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Options";
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(151, 34);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(79, 23);
            this.location.TabIndex = 3;
            this.location.Text = "Add Location";
            this.location.UseVisualStyleBackColor = true;
            this.location.Click += new System.EventHandler(this.location_Click);
            // 
            // department
            // 
            this.department.Location = new System.Drawing.Point(151, 63);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(94, 23);
            this.department.TabIndex = 4;
            this.department.Text = "Add Department";
            this.department.UseVisualStyleBackColor = true;
            this.department.Click += new System.EventHandler(this.department_Click);
            // 
            // course
            // 
            this.course.Location = new System.Drawing.Point(151, 92);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(75, 23);
            this.course.TabIndex = 5;
            this.course.Text = "Add Course";
            this.course.UseVisualStyleBackColor = true;
            this.course.Click += new System.EventHandler(this.course_Click);
            // 
            // topic
            // 
            this.topic.Location = new System.Drawing.Point(151, 121);
            this.topic.Name = "topic";
            this.topic.Size = new System.Drawing.Size(75, 23);
            this.topic.TabIndex = 6;
            this.topic.Text = "Add Topic";
            this.topic.UseVisualStyleBackColor = true;
            this.topic.Click += new System.EventHandler(this.topic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Menu Options";
            // 
            // updateuser
            // 
            this.updateuser.Location = new System.Drawing.Point(12, 63);
            this.updateuser.Name = "updateuser";
            this.updateuser.Size = new System.Drawing.Size(75, 23);
            this.updateuser.TabIndex = 8;
            this.updateuser.Text = "Update User";
            this.updateuser.UseVisualStyleBackColor = true;
            this.updateuser.Click += new System.EventHandler(this.updateuser_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(257, 158);
            this.Controls.Add(this.updateuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.topic);
            this.Controls.Add(this.course);
            this.Controls.Add(this.department);
            this.Controls.Add(this.location);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adduser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Admin Controls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adduser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button location;
        private System.Windows.Forms.Button department;
        private System.Windows.Forms.Button course;
        private System.Windows.Forms.Button topic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateuser;
    }
}