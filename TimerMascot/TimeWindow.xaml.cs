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

namespace TimerMascot
{
    /// <summary>
    /// TimeWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class TimeWindow : Window
    {
        public TimeWindow()
        {
            InitializeComponent();
        }

        //時間を表示
        public void DisplayTime(string Time)
        {
            Dispatcher.Invoke(() => this.Time.Text = Time);
        }

        //時間を消去
        public void ClearTime()
        {
            DisplayTime(string.Empty);
        }
    }
}
