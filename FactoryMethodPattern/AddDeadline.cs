using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactoryMethodPattern.Course;
using FactoryMethodPattern.Model;
using FactoryMethodPattern.Factory;
using System.Data;

namespace FactoryMethodPattern
{
    public partial class AddDeadline : Form
    {
        public AddDeadline()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ExtendDeadline deadline = new ExtendDeadline();
                string CourseName = cbCourseName.Text;
                string DeadlineDay = txtDeadlineDay.Text;
                string DeadlineDescription = txtDescription.Text;
                deadline.AddDeadline(CourseName, DeadlineDay, DeadlineDescription);
            }
            catch
            {
                MessageBox.Show("Add failed");
            }
            MessageBox.Show("Add complete");
        }
    }
}
