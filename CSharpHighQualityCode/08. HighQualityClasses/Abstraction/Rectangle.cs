﻿using System;

namespace Abstraction
{
    class Rectangle : Figure
    {
        private double width;
        private double height;

        public Rectangle()
            :this(0,0)
        {
        }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width 
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cannot set width to a negative value.");
                }

                this.width = value;
            }
        }

        public double Height 
        { 
            get
            {
                return this.height;
            }

            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cannot set height to a negative value.");
                }

                this.height = value;
            }
        }


        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
