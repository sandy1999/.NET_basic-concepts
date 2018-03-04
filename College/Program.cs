using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedDelegate derivedDelegate = new DerivedDelegate();
            addDelegate ad = new addDelegate(derivedDelegate.addNumber);
            ad.Invoke(20, 30);
            addStrint dstr = new addStrint(Delegate.addString);
            string str = dstr.Invoke("Sanidhya");
            Console.WriteLine(str);

            // indexer function perform

            InClass inClass = new InClass(101, "Sanidhya", 2500);
            Console.WriteLine("Employee id is " + inClass[0]);
            Console.WriteLine("Employee name is " + inClass[1]);
            Console.ReadLine();
        }
    }
}
