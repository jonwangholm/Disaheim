using Program;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim_2._0
{
    public class Controller
    {

        private static List<Book> books = new List<Book>();
        private static List<Amulet> amulets = new List<Amulet>();
        private static List<Course> courses = new List<Course>();

        public Controller()
        {
            books = new List<Book>();
            amulets = new List<Amulet>();
            courses = new List<Course>();  
        }

        public void addToList(Book book)
        {
            books.Add(book);
        }
        public void addToList(Amulet amulet)
        {
            amulets.Add(amulet);
        }
        public void addToList(Course course)
        {
            courses.Add(course);
        }




    }
}
