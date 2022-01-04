using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    class Program
    {
        static void Main(string[] args)
        { // foreach ile dizideki elemanları yazdırma
            double[] ondaliklisayilar = { 1.2, 2.3, 3.4, 4.5, 5.6, 6.7 };
            foreach (double c in ondaliklisayilar)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
