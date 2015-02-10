using System.Timers;
using System.Windows;
using Hardcodet.Wpf.TaskbarNotification;

namespace Stretch_
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly TaskbarIcon _icon;
        public MainWindow()
        {
            _icon = new TaskbarIcon();
            _icon.Icon = Properties.Resources.icon;
            InitializeComponent();
            
            Timer timer = new Timer(2100000);
            timer.Elapsed += _timer_Elapsed;
            timer.Start();
        }

        void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _icon.ShowBalloonTip("Stretch!", "Take a break", BalloonIcon.Info);
        }
    }
}
