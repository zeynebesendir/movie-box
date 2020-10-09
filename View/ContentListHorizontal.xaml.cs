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

namespace MovieBox.View
{
    /// <summary>
    /// Interaction logic for CategoryGroup.xaml
    /// </summary>
    public partial class ContentListHorizontal : UserControl
    {
        public ContentListHorizontal()
        {
            InitializeComponent();
            
        }

        public static readonly DependencyProperty ListTitleProperty = DependencyProperty.Register
         (
              "ListTitle",
              typeof(string),
              typeof(ContentListHorizontal),
              new PropertyMetadata(string.Empty)
         );

        public string ListTitle
        {
            get { return (string)GetValue(ListTitleProperty); }
            set { SetValue(ListTitleProperty, value); }
        }

        private void lvMovies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Content movie = (Content)lvMovies.SelectedItem;

            if (movie != null)
                Client.Instance.MovieLayer.GetContentDetail(movie.Id.ToString());

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            string txt = ((RadioButton)sender).Content.ToString();

            lvMovies.Items.Clear();

            switch (txt)
            {
                case "Streaming":
                    break;
                case "On TV":

                    break;
                case "For Rent":
                    break;
                case "In Theatres":
                    break;

            }

        }
    }
}
