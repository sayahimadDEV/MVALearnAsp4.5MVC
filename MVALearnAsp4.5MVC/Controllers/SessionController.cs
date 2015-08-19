using MVALearnAsp4._5MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVALearnAsp4._5MVC.Controllers
{
    public class SessionController : Controller
    {
        // GET: Session
        public ActionResult Index()
        {
            ConferenceContext Context = new ConferenceContext();
            List<Session> Sessions = Context.Sessions.ToList();
            return View(Session);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Create(Session session)
        {
            if (!ModelState.IsValid)
            {
                return View(session);
            }

            try
            {
                ConferenceContext context = new ConferenceContext();
                context.Sessions.Add(session);
                context.SaveChanges();
            }
            catch ( Exception e)
            {
                ModelState.AddModelError("error", e.Message);
                return View(session);
            }

            TempData["Message"] = "Created" + session.Title;
            return RedirectToAction("Index");
        }
    }
}