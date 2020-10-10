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
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Page
    {
        public Search()
        {
            InitializeComponent();
            lvSearchResult.DataContext = Client.Instance.MovieLayer.searchResult;
        }


        private void lvSearchResult_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Content content = (Content)((ListView)sender).SelectedItem;

            Client.Instance.MovieLayer.GetContentDetail(content.Id.ToString());
        }
    }
}
