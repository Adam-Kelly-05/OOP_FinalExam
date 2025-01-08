namespace OOP_FinalExam
{
    internal class Ticket
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int AvailableTickets { get; set; }

        public override string ToString() // ToString used so the tickets can be printed in a visually appealing way
        {
            return $"{Name} - {Price} - [AVAILABLE - {AvailableTickets}";
        }
    }

    internal class VIPTicket : Ticket // VIPTicket class is an extention of Ticket class
    {
        public string AdditionalExtras { get; set; }

        public decimal AdditionalCost { get; set; }
    }
}
