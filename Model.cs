using System;
using System.Collections.Generic;
namespace FactoryMethod
{
    public interface Course
    {
        String CourseName();

        List<Deadline> deadlines();
    }



    public class Deadline
    {
        private String CourseName;
        private String DeadlineDay;

        private String DeadlineDescription;

        public Deadline(string courseName, string deadlineDay, string deadlineDescription)
        {
            this.CourseName = courseName;
            this.DeadlineDay = deadlineDay;
            this.DeadlineDescription = deadlineDescription;
        }
        public String getCourseName()
        {
            return this.CourseName;
        }

        public void setCourseName(String CourseName)
        {
            this.CourseName = CourseName;
        }

        public String getDeadlineDay()
        {
            return this.DeadlineDay;
        }

        public void setDeadlineDay(String DeadlineDay)
        {
            this.DeadlineDay = DeadlineDay;
        }

        public String getDeadlineDescription()
        {
            return this.DeadlineDescription;
        }

        public void setDeadlineDescription(String DeadlineDescription)
        {
            this.DeadlineDescription = DeadlineDescription;
        }
    }

    public class OOSE : Course
    {
        public OOSE()
        {

        }
        public List<Deadline> deadlines()
        {
            List<Deadline> deadlines = new List<Deadline>()
            {
                new Deadline(CourseName(),"24/04/2022","This is a description"),
                new Deadline(CourseName(),"25/04/2022","This is a description"),
                new Deadline(CourseName(),"26/04/2022","This is a description"),
                new Deadline(CourseName(),"27/04/2022","This is a description"),
            };
            return deadlines;
        }
        public string CourseName()
        {
            return "OOSE";
        }
    }


    public class DesignPattern : Course
    {
        public List<Deadline> deadlines()
        {
            List<Deadline> deadlines = new List<Deadline>()
            {
                new Deadline(CourseName(),"24/04/2022","This is a description"),
                new Deadline(CourseName(),"25/04/2022","This is a description"),
                new Deadline(CourseName(),"26/04/2022","This is a description"),
                new Deadline(CourseName(),"27/04/2022","This is a description"),
            };
            return deadlines;
        }
        public string CourseName()
        {
            return "Design Pattern";
        }
    }


}

