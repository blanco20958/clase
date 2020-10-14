namespace ClaseVisualStudio
{
    class Ejercicios
    {
        // Ejercicio: Haz una función que imprima por pantalla 
        // los números desde el 0 hasta el 99

        public static void Ejercicio1()
        {
            int contador = 0;
            while (contador < 100)
            {
                System.Console.WriteLine(contador);
                // contador = contador + 1;
                // contador += 1;
                contador++;
            }

        }

        public static void Ejercicio2()
        {
            int i = 0;
            while (i < 100)
            {
                System.Console.WriteLine(i);
                i++;
            }
        }
        
        public static void Ejercicio3()
        {
            int i = 0;
            while (i < 100) 
            {
                System.Console.WriteLine(i*2);
                i++;
            }

        }

        public static void Ejercicio4()
        {
            int i = 0;
            while (i < 100)
            {
                System.Console.WriteLine(i * 3 + 1);
                i++;
            }

        }
        
        public static void Ejercicio5()
        {
            int i = 0;
            while (i<100)
            {
                System.Console.WriteLine(i * i);
                i++;
            }
        }

        public static void Ejercicio61()
        {
            int i = 0;
            while (i<100)
            {
                if ((i%2)!=0)
                
                    System.Console.WriteLine(i * (-1));
                    
               else 
                
                   System.Console.WriteLine(i);
                    i++; 
            }

        }
        public static void Ejercicio6()
        {
            int i = 0;
            while (i<100)
            {
                if (Utils.IsEven(i))
                    System.Console.WriteLine(i);
                else
                    System.Console.WriteLine(-i);
            }


        }







    }
}
