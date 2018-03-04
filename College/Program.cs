using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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

            //Using collection arrayList;

            ArrayList al = new ArrayList();

            al.Add(25);
            al.Add(50);
            al.Add(26);

            Console.WriteLine(al.Capacity);
            Console.WriteLine(al.Count);
            al.Sort();
            foreach (int i in al)
            {
                Console.WriteLine(i);
            }

            DerivedDelegate derivedDelegate = new DerivedDelegate();
            addDelegate ad = new addDelegate(derivedDelegate.addNumber);
            ad.Invoke(20, 60);
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
