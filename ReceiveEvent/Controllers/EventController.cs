using ReceiveEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using ReceiveEvent.Services;
using System.Web.Mvc;
using System.Net.Http;
using Newtonsoft.Json;

namespace ReceiveEvent.Controllers
{
    public class EventController : ApiController
    {
        private EventRepository eventRepository;

        public EventController() {
            this.eventRepository = new EventRepository();
        }

        [System.Web.Http.Route("api/Event/Get")]
        [System.Web.Http.HttpGet]

        public List<Event> Get() {
            return this.eventRepository.GetAllEvents();
        }

        [System.Web.Http.Route("api/Event/Get/{eventId:int}")]
        [System.Web.Http.HttpGet]

        public Event Get(int eventId) {
            return this.eventRepository.GetOneEvent(eventId);
        }

        [System.Web.Http.Route("api/Event/Send")]
        [System.Web.Http.AcceptVerbs("POST")]
        [System.Web.Http.HttpPost]
        public IHttpActionResult Post(Event eventToAdd) { //send with socket
            this.eventRepository.PostEvent(eventToAdd);

            return Ok();
        }
    }
}