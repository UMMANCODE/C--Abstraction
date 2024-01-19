using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20 {
    internal class Rectangle: Shape {
        public double Height;
        public double Width;
        public override double CalculateArea() {
            return Height * Width;
        }
    }
}
