namespace OOP_FinalExam
{
    public class Ticket
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int AvailableTickets { get; set; }
    }

    public class VIPTicket : Ticket
    {
        public string AdditionalExtras { get; set; }

        public decimal AdditionalCost { get; set; }
    }
}
