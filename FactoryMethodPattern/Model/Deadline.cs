using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Model
{
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
}
