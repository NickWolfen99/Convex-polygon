using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzpMnogo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of angles:");
            int n = Convert.ToInt16(Console.ReadLine());

            int[,] Point = new int[n, 2];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"P[{i + 1}]:x=");
                Point[i, 0] = Convert.ToInt16(Console.ReadLine());
                Console.Write($"P[{i + 1}]:y=");
                Point[i, 1] = Convert.ToInt16(Console.ReadLine());
            }
            double maxdiamP = 0;
            for (int i = 0; i < n; i++)
            { for (int j = i + 1; i < n; i++)
                { double diamP = Math.Sqrt(Math.Pow(Math.Abs(Point[i,0]-Point[j,0]),2)+ Math.Pow(Math.Abs(Point[i, 1] - Point[j, 1]), 2));
                    if (diamP>maxdiamP) maxdiamP=diamP;
                }
            }
            Console.WriteLine($"The biggest distance between 2 points is {maxdiamP}");
                    Console.ReadLine();
        }
    }
}
