﻿using System;

namespace ClaseVisualStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int sol;
            sol = Utils.GetMinvalue(10, 7);

            int sol2;
            sol2 = Utils.GetMaxValue(4, 9);

            bool sol3;
            sol3 = Utils.IsEven(9);

            Ejercicios.Ejercicio1();
            Ejercicios.Ejercicio2();
            Ejercicios.Ejercicio3();
            Ejercicios.Ejercicio4();
            Ejercicios.Ejercicio5();
            Ejercicios.Ejercicio61();
            Ejercicios.Ejercicio6();
            */
            int result = EjerciciosExamen.Add(1,2);
            System.Console.WriteLine(result);

            double result2 = EjerciciosExamen.Ejercicio2(5, 8);
            System.Console.WriteLine(result2);

            double result3 = EjerciciosExamen.Ejercicio3(9, 4);
            System.Console.WriteLine(result3);

            string result4 = EjerciciosExamen.Ejercicio4("patatas", "con", "ketchup");
            System.Console.WriteLine(result4);

            bool result5 = EjerciciosExamen.Ejercicio5(9, 7);
            System.Console.WriteLine(result5);

        }

      
        
            

        
    }
}
