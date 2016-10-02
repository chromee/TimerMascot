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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace TimerMascot
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        int timerCount;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Quit_Clicked(object sender, RoutedEventArgs e)
        {
            Close();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void timerInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            //if()
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            timerCount = Int32.Parse(timerInput.Text);
            timerLabel.Content = timerCount;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1.0);
            timer.Tick += timer_Tick;
            timer.Start();
            FirstCanvas.Visibility = Visibility.Hidden;
            CountCanvas.Visibility = Visibility.Visible;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            timerCount--;
            timerLabel.Content = timerCount;
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            if(StopButton.Content.ToString()=="すとっぷ")
            {
                timer.Stop();
                StopButton.Content = "さいかい";
            }
            else
            {
                timer.Start();
                StopButton.Content = "すとっぷ";
            }
            
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            FirstCanvas.Visibility = Visibility.Visible;
            CountCanvas.Visibility = Visibility.Hidden;
        }
    }
}
