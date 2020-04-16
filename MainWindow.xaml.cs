﻿using System;
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
        char flag;

        public MainWindow()
        {
            flag = 'D';
            InitializeComponent();
        }
            

        private void Button_ClickSys(object sender, RoutedEventArgs e)
        {
            Calc calc = new Calc();

            Button clickedButton = (Button)sender;
            switch (clickedButton.Name)
            {
                case "BtnHEX":
                    switch(flag)
                    {
                        case 'D':
                            if (flag == 'B') textBlock.Text = Convert.ToString(calc.decTohex(Convert.ToInt32(textBlock.Text)));
                            flag = 'H';
                            break;

                        case 'B':
                            if (flag == 'B')
                            {
                                textBlock.Text = Convert.ToString(calc.toDec(Convert.ToInt32(textBlock.Text), 2));
                                textBlock.Text = Convert.ToString(calc.decTohex(Convert.ToInt32(textBlock.Text)));
                            }
                            flag = 'H';
                            break;

                        case 'O':
                            if (flag == 'O')
                            {
                                textBlock.Text = Convert.ToString(calc.toDec(Convert.ToInt32(textBlock.Text), 8));
                                textBlock.Text = Convert.ToString(calc.decTohex(Convert.ToInt32(textBlock.Text)));
                            }
                            flag = 'H';
                            break;
                    }   
                    break;

                case "BtnBIN":
                    switch(flag)
                    {
                        case 'D':
                            if (flag == 'D') textBlock.Text = Convert.ToString(calc.decTo(Convert.ToInt32(textBlock.Text), 2));
                            flag = 'B';
                            break;

                        case 'O':
                            if (flag == 'O')
                            {
                                textBlock.Text = Convert.ToString(calc.toDec(Convert.ToInt32(textBlock.Text), 8));
                                textBlock.Text = Convert.ToString(calc.decTo(Convert.ToInt32(textBlock.Text), 2));
                            }
                            flag = 'B';
                            break;

                        case 'H':
                            if (flag == 'H')
                            {
                                textBlock.Text = Convert.ToString(calc.hexToDec(textBlock.Text));
                                textBlock.Text = Convert.ToString(calc.decTo(Convert.ToInt32(textBlock.Text), 2));
                            }
                            flag = 'B';
                            break;
                    }

                    break;

                case "BtnOCT":
                    switch(flag)
                    {
                        case 'D':
                            if(flag == 'D') textBlock.Text = Convert.ToString(calc.decTo(Convert.ToInt32(textBlock.Text), 8));
                            flag = 'O';
                            break;

                        case 'B':
                            if (flag == 'B')
                            {
                                textBlock.Text = Convert.ToString(calc.toDec(Convert.ToInt32(textBlock.Text), 2));
                                textBlock.Text = Convert.ToString(calc.decTo(Convert.ToInt32(textBlock.Text), 8));
                            }
                            flag = 'O';
                            break;

                        case 'H':
                            if (flag == 'B')
                            {
                                textBlock.Text = Convert.ToString(calc.hexToDec(textBlock.Text));
                                textBlock.Text = Convert.ToString(calc.decTo(Convert.ToInt32(textBlock.Text), 8));
                            }
                            flag = 'O';
                            break;
                    }
                    break;

                case "BtnDEC":
                    
                    switch(flag)
                    {
                        case 'B':
                            if (flag == 'B') textBlock.Text = Convert.ToString(calc.toDec(Convert.ToInt32(textBlock.Text), 2));
                            flag = 'D';
                            break;

                        case 'O':
                            if (flag == 'O') textBlock.Text = Convert.ToString(calc.toDec(Convert.ToInt32(textBlock.Text), 8));
                            flag = 'D';
                            break;
                        case 'H':
                            if (flag == 'H') textBlock.Text = Convert.ToString(calc.hexToDec(textBlock.Text));
                            flag = 'D';
                            break;
                    }

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
                case "BtnClearLine":
                    textBlock.Text = "";
                    break;

                case "BtnDelchar":         
                    int lenght = textBlock.Text.Length - 1;
                    string text = textBlock.Text;
                    textBlock.Text = "";
                        for (int i = 0; i < lenght; i++)
                        {
                        textBlock.Text = textBlock.Text + text[i];
                        }                   
                    break;

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