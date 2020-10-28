

namespace ClaseVisualStudio
{
    class EjerciciosExamen
    {
        public static int Add(int a, int b)
        {
            /*
             int c;
             c=a + b;
             return c;
             */
            return a + b;



        }

        public static double Ejercicio2(double a, double b)
        {
            return a - b;
        }

        public static double Ejercicio3(double a, double b)
        {
            /* 
             if (a<b)
             {
                 return a;
             }
             else
             {
                 return b;
             }

             */
            if (a < b)
                return a;
            else
                return b;
            /* 
               if (a<b)
                  return a;
               return b;
               */

        }
        public static string Ejercicio4(string a, string b, string c)
        {
            return a + b + c;
        }

        public static bool Ejercicio5(int a, int b)
        {
            /*
            if (a < b)
                return true;
            else
                return false;
                */
            return a < b;
        }
        public static int Ejercicio6(int a, int b)
        {
            if (a < b)
                return -1;
            else if (a>b)
                return 1;
            else 
                return 0;
            /*
             if (a<b)
                return -1;
             if (a<b)
               return 1;
             return 0;
             */
        }
        public static double Ejercicio7(double a, double b)
        {
            if (a < b)

                return b * b;

            else

                return 2.0*a + b;
            

        }










    }
}
