using System;

namespace FactoryMethod
{
    // The Creator class declares the factory method that is supposed to return
    // an object of a Product class. The Creator's subclasses usually provide
    // the implementation of this method.

    abstract class Creator
    {
        public abstract Deadline FactoryMethod();

        public Deadline GetDeadline()
        {
            ClosetDeadline closetDeadline = new ClosetDeadline();
            Deadline closet = closetDeadline.FactoryMethod();
            return closet;
        }

        public Deadline GetDeadlineCourse()
        {
            return null;
        }
    }

    class ClosetDeadline : Creator
    {
        public override Deadline FactoryMethod()
        {
            OOSE OOSE = new OOSE();
            DesignPattern designPattern = new DesignPattern();

            List<Deadline> deadlines = OOSE.deadlines();
            deadlines.AddRange(designPattern.deadlines());
            Deadline deadlineCloset = deadlines[0];
            DateTime closet = ConvertStringToDatetime(deadlineCloset.getDeadlineDay());

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
            return deadlineCloset;
        }

        public DateTime ConvertStringToDatetime(String dateTime)
        {
            return DateTime.ParseExact(dateTime, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
        }
    }


    class DeadlineCourse : Creator
    {
        string courseName;
        public DeadlineCourse(string CourseName)
        {
            this.courseName = CourseName;
        }
        public override Deadline FactoryMethod()
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
            return deadlines[0];
        }
    }
}