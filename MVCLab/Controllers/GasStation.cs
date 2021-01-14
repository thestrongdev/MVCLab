using Microsoft.AspNetCore.Mvc;
using MVCLab.Models.GasStation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCLab.Controllers
{
    public class GasStation : Controller
    {
        public IActionResult MileageForm()
        {

            var model = new MileageFormResultsViewModel(); 

            return View(model);
        }

        public IActionResult MileageFormResults(MileageFormResultsViewModel model)
        {

            model.remainingMiles = model.Gallons * model.Mileage;

            model.enoughGas = model.remainingMiles > model.TripDistance;

            if (model.enoughGas)
            {
                model.userNotification = "You have enough gas for your trip!!!!";
            }
            else
            {
                model.userNotification = "You do NOT have enough gas for your trip :(";
            }

            return View(model);
        }
    }
}
