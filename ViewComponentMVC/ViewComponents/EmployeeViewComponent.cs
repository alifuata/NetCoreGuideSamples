
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentMVC.Models;

namespace ViewComponentMVC.ViewComponents
{
    [ViewComponent(Name = "EmployeeViewComponent")]
    public class EmployeeViewComponent : ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            List<EmployeeModel> employeeList = new List<EmployeeModel>()
            {
                new EmployeeModel(){employeeId=1,nameSurname="John Doe",eMail="john@doe.com"},
                new EmployeeModel(){employeeId=2,nameSurname="Jane Doe",eMail="jane@doe.com"}
            };
            return View(employeeList);
        }
      
    }
}
