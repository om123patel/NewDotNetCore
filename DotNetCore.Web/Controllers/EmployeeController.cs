using DotNetCore.DomainModel;
using DotNetCore.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using DotNetCore.Utilities.Constants;

namespace DotNetCore.Web.Controllers
{
    //[ApiController]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDesignationService _designationService;
        private readonly IDepartmentService _departmentService;

        public EmployeeController(IEmployeeService employeeService, IDesignationService designationService, IDepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
            _designationService = designationService;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Grid([FromBody] searchModel model)
        {
            if (string.IsNullOrEmpty(model.SortingColumn))
                model.SortingColumn = "FirstName";

            return View(_employeeService.GetList(model.Page, model.PageSize, model.SortingColumn, model.SortingDirection));
        }


        public ActionResult Create()
        {
            EmployeeModel model = new EmployeeModel();
            model.DepartmentList = _departmentService.GetAll().Select(d =>
            new SelectListItem
            {
                Text = d.Name,
                Value = d.Id.ToString()

            }).ToList();

            model.DesignationList = _designationService.GetAll().Select(d =>
            new SelectListItem
            {
                Text = d.Name,
                Value = d.Id.ToString()

            }).ToList();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                _employeeService.Create(model);
                return RedirectToAction("Index");
            }
            return View();
        }


        public ActionResult Edit(int Id)
        {
            EmployeeModel model = _employeeService.GetById(Id);

            model.DepartmentList = _departmentService.GetAll().Select(d =>
           new SelectListItem
           {
               Text = d.Name,
               Value = d.Id.ToString()

           }).ToList();

            model.DesignationList = _designationService.GetAll().Select(d =>
            new SelectListItem
            {
                Text = d.Name,
                Value = d.Id.ToString()

            }).ToList();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                _employeeService.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }


        //GET: /Country/Delete/5


        public ActionResult Delete(int id)
        {
            EmployeeModel country = _employeeService.GetById(id);
            return View(country);
        }

        //
        // POST: /Country/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public ActionResult Delete(long id, object o)
        {
            _employeeService.Delete(id);
            return RedirectToAction("Index");
        }
    }

    public class searchModel
    {
        public int? Page { get; set; }
        public int? PageSize { get; set; }
        public string SortingColumn { get; set; }
        public string SortingDirection { get; set; }
    }
}