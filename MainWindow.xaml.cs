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
                 
                    break;
                case "BtnDEC":
              
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
                    textBlock.Text += "1";
                    break;

                case "BtnNum2":
                    textBlock.Text += "2";
                    break;

                case "BtnNum3":
                    textBlock.Text += "3";
                    break;

                case "BtnNum4":
                    textBlock.Text += "4";
                    break;

                case "BtnNum5":
                    textBlock.Text += "5";
                    break;

                case "BtnNum6":
                    textBlock.Text += "6";
                    break;

                case "BtnNum7":
                    textBlock.Text += "7";
                    break;

                case "BtnNum8":
                    textBlock.Text += "8";
                    break;

                case "BtnNum9":
                    textBlock.Text += "9";
                    break;

                case "BtnNum0":
                    textBlock.Text += "0";
                    break;

                case "BtnA":
                    textBlock.Text += "A";
                    break;

                case "BtnB":
                    textBlock.Text += "B";
                    break;

                case "BtnC":
                    textBlock.Text += "C";
                    break;

                case "BtnD":
                    textBlock.Text += "D";
                    break;

                case "BtnE":
                    textBlock.Text += "E";
                    break;

                case "BtnF":
                    textBlock.Text += "F";
                    break;

                default:
                    break;
            }
        }
    }
}
