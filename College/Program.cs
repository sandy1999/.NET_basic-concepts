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
            // Adding array functionality with for each 

            int[] n = new int[10];

            for (int i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            foreach (int j in n)
            {
                int i = j - 100;
                Console.WriteLine("Element [{0}] = {1}", i, j);
            }

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

            Object obj;
            obj = inClass[0];
            Console.Write(obj);
            Console.ReadLine();
        }
    }
}
