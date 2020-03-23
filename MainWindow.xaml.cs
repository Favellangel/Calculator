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

namespace lab12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_ClickSys(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            switch (clickedButton.Name)
            {
                case "BtnHEX":
                    MessageBox.Show("Click on button BtnHEX");
                    break;
                case "BtnDEC":
                    MessageBox.Show("Click on button BtnDEC");
                    break;
                default:
                    break;
            }
        }
        private void Button_ClickNum(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            switch (clickedButton.Name)
            {
                case "BtnNum1":
                    MessageBox.Show("Click on button BtnNum1");
                    break;
                default:
                    break;
            }
        }
    }
}
