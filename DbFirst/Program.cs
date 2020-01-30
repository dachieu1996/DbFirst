using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoEntities();
            var courses = context.GetCourses();
            foreach (var course in courses)
            {
                Console.WriteLine(course.Title + "\n");
            }
        }
    }
}
