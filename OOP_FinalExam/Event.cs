namespace OOP_FinalExam
{
    public enum EventType { Music, Comedy, Theatre }

    class Event
    {
        public string Name { get; set; }

        public DateTime EventDate { get; set; }

        public List<Ticket> Tickets { get; set; }

        public EventType TypeOfEvent { get; set; }
    }
}
