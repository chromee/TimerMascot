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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1.0);
            timer.Tick += timer_Tick;
            timer.Start();
            int timerCount = Int32.Parse(timerInput.Text);
            firstInputHidden();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            //timerText.Text = ;
        }

        void firstInputHidden()
        {
            label.Visibility = Visibility.Hidden;
            timerInput.Visibility = Visibility.Hidden;
            label1.Visibility = Visibility.Hidden;
            StartButton.Visibility = Visibility.Hidden;
        }
    }
}
