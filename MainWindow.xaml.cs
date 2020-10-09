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
            Client.Instance.MovieLayer.BackRequested += MovieLayer_BackRequested;
        }

        private void MovieLayer_BackRequested(object sender, EventArgs e)
        {
        

        }

        private void MovieLayer_SearchResultLoaded(object sender, EventArgs e)
        {
            mainFrame.NavigationService.Navigate(new Search());
        }

        private void Instance_DetailRequested(object sender, EventArgs e)
        {
            //error control
            mainFrame.NavigationService.Navigate(new ContentDetail((Content)sender));
        }


        private void Image_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
