using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern.Model;
using FactoryMethodPattern.Course;

namespace FactoryMethodPattern.Factory
{
    public class CourseDeadline : DeadlineFactory
    {
        string courseName;
        public CourseDeadline(string CourseName)
        {
            this.courseName = CourseName;
        }
        public List<Deadline> GetDeadlines()
        {
            CourseInterface course = new DesignPattern();
            switch (courseName)
            {
                case "OOSE":
                    course = new OOSE();
                    break;
                case "Design Pattern":
                    course = new DesignPattern();
                    break;
                default:
                    break;
            }

            List<Deadline> deadlines = course.deadlines();
            return deadlines;
        }
    }
}
