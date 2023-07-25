using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AsyncDemo.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Label.Content = await GetLabelTextFromDb();

            //ThreadPool.QueueUserWorkItem(state =>
            //{
            //    var text = GetLabelTextFromDb();

            //    Application.Current.Dispatcher.Invoke(() =>
            //    {
            //        Label.Content = text;
            //    });
            //});
        }

        private async Task<string> GetLabelTextFromDb()
        {
            await Task.Delay(TimeSpan.FromSeconds(4));
            // Thread.Sleep(TimeSpan.FromSeconds(4));

            return "Label text at " + DateTime.Now.ToShortTimeString();
        }
    }
}
