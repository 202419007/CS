using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Homework
{
    class Student
    {
        public string Number;
        public string Name;
        public DateTime BirthInfo;
        public string DepartmentCode;
        public string AdvisorNumber;
        public int Year;
        public string Class;
        public string RegStatus;
        public string Address;
        public string Contact;

        public override string ToString()
        {
            return $"[{this.Number}]{this.Name}";  // this = self
        }
    }
}
