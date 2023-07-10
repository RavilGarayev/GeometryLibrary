namespace GeometryLibrary
{
    public class GeometryCalculator
    {
        public double CalculateCircleArea(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус не может быть отрицательным.");
            }

            return Math.PI * Math.Pow(radius, 2);
        }

        public double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA < 0 || sideB < 0 || sideC < 0)
            {
                throw new ArgumentException("Длина стороны не может быть отрицательной.");
            }

            // Проверка на прямоугольный треугольник
            bool isRightTriangle = IsRightTriangle(sideA, sideB, sideC);

            double semiPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) *
                                    (semiPerimeter - sideB) * (semiPerimeter - sideC));
            return area;
        }

        private bool IsRightTriangle(double sideA, double sideB, double sideC)
        {
            // Проверка на прямоугольный треугольник по теореме Пифагора
            double aSquared = sideA * sideA;
            double bSquared = sideB * sideB;
            double cSquared = sideC * sideC;

            return aSquared == bSquared + cSquared ||
                   bSquared == aSquared + cSquared ||
                   cSquared == aSquared + bSquared;
        }
    }
}