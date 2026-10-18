using System;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tarea
{
    internal class Program
    {
        // EJERCICIO #1
        // SUMAR LOS NUMEROS PARES DEL 1 AL 100 XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

        static void Main(string[] args)
        {

            cabecera(1);

            int total = sumar(100);

            Console.Write(" = " + total);
            Console.WriteLine("");
            Console.ReadKey();

            static int sumar(int maximo)
            {
                int suma = 0;

                for (int i = 0; i <= maximo; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i);
                        suma += i;
                        if (i < maximo)
                            Console.Write(" + ");
                    }
                }
                return suma;
            }


            // EJERCICIO #2
            // FUNCION SUMAR
            //----------------------------------------------------------------------
            // UNA FUNCION CON 2 PARAMETROS Y ENCONTRAR EL MAYOR Y EL MENOR XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX


            int num1, num2;

            cabecera(2);

            Console.Write("Introduce el primer número:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Introduce el segundo número:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine(encuentra(num1, num2));
            Console.ReadKey();
        
            static string encuentra(int num1, int num2)
            {
                if (num1 == num2)
                {
                    return "Los numeros son iguales.";
                }

                string resultado = num1 > num2 ? string.Format("El num mayor es {0} y el menor es {1}", num1, num2)
                                                : string.Format("El numero mayor es {1} y el menor es {0}", num1, num2);

                return resultado;
            }

            //----------------------------------------------------------------------

            // EJERCICIO #3
            // FACTORIAL DE UN NUMERO POSITIVO XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            
            int numE3;

            cabecera(3);

            Console.Write("Introduce el num para calcular el factorial:");
            numE3 = Convert.ToInt32(Console.ReadLine());

            factorial(numE3);
            Console.ReadKey();


            static void factorial(int numE3)
            {
                long resultado = 1;
                for (int i = numE3; i >= 1; i--)
                {
                    Console.Write(i);

                    resultado *= i;

                    if (i > 1)
                        Console.Write(" * ");
                }
                Console.WriteLine("");
                Console.WriteLine($"El factorial de {numE3} es: {resultado}");
            }

            //----------------------------------------------------------------------


            // EJERCICIO #4
            // PROCEDIMIENTO PARA ENCONTRAR SI UN NUM ES PAR O IMPAR XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            cabecera(4);

            int numE4;
            Console.Write("Introduce un num para saber si es PAR o IMPAR:");
            numE4 = Convert.ToInt32(Console.ReadLine());
            tipoNum(numE4);
            Console.ReadKey();


            static void tipoNum(int numE4)
            {
                if (numE4 % 2 == 0)
                    Console.WriteLine($"El número {numE4} es PAR");
                else
                    Console.WriteLine($"El número {numE4} es IMPAR");
            }


            //----------------------------------------------------------------------

            // EJERCICIO #5
            // PROCEDIMIENTO USANDO PARAMETRO DE REFERENCIA, VERIFICAR SI ES DIVISIBLE ENTRE 2,3,5 O 7 XXXXXXXXXXXXXXXXXXXXXXXXX

            cabecera(5);

            int numE5;
            string resultado = "";
            Console.Write("Introduce un número: ");
            numE5 = Convert.ToInt32(Console.ReadLine());
            esDiv(numE5, ref resultado);
            Console.WriteLine(resultado);
            Console.ReadKey();
            


            static void esDiv(int numero, ref string resultado) 
            {
                if (numero % 2 == 0)
                    resultado = $"El número {numero} es divisible por 2.";
                else if (numero % 3 == 0)
                    resultado = $"El número {numero} es divisible por 3.";
                else if (numero % 5 == 0)
                    resultado = $"El número {numero} es divisible por 5.";
                else if (numero % 7 == 0)
                    resultado = $"El número {numero} es divisible por 7.";
                else
                    resultado = "El número no es divisible por 2, 3, 5 o 7.";
            }

            //----------------------------------------------------------------------


            // EJERCICIO #6
            //Realizar la impresión de los siguientes mensajes: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
            //Entrada
            //Se tiene números del 1 al 100:
            //Si el número es divisible entre 3 mostrar el mensaje: Fizz
            //Si el número es divisible entre 5 mostrar el mensaje: Buzz
            //Si el número es divisible entre 15 mostrar el mensaje: FizzBuzz
            //Si el número no es divisible entre 3, 5 y 15 mostrar una cadena vacia
            //Salida
            //Se mostrará el valor y mensaje correspondiente, en una fila
            //La solución debe estar en una función.
            //Tip.- Se debe utilizar un for con los números del 1 al 100 e ir colocando los mensajes cuando el número es divisible, no se debe solicitar información por teclado.


            cabecera(6);

            string mensaje = "";

            for (int i = 1; i <= 100; i++)
            {
                mensaje = imprime(i);
                Console.WriteLine(mensaje);
            }
            Console.ReadKey();


            static string imprime(int x)
            {
                string mensaje = "";

                if (x % 15 == 0)
                    mensaje = "FizzBuzz";
                else if (x % 3 == 0)
                    mensaje = "Fizz";
                else if (x % 5 == 0)
                    mensaje = "Buzz";

                mensaje = $"{x}: {mensaje}";

                return mensaje;
            }

            //----------------------------------------------------------------------


            static void cabecera(int ne)
            {
                Console.WriteLine("");
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Ejercicio #"+ne);
                Console.WriteLine("");
            }


        }

    }
}