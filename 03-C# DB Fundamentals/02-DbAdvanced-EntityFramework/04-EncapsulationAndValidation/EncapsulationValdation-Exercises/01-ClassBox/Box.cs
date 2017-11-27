﻿namespace _01_ClassBox
{
    class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                this.height = value;
            }
        }

        public double SurfaceArea()
        {
            double surfaceArea = 
                (2 * this.length * this.width) +
                (2 * this.length * this.height) +
                (2 * this.width * this.height);

            return surfaceArea;
        }

        public double LateralSurfaceArea()
        {
            double lateralSurfaceArea = 
                (2 * this.length * this.height) +
                (2 * this.width * this.height);

            return lateralSurfaceArea;
        }

        public double Volume()
        {
            double volume = this.length * this.width * this.height;

            return volume;
        }
    }
}
