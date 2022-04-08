using System;

namespace Secao4_ExerciciosPropostos
{
    class Rectangle
    {
        private double width;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        private double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Area()
        {
            return width * height;
        }

        public double Perimeter()
        {
            return 2 * (width + height);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
        }
    }
}
