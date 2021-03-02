using System;

namespace Shustrov_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float m = float.Parse(Console.ReadLine());
            float n = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            float b;
            if (m > 0)
            {
                b = m * m;
            }
            else if (m == 0)
            {
                b = n;
            }
            else
            {
                b = (float)(m * Math.Cos(m));
            }


            float a;
            if (b!=c)
            {
                a = b * b;
            }
            else
            {
                a = (float)(b * Math.Cos(b));
            }


            float W = (float)((a * a + Math.Cos(a)) / (a + Math.Sin(a)* Math.Sin(a)* Math.Sin(a)) - Math.Tan(a));

            Console.WriteLine(W);

        }
    }
}
