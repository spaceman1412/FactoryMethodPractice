using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern.Model;


namespace FactoryMethodPattern.Course
{
    public class OOSE : CourseInterface
    {
        List<Deadline> list = new List<Deadline>()
            {
                new Deadline("OOSE","24/04/2022","This is a description"),
                new Deadline("OOSE","25/04/2022","This is a description"),
                new Deadline("OOSE","26/04/2022","This is a description"),
                new Deadline("OOSE","27/04/2022","This is a description"),
            };
        public OOSE()
        {
             
        }
        public List<Deadline> deadlines()
        {
            
            return this.list;
        }
        public string CourseName()
        {
            return "OOSE";
        }

        public void AddDeadline(string DeadlineDay, string DeadlineDescription)
        {
            this.list.Add(new Deadline(CourseName(), DeadlineDay, DeadlineDescription));
        }
    }
}
