namespace OOP_FinalExam
{
    public enum EventType { Music, Comedy, Theatre }

    internal class Event : IComparable
    {
        public string Name { get; set; }

        public DateTime EventDate { get; set; }

        public List<Ticket> Tickets { get; set; }

        public EventType TypeOfEvent { get; set; } // TypeOfEvent's type is the enum EventType

        public int CompareTo(object Event) // The events can now be sorted by the events date
        {
            return EventDate.CompareTo(Event);
        }

        public override string ToString()  // ToString used so the events can be printed in a visually appealing way
        {
            return $"{Name} - {EventDate}";
        }
    }
}
