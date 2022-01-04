using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_ornek2
{
    class Program
    {
        static void Main(string[] args)
        { //foreach ile mevsimleri yazdırma
            string[] mevsimler = { "İlkbahar", "Yaz","Sonbahar","Kış" };
            foreach (string b in mevsimler)
            {
                Console.WriteLine(b);
            }
            Console.ReadKey();
        }
    }
}
