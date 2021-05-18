using System;

namespace TP5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1();
            //Ejercicio2();
            //Ejercicio3();
            Ejercicio4();

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
            if (num > 0)
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

                switch (operacion)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine("La suma de {0} y de {1} es igual a: {2}\n", num1, num2, resultado);
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine("La resta de {0} y de {1} es igual a: {2}\n", num1, num2, resultado);
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine("El producto entre {0} y {1} es igual a: {2}\n", num1, num2, resultado);
                        break;
                    case 4:
                        if (num2 > 0)
                        {
                            resultado = (float)num1 / num2;
                            Console.WriteLine("El cociente entre {0} y {1} es igual a: {2}\n", num1, num2, resultado);
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

            //Console.WriteLine(Math.Max(num1, num2));
        }
        private static void Ejercicio3()
        {
            Console.WriteLine("Ingrese un numero para realizar las operaciones: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Valor Absoluto = " + Math.Abs(num1) + "\n");
            Console.WriteLine("El cuadrado es igual = " + Math.Pow(num1, 2) + "\n");
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
        private static void Ejercicio4()
        {
            string cadena, cadena2, nuevaCadena;
 
            Console.WriteLine("Ingrese una cadena");
            cadena = Console.ReadLine();
            //Console.WriteLine(cadena);
            //---Longitud de una cadena---//
            Console.WriteLine("\nLa longitud de la cadena es de: {0}\n", cadena.Length);
            //------Concatenar 2 cadenas-------//
            Console.WriteLine("Ingrese otra cadena\n");
            cadena2 = Console.ReadLine();
            nuevaCadena = string.Concat(cadena, " ", cadena2);
            Console.WriteLine(nuevaCadena);
            //------Extraer una subcadena-------//
            Console.WriteLine("\nSubcadena: ({0})", nuevaCadena.Substring(1, 5));
            //---Ciclo foreach---//
            Console.WriteLine("Cadena recorrida con foreach");
            foreach(var caracter in nuevaCadena)
            {
                Console.Write(caracter + " ");
            }
            Console.WriteLine("\nIngrese la palabra buscada\n");
            string buscar = Console.ReadLine();
            //Console.WriteLine("-----------------"+cadena.Contains(buscar)+"-----------------");
            if(cadena.Contains(buscar))
            {
                Console.WriteLine("Palabra encontrada\n");
            }
            else
            {
                Console.WriteLine("No se encontro la palabra\n");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Mayuscula: \n" + nuevaCadena.ToUpper());
            Console.WriteLine("Minuscula: \n" + nuevaCadena.ToLower());
            //---Reemplazar un caracter por otro---//
            Console.WriteLine("Ingrese con lo que quiere cambiar el caracter de espacio");
            string remplazo = Console.ReadLine();
            nuevaCadena = nuevaCadena.Replace(" ", remplazo);
            Console.WriteLine(nuevaCadena + "\n");
            //---Comparar los valores de 2 cadenas---//
            Console.WriteLine("Comparacion de la cadena '{0}' y la cadena '{1}'\n", cadena, cadena2);
            Console.WriteLine(string.Compare(cadena, cadena2) == 0? "true" : "false");
            
            //---Calculadora--//
            Console.WriteLine("\n--------------Calculadora 2------------------");
            int num1, num2, respuesta, ope = 0;
            float resultado = 0;
            do
            {
                Console.WriteLine("Ingrese la operacion que desea realizar\nPor ejemplo 54+23\n");
                string operacion = Console.ReadLine();        
                if(operacion.Contains("+"))
                {
                    ope = 1;
                }
                if(operacion.Contains("-"))
                {
                    ope = 2;
                }
                if(operacion.Contains("*"))
                {
                    ope = 3;
                }
                if(operacion.Contains("/"))
                {
                    ope = 4;
                }

                string[] numeros = operacion.Split('+', '-', '*', '/');
                num1 = Convert.ToInt32(numeros[0]);
                num2 = Convert.ToInt32(numeros[1]);
                switch (ope)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine("La suma de {0} y de {1} es igual a: {2}\n", num1, num2, resultado);
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine("La resta de {0} y de {1} es igual a: {2}\n", num1, num2, resultado);
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine("El producto entre {0} y {1} es igual a: {2}\n", num1, num2, resultado);
                        break;
                    case 4:
                        if (num2 > 0)
                        {
                            resultado = (float)num1 / num2;
                            Console.WriteLine("El cociente entre {0} y {1} es igual a: {2}\n", num1, num2, resultado);
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
        }
    }
}
