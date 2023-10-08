using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwo
{
    class ProductionWork :Employee
    {
        private string shift;
        private decimal payRate;

        public ProductionWork() { }

        public ProductionWork (string shift, decimal payRate)
        {
            this.shift = shift;
            this.payRate = payRate;
        }

        public string Shift 
        { 
            get { return shift; }
            set {  shift = value; }
        }
        public decimal PayRate
        {
            get { return payRate; }
            set { payRate = value; }
        }
    }
}
