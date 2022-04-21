using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork1
{
    class Pentagon : Figures 
    {
        public Pentagon(double x1, double x2, double y1, double y2) : base(x1, x2, y1, y2) { 
        
        }
       

    public override void Print()
        {
            Console.WriteLine("Pentagon output");
            base.Print();
            
        }
    }
}
