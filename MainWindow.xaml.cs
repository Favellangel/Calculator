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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        public void test()
        {

        }

        private void BtnNum1_Click_1(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "1";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "0";
        }

        private void BtnNum2_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "2";
        }

        private void BtnNum3_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "3";
        }

        private void BtnNum4_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "4";
        }

        private void BtnNum5_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "5";
        }

        private void BtnNum6_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "6";
        }

        private void BtnNum7_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "7";
        }

        private void BtnNum8_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "8";
        }

        private void BtnNum9_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "9";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "(";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            textBlock.Text += ")";
        }

        private void BtnA_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "A";
        }

        private void BtnB_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "B";
        }

        private void BtnC_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "C";
        }

        private void BtnD_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "D";
        }

        private void BtnE_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "E";
        }

        private void BtnF_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "F";
        }
    }
}
