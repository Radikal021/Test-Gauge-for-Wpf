using System;
using System.Windows;

namespace TestGauge
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Random r = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Guage1.SetValuePoint(r.Next(0, 100));

        }
    }
}
