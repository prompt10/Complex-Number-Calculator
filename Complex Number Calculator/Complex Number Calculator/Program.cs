using System;
using System.Numerics;

namespace Complex_Number_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, time = 7, mju = 100;
            string a, b, symbol;
            double c, d, ado, bdo, ppow;
            a = Console.ReadLine();
            b = Console.ReadLine();
            ado = Convert.ToDouble(a);
            bdo = Convert.ToDouble(b);

            for (int i = 0; i < mju; i++)
            {
                    symbol = Console.ReadLine();
                    if (symbol == "+" || symbol == "-" || symbol == "*" || symbol == "/")
                    {
                        c = int.Parse(Console.ReadLine());
                        d = int.Parse(Console.ReadLine());
                        c = Convert.ToDouble(c);
                        d = Convert.ToDouble(d);
                        if (symbol == "+")
                        {
                            Console.WriteLine("{0} + {1}i", ado + c, bdo + d);
                        continue;
                        }
                        if (symbol == "-")
                        {
                            Console.WriteLine("{0} + {1}i", ado - c, bdo - d);
                        continue;
                    }
                        if (symbol == "*")
                        {
                            Console.WriteLine("{0} + {1}i", ((ado * c) - (bdo * d)), ((ado * d) + (bdo * c)));
                        continue;
                    }
                        if (symbol == "/")
                        {
                            Console.WriteLine("{0} + {1}i; c+di != 0", (((ado * c) + (bdo * d)) / (Math.Pow(c, 2) + Math.Pow(d, 2))), (((bdo * c) - (ado * d)) / (Math.Pow(c, 2) + Math.Pow(d, 2))));
                        continue;
                    }

                    }
                    if (symbol == "^")
                    {
                        p = int.Parse(Console.ReadLine());
                        ppow = Convert.ToDouble(p);
                    //Using Complex for "^" where the power indicator could be ridiculously high so the cpu won't break in the process of calculation and to reduce the amount of line required for streamlining
                    Complex p1 = new Complex(ado, bdo);
                        Complex.Pow(p1, ppow);
                        Console.WriteLine("{0} where the second part is mutiplied by i", Complex.Pow(p1, ppow));
                    continue;
                }
                    if (symbol == "|")
                    {
                        Console.WriteLine("{0}", Math.Sqrt((Math.Pow(ado, 2) + Math.Pow(bdo, 2))));
                    continue;
                }
                    if (symbol != "+" || symbol != "-" || symbol != "*" || symbol != "/" || symbol != "^" || symbol != "|")
                    {
                        break;
                    }
                mju++;
            }
         
        }
    }
}
