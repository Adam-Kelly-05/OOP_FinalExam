using System.Reflection.Metadata.Ecma335;

namespace OOP_FinalExam
{
    public enum EventType { Music, Comedy, Theatre }

    public class Event : IComparable
    {
        public string Name { get; set; }

        public DateTime EventDate { get; set; }

        public List<Ticket> Tickets { get; set; }

        public EventType TypeOfEvent { get; set; }

        public int CompareTo(object Event)
        {
            return EventDate.CompareTo(Event);
        }
    }
}
