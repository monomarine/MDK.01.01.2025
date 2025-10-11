using _02._05_EventsWPF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _02._05_EventsWPF
{
    /// <summary>
    /// Логика взаимодействия для Monitor.xaml
    /// </summary>
    public partial class Monitor : Window
    {
        private List<INotificationService> _services = new();


        public Monitor(ICollection<Order> orders)
        {
            InitializeComponent();
            var consoleService = new ConsoleNotificationService();
            var fileService = new FileNotificationService();

            _services.Add(consoleService);
            _services.Add(fileService);

            foreach (var service in _services)
            {
                service.AddOrder(orders.ToArray<Order>());
                service.UpdateData += UpdateList;
            }
        }

        private void UpdateList(object sender, OrderEventArgs e)
        {
            string serviceType = sender is ConsoleNotificationService ? "[КОНСОЛЬ]" : "[ФАЙЛ]";
            monitorListBox.Items.Add($"{serviceType} {e.Message}");
            monitorListBox.Items.Refresh();
        }

        protected override void OnClosed(EventArgs e)
        {
            foreach (var service in _services)
            {
                service.Dispose();
            }
            base.OnClosed(e);
        }
    }
}
