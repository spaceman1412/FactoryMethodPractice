using System;

namespace FactoryMethod
{
    // The Creator class declares the factory method that is supposed to return
    // an object of a Product class. The Creator's subclasses usually provide
    // the implementation of this method.

    class Program
    {
        static void Main(string[] args)
        {
            ClosetDeadline deadline = new ClosetDeadline();
            List<Deadline> list = deadline.GetDeadlines();
            foreach (Deadline deadline1 in list)
            {
                Console.WriteLine(deadline1.getDeadlineDay());
            }

            DeadlineCourse deadlineCourse = new DeadlineCourse("OOSE");
            list = deadlineCourse.GetDeadlines();
            foreach (Deadline deadline1 in list)
            {
                Console.WriteLine(deadline1.getDeadlineDay());
            }
        }
    }
}