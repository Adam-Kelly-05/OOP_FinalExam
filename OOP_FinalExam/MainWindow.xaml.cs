// Github Link: https://github.com/Adam-Kelly-05/OOP_FinalExam.git
// using System.Text;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOP_FinalExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Event Event1 = new Event() { Name = "Oasis Croke Park", EventDate = new DateTime(2025, 06, 20), TypeOfEvent = EventType.Music };
        Event Event2 = new Event() { Name = "Electric Picnic", EventDate = new DateTime(2025, 08, 20), TypeOfEvent = EventType.Music };

        Ticket Ticket1 = new Ticket() { Name = "Early Bird", Price = 100m, AvailableTickets = 100 };
        Ticket Ticket2 = new Ticket() { Name = "Platinium", Price = 150m, AvailableTickets = 100 };

        VIPTicket VIPTicket1 = new VIPTicket() { Name = "Ticket and Hotel Package", Price = 150m, AdditionalCost = 100m, AdditionalExtras = "4* hotel", AvailableTickets = 100 };
        VIPTicket VIPTicket2 = new VIPTicket() { Name = "Weekend Ticket", Price = 200m, AdditionalCost = 100m, AdditionalExtras = "with camping", AvailableTickets = 100 };


        public MainWindow()
        {
            InitializeComponent();
        }
    }
}