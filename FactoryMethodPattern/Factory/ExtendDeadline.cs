using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern.Model;
using FactoryMethodPattern.Course;

namespace FactoryMethodPattern.Factory
{
    public class ExtendDeadline : DeadlineFactory
    {
        public List<Deadline> GetDeadlines()
        {
            List<Deadline> deadlines = new List<Deadline>();
            deadlines.AddRange(new OOSE().deadlines());
            deadlines.AddRange(new DesignPattern().deadlines());
            return deadlines;
        }

        public void AddDeadline(string CourseName, string DeadlineDay, string DeadlineDescription)
        {
            switch(CourseName)
            {
                case "OOSE":
                    OOSE oOSE = new OOSE();
                    oOSE.AddDeadline(DeadlineDay, DeadlineDescription); 
                    break;
                case "Design Pattern":
                    DesignPattern designPattern = new DesignPattern();
                    designPattern.AddDeadline(DeadlineDay, DeadlineDescription);
                    break;
            }
        }
    }
}
