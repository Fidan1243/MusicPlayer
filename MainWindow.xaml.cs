using Microsoft.Win32;
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

namespace $safeprojectname$
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Player player = new Player();
        MediaPlayer playerr = new MediaPlayer();
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            player.Play();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            player.Pause();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
        }

        private void btnFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            if (dialog.ShowDialog() ==  true)
            {
                player.CurrentMelody.Open(new Uri(dialog.FileName));
                btnPlay.IsEnabled = true;
                btnPause.IsEnabled = true;
                btnPNext.IsEnabled = true;
            }
        }
    }
}
