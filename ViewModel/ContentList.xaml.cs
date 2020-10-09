using MovieBox.Model;
using MovieBox.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MovieBox.ViewModel
{
    /// <summary>
    /// Interaction logic for ContentList.xaml
    /// </summary>
    public partial class ContentList : Page
    {
        public ContentList()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {


            Client.Instance.MovieLayer.MoviesLoaded += Client_MoviesLoaded;

        }

        private void Client_MoviesLoaded(object sender, EventArgs e)
        {
            List<List<Content>> categoryList = new List<List<Content>>();
            List<Content> cat = (List<Content>)sender;

            for (int i = 0; i < 5; i++)
            {
                categoryList.Add(cat);
            }

            lvCategories.ItemsSource = categoryList;

        }
    }
}

