using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCLab.Models.Calculator
{
    public class OperationFormResultViewModel
    {
        public AdditionFormResultViewModel AddModel { get; set; }
        public DivisionFormResultViewModel DivideModel { get; set; }

        public string results { get; set; }

        public string Operation { get; set; }


        public OperationFormResultViewModel()
        {
            AddModel = new AdditionFormResultViewModel();
            DivideModel = new DivisionFormResultViewModel();

            AddModel.X = 0;
            AddModel.Y = 0;
            DivideModel.Divisor = 1;
            DivideModel.Dividend = 0;
        }

    }
}
