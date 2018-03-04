using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    class InClass
    {
        int eno;
        string ename;
        int salary;

        public InClass(int eno, string ename, int salary)
        {
            this.eno = eno;
            this.ename = ename;
            this.salary = salary;
        }
          
        public Object this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return eno;
                }
                else if (index == 1)
                {
                    return ename;
                }
                else if (index == 2)
                {
                    return salary;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
