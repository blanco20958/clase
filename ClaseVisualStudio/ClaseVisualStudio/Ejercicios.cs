﻿namespace ClaseVisualStudio
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
    }
}
