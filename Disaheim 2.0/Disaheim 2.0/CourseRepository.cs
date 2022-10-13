using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim_2._0
{
    public class CourseRepository
    {
        private static List<Course> courses = new List<Course>();
        Utility utility = new Utility();
        public void addToList(Course course)
        {
            courses.Add(course);
        }

        public Course GetCourse(string name)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].Name == name)
                {
                    return courses[i];
                }
            }
            return null;
        }

        public double getTotalValue()
        {
            double pris = 0;
            for (int i = 0; i < courses.Count; i++)
            {
                pris += utility.getValueOfCourse(courses[i]);
            }
            return pris;
        } 


    }
}
