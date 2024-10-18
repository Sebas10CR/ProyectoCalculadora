using System;

namespace proyecto_calculadora
{
    internal class Operaciones
    {
        public abstract class Operacion
        {
            public abstract double Calcular(double valor1, double valor2 = 0);
        }

        public class Suma : Operacion
        {
            public override double Calcular(double valor1, double valor2)
            {
                return valor1 + valor2;
            }
        }

        public class Resta : Operacion
        {
            public override double Calcular(double valor1, double valor2)
            {
                return valor1 - valor2;
            }
        }

        public class Multiplicacion : Operacion
        {
            public override double Calcular(double valor1, double valor2)
            {
                return valor1 * valor2;
            }
        }

        public class Division : Operacion
        {
            public override double Calcular(double valor1, double valor2)
            {
                if (valor2 == 0)
                    throw new DivideByZeroException("No se puede dividir por cero.");
                return valor1 / valor2;
            }
        }

        public class RaizCuadrada : Operacion
        {
            public override double Calcular(double valor1, double valor2 = 0)
            {
                if (valor1 < 0)
                    throw new InvalidOperationException("No se puede calcular la raíz cuadrada de un número negativo.");
                return Math.Sqrt(valor1);
            }
        }

        public class Potencia : Operacion
        {
            public override double Calcular(double valor1, double valor2)
            {
                return Math.Pow(valor1, valor2);
            }
        }

        public class PotenciaDeDiez : Operacion
        {
            public override double Calcular(double valor1, double valor2 = 0)
            {
                return Math.Pow(10, valor1);
            }
        }

        public class Logaritmo : Operacion
        {
            public override double Calcular(double valor1, double valor2 = 0)
            {
                if (valor1 <= 0)
                    throw new InvalidOperationException("El logaritmo solo está definido para números positivos.");
                return Math.Log10(valor1);
            }
        }

        public class Cuadrado : Operacion
        {
            public override double Calcular(double valor1, double valor2 = 0)
            {
                return Math.Pow(valor1, 2);
            }
        }

        public class Factorial : Operacion
        {
            public override double Calcular(double valor1, double valor2 = 0)
            {
                if (valor1 < 0)
                    throw new InvalidOperationException("No se puede calcular el factorial de un número negativo.");

                // Asegúrate de que valor1 es un entero no negativo
                if (valor1 != Math.Floor(valor1))
                    throw new InvalidOperationException("El factorial solo está definido para números enteros no negativos.");

                return FactorialRecursivo((int)valor1);
            }

            private int FactorialRecursivo(int n)
            {
                if (n == 0 || n == 1) return 1;
                return n * FactorialRecursivo(n - 1);
            }
        }

        // Esta clase no es utilizada actualmente, considera eliminarla si no es necesaria.
        public class CambioDeSigno : Operacion
        {
            public override double Calcular(double valor1, double valor2 = 0)
            {
                return -valor1;
            }
        }
    }
}
