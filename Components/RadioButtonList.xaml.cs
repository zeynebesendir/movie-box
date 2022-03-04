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

namespace MovieBox.View
{
    /// <summary>
    /// Interaction logic for RadioButtonList.xaml
    /// </summary>
    public partial class RadioButtonList : UserControl
    {
        public RadioButtonList()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            if (Tag == null || spButtons.Children.Count != 0)
                return;

            switch (Tag.ToString())
            {
                case "Free To Watch":
                case "Trending":
                    SetTimes();
                    break;
                case "Latest Trailers":
                case "Whats Popular":
                    SetGroups();
                    break;
            }

        }

        private void SetTimes()
        {
            foreach (TimeWindow time in (TimeWindow[])Enum.GetValues(typeof(TimeWindow)))
            {
                RadioButton btn = new RadioButton
                {
                    Content = time.ToString(),
                    Style = FindResource("RadioButtonStyle") as Style,
                    GroupName = Tag.ToString(),
                };

                btn.Checked += Btn_Checked;
                spButtons.Children.Add(btn);

                if (spButtons.Children.IndexOf(btn) == 0)
                {
                    btn.IsChecked = true;
                }
            }
        }

        private void SetGroups()
        {
            foreach (ContentGroup group in (ContentGroup[])Enum.GetValues(typeof(ContentGroup)))
            {
                RadioButton btn = new RadioButton
                {
                    Content = group.ToString(),
                    Style = FindResource("RadioButtonStyle") as Style,
                    GroupName = Tag.ToString(),
                };

                btn.Checked += Btn_Checked;
                spButtons.Children.Add(btn);

                if (spButtons.Children.IndexOf(btn) == 0)
                {
                    btn.IsChecked = true;
                }
            }


        }

        private void Btn_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
