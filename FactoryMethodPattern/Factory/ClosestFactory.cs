using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern.Model;
using FactoryMethodPattern.Course;

namespace FactoryMethodPattern.Factory
{
    public class ClosestFactory : DeadlineFactory
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
}
