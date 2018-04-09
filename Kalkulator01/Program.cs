using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator01
{
    class Program
    {
        static void Main(string[] args)
        {
            int Continue = 1;
            int Exit = 0;

            while (Continue > Exit)
            {

                double x1, x2;
                string _operator;
                Console.Clear();
                Console.WriteLine("Ange första nummer: ");
                x1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ange operation: ");
                _operator = Console.ReadLine();
                Console.WriteLine("Ange andra nummer: ");
                x2 = Convert.ToDouble(Console.ReadLine());


                switch (_operator)
                {

                    case "+":
                        double sum = add(x1, x2);
                        Console.WriteLine(sum);
                        break;
                    case "-":
                        double sam = sub(x1, x2);
                        Console.WriteLine(sam);
                        break;
                    case "/":
                        double sem = div(x1, x2);
                        Console.WriteLine(sem);
                        break;
                    case "*":
                        double sim = mult(x1, x2);
                        Console.WriteLine(sim);
                        break;
                }
                Console.WriteLine("Tryck 1 för att fortsätta: Tryck 0 för att avsluta: ");
                Continue = int.Parse(Console.ReadLine());
            }

            double add(double a, double b)
            {
                double c = 0;
                c = a + b;
                return c;
            }
            double sub(double q, double p)
            {
                double y = 0;
                y = q - p;
                return y;
            }
            double div(double w, double o)
            {
                double d = 0;
                d = w / o;
                return d;
            }
            double mult(double e, double i)
            {
                double m = 0;
                m = e * i;
                return m;
            }
        }
    }
}

   