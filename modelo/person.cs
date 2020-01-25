using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Person
    {
        private String name;
        private String lastname;
        private int age;
        private int semester;
        private Boolean recycle;

        public Person(String n, String l, int a, int s, Boolean r) {
            Name = n;
            Lastname = l;
            Age = a;
            semester = s;
            Recycle = r;
        }

        public String Name { get; set;}
        public String Lastname { get; set;}
        public int Age { get; set; }
        public int Semester { get; set; }
        public Boolean Recycle { get; set; }

        public int getSemester() {
            return semester;
        }

    }
}
