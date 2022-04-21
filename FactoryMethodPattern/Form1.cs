
using FactoryMethodPattern.Course;
using FactoryMethodPattern.Model;
using FactoryMethodPattern.Factory;
using System.Data;

namespace FactoryMethodPattern

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClosestFactory deadlines = new ClosestFactory();
            List<Deadline> list = deadlines.GetDeadlines();

            LoadDataToDgv(list);
        }

        public void LoadDataToDgv(List<Deadline> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CourseName");
            dt.Columns.Add("DeadlineDay");
            dt.Columns.Add("DeadlineDescription");
            foreach (var oItem in list)
            {
                dt.Rows.Add(new object[] { oItem.getCourseName(), oItem.getDeadlineDay(), oItem.getDeadlineDescription() });
            }
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String courseName = cbCourseName.Text;
            CourseDeadline deadline = new CourseDeadline(courseName);
            List<Deadline> list = deadline.GetDeadlines();

            LoadDataToDgv(list);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExtendDeadline deadline = new ExtendDeadline();
            List<Deadline> deadlines = deadline.GetDeadlines();
            LoadDataToDgv(deadlines);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddDeadline form = new AddDeadline();
            form.ShowDialog();
        }
    }
}