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
using System.Windows.Shapes;

namespace Splash
{
    /// <summary>
    /// Interaction logic for Splash.xaml
    /// </summary>
    public partial class SplashWindow : Window
    {
        public BitmapImage BackgroundImage { get; set; }
        public SoundPlayer Player { get; set; }

        public SplashWindow()
        {
            InitializeComponent();
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                new BitmapImage(new Uri(@"..\..\Images\gost1.png", UriKind.Relative));
            this.Background = myBrush;
            SoundPlayer player = new SoundPlayer(@"..\..\Sounds\scream1.wav");
            player.Play();
        }

        public SplashWindow(BitmapImage image, SoundPlayer player)
        {
            this.BackgroundImage = image;
            this.Player = player;
            InitializeComponent();
            Player.Play();
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource = BackgroundImage;
            this.Background = myBrush;
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            Player.Play();
            System.Threading.Thread.Sleep(2000);
            this.Close();
        }
    }
}
