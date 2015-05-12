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
            
            Timer timer = new Timer(1500000);
            timer.Elapsed += (sender, e) => _icon.ShowBalloonTip("Stretch!", "Take a break", BalloonIcon.Info);
            timer.Start();
        }
    }
}
