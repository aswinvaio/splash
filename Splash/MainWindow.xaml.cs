using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace Splash
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BitmapImage image;
        SoundPlayer player;
        public MainWindow()
        {
            InitializeComponent();
            image = new BitmapImage(new Uri(@"..\..\Images\gost1.png", UriKind.Relative));
            player = new SoundPlayer(@"..\..\Sounds\scream1.wav");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SplashWindow sw = new SplashWindow(this.image,this.player);
            sw.Show();
        }
    }
}
