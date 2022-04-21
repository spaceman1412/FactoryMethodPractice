using System;

namespace FactoryMethod
{

    public interface DeadlineFactory
    {
        public List<Deadline> GetDeadlines();
    }


    class ClosetDeadline : DeadlineFactory
    {
        public List<Deadline> GetDeadlines()
        {
            OOSE OOSE = new OOSE();
            DesignPattern designPattern = new DesignPattern();

            List<Deadline> deadlines = OOSE.deadlines();
            deadlines.AddRange(designPattern.deadlines());
            Deadline deadlineCloset = deadlines[0];
            DateTime closet = ConvertStringToDatetime(deadlineCloset.getDeadlineDay());

            List<Deadline> closets = new List<Deadline>();


            //Get closet deadline
            foreach (Deadline deadline in deadlines)
            {
                DateTime dateTime = ConvertStringToDatetime(deadline.getDeadlineDay());
                int result = DateTime.Compare(dateTime, closet);
                if (result < 0)
                {
                    closet = dateTime;
                    deadlineCloset = deadline;
                }
            }


            //Get deadline equal with closet
            foreach (Deadline deadline in deadlines)
            {
                DateTime dateTime = ConvertStringToDatetime(deadline.getDeadlineDay());
                int result = DateTime.Compare(dateTime, closet);
                if (result == 0)
                {
                    closets.Add(deadline);
                }
            }
            return closets;
        }


        public DateTime ConvertStringToDatetime(String dateTime)
        {
            return DateTime.ParseExact(dateTime, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
        }
    }



    class DeadlineCourse : DeadlineFactory
    {
        string courseName;
        public DeadlineCourse(string CourseName)
        {
            this.courseName = CourseName;
        }
        public List<Deadline> GetDeadlines()
        {
            Course course = new DesignPattern();
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
