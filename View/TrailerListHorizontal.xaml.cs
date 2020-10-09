using MovieBox.Model;
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
    /// Interaction logic for TrailerListHorizontal.xaml
    /// </summary>
    public partial class TrailerListHorizontal : UserControl
    {
        public TrailerListHorizontal()
        {
            InitializeComponent();
        }
        public static readonly DependencyProperty ListTitleProperty = DependencyProperty.Register
        (
             "ListTitle",
             typeof(string),
             typeof(TrailerListHorizontal),
             new PropertyMetadata(string.Empty)
        );

        public string ListTitle
        {
            get { return (string)GetValue(ListTitleProperty); }
            set { SetValue(ListTitleProperty, value); }
        }

        private void lvTrailers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void userControl_Loaded(object sender, RoutedEventArgs e)
        {
        
        }

        private void StackPanel_MouseEnter(object sender, MouseEventArgs e)
        {

        }
    }
}
