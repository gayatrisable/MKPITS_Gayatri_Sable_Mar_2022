using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ass_class_result
{
     class Result
    {
        
        public int calculatetotal(int phy,int chem,int math)
        {
        
        int total = chem + phy + math;
            return  total;
        }
        public float calculatepercentage(int total)
        {
            float per = (total / 300.0f) * 100;
            return  per;
        }
        
        public string calculategrade(float per)
        {
           
            if (per >= 75)
            {
                return " Distinction ";
            }
            else if (per >= 65)
            {
                return " first class ";
            }
            else if (per >= 45)
            {
                return " Second class ";
            }
            else
            {
                return " fail ";
            }
        }

    }
}
    

