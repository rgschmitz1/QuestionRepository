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
    public partial class UserForm : Form
    {
        private static int userID;
        private static int locationID;
        private static int departmentID;
        private static int courseID;
        private static int topicID;
        private static int difficultyID;
        private static int typeID;
        private static int formatID;

        public UserForm(int id)
        {
            // Pass UserID key to track user activity
            userID = id;

            InitializeComponent();

            populateQuestions();
        }

        private void question_SelectedIndexChanged(object sender, EventArgs e)
        {
            history.Enabled = editquestion.Enabled = !string.IsNullOrWhiteSpace(question.Text);
        }

        private void populateQuestions()
        {
            // Populate Questions dropdown
            StringBuilder sql = new StringBuilder("SELECT QuestionTitle FROM Questions");
            if (locationID != 0 || departmentID != 0 || courseID != 0 || topicID != 0 ||
                difficultyID != 0 || typeID != 0 || formatID != 0)
            {
                sql.Append(" WHERE ");
            }
            // First use topicID to narrow things down
            var idmap = new Dictionary<string, int>();
            if (locationID != 0) idmap.Add("LocationID", locationID);
            if (departmentID != 0) idmap.Add("DepartmentID", departmentID);
            if (courseID != 0) idmap.Add("CourseID", courseID);
            if (topicID != 0) idmap.Add("TopicID", topicID);
            var first = true;
            var last = idmap.Count;

            foreach (var key in idmap.Keys)
            {
                last--;
                if (first)
                {
                    sql.Append("CourseTopicRefID IN (SELECT CourseTopicRefID FROM CourseTopics WHERE ");
                    sql.Append(key + "=" + idmap[key]);
                    first = false;
                }
                else
                {
                    sql.Append(" AND " + key + "=" + idmap[key] );
                }
                if (last == 0)
                {
                    sql.Append(")");
                }
            }

            idmap.Clear();
            if (difficultyID != 0) idmap.Add("DifficultyID", difficultyID);
            if (typeID != 0) idmap.Add("TypeID", typeID);
            if (formatID != 0) idmap.Add("FormatID", formatID);

            foreach (var key in idmap.Keys)
            {
                if (first)
                {
                    sql.Append(key + "=" + idmap[key]);
                    first = false;
                }
                else
                {
                    sql.Append(" AND " + key + "=" + idmap[key]);
                }
            }

            DataTable dt = SqlManager.query(sql.ToString());
            question.Items.Clear();
            if (dt.Rows.Count == 0)
            {
                noquestions.Visible = true;
            }
            else
            {
                noquestions.Visible = false;
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                question.Items.Add(dt.Rows[i][0]);
            }
            editquestion.Enabled = history.Enabled = false;
            populateLocation();
            populateDepartment();
            populateCourse();
            populateTopic();
            populateDifficulty();
            populateType();
            populateFormat();
        }

        private void populateLocation()
        {
            StringBuilder sql = new StringBuilder("SELECT LocationName FROM Locations ");
            sql.Append("WHERE LocationID IN (SELECT LocationID FROM CourseTopics WHERE ");
            sql.Append("CourseTopicRefID IN (SELECT CourseTopicRefID FROM Questions WHERE QuestionTitle IN (");
            for (int i = question.Items.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    sql.Append("'" + question.Items[i] + "')))");
                }
                else
                {
                    sql.Append("'" + question.Items[i] + "', ");
                }
            }
            DataTable dt = SqlManager.query(sql.ToString());
            populateComboBox(location, dt);
        }

        private void populateDepartment()
        {
            StringBuilder sql = new StringBuilder("SELECT DepartmentName FROM Departments ");
            sql.Append("WHERE DepartmentID IN (SELECT DepartmentID FROM CourseTopics WHERE ");
            //sql.Append("LocationID=" + locationID + " AND ");
            sql.Append("CourseTopicRefID IN (SELECT CourseTopicRefID FROM Questions WHERE QuestionTitle IN (");
            for (int i = question.Items.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    sql.Append("'" + question.Items[i] + "')))");
                }
                else
                {
                    sql.Append("'" + question.Items[i] + "', ");
                }
            }
            DataTable dt = SqlManager.query(sql.ToString());
            populateComboBox(department, dt);
        }

        private void populateCourse()
        {
            StringBuilder sql = new StringBuilder("SELECT CourseName FROM Courses ");
            sql.Append("WHERE CourseID IN (SELECT CourseID FROM CourseTopics WHERE ");
            //sql.Append("LocationID =" + locationID + " AND ");
            //sql.Append("DepartmentID=" + departmentID + " AND ");
            sql.Append("CourseTopicRefID IN (SELECT CourseTopicRefID FROM Questions WHERE QuestionTitle IN (");
            for (int i = question.Items.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    sql.Append("'" + question.Items[i] + "')))");
                }
                else
                {
                    sql.Append("'" + question.Items[i] + "', ");
                }
            }
            DataTable dt = SqlManager.query(sql.ToString());
            populateComboBox(course, dt);
        }

        private void populateTopic()
        {
            StringBuilder sql = new StringBuilder("SELECT TopicDescription FROM Topics ");
            sql.Append("WHERE TopicID IN (SELECT TopicID FROM CourseTopics WHERE ");
            sql.Append("CourseTopicRefID IN (SELECT CourseTopicRefID FROM Questions WHERE QuestionTitle IN (");
            for (int i = question.Items.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    sql.Append("'" + question.Items[i] + "')))");
                }
                else
                {
                    sql.Append("'" + question.Items[i] + "', ");
                }
            }
            DataTable dt = SqlManager.query(sql.ToString());
            populateComboBox(topic, dt);
        }

        private void populateDifficulty()
        {
            // If there are no questions, just return
            if (question.Items.Count == 0)
            {
                difficulty.Items.Clear();
                return;
            }

            StringBuilder sql = new StringBuilder("SELECT DifficultyDescription FROM Difficulty " +
                "WHERE DifficultyID IN (SELECT DifficultyID FROM Questions WHERE QuestionTitle IN (");
            for (int i = question.Items.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    sql.Append("'" + question.Items[i] + "'))");
                }
                else
                {
                    sql.Append("'" + question.Items[i] + "', ");
                }
            }
            DataTable dt = SqlManager.query(sql.ToString());
            populateComboBox(difficulty, dt);
        }

        private void populateType()
        {
            // If there are no questions, just return
            if (question.Items.Count == 0)
            {
                type.Items.Clear();
                return;
            }

            StringBuilder sql = new StringBuilder("SELECT TypeDescription FROM QuestionTypes " +
                "WHERE TypeID IN (SELECT TypeID FROM Questions WHERE QuestionTitle IN (");
            for (int i = question.Items.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    sql.Append("'" + question.Items[i] + "'))");
                }
                else
                {
                    sql.Append("'" + question.Items[i] + "', ");
                }
            }
            DataTable dt = SqlManager.query(sql.ToString());
            populateComboBox(type, dt);
        }

        private void populateFormat()
        {
            // If there are no questions, just return
            if (question.Items.Count == 0)
            {
                format.Items.Clear();
                return;
            }

            StringBuilder sql = new StringBuilder("SELECT FormatDescription FROM OutputFormats " +
                "WHERE FormatID IN (SELECT FormatID FROM Questions WHERE QuestionTitle IN (");
            for (int i = question.Items.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    sql.Append("'" + question.Items[i] + "'))");
                }
                else
                {
                    sql.Append("'" + question.Items[i] + "', ");
                }
            }
            DataTable dt = SqlManager.query(sql.ToString());
            populateComboBox(format, dt);
        }

        private void location_SelectedIndexChanged(object sender, EventArgs e)
        {
            locationID = Convert.ToInt32(SqlManager.query("SELECT LocationID FROM Locations " +
                "WHERE LocationName='" + location.Text + "'").Rows[0][0]);
            populateQuestions();
            department.Enabled = true;
        }

        private void department_SelectedIndexChanged(object sender, EventArgs e)
        {
            departmentID = Convert.ToInt32(SqlManager.query("SELECT DepartmentID FROM Departments " +
                "WHERE DepartmentName='" + department.Text + "' AND LocationID=" + locationID).Rows[0][0]);
            populateQuestions();
            course.Enabled = true;
        }

        private void course_SelectedIndexChanged(object sender, EventArgs e)
        {
            courseID = Convert.ToInt32(SqlManager.query("SELECT CourseID FROM Courses " +
                "WHERE CourseName='" + course.Text + "' AND LocationID=" + locationID + " AND DepartmentID=" + departmentID).Rows[0][0]);
            populateQuestions();
        }

        private void topic_SelectedIndexChanged(object sender, EventArgs e)
        {
            topicID = Convert.ToInt32(SqlManager.query("SELECT TopicID FROM Topics WHERE " +
                "TopicDescription='" + topic.Text + "'").Rows[0][0]);
            populateQuestions();
        }

        private void difficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            difficultyID = Convert.ToInt32(SqlManager.query("SELECT DifficultyID FROM Difficulty " +
                "WHERE DifficultyDescription='" + difficulty.Text + "'").Rows[0][0]);
            populateQuestions();
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeID = Convert.ToInt32(SqlManager.query("SELECT TypeID FROM QuestionTypes " +
                "WHERE TypeDescription='" + type.Text + "'").Rows[0][0]);
            populateQuestions();
        }

        private void format_SelectedIndexChanged(object sender, EventArgs e)
        {
            formatID = Convert.ToInt32(SqlManager.query("SELECT FormatID FROM OutputFormats " +
                "WHERE FormatDescription='" + format.Text + "'").Rows[0][0]);
            populateQuestions();
        }

        private void populateComboBox(ComboBox combobox, DataTable dt)
        {
            for (int i = combobox.Items.Count - 1; i >= 0; i--)
            {
                var remove = true;
                for (int j = dt.Rows.Count - 1; j >= 0; j--)
                {
                    if (dt.Rows[j][0].Equals(combobox.Items[i]))
                    {
                        remove = false;
                        dt.Rows.RemoveAt(j);
                        break;
                    }
                }
                if (remove)
                {
                    combobox.Items.RemoveAt(i);
                }
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                combobox.Items.Add(dt.Rows[i][0]);
            }
        }

        private void clearfilters_Click(object sender, EventArgs e)
        {
            // Disable some filters
            department.Enabled = course.Enabled = false;

            location.Items.Clear();
            department.Items.Clear();
            course.Items.Clear();
            topic.Items.Clear();
            difficulty.Items.Clear();
            type.Items.Clear();
            format.Items.Clear();

            locationID = departmentID = courseID = topicID = difficultyID = typeID = formatID = 0;

            populateQuestions();
        }

        private void addquestion_Click(object sender, EventArgs e)
        {
            new AddQuestion(userID, 0).ShowDialog();
            populateQuestions();
        }

        private void history_Click(object sender, EventArgs e)
        {
            var sql = "SELECT EditTimestamp, UserName, EditDescription FROM History H, Users U " +
                "WHERE QuestionID = (SELECT QuestionID FROM Questions WHERE QuestionTitle='" + question.Text + "') AND H.UserID = U.UserID";
            DataTable dt = SqlManager.query(sql);
            dt.Columns[0].ColumnName = "Edit Timestamp";
            dt.Columns[1].ColumnName = "Username";
            dt.Columns[2].ColumnName = "Description";
            new History(dt).ShowDialog();
        }

        private void editquestion_Click(object sender, EventArgs e)
        {
            int questionid = Convert.ToInt32(SqlManager.query("SELECT QuestionID FROM Questions WHERE QuestionTitle='" + question.Text + "'").Rows[0][0]);
            new AddQuestion(userID, questionid).ShowDialog();
            populateQuestions();
        }
    }
}