using _02._05_EventsWPF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace _02._05_EventsWPF
{
    public partial class Monitor : Window
    {
        private readonly NotificationService _service = new NotificationService();
        private readonly ILogger _consoleLogger;
        private readonly ILogger _fileLogger;

        public Monitor(ICollection<Order> orders)
        {
            InitializeComponent();

            _consoleLogger = new ConsoleLogger();
            _fileLogger = new FileLogger("orders_monitor.log");

            _consoleLogger.Log("Монитор заказов запущен");
            _fileLogger.Log("Монитор заказов запущен");

            _service.AddOrder(orders.ToArray());
            _service.UpdateData += UpdateList;
        }

        private void UpdateList(object sender, OrderEventArgs e)
        {
            Dispatcher.InvokeAsync(() =>
            {
                monitorListBox.Items.Add(e.Message);

                if (monitorListBox.Items.Count > 0)
                {
                    monitorListBox.ScrollIntoView(monitorListBox.Items[monitorListBox.Items.Count - 1]);
                }
            });

            _consoleLogger.Log(e.Message);
            _fileLogger.Log(e.Message);

            if (e.Message.Contains("ошибка", StringComparison.OrdinalIgnoreCase))
            {
                _consoleLogger.LogError(e.Message);
                _fileLogger.LogError(e.Message);
            }
            else if (e.Message.Contains("внимание", StringComparison.OrdinalIgnoreCase))
            {
                _consoleLogger.LogWarning(e.Message);
                _fileLogger.LogWarning(e.Message);
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            _consoleLogger.Log("Монитор заказов закрыт");
            _fileLogger.Log("Монитор заказов закрыт");

            _service.UpdateData -= UpdateList;
            base.OnClosed(e);
        }
    }
}