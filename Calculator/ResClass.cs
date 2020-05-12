using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator
{
    class ResClass
    {
        public static double Resault =0;
        public static double a = 0;
        public static double b = 0;
        public static int operation;
        public static string Resault_copy;
        // 1-сложение, 2-вычитание, 3-умножение, 4-деление, 5-степень, 6-корень
        public static double Get_Resault(int op, double x, double y)
        {
            double res=0;
            if (op == 1) res = x + y;
            else if (op == 2) res = x - y;
            else if (op == 3) res = x * y;
            else if (op == 4)
            {
                try
                {
                    res = x / y;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something is not right.\nTry again");
                }
            }
            else if (op == 5) res = Math.Pow(x, y);
            else
            {
                if (x < 0)
                { 
                    MessageBox.Show("Number must be at least zero or more");
                    res = x;
                }
                else res = Math.Sqrt(x);
            }
            return res;
        }
            }
}
