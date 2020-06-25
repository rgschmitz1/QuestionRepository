namespace TCSS445_Final_Project
{
    partial class AddDepartment
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
            this.location = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.ComboBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Location";
            // 
            // location
            // 
            this.location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.location.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.location.FormattingEnabled = true;
            this.location.Location = new System.Drawing.Point(121, 6);
            this.location.MaxDropDownItems = 100;
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(121, 21);
            this.location.Sorted = true;
            this.location.TabIndex = 1;
            this.location.SelectedIndexChanged += new System.EventHandler(this.location_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department Name";
            // 
            // department
            // 
            this.department.Enabled = false;
            this.department.FormattingEnabled = true;
            this.department.Location = new System.Drawing.Point(121, 34);
            this.department.MaxDropDownItems = 100;
            this.department.MaxLength = 80;
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(121, 21);
            this.department.Sorted = true;
            this.department.TabIndex = 3;
            this.department.TextChanged += new System.EventHandler(this.department_TextChanged);
            // 
            // submit
            // 
            this.submit.Enabled = false;
            this.submit.Location = new System.Drawing.Point(92, 72);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 4;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // AddDepartment
            // 
            this.AcceptButton = this.submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 107);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.department);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.location);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddDepartment";
            this.ShowIcon = false;
            this.Text = "Add Department";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox location;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.Button submit;
    }
}