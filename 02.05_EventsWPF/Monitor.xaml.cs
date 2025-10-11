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
        private NotificationServiceLog _services= new NotificationServiceLog();
        private NotificationServiceFile _servicesForFile = new NotificationServiceFile();

        public Monitor(ICollection<Order> orders)
        {
            InitializeComponent();
            _services.AddOrder(orders.ToArray<Order>());
            _services.UpdateData += UpdateList;

            _servicesForFile.AddOrder(orders.ToArray<Order>());
            
        }
        
        private void UpdateList(object sender, OrderEventArgs e)
        {
            monitorListBox.Items.Add(e.Message);
            monitorListBox.Items.Refresh();
        }
    }
}
