

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
        }
        public static void Ejercicio15(int n)
        {
            for (int f = 0; f < n; f++)
            {
                for (int c=0; c<n; c++)
                    System.Console.Write("*");
                System.Console.WriteLine();

            }

        }
        public static void Ejercicio16(int n)
        {
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (f % 2 == 0)
                        System.Console.Write("*");
                    else
                        System.Console.Write("+");

                }
                System.Console.WriteLine();

            }


        }
        public static void Ejercicio17(int n)
        {
            for (int f=0; f<n; f++)
            {
                for (int c=0; c<n; c++)
                {
                    int suma = f + c;
                    if (suma % 2 == 0) 
                        System.Console.Write("*");
                    else
                        System.Console.Write("+");

                }
                System.Console.WriteLine();


            }






        }
        public static void Ejercicio18(int n)
        {
            for (int f= 0; f<n; f++)
            {
                for (int c =0; c<=f; c++)
                
                    System.Console.Write("*");

                
                System.Console.WriteLine();

            }



        }
        public static void Ejercicio19(int n)
        {
            for (int f=0; f<n; f++)
            {
                int nasteriscos = f + 1;
                int nespacios = n - f - 1;

                for (int c = 0; c < nespacios; c++)
                    System.Console.Write(" ");
                for (int c = 0; c < nasteriscos; c++)
                    System.Console.Write("*");

                System.Console.WriteLine();
            }


        }
        public static void Ejercicio20(int n)
        {
            for (int f =0; f<n;f++)
            {
                int espacios1 = n - f - 1;
                int espacios2 = f * 2;

                for (int c = 0; c < espacios1; c++)
                    System.Console.Write(" ");

                System.Console.Write("*");

                for (int c = 0; c < espacios2; c++)
                    System.Console.Write(" ");

                System.Console.Write("*");

                System.Console.WriteLine();

            }
        }
        public static void Ejercicio21(int n)
        {
            for (int f =0; f<n; f++)
            {
                int espacios1 = f;
                int espacios2 = (n - f - 1) * 2;

                for (int c = 0; c < espacios1; c++)
                    System.Console.Write(" ");

                System.Console.Write("*");

                for (int c = 0; c < espacios2; c++)
                    System.Console.Write(" ");

                System.Console.Write("*");

                System.Console.WriteLine();

            }

        }
        public static void Ejercicio22 ()
        {
            for (int f=0; f<10; f++)
            {
                for (int c = 0; c <15; c++)
                {
                    if (0 <= c && c <= 5 && 0 <= f && f <= 2)
                    {
                        int suma = f + c;
                        if (suma % 2 == 0)
                            System.Console.Write("+");
                        else
                            System.Console.Write(" ");

                        
                    }
                    else
                        System.Console.Write("-");


                }
                System.Console.WriteLine(); 
                
                            
            }




        }
        public static void Ejercicio23(int n)
        {
            Ejercicio20(n);
            Ejercicio21(n);

        }
        public static void Ejercicio24()
        {
            while (true)
            {
                for (int i = 0; i < 10; i++)
                {
                    Ejercicio23(i);
                    System.Threading.Thread.Sleep(100);
                    System.Console.Clear();


                }

        }   }
        public static void Ejercicio25()
        {
           for (int f=0; f<15; f++)
           {
                for (int c=0; c<70; c++)
                {
                    if (f == 0 || c==69)
                        System.Console.Write("*");
                    




                }







           }


        }













}   }   

    
