

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
            else if (a > b)
                return 1;
            else
                return 0;
            /*
             if (a<b)
                return -1;
             if (a>b)
               return 1;
             return 0;
             */
        }
        public static double Ejercicio7(double a, double b)
        {
            if (a < b)

                return b * b;

            else

                return 2.0 * a + b;


        }
        public static void Ejercicio8(int code)
        {
            switch (code)
            {
                case 0:
                    System.Console.WriteLine("Error grave");
                    break;
                case 1:
                    System.Console.WriteLine("Error moderado");
                    break;
                case 2:
                    System.Console.WriteLine("Error leve");
                    break;
                default:
                    System.Console.WriteLine("Error desconocido");
                    break;


            }
        }
        public static void Ejercicio9(int n)
        {
            int i = 0;
            while (i <= n)
            {
                System.Console.Write(i + ",");
                i += 3;

            }



        }
        public static void Ejercicio10(int n)
        {
            for (int i = 0; i <= n; i++)

                System.Console.Write(i + ",");

        }

        public static void Ejercicio11(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                System.Console.Write(i);
                if (i < n)
                    System.Console.Write(",");
            }

            /*
              for (int i=0; i<n; i++)
                  System.Console.Write(i+",");
              scw (n);  
             */

        }
        public static void Ejercicio12(int n)
        {
            for (int i = 0; i < n; i++)
                System.Console.Write("*");

        }
        public static void Ejercicio13(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                    System.Console.Write("+");
                else
                    System.Console.Write("*");

            }


        }
        public static void Ejercicio14(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int rest = i % 4;
                switch (rest)
                {
                    case 0:
                        System.Console.Write("-");
                        break;

                    case 1:
                        System.Console.Write("+");
                        break;

                    case 2:
                        System.Console.Write("*");
                        break;
                    case 3:
                        System.Console.Write("/");
                        break;
                }

            }












    }   }
}
