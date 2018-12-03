using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ReceiveEvent.Models;

namespace ReceiveEvent.Services {
    public class EventRepository {
        //EventLocationData
        private SqlConnection databaseConnection = new SqlConnection (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EventLocationData;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private SqlCommand databaseGetAllEvents;
        private SqlCommand databaseGetEvent;
        private SqlCommand databasePostEvent;
        private SqlDataReader databaseReader;

        List<Event> listOfEvents = new List<Event>();
        Event currentEvent;

        public List<Event> GetAllEvents() {
            using (databaseConnection) {
                databaseConnection.Open();
                databaseGetAllEvents = new SqlCommand("SELECT * FROM Events", databaseConnection);
                databaseReader = databaseGetAllEvents.ExecuteReader();

                while (databaseReader.Read()) {
                    currentEvent = new Event((int)databaseReader["Id"], (string)databaseReader["Location"], (string)databaseReader["EventType"]);
                    listOfEvents.Add(currentEvent);
                }
                databaseConnection.Close();
            }
            return listOfEvents;
        }

        public Event GetOneEvent(int eventId) {
            using (databaseConnection) {
                databaseConnection.Open();

                databaseGetAllEvents = new SqlCommand("SELECT * FROM Events WHERE Id = @eventId", databaseConnection);
                databaseGetAllEvents.Parameters.AddWithValue("@eventId", eventId);

                databaseReader = databaseGetAllEvents.ExecuteReader();

                while (databaseReader.Read()) {
                    currentEvent = new Event((int)databaseReader["Id"], (string)databaseReader["Location"], (string)databaseReader["EventType"]);
                }
                databaseConnection.Close();
            }
            return currentEvent;
            //return listOfEvents.Where(x => x.eventId == eventId).FirstOrDefault();
        }

        public void PostEvent(Event eventToAdd) {
            using (databaseConnection) {
                databaseConnection.Open();

                databasePostEvent = new SqlCommand("INSERT Events (Location, EventType) VALUES (@location, @eventType)", databaseConnection);
                databasePostEvent.Parameters.AddWithValue("@location", eventToAdd.location);
                databasePostEvent.Parameters.AddWithValue("@eventType", eventToAdd.eventType);

                databasePostEvent.ExecuteNonQuery();

                databaseConnection.Close();
            }
        }
    }
}