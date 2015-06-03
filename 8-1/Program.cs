using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tester t = new Tester();
            t.run();
        }
    }
    class Tester
    {
        public void run()
        {
            int intVer = tripler(3);
            float floatVer = tripler(3.1F);
            Console.WriteLine("{0} {1}", intVer, floatVer);
        }
        private static int tripler(int num)
        {
            return num *= 3;
            // It's a little strange to use the *= operator here - it would make more sense to just do
            // return num*3;
            // instead, as you don't need to modify the num value
        }
        private static float tripler(float num)
        {
            return num *= 3;
            // Same as above. It's also safer to multiply by 3f rather than just 3, as you can sometimes get
            // odd behavoir when you multiply floats and ints.
        }
    }
}
