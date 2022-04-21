using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern.Model;


namespace FactoryMethodPattern.Course
{
    public class DesignPattern : CourseInterface
    {
        private List<Deadline> list = new List<Deadline>()
            {
                new Deadline("Design Pattern","24/04/2022","This is a description"),
                new Deadline("Design Pattern","25/04/2022","This is a description"),
                new Deadline("Design Pattern","26/04/2022","This is a description"),
                new Deadline("Design Pattern","27/04/2022","This is a description"),
            };
        

        public DesignPattern()
        {
           
        }
        public List<Deadline> deadlines()
        {            
            return this.list;
        }
        public string CourseName()
        {
            return "Design Pattern";
        }
        public void AddDeadline( string DeadlineDay, string DeadlineDescription)
        {
            this.list.Add(new Deadline(CourseName(), DeadlineDay, DeadlineDescription));
        }
    }
}
