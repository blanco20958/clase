namespace ClaseVisualStudio
{
    class Geometry
    {
        public static double GetVector2DLength(double x, double y)
        {
            double aux;
            double length;
            aux = x * x + y * y;
            length = System.Math.Sqrt(aux);
            return length;
        }

        public static double GetVector3DLength(double x, double y, double z)
        {
            double aux;
            double length;
            aux = x * x * +y * y + z * z;
            length = System.Math.Sqrt(aux);
            return length;
        }

        public static double GetCircleArea(double r)
        {
            double areac;
            areac = System.Math.PI * r * r;

            return areac;

        }

        public static double GetRectangleArea(double weight, double height)
        {
            double arearec;
            arearec = weight * height;

            return arearec;

        }

        public static double GetEllipseArea(double r1,double r2)
        {
            double areae;
            areae = r1 * r2 * System.Math.PI;
            return areae;

        }


    }


}