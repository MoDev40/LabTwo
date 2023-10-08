using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwo
{
    class Employee
    {
        private string ename;
        private int number;

        public Employee() { }

        public Employee(string ename, int number)
        {
            this.ename = ename;
            this.number = number;
        }   

        public string Ename
        {
            get { return ename; }
            set { ename = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}
