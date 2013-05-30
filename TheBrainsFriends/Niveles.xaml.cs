using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace TheBrainsFriends
{
    public partial class Niveles : PhoneApplicationPage
    {
        public Niveles()
        {
            InitializeComponent();
        }

        private void cmdPrincipiante_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Principiante.xaml", UriKind.Relative));
        }

        private void cmdIntermedio_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Intermedio.xaml", UriKind.Relative));
        }

        private void cmdExperto_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Experto.xaml", UriKind.Relative));
        }
    }
}
