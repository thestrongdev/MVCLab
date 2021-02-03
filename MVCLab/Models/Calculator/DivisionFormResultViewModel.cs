using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCLab.Models.Calculator
{
    public class DivisionFormResultViewModel : OperationFormResultViewModel
    {
        public double Dividend { get; set; }
        public double Divisor { get; set; }
        public double Quotient { get; set; }

        public double Remainder { get; set; }


    }
}
