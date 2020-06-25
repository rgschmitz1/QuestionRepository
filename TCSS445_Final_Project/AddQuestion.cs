using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCSS445_Final_Project
{
    public partial class AddQuestion : Form
    {
        private int userID;
        private int questionID;
        private int locationID;
        private int departmentID;
        private int courseID;
        private int topicID;
        private int difficultyID;
        private int typeID;
        private int formatID;

        DataTable subquestionDt = new DataTable();
        DataTable answerDt = new DataTable();

        public AddQuestion(int aid, int qid)
        {
            // Author ID will be tracked for later
            userID = aid;
            // Question ID will be used if valid ID is passed
            questionID = qid;

            InitializeComponent();

            // Label columns for easier access
            subquestionDt.Columns.Add("SubQuestionText", typeof(String));
            subquestionDt.Columns.Add("SubQuestionImage", typeof(String));
            answerDt.Columns.Add("AnswerText", typeof(String));
            answerDt.Columns.Add("AnswerImage", typeof(String));

            // populate dropdown boxes
            populateDropDown(location, "SELECT LocationName FROM Locations");
            populateDropDown(topic, "SELECT TopicDescription FROM Topics");
            populateDropDown(difficulty, "SELECT DifficultyDescription FROM Difficulty");
            populateDropDown(type, "SELECT TypeDescription FROM QuestionTypes");
            populateDropDown(format, "SELECT FormatDescription FROM OutputFormats");
            if (questionID != 0)
            {
                // Populate all fields with question data if a question id was passed to the question
                var sql = "SELECT QuestionTitle, QuestionBody, QuestionImage, " +
                    "DifficultyID, TypeID, FormatID, LocationID, DepartmentID, CourseID, TopicID " +
                    "FROM Questions Q, CourseTopics C " +
                    "WHERE Q.CourseTopicRefID=C.CourseTopicRefID AND QuestionID=" + questionID;
                DataTable dt = SqlManager.query(sql);
                title.Text = dt.Rows[0][0].ToString();
                body.Text = dt.Rows[0][1].ToString();
                image.Text = dt.Rows[0][2].ToString();
                var ret = SqlManager.query("SELECT DifficultyDescription FROM Difficulty WHERE DifficultyID=" + dt.Rows[0][3].ToString()).Rows[0][0].ToString();
                difficulty.SelectedIndex = difficulty.FindStringExact(ret);
                ret = SqlManager.query("SELECT TypeDescription FROM QuestionTypes WHERE TypeID=" + dt.Rows[0][4].ToString()).Rows[0][0].ToString();
                type.SelectedIndex = type.FindStringExact(ret);
                ret = SqlManager.query("SELECT FormatDescription FROM OutputFormats WHERE FormatID=" + dt.Rows[0][5].ToString()).Rows[0][0].ToString();
                format.SelectedIndex = format.FindStringExact(ret);
                ret = SqlManager.query("SELECT LocationName FROM Locations WHERE LocationID=" + dt.Rows[0][6].ToString()).Rows[0][0].ToString();
                location.SelectedIndex = location.FindStringExact(ret);
                ret = SqlManager.query("SELECT DepartmentName FROM Departments WHERE DepartmentID=" + dt.Rows[0][7].ToString()).Rows[0][0].ToString();
                department.SelectedIndex = department.FindStringExact(ret);
                ret = SqlManager.query("SELECT CourseName FROM Courses WHERE CourseID=" + dt.Rows[0][8].ToString()).Rows[0][0].ToString();
                course.SelectedIndex = course.FindStringExact(ret);
                ret = SqlManager.query("SELECT TopicDescription FROM Topics WHERE TopicID=" + dt.Rows[0][9].ToString()).Rows[0][0].ToString();
                topic.SelectedIndex = topic.FindStringExact(ret);
                // Populate subquestions
                sql = "SELECT SubQuestionID, SubQuestionText, SubQuestionImage FROM SubQuestions " +
                    "WHERE QuestionID=" + questionID + " ORDER BY SubQuestionID";
                dt = SqlManager.query(sql);
                if (dt.Rows.Count > 0) subquestion.Enabled = true;
                for (int i=0; i < dt.Rows.Count; i++)
                {
                    subquestion.Items.Add("SubQuestion " + i);
                    var row = subquestionDt.NewRow();
                    row["SubQuestionText"] = dt.Rows[i][1];
                    row["SubQuestionImage"] = dt.Rows[i][2];
                    subquestionDt.Rows.Add(row);
                }
                // Populate answers
                sql = "SELECT AnswerID, AnswerText, AnswerImage FROM Answers " +
                    "WHERE QuestionID=" + questionID + " ORDER BY AnswerID";
                dt = SqlManager.query(sql);
                if (dt.Rows.Count > 0) answer.Enabled = true;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    answer.Items.Add("Answer " + i);
                    var row = answerDt.NewRow();
                    row["AnswerText"] = dt.Rows[i][1];
                    row["AnswerImage"] = dt.Rows[i][2];
                    answerDt.Rows.Add(row);
                }
            }
        }

        private void populateDropDown(ComboBox combobox, string sql)
        {
            DataTable dt = SqlManager.query(sql);
            combobox.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                combobox.Items.Add(dt.Rows[i][0]);
            }
        }

        private void location_SelectedIndexChanged(object sender, EventArgs e)
        {
            locationID = Convert.ToInt32(SqlManager.query("SELECT LocationID FROM Locations " +
                "WHERE LocationName='" + location.Text + "'").Rows[0][0]);
            // Populate department dropdown
            department.Enabled = true;
            var sql = "SELECT DepartmentName FROM Departments WHERE LocationID=" + locationID;
            populateDropDown(department, sql);
            // Clear course items if this field was previously selected
            course.Items.Clear();
            course.Enabled = false;
            enableSubmit();
        }

        private void department_SelectedIndexChanged(object sender, EventArgs e)
        {
            departmentID = Convert.ToInt32(SqlManager.query("SELECT DepartmentID FROM Departments " +
                "WHERE DepartmentName='" + department.Text + "' AND LocationID=" + locationID).Rows[0][0]);
            // Populate course dropdown
            course.Enabled = true;
            var sql = "SELECT CourseName FROM Courses WHERE LocationID=" + locationID + " AND DepartmentID=" + departmentID;
            populateDropDown(course, sql);
            enableSubmit();
        }

        private void course_SelectedIndexChanged(object sender, EventArgs e)
        {
            courseID = Convert.ToInt32(SqlManager.query("SELECT CourseID FROM Courses " +
                "WHERE CourseName='" + course.Text + "' AND LocationID=" + locationID +
                " AND DepartmentID=" + departmentID).Rows[0][0]);
            enableSubmit();
        }

        private void topic_SelectedIndexChanged(object sender, EventArgs e)
        {
            topicID = Convert.ToInt32(SqlManager.query("SELECT TopicID FROM Topics WHERE " +
                "TopicDescription='" + topic.Text + "'").Rows[0][0]);
            enableSubmit();
        }

        private void difficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            difficultyID = Convert.ToInt32(SqlManager.query("SELECT DifficultyID FROM Difficulty " +
                "WHERE DifficultyDescription='" + difficulty.Text + "'").Rows[0][0]);
            enableSubmit();
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeID = Convert.ToInt32(SqlManager.query("SELECT TypeID FROM QuestionTypes " +
                "WHERE TypeDescription='" + type.Text + "'").Rows[0][0]);
            enableSubmit();
        }

        private void format_SelectedIndexChanged(object sender, EventArgs e)
        {
            formatID = Convert.ToInt32(SqlManager.query("SELECT FormatID FROM OutputFormats " +
                "WHERE FormatDescription='" + format.Text + "'").Rows[0][0]);
            enableSubmit();
        }

        private void enableSubmit()
        {
            submit.Enabled = !string.IsNullOrWhiteSpace(title.Text) &&
                !string.IsNullOrWhiteSpace(body.Text) &&
                !string.IsNullOrWhiteSpace(location.Text) &&
                !string.IsNullOrWhiteSpace(department.Text) &&
                !string.IsNullOrWhiteSpace(course.Text) &&
                !string.IsNullOrWhiteSpace(topic.Text) &&
                !string.IsNullOrWhiteSpace(difficulty.Text) &&
                !string.IsNullOrWhiteSpace(type.Text) &&
                !string.IsNullOrWhiteSpace(format.Text);
        }

        private void submit_Click(object sender, EventArgs e)
        {
            // Check question title, this should be unique to make searching easier
            if (questionID == 0 && SqlManager.query("SELECT 1 from Questions WHERE QuestionTitle='" + title.Text + "'").Rows.Count == 1)
            {
                MessageBox.Show("Question title already exists, update title and resubmit.", "Title not unique",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                submit.Enabled = false;
                return;
            }
            else if (questionID != 0 && SqlManager.query("SELECT 1 from Questions WHERE QuestionTitle='" + title.Text + "' AND QuestionID<>" + questionID).Rows.Count == 1)
            {
                MessageBox.Show("Question title already exists, update title and resubmit.", "Title not unique",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                submit.Enabled = false;
                return;
            }

            // Check if user would like to commit question to database
            var result = MessageBox.Show("Would you like to commit your question to the database?",
                "Commit Question", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;
            // Check if course topics refernece exists, otherwise create a new reference
            var courseTopicRefID = 0;
            while (true)
            {
                DataTable dt = SqlManager.query("SELECT CourseTopicRefID FROM CourseTopics " +
                    "WHERE LocationID=" + locationID + " AND DepartmentID=" + departmentID + " AND CourseID=" + courseID +
                    " AND TopicID=" + topicID);
                if (dt.Rows.Count == 0)
                {
                    if (!SqlManager.insert("INSERT INTO CourseTopics (LocationID, DepartmentID, CourseID, TopicID) " +
                        "VALUES (" + locationID + ", " + departmentID + ", " + courseID + ", " + topicID + ")"))
                    {
                        MessageBox.Show("Course topic info could not be inserted into database, contact database admin.", "Database Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        submit.Enabled = false;
                        return;
                    }
                }
                else
                {
                    courseTopicRefID = Convert.ToInt32(dt.Rows[0][0]);
                    break;
                }
            }
            StringBuilder sql;
            if (questionID != 0)
            {
                sql = new StringBuilder("UPDATE Questions SET ");
                if (!string.IsNullOrWhiteSpace(image.Text))
                {
                    sql.Append("QuestionImage='" + image.Text + "', ");
                }
                sql.Append("QuestionTitle='" + title.Text + "', ");
                sql.Append("QuestionBody='" + body.Text + "', ");
                sql.Append("CourseTopicRefID=" + courseTopicRefID + ", ");
                sql.Append("DifficultyID=" + difficultyID + ", ");
                sql.Append("TypeID=" + typeID + ", ");
                sql.Append("FormatID=" + formatID + " ");
                sql.Append("WHERE QuestionID=" + questionID);
            }
            else
            {
                sql = new StringBuilder("INSERT INTO Questions (");
                if (!string.IsNullOrWhiteSpace(image.Text))
                {
                    sql.Append("QuestionImage, ");
                }
                sql.Append("QuestionPublished, QuestionTitle, QuestionBody, CourseTopicRefID, ");
                sql.Append("DifficultyID, TypeID, FormatID, AuthorID) VALUES (1, '");
                sql.Append(title.Text + "', '");
                sql.Append(body.Text + "', ");
                sql.Append(courseTopicRefID + ", ");
                sql.Append(difficultyID + ", ");
                sql.Append(typeID + ", ");
                sql.Append(formatID + ", ");
                sql.Append(userID + ")");
            }
            if (SqlManager.insert(sql.ToString()))
            {
                if (questionID != 0 && subquestionDt.Rows.Count > 0)
                {
                    SqlManager.update("DELETE FROM SubQuestions WHERE QuestionID=" + questionID);
                }
                // Add subquestion(s) if present
                for (int i = 0; i < subquestionDt.Rows.Count; i++)
                {
                    var sqlSubQ = new StringBuilder("INSERT INTO SubQuestions (QuestionID, SubQuestionID, SubQuestionText");
                    if (!string.IsNullOrWhiteSpace(subquestionDt.Rows[i]["SubQuestionImage"].ToString()))
                    {
                        sqlSubQ.Append(", SubQuestionImage) ");
                    }
                    else
                    {
                        sqlSubQ.Append(") ");
                    }
                    sqlSubQ.Append("SELECT QuestionID, ");
                    sqlSubQ.Append(i + ", ");
                    sqlSubQ.Append("'" + subquestionDt.Rows[i]["SubQuestionText"] + "' ");
                    if (!string.IsNullOrWhiteSpace(subquestionDt.Rows[i]["SubQuestionImage"].ToString()))
                    {
                        sqlSubQ.Append(", '" + subquestionDt.Rows[i]["SubQuestionImage"] + "' ");
                    }
                    sqlSubQ.Append("FROM Questions WHERE QuestionTitle='");
                    sqlSubQ.Append(title.Text + "'");
                    SqlManager.insert(sqlSubQ.ToString());
                }

                // Add answer(s) if present
                if (questionID != 0 && answerDt.Rows.Count > 0)
                {
                    SqlManager.update("DELETE FROM Answers WHERE QuestionID=" + questionID);
                }
                for (int i = 0; i < answerDt.Rows.Count; i++)
                {
                    var sqlAns = new StringBuilder("INSERT INTO Answers (QuestionID, AnswerID, AnswerText");
                    if (!string.IsNullOrWhiteSpace(answerDt.Rows[i]["AnswerImage"].ToString()))
                    {
                        sqlAns.Append(", AnswerImage) ");
                    }
                    else
                    {
                        sqlAns.Append(") ");
                    }
                    sqlAns.Append("SELECT QuestionID, ");
                    sqlAns.Append(i + ", ");
                    sqlAns.Append("'" + answerDt.Rows[i]["AnswerText"] + "' ");
                    if (!string.IsNullOrWhiteSpace(answerDt.Rows[i]["AnswerImage"].ToString()))
                    {
                        sqlAns.Append(", '" + answerDt.Rows[i]["AnswerImage"] + "' ");
                    }
                    sqlAns.Append("FROM Questions WHERE QuestionTitle='");
                    sqlAns.Append(title.Text + "'");
                    SqlManager.insert(sqlAns.ToString());
                }

                // Add history tag
                sql = new StringBuilder("INSERT INTO History (QuestionID, UserID, EditDescription)");
                sql.Append("SELECT QuestionID, AuthorID, '");
                if (questionID == 0)
                {
                    sql.Append("Initial Commit");
                }
                else
                {
                    var commitMsg = new CommitMessage();
                    string msg = null;
                    while (string.IsNullOrWhiteSpace(msg))
                    {
                        commitMsg.ShowDialog();
                        msg = commitMsg.msg;
                    }
                    sql.Append(msg);
                }
                sql.Append("' FROM Questions WHERE QuestionTitle='");
                sql.Append(title.Text + "'");
                if (SqlManager.insert(sql.ToString()))
                {
                    MessageBox.Show("Question successfully added to database.", "Question Added Successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("An error occured trying to insert into history table, see database admin.",
                        "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("An error occured trying to insert into questions table, see database admin.",
                    "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void title_TextChanged(object sender, EventArgs e)
        {
            enableSubmit();
        }

        private void body_TextChanged(object sender, EventArgs e)
        {
            enableSubmit();
        }

        private void subquestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            editSubquestion.Enabled = true;
        }

        private void addSubquestion_Click(object sender, EventArgs e)
        {
            new SubQuestionAnswer(subquestion, subquestionDt, -1, false).ShowDialog();
            if (subquestion.Items.Count > 0)
            {
                subquestion.Enabled = true;
            }
        }

        private void editSubquestion_Click(object sender, EventArgs e)
        {
            new SubQuestionAnswer(subquestion, subquestionDt, subquestion.SelectedIndex, false).ShowDialog();
        }

        private void answer_SelectedIndexChanged(object sender, EventArgs e)
        {
            editAnswer.Enabled = true;
        }

        private void addAnswer_Click(object sender, EventArgs e)
        {
            var form = new SubQuestionAnswer(answer, answerDt, -1, true);
            form.Text = "Answer";
            form.ShowDialog();
            if (answer.Items.Count > 0)
            {
                answer.Enabled = true;
            }
        }

        private void editAnswer_Click(object sender, EventArgs e)
        {
            var form = new SubQuestionAnswer(answer, answerDt, answer.SelectedIndex, true);
            form.Text = "Answer";
            form.ShowDialog();
        }
    }
}