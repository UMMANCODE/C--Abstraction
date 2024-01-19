using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20 {
    internal class Circle: Shape {
        public double Radius;
        public override double CalculateArea() {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
