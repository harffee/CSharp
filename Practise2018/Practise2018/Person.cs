using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise2018
{
    public class Person:ICustomCompare
    {
        int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int CompareTo(object value)
        {
            if(value==null)
            {
                return 1;
            }
            Person otherp = (Person)value;
            if(this.Age<otherp.Age)
            {
                return 1;
            }
            return 0;
        }
    }
}
