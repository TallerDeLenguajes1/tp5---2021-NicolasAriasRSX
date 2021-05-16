using System;

namespace TP5
{
    class Program
    {
        static void Main(string[] args)
        {

            Ejercicio3();

        }

        private static void Ejercicio1()
        {
            //int rest, numInvert;
            Console.WriteLine("Ingrese un numero mayor que 0\n");
            int rest;
            int numInvert = 0;
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numero Ingresado " + num + "\n");
            //Console.WriteLine(num);
            if(num > 0)
            {
                while (num > 0)
                {
                    rest = num % 10;
                    numInvert = numInvert * 10 + rest;
                    num = num / 10;
                }
                Console.WriteLine("El numero invertido es: " + numInvert + "\n");
            }
            else
            {
                Console.WriteLine("Numero ingresado es menor o igual que 0\nError");
            }
        }
        private static void Ejercicio2()
        {
            int num1, num2, operacion, respuesta;
            float resultado = 0;

            do
            {
                Console.WriteLine("Seleccione la operacion que desea realizar\n");
                Console.WriteLine("1 Suma.\n2 Resta.\n3 Producto.\n4 Divison.\n");
                operacion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el primer numero: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                switch(operacion)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine("num1 + num2 = " + resultado + "\n");
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine("num1 - num2 = " + resultado + "\n");
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine("num1 * num2 = " + resultado + "\n");
                        break;
                    case 4:
                        if (num2 > 0)
                        {
                            resultado = (float) num1 / num2;
                            Console.WriteLine("num1 / num2 = " + resultado + "\n");
                        }
                        else
                        {
                            Console.WriteLine("No se puede hacer la operacion, segundo numero incorrecto\n");
                        }
                        break;
                    default:
                        Console.WriteLine("Operacion incorrecta\n");
                        break;
                }
                //Console.WriteLine(resultado);
                Console.WriteLine("\n¿Desea realizar otra operacion?\n1 si\n2 no");
                respuesta = Convert.ToInt32(Console.ReadLine());
            }
            while (respuesta < 2);

            Console.WriteLine(Math.Max(num1, num2));
        }
        private static void Ejercicio3()
        {
            Console.WriteLine("Ingrese un numero para realizar las operaciones: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Valor Absoluto = " + Math.Abs(num1) + "\n");
            Console.WriteLine("El cuadrado es igual = " + Math.Pow(num1,2) + "\n");
            if (num1 >= 0)
            {
                Console.WriteLine("La Raiz Cuadrada = " + Math.Sqrt(num1) + "\n");
            }
            else
            {
                Console.WriteLine("No se puede calcular la raiz cuadrada\n");
            }
            Console.WriteLine("El Seno = " + Math.Sin(num1) + "\n");
            Console.WriteLine("El Coseno = " + Math.Cos(num1) + "\n");
            Console.WriteLine("La Parte Entera = " + Math.Truncate(num1) + "\n\n\n");

            Console.WriteLine("Ingrese el primer numero \n");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero \n");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("EL numero mayor es = " + Math.Max(a, b) + "\n");
            Console.WriteLine("EL numero menor es = " + Math.Min(a, b) + "\n");
        }
    }
}
