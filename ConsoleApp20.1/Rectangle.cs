using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20._1 {
    internal class Rectangle: IShape {
        public double Height;
        public double Width;
        public double CalculateArea() {
            return Height * Width;
        }
    }
}
