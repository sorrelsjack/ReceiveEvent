using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReceiveEvent.Models {
    public class Event {
        public int eventId;
        public string location;
        public string eventType;

        public Event (string location, string eventType) {
            this.location = location;
            this.eventType = eventType;
        }

        public Event(int eventId, string location, string eventType) {
            this.eventId = eventId;
            this.location = location;
            this.eventType = eventType;
        }
    }
}