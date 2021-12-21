using System;
using System.Threading.Channels;
using Microsoft.Win32.SafeHandles;

namespace Delegates
{
    class Program
    {
        delegate double Zadanie11(double x);
        delegate double Zadanie12(double x);
        
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1\n");
            Console.WriteLine("Vvedite x nachalnoe: ");
            double xnach = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vvedite x konechnoe: ");
            double xkon = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vvedite shag: ");
            double shag = Convert.ToDouble(Console.ReadLine());
            Zadanie11 tan = Tan;
            Zadanie12 cos = Cos;
            Console.WriteLine("Cos(x)\tTan(x)");
            for (; xnach < xkon; xnach += shag)
            {
                Console.WriteLine($"{cos(xnach):f2}\t{tan(xnach):f2}");
            }
        }

        public static double Tan(double x) { return Math.Tan(x); }
        public static double Cos(double x) { return Math.Cos(x); }
    }
}