﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork1
{
    class Triangle : Figures
    {
        public Triangle(double x1, double x2, double y1, double y2) : base(x1, x2, y1, y2)
        {

        }


        public override void Print()
        {
            Console.WriteLine("Triangle output");
            base.Print();

        }
    }
}
