using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20._1 {
    internal class Circle: IShape {
        public double Radius;
        public double CalculateArea() {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
