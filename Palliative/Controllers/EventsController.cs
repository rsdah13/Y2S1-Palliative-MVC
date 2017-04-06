using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Palliative.Models;
using System.Net;

namespace Palliative.Controllers
{
    public class EventsController : Controller
    {
        EventModelDbContext db = new EventModelDbContext();
        // GET: Events
        public ActionResult Index()
        {
            return View(db.Events.Where(x => x.current == true).ToList());
        }
        
        public ActionResult Add(DateTime event_date, string event_type, string event_data)
        {
            EventModel e = new EventModel();
            e.date = event_date;
            e.event_data = event_data;
            e.event_type = event_type;
            e.created = DateTime.Now;
            e.current = true;
            db.Events.Add(e);
            db.SaveChanges();
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        public ActionResult Update(int id, DateTime event_date, string event_type, string event_data)
        {
            db.Events.Find(id).current = false;
            EventModel e = new EventModel();
            e.date = event_date;
            e.event_data = event_data;
            e.event_type = event_type;
            e.created = DateTime.Now;
            e.current = true;
            db.Events.Add(e);
            db.SaveChanges();

            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    }
}