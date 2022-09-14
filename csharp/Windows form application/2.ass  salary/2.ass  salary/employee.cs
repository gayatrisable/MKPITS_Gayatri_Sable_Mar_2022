using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ass__salary
{
     class employee
    {
        public int empno;
        public string empname;
        

        public float calculatebonus(int basicsal)
        {
            float bonus = basicsal * 0.45f;
            return bonus;
        }
        public float calulatetotalsalary(float bonus,int basicsa)
        {
            float totalsal = bonus + basicsa;
            return totalsal;
        }
    }
}
