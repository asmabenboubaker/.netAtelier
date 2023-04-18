using AM.applicationCore;
using AM.applicationCore.Interfaces;
using AM.applicationCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Packaging.Signing;

namespace AM.UI.web.Controllers
{
    public class FlightController : Controller
    {
        private IserviceFlight IserviceFlight;
        private IServicePlane servicePlane;
        public FlightController(IserviceFlight iserviceFlight,IServicePlane servicePlane) { 
        
        this.IserviceFlight = iserviceFlight;
            this.servicePlane = servicePlane;
        }
        // GET: FlightController
        public ActionResult Index(string destination)
        {

            var list = IserviceFlight.GetAll().ToList();
            if (destination != null) {
            list=list.Where(f => f.Destination.Contains(destination)).ToList();
            }
            return View(list);
        }

        // GET: FlightController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FlightController/Create
        public ActionResult Create()
        {
            ViewBag.Planes =new SelectList( servicePlane.GetAll(),"PlaneId", "Information");
            return View();
        }

        // POST: FlightController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Flight collection, IFormFile piloteFile)
        {
            try
            {
                if(piloteFile!=null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "NewFolder", piloteFile.FileName);
                    var stream = new FileStream(path, FileMode.Create);
                    piloteFile.CopyTo(stream);
                    collection.Pilote = piloteFile.FileName;
                }
                
                IserviceFlight.Add(collection);
                IserviceFlight.Commit();
                return RedirectToAction(nameof(Index));
               
            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController/Edit/5
        public ActionResult Edit(int id)
        {
            var flight = IserviceFlight.GetById(id);
            ViewBag.Planes = new SelectList(servicePlane.GetAll(), "PlaneId","Information");
            return View(flight);

        }

        // POST: FlightController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Flight collection)
        {
            try
            {
                IserviceFlight.Update(collection);
                IserviceFlight.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FlightController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        //[HttpPost]
        //public ActionResult Index(string destination)
        //{
        //    return View("index",IserviceFlight.GetAll().Where(f=>f.Destination.Contains(destination)));
        //}

    }
}
