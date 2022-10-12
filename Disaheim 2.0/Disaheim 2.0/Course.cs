using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim_2._0
{
    public class Course
    {
        string _name;
        int _durationInMinutes;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public int DurationInMinutes
        {
            get { return _durationInMinutes; }
            set { _durationInMinutes = value; }
        }
        public Course(string Name, int DurationInMinutes)
        {
            _name = Name;
            _durationInMinutes = DurationInMinutes;
        }
        public Course(string Name) : this(Name, 0) { }

        public override string ToString()
        {
            return "Name: " + Name + ", " + "Duration in Minutes: " + DurationInMinutes; 
        }
    }
}
