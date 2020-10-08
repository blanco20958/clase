namespace ClaseVisualStudio
{
    class EquationSolvers
    {
        public static Equation2Solution SolveEquation2(double a, double b, double c)
        {
            double aux, root;
            Equation2Solution result;
            result = new Equation2Solution();

            aux = b * b - 4.0 * a * c;
            root = System.Math.Sqrt(aux);
            result.solution1 = (-b + root) / (2.0 * a); 
            result.solution2 = (-b - root) / (2.0 * a);
            return result;

        }

        


    }  
}   