using SimpleGUI.UserControls;
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

namespace SimpleGUI
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

       
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            if (MainwindowAnimation.IsVisible)
            {
                MainwindowAnimation.Visibility = Visibility.Hidden;
                piExpand.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowDown;
            }
            else
            {
                MainwindowAnimation.Visibility = Visibility.Visible;
                piExpand.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowUp;
            }
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void SwtichPage(object sender, RoutedEventArgs e)
        {
            TabView.Children.Clear();
            var sentBy = (Button)sender;
            switch (sentBy.Name)
            {
                case "btnHome":
                    TabView.Children.Add(new ucHome());                  
                    break;
                default:
                    break;
            }
        }
    }
}
