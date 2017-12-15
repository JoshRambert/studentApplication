using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentApplication
{
    abstract class Student
    {
        //Fields 
        private string _name;
        private string _id;

        //Constructor
        public Student(string name, string id) {
            _name = name;
            _id = id;
        }

        //Create the properties 
        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        public string Id {
            get { return _id; }
            set { _id = value; }
        }

        //Get the requiredHours only
        public abstract double RequiredHours {
            get;
        }
    }
}
