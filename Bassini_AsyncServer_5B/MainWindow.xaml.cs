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
using Bassini_AsyncSocketLib;

namespace Bassini_AsyncServer_5B
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AsyncSocketServer mServer;

        public MainWindow()
        {
            InitializeComponent();
            mServer = new AsyncSocketServer();
        }

        private void btnAscolta_Click(object sender, RoutedEventArgs e)
        {
            mServer.InAscolto();
        }

        private void btnDisconnetti_Click(object sender, RoutedEventArgs e)
        {
            mServer.Disconnetti();
        }

        private void btnInvia_Click(object sender, RoutedEventArgs e)
        {
            mServer.InviaATutti(txtMessaggio.Text);
        }
    }
}
