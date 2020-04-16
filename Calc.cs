
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace lab12
{
    class Calc
    {
        public Calc() { }


        // перевод из десятичной в выбраную систему счисления
        public int decTo(int num, int numSys)
        {
            int res = 0;
            int ten = 1;
            while (num > 0)
            {
                res += (num % numSys) * ten;
                num /= numSys;
                ten *= 10;
            }
            return res;
        }

        // перевод из выбранной системы счисления в десятичную
        public int toDec(int num, int numSys)
        {
            int res = 0;
            for (int i = 0; num > 0; i++)
            {
                res += ((num % 10) * (int)Math.Pow(numSys, i));
                num /= 10;
            }
            return res;
        }

        // перевод из десятичной в 16
        public string decTohex(int num)
        {
            string res = "";
            if (num == 0) return "";
            res += decTohex(num / 16);

            switch (num % 16)
            {
                case 10: res+= "A"; break;
                case 11: res += "B"; break;
                case 12: res += "C"; break;
                case 13: res += "D"; break;
                case 14: res += "E"; break;
                case 15: res += "F"; break;
                default: res += (num % 16).ToString(); break;
            }
            return res;
        }


        // перевод из 16 в 10
        public int hexToDec(string num)
        {
            int hex = 0;
            int[] res = new int[40];
            char[] ch = new char[1];
            int i;
            for (i = 0; i < (num.Length - 2); i++)
            {
                if ((num[i] >= 48) && (num[i] <= 57))
                {
                    ch[0] = num[i];
                    res[i] = (int)ch[0]; 
                }
                else
                {
                    switch (num[i])
                    {
                        case 'A': res[i] = 10; break;
                        case 'B': res[i] = 11; break;
                        case 'C': res[i] = 12; break;
                        case 'D': res[i] = 13; break;
                        case 'E': res[i] = 14; break; 
                        case 'F': res[i] = 15; break;
                        default:; break;
                    }
                }

            }


            for (int j = 0; i >= 0; i--)
            {
                hex += (res[i] * (int)Math.Pow(16, j));
                ++j;
            }
            return hex;
        }

    }
}

