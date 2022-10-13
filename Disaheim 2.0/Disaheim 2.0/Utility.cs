using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim_2._0
{
    public class Utility
    {
        public double getValueOfBook(Book book)
        {
            return book.Price;
        }

        public double getValueOfAmulet(Amulet amulet)
        {
            switch (amulet.Quality)
            {
                case Level.low:
                    return 12.5;

                case Level.medium:
                    return 20;

                case Level.high:
                    return 27.5;

                default:
                    return 0;
            }
        }
        public double getValueOfCourse(Course course)
        {
            double temp = course.DurationInMinutes / 60;
            double price = Math.Ceiling(temp) * 875;
            return price;
        }
    }
}
