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
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0,0,10);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            String messaggio = DateTime.Now.ToShortDateString() + "T" + DateTime.Now.ToShortTimeString();


            mServer.InviaATutti(messaggio);
        }

        private void btnDisconnetti_Click(object sender, RoutedEventArgs e)
        {
            mServer.Disconnetti();
        }

        private void btnInvia_Click(object sender, RoutedEventArgs e)
        {
            string messaggio = txtMessaggio.Text;

            
            mServer.InviaATutti(messaggio);
        }
    }
}
/*
 Esercizio TimeServer
- Client si connette
	- se il client mi scrive time, date -> ora,data
	- se il client mi scrive qualsiasi altra cosa -> "Non ho capito"
- Il server ogni 10 secondi invia a tutti i client un messaggio con formato: "dd/mm/aaaaThh:mm"

COSA IMPORTANTE
- Nuova soluzione(WPF .NET Framework) Cognome_AsyncTimeServer
- La libreria può essere importata e si deve chiamare Cognome_SocketAsyncLib

Suggerimenti
- Controllare se il server già in ascolto (due volte click su bottone errore!)

 
 
 
 */