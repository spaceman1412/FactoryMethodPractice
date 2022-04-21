using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern.Model;


namespace FactoryMethodPattern.Course
{
    public interface CourseInterface
    {
        String CourseName();

        List<Deadline> deadlines();
    }
}
