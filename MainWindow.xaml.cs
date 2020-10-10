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
using MovieBox.Model;
using MovieBox.Service;
using MovieBox.ViewModel;

namespace MovieBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new Home());
            Client.Instance.MovieLayer.ContentDetailLoaded += Instance_DetailRequested; ;
            Client.Instance.MovieLayer.SearchResultLoaded += MovieLayer_SearchResultLoaded;
        }

        private void MovieLayer_SearchResultLoaded(object sender, EventArgs e)
        {
            navigate(new Search());
        }

        private void Instance_DetailRequested(object sender, EventArgs e)
        {
            //error control
            navigate(new ContentDetail((Content)sender));
        }

        private void navigate(object sender)
        {
            btnBack.Visibility = Visibility.Visible;
            mainFrame.NavigationService.Navigate(sender);
        }

        private void btnBack_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (mainFrame.NavigationService != null && mainFrame.NavigationService.CanGoBack)
            {
                mainFrame.NavigationService.GoBack();

                if (!mainFrame.NavigationService.CanGoBack)
                {
                    btnBack.Visibility = Visibility.Hidden;
                }
            }
        }

        
    }
}
