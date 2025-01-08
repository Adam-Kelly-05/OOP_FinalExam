// Github Link: https://github.com/Adam-Kelly-05/OOP_FinalExam.git

using System.Collections.ObjectModel;
using System.Windows;

namespace OOP_FinalExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Event> events;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Event event1 = new Event { Name = "Oasis Croke Park", EventDate = new DateTime(2025, 06, 20), TypeOfEvent = EventType.Music };
            Event event2 = new Event() { Name = "Electric Picnic", EventDate = new DateTime(2025, 08, 20), TypeOfEvent = EventType.Music };

            events = new ObservableCollection<Event>();
            events.Add(event1);
            events.Add(event2);

            Ticket ticket1 = new Ticket() { Name = "Early Bird", Price = 100m, AvailableTickets = 100 };
            Ticket ticket2 = new Ticket() { Name = "Platinium", Price = 150m, AvailableTickets = 100 };
            List<Ticket> Tickets = new List<Ticket> { ticket1, ticket2 };

            VIPTicket VIPTicket1 = new VIPTicket() { Name = "Ticket and Hotel Package", Price = 150m, AdditionalCost = 100m, AdditionalExtras = "4* hotel", AvailableTickets = 100 };
            VIPTicket VIPTicket2 = new VIPTicket() { Name = "Weekend Ticket", Price = 200m, AdditionalCost = 100m, AdditionalExtras = "with camping", AvailableTickets = 100 };
            List<VIPTicket> VIPTickets = new List<VIPTicket> { VIPTicket1, VIPTicket2 };

            LSTBX1.ItemsSource = events;
            LSTBX2.ItemsSource = events;

            // Unfortunalty the events list isn't displaying in LSTBX1, no errors are showing and I spent most of the time trying to overcome this, the sample data also disapears
        }

        private void BookBTN_Click(object sender, RoutedEventArgs e)
        {
            BookBTN.Content = "Test"; // Test to make sure my app knows about the cs file

            BookingLogic();
        }

        public static void BookingLogic()
        {

        }
    }
}