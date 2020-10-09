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
    /// Interaction logic for ContentDetail.xaml
    /// </summary>
    public partial class ContentDetail : Page
    {
        public ContentDetail(Content content)
        {
            InitializeComponent();
            this.DataContext = content;
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
