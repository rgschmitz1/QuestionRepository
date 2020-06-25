namespace TCSS445_Final_Project
{
    partial class AddQuestion
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.body = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.course = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.topic = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.difficulty = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.format = new System.Windows.Forms.ComboBox();
            this.submit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.TextBox();
            this.imageToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.addSubquestion = new System.Windows.Forms.Button();
            this.subquestion = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.editSubquestion = new System.Windows.Forms.Button();
            this.editAnswer = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.addAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(45, 6);
            this.title.MaxLength = 50;
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(743, 20);
            this.title.TabIndex = 1;
            this.title.TextChanged += new System.EventHandler(this.title_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Body";
            // 
            // body
            // 
            this.body.Location = new System.Drawing.Point(45, 32);
            this.body.MaxLength = 8000;
            this.body.Multiline = true;
            this.body.Name = "body";
            this.body.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.body.Size = new System.Drawing.Size(743, 193);
            this.body.TabIndex = 3;
            this.body.TextChanged += new System.EventHandler(this.body_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Location";
            // 
            // location
            // 
            this.location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.location.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.location.FormattingEnabled = true;
            this.location.Location = new System.Drawing.Point(76, 257);
            this.location.MaxDropDownItems = 100;
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(121, 21);
            this.location.Sorted = true;
            this.location.TabIndex = 5;
            this.location.SelectedIndexChanged += new System.EventHandler(this.location_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Department";
            // 
            // department
            // 
            this.department.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.department.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.department.Enabled = false;
            this.department.FormattingEnabled = true;
            this.department.Location = new System.Drawing.Point(76, 284);
            this.department.MaxDropDownItems = 100;
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(406, 21);
            this.department.Sorted = true;
            this.department.TabIndex = 7;
            this.department.SelectedIndexChanged += new System.EventHandler(this.department_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Course";
            // 
            // course
            // 
            this.course.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.course.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.course.Enabled = false;
            this.course.FormattingEnabled = true;
            this.course.Location = new System.Drawing.Point(76, 311);
            this.course.MaxDropDownItems = 100;
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(406, 21);
            this.course.Sorted = true;
            this.course.TabIndex = 9;
            this.course.SelectedIndexChanged += new System.EventHandler(this.course_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Topic";
            // 
            // topic
            // 
            this.topic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.topic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.topic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.topic.FormattingEnabled = true;
            this.topic.Location = new System.Drawing.Point(76, 338);
            this.topic.MaxDropDownItems = 100;
            this.topic.Name = "topic";
            this.topic.Size = new System.Drawing.Size(341, 21);
            this.topic.Sorted = true;
            this.topic.TabIndex = 11;
            this.topic.SelectedIndexChanged += new System.EventHandler(this.topic_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Difficulty";
            // 
            // difficulty
            // 
            this.difficulty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.difficulty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.difficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficulty.FormattingEnabled = true;
            this.difficulty.Location = new System.Drawing.Point(544, 260);
            this.difficulty.MaxDropDownItems = 100;
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(121, 21);
            this.difficulty.TabIndex = 13;
            this.difficulty.SelectedIndexChanged += new System.EventHandler(this.difficulty_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(507, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Type";
            // 
            // type
            // 
            this.type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(544, 287);
            this.type.MaxDropDownItems = 100;
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(121, 21);
            this.type.Sorted = true;
            this.type.TabIndex = 15;
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(499, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Format";
            // 
            // format
            // 
            this.format.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.format.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.format.FormattingEnabled = true;
            this.format.Location = new System.Drawing.Point(544, 315);
            this.format.MaxDropDownItems = 100;
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(121, 21);
            this.format.Sorted = true;
            this.format.TabIndex = 17;
            this.format.SelectedIndexChanged += new System.EventHandler(this.format_SelectedIndexChanged);
            // 
            // submit
            // 
            this.submit.Enabled = false;
            this.submit.Location = new System.Drawing.Point(713, 388);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 18;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Image";
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(45, 231);
            this.image.MaxLength = 50;
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(743, 20);
            this.image.TabIndex = 20;
            this.imageToolTip.SetToolTip(this.image, "Input image location");
            // 
            // addSubquestion
            // 
            this.addSubquestion.Location = new System.Drawing.Point(423, 364);
            this.addSubquestion.Name = "addSubquestion";
            this.addSubquestion.Size = new System.Drawing.Size(115, 23);
            this.addSubquestion.TabIndex = 21;
            this.addSubquestion.Text = "Add SubQuestion";
            this.addSubquestion.UseVisualStyleBackColor = true;
            this.addSubquestion.Click += new System.EventHandler(this.addSubquestion_Click);
            // 
            // subquestion
            // 
            this.subquestion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.subquestion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.subquestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subquestion.Enabled = false;
            this.subquestion.FormattingEnabled = true;
            this.subquestion.Location = new System.Drawing.Point(76, 366);
            this.subquestion.MaxDropDownItems = 100;
            this.subquestion.Name = "subquestion";
            this.subquestion.Size = new System.Drawing.Size(341, 21);
            this.subquestion.Sorted = true;
            this.subquestion.TabIndex = 23;
            this.subquestion.SelectedIndexChanged += new System.EventHandler(this.subquestion_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "SubQuestion";
            // 
            // editSubquestion
            // 
            this.editSubquestion.Enabled = false;
            this.editSubquestion.Location = new System.Drawing.Point(544, 364);
            this.editSubquestion.Name = "editSubquestion";
            this.editSubquestion.Size = new System.Drawing.Size(115, 23);
            this.editSubquestion.TabIndex = 24;
            this.editSubquestion.Text = "Edit SubQuestion";
            this.editSubquestion.UseVisualStyleBackColor = true;
            this.editSubquestion.Click += new System.EventHandler(this.editSubquestion_Click);
            // 
            // editAnswer
            // 
            this.editAnswer.Enabled = false;
            this.editAnswer.Location = new System.Drawing.Point(544, 391);
            this.editAnswer.Name = "editAnswer";
            this.editAnswer.Size = new System.Drawing.Size(115, 23);
            this.editAnswer.TabIndex = 28;
            this.editAnswer.Text = "Edit Answer";
            this.editAnswer.UseVisualStyleBackColor = true;
            this.editAnswer.Click += new System.EventHandler(this.editAnswer_Click);
            // 
            // answer
            // 
            this.answer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.answer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.answer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.answer.Enabled = false;
            this.answer.FormattingEnabled = true;
            this.answer.Location = new System.Drawing.Point(76, 393);
            this.answer.MaxDropDownItems = 100;
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(341, 21);
            this.answer.Sorted = true;
            this.answer.TabIndex = 27;
            this.answer.SelectedIndexChanged += new System.EventHandler(this.answer_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Answer";
            // 
            // addAnswer
            // 
            this.addAnswer.Location = new System.Drawing.Point(423, 391);
            this.addAnswer.Name = "addAnswer";
            this.addAnswer.Size = new System.Drawing.Size(115, 23);
            this.addAnswer.TabIndex = 25;
            this.addAnswer.Text = "Add Answer";
            this.addAnswer.UseVisualStyleBackColor = true;
            this.addAnswer.Click += new System.EventHandler(this.addAnswer_Click);
            // 
            // AddQuestion
            // 
            this.AcceptButton = this.submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.editAnswer);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.addAnswer);
            this.Controls.Add(this.editSubquestion);
            this.Controls.Add(this.subquestion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.addSubquestion);
            this.Controls.Add(this.image);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.format);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.difficulty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.topic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.course);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.department);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.location);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.body);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddQuestion";
            this.ShowIcon = false;
            this.Text = "Add Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox body;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox location;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox course;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox topic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox difficulty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox format;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox image;
        private System.Windows.Forms.ToolTip imageToolTip;
        private System.Windows.Forms.Button addSubquestion;
        private System.Windows.Forms.ComboBox subquestion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button editSubquestion;
        private System.Windows.Forms.Button editAnswer;
        private System.Windows.Forms.ComboBox answer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button addAnswer;
    }
}