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
            Console.WriteLine(deadline.FactoryMethod().getCourseName());

            DeadlineCourse deadlineCourse = new DeadlineCourse("OOSE");
            Console.WriteLine(deadlineCourse.FactoryMethod().getCourseName());
        }
    }
}