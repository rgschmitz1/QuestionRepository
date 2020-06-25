namespace TCSS445_Final_Project
{
    partial class UserForm
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
            this.addquestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.question = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.course = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.topic = new System.Windows.Forms.ComboBox();
            this.editquestion = new System.Windows.Forms.Button();
            this.clearfilters = new System.Windows.Forms.Button();
            this.difficulty = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.format = new System.Windows.Forms.ComboBox();
            this.noquestions = new System.Windows.Forms.Label();
            this.history = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addquestion
            // 
            this.addquestion.Location = new System.Drawing.Point(680, 177);
            this.addquestion.Name = "addquestion";
            this.addquestion.Size = new System.Drawing.Size(108, 23);
            this.addquestion.TabIndex = 0;
            this.addquestion.Text = "Add New Question";
            this.addquestion.UseVisualStyleBackColor = true;
            this.addquestion.Click += new System.EventHandler(this.addquestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question Title";
            // 
            // question
            // 
            this.question.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.question.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.question.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.question.FormattingEnabled = true;
            this.question.Location = new System.Drawing.Point(90, 6);
            this.question.MaxDropDownItems = 100;
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(698, 21);
            this.question.Sorted = true;
            this.question.TabIndex = 2;
            this.question.SelectedIndexChanged += new System.EventHandler(this.question_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Location";
            // 
            // location
            // 
            this.location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.location.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.location.FormattingEnabled = true;
            this.location.Location = new System.Drawing.Point(90, 37);
            this.location.MaxDropDownItems = 100;
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(121, 21);
            this.location.Sorted = true;
            this.location.TabIndex = 4;
            this.location.SelectedIndexChanged += new System.EventHandler(this.location_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Department";
            // 
            // department
            // 
            this.department.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.department.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.department.Enabled = false;
            this.department.FormattingEnabled = true;
            this.department.Location = new System.Drawing.Point(90, 71);
            this.department.MaxDropDownItems = 100;
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(263, 21);
            this.department.Sorted = true;
            this.department.TabIndex = 6;
            this.department.SelectedIndexChanged += new System.EventHandler(this.department_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Course";
            // 
            // course
            // 
            this.course.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.course.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.course.Enabled = false;
            this.course.FormattingEnabled = true;
            this.course.Location = new System.Drawing.Point(90, 105);
            this.course.MaxDropDownItems = 100;
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(263, 21);
            this.course.Sorted = true;
            this.course.TabIndex = 8;
            this.course.SelectedIndexChanged += new System.EventHandler(this.course_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Topic";
            // 
            // topic
            // 
            this.topic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.topic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.topic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.topic.FormattingEnabled = true;
            this.topic.Location = new System.Drawing.Point(90, 138);
            this.topic.MaxDropDownItems = 100;
            this.topic.Name = "topic";
            this.topic.Size = new System.Drawing.Size(263, 21);
            this.topic.Sorted = true;
            this.topic.TabIndex = 10;
            this.topic.SelectedIndexChanged += new System.EventHandler(this.topic_SelectedIndexChanged);
            // 
            // editquestion
            // 
            this.editquestion.Enabled = false;
            this.editquestion.Location = new System.Drawing.Point(15, 177);
            this.editquestion.Name = "editquestion";
            this.editquestion.Size = new System.Drawing.Size(108, 23);
            this.editquestion.TabIndex = 11;
            this.editquestion.Text = "View/Edit Question";
            this.editquestion.UseVisualStyleBackColor = true;
            this.editquestion.Click += new System.EventHandler(this.editquestion_Click);
            // 
            // clearfilters
            // 
            this.clearfilters.Location = new System.Drawing.Point(348, 177);
            this.clearfilters.Name = "clearfilters";
            this.clearfilters.Size = new System.Drawing.Size(75, 23);
            this.clearfilters.TabIndex = 12;
            this.clearfilters.Text = "Clear Filters";
            this.clearfilters.UseVisualStyleBackColor = true;
            this.clearfilters.Click += new System.EventHandler(this.clearfilters_Click);
            // 
            // difficulty
            // 
            this.difficulty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.difficulty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.difficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficulty.FormattingEnabled = true;
            this.difficulty.Location = new System.Drawing.Point(467, 40);
            this.difficulty.MaxDropDownItems = 100;
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(121, 21);
            this.difficulty.TabIndex = 13;
            this.difficulty.SelectedIndexChanged += new System.EventHandler(this.difficulty_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Difficulty";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Type";
            // 
            // type
            // 
            this.type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(467, 71);
            this.type.MaxDropDownItems = 100;
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(121, 21);
            this.type.Sorted = true;
            this.type.TabIndex = 16;
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Format";
            // 
            // format
            // 
            this.format.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.format.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.format.FormattingEnabled = true;
            this.format.Location = new System.Drawing.Point(467, 100);
            this.format.MaxDropDownItems = 100;
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(121, 21);
            this.format.Sorted = true;
            this.format.TabIndex = 18;
            this.format.SelectedIndexChanged += new System.EventHandler(this.format_SelectedIndexChanged);
            // 
            // noquestions
            // 
            this.noquestions.AutoSize = true;
            this.noquestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noquestions.ForeColor = System.Drawing.Color.Red;
            this.noquestions.Location = new System.Drawing.Point(402, 141);
            this.noquestions.Name = "noquestions";
            this.noquestions.Size = new System.Drawing.Size(216, 13);
            this.noquestions.TabIndex = 19;
            this.noquestions.Text = "No questions found for applied filters";
            this.noquestions.Visible = false;
            // 
            // history
            // 
            this.history.Enabled = false;
            this.history.Location = new System.Drawing.Point(136, 176);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(75, 23);
            this.history.TabIndex = 20;
            this.history.Text = "View History";
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 211);
            this.Controls.Add(this.history);
            this.Controls.Add(this.noquestions);
            this.Controls.Add(this.format);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.difficulty);
            this.Controls.Add(this.clearfilters);
            this.Controls.Add(this.editquestion);
            this.Controls.Add(this.topic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.course);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.department);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.location);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.question);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addquestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "User Controls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addquestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox question;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox location;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox course;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox topic;
        private System.Windows.Forms.Button editquestion;
        private System.Windows.Forms.Button clearfilters;
        private System.Windows.Forms.ComboBox difficulty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox format;
        private System.Windows.Forms.Label noquestions;
        private System.Windows.Forms.Button history;
    }
}