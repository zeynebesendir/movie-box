using MovieBox.Model;
using MovieBox.Service;
using MovieBox.View;
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
using static MovieBox.Common.Enums;

namespace MovieBox.ViewModel
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
            GetContent();
        }

        private async void GetContent()
        {

            //POPULAR MOVIES
            Client.Instance.MovieLayer.MoviesLoaded += MovieLayer_MoviesLoaded;
            await Client.Instance.MovieLayer.getPopularMoviesAsync();

            //FREE 
            Client.Instance.MovieLayer.StreamingLoaded += MovieLayer_StreamingLoaded;
            await Client.Instance.MovieLayer.getStreamingAsync();

            Client.Instance.MovieLayer.InTheatreLoaded += MovieLayer_InTheatreLoaded;
            await Client.Instance.MovieLayer.getInTheaterAsync();

            //TRENDING
            Client.Instance.MovieLayer.TrendingLoaded += MovieLayer_TrendingLoaded;
            await Client.Instance.MovieLayer.GetTrending();

        }

        private void MovieLayer_MoviesLoaded(object sender, EventArgs e)
        {
            List<Content> movies = (List<Content>)sender;
            popularList.DataContext = movies;
        }


        private void MovieLayer_StreamingLoaded(object sender, EventArgs e)
        {
            List<Content> streaming = (List<Content>)sender;
            freeList.DataContext = streaming;
        }

        private void MovieLayer_InTheatreLoaded(object sender, EventArgs e)
        {
            List<Content> theatres = (List<Content>)sender;
            trailerList.DataContext = theatres;
        }


        private void MovieLayer_TrendingLoaded(object sender, EventArgs e)
        {
            List<Content> trending = (List<Content>)sender;
            trendingList.DataContext = trending;
        }


        #region Search

        private void tbSearch_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            tbSearch.Text = "";

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string str = tbSearch.Text;
            if (String.IsNullOrEmpty(str) || str.Equals("  Search for a movie, tv show, person....."))
                return;

            search();

        }

        private void tbSearch_LostFocus(object sender, RoutedEventArgs e)
        {
            tbSearch.Text = "  Search for a movie, tv show, person.....";
        }

        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key != System.Windows.Input.Key.Enter)
                return;


            e.Handled = true;
            search();
        }

        private void search()
        {
            string keyword = tbSearch.Text;

            if (!keyword.Equals(""))
            {
                Client.Instance.MovieLayer.GetSearchResult(keyword);
            }
        }

        #endregion

    }
}