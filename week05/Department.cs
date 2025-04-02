using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Homework
{
    //Object 클래스를 상속한
    //Department 클래스
    class Department : Object
    {
        public string Code;
        public string Name;

        public override string ToString()
        {
            return $"[{Code}] {Name}";
        }
    }
}
