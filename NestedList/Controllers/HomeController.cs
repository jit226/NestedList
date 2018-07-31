using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NestedList.Models;


namespace NestedList.Controllers
{
    public class HomeController : Controller
    {
        string listStorage = string.Empty;
        // GET: Default
        public ActionResult Index()
        {
            string nestedListString = CreateList(0);
            if (nestedListString.Length > 9)
            {
                nestedListString = nestedListString.Substring(4, nestedListString.Length - 4);
                nestedListString = nestedListString.Substring(0, nestedListString.Length - 5);
            }
            HtmlString nestedListHtml = new HtmlString(nestedListString);

            return View(nestedListHtml);
        }
        private string CreateList(int parentId)
        {
            List<Employee> employees = Employee.GetList().Where(emp => emp.ParentId == parentId).OrderBy(emp => emp.ParentId).ToList();
            if (employees.Count() > 0)
            {
                listStorage = listStorage + "<li><ul>";
                foreach (var emps in employees)
                {
                    listStorage = listStorage + "<li>" + emps.Name + "</li>";
                    listStorage = CreateList(emps.Id);

                }
                listStorage = listStorage + "</ul></li>";
            }
            return listStorage;
        }

    }
}