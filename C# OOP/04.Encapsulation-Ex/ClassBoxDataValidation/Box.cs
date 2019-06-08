namespace ClassBoxDataValidation
{
    using System;

    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            ValidateParameter(length, width, height);
            this.length = length;
            this.width = width;
            this.height = height;
        }

        private void ValidateParameter(params double[] parameters)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                var parameter = parameters[i];

                if (parameter <= 0)
                {
                    throw new ArgumentException($"{(PropertyNumber)i} cannot be zero or negative.");
                }
            }
        }

        public double CalculateSurfaceArea()
        {
            return 2 * (this.length * this.width) + CalculateLateralSurfaceArea();
        }

        public double CalculateLateralSurfaceArea()
        {
            return 2 * (this.length * this.height + this.width * this.height);
        }

        public double CalculateVolume()
        {
            return this.width * this.height * this.length;
        }
    }
}
