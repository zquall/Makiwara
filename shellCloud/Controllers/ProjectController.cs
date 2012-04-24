using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReplicantFacility.Factory;
using ReplicantRepository.DataTransferObjects;
using ReplicantRepository.Request;
using Hades.Session;
using shellCloud.Models;

namespace shellCloud.Controllers
{
    public class ProjectController : Controller
    {
        //
        // GET: /Project/

        public ActionResult Index()
        {
            var model = new ProjectInformModel();
            var request = new ProjectInformRequest { EmployeeId = SessionManager.EmployeeId };
            model.PendingProjectInforms = new ProjectInformFactory().GetPendingProjectInform(request).ProjectInformList;
            return View(model);
        }

        //
        // GET: /Project/Details/5

        public ActionResult InformManager()
        {
            return View();
        }



        //
        // POST: /Project/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Project/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Project/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Project/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Project/Delete/5

        [HttpGet]
        public ActionResult CreateProjectInform(string projectCode = "")
        {
            // Security needed
            if (projectCode != string.Empty)
            {
                var request = new ProjectRequest() { ProjectCode = projectCode };
                var response = new ProjectFactory().GetProjectByCode(request);
                if(response.Project != null)
                {
                    var model = new ProjectInformModel();
                    model.Project = response.Project;
                    model.DateCreated = DateTime.Now;
                    model.DateModified = DateTime.Now;
                    model.InspectorName = SessionManager.FullName;
                    return View(model);
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult CreateProjectInform()
        {
            return View();
        }
        
        // data GET service
        [HttpGet]
        public JsonResult GetActiveProjects()
        {
            var jsonData = new ProjectFactory().GetActiveProjects();
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }
    }
}
