using Microsoft.AspNetCore.Mvc;
using MVCLab.Models.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCLab.Controllers
{
    public class Calculator : Controller
    {
        public IActionResult OperationForm()
        {
            return View();
        }

        public IActionResult OperationFormResult(OperationFormResultViewModel model)
        {
            model.AddModel.Sum = model.AddModel.X + model.AddModel.Y;
            model.DivideModel.Quotient = model.DivideModel.Dividend / model.DivideModel.Divisor;
            model.DivideModel.Remainder = model.DivideModel.Dividend % model.DivideModel.Divisor;

            if (model.AddModel.Sum != 0)
            {
                model.Operation = "Addition";
                model.results = $"Your sum is {model.AddModel.Sum}";
            }
            else if (model.DivideModel.Quotient != 0)
            {
                model.Operation = "Division";
                model.results = $"Your quotient is {model.DivideModel.Quotient} and your remainder is {model.DivideModel.Remainder}";
            }
            else
            {
                model.Operation = "Nothing computed";
                model.results = $"Both values cannot be zero";
            }

            return View(model);
        }

        //public IActionResult AdditionFormResult(OperationFormResultViewModel model)
        //{
        //    model.AddModel.sum = model.AddModel.x + model.AddModel.y;
        //    model.Operation = "Addition";
        //    model.results = $"Your sum is {model.AddModel.sum}";
        //    return View(model);
        //}

        //public IActionResult DivisionFormResult(OperationFormResultViewModel model)
        //{
        //    model.DivideModel.Quotient = model.DivideModel.Dividend / model.DivideModel.Divisor;
        //    model.DivideModel.Remainder = model.DivideModel.Dividend % model.DivideModel.Divisor;
        //    model.Operation = "Division";
        //    model.results = $"Your quotient is {model.DivideModel.Quotient} and your remainder is {model.DivideModel.Remainder}";

        //    return View(model);
        //}
    }
}
