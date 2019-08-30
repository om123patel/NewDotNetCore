using DotNetCore.DomainModel;
using DotNetCore.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DotNetCore.Web.Controllers
{
    public class CountryController : Controller
    {
        //initialize service object
        private readonly ICountryService _CountryService;

        ////Test Life-Time of DI - ENG-00001
        //public IOperationService OperationService { get; }
        //public IOperationTransient TransientOperation { get; }
        //public IOperationScoped ScopedOperation { get; }
        //public IOperationSingleton SingletonOperation { get; }
        //public IOperationSingletonInstance SingletonInstanceOperation { get; }

        //Test Life-Time of DI - ENG-00001
        //public CountryController(IOperationService operationService,
        //IOperationTransient transientOperation,
        //IOperationScoped scopedOperation,
        //IOperationSingleton singletonOperation,
        //IOperationSingletonInstance singletonInstanceOperation)
        //{
        //    OperationService = operationService;
        //    TransientOperation = transientOperation;
        //    ScopedOperation = scopedOperation;
        //    SingletonOperation = singletonOperation;
        //    SingletonInstanceOperation = singletonInstanceOperation;
        //}

        //Test Life-Time of DI - ENG-00001
        //public ActionResult Index()
        //{
        //    Debug.WriteLine("Controller Index TransientOperation:" + TransientOperation.OperationId);
        //    Debug.WriteLine("Controller Index ScopedOperation:" + ScopedOperation.OperationId);
        //    Debug.WriteLine("Controller Index SingletonOperation:" + SingletonOperation.OperationId);
        //    Debug.WriteLine("Controller Index SingletonInstanceOperation:" + SingletonInstanceOperation.OperationId);

        //    OperationService.writeMessag();

        //    return View();
        //}


        public CountryController(ICountryService CountryService)
        {
            _CountryService = CountryService;
        }

        //
        // GET: /Country/
        public ActionResult Index()
        {
            var IpAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            return View(_CountryService.GetAll());
        }

        //
        // GET: /Country/Details/5
        public ActionResult Details(int id)
        {


            return View();
        }

        //
        // GET: /Country/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Country/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CountryModel country)
        {

            // TODO: Add insert logic here
            if (ModelState.IsValid)
            {
                _CountryService.Create(country);
                return RedirectToAction("Index");
            }
            return View(country);

        }

        //
        // GET: /Country/Edit/5
        public ActionResult Edit(int id)
        {
            CountryModel country = _CountryService.GetById(id);
            return View(country);
        }

        //
        // POST: /Country/Edit/5
        [HttpPost]
        public ActionResult Edit(CountryModel country)
        {

            if (ModelState.IsValid)
            {
                _CountryService.Update(country);
                return RedirectToAction("Index");
            }
            return View(country);

        }

        //
        // GET: /Country/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    CountryModel country = _CountryService.GetById(id);
        //    if (country == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(country);
        //}

        ////
        //// POST: /Country/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, FormCollection data)
        //{
        //    CountryModel country = _CountryService.GetById(id);
        //    _CountryService.Delete(country);
        //    return RedirectToAction("Index");
        //}
    }
}