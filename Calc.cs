using System;
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
            if (num == 0) return "";
            decTohex(num / 16);
            switch (num % 16)
            {
                case 10: return "A"; break;
                case 11: return "B"; break;
                case 12: return "C"; break;
                case 13: return "D"; break;
                case 14: return "E"; break;
                case 15: return "F"; break;
                default: return (num % 16).ToString(); break;
            }
        }


        // перевод из 16 в 10
        /*public int hexToDec(string num)
                {
                    int hex = 0;
                    int res[40];
                    char ch[1];
                    int i;
                    for (i = 0; i < (num.size() - 2); i++)
                    {
                        if ((num[i] >= 48) && (num[i] <= 57))
                        {
                            ch[0] = num[i];
                            res[i] = atoi(ch);
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
                        //cout « "i:" « i « "\n";
                    }

                    —i;
                    //cout « "i:" « i « "\n";
                    //cout « "\n";
                    for (int j = 0; i >= 0; i--)
                    {
                        //cout « "i:" « i « "\n";
                        hex += (res[i] * pow(16, j)); // error
                        ++j;
                    }
                    return hex;
                }

            }*/

    }
}
