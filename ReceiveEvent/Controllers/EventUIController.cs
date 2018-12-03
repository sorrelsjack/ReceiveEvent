using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReceiveEvent.Controllers;
using ReceiveEvent.Models;

namespace ReceiveEvent.Controllers
{
    public class EventUIController : Controller
    {
        EventController eventController = new EventController();
        Event submittedEvent;
        // GET: EventUI
        public ActionResult Index()
        {
            ViewBag.Title = "API";

            return View();
        }

        public void btnGet_Click(object sender, EventArgs e) {
            eventController.Get();
        }

        public void btnGetAll_Click(object sender, EventArgs e) {

        }

        /*[HttpPost]
        public ActionResult btnPost_Click() {
            submittedEvent = new Event(locationField.Value, eventField.Value);
            eventController.Post(submittedEvent);

            return View();
        }*/
    }
}