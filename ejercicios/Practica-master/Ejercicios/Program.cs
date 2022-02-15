using System;
using System.IO;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace Ejercicios
{
    class Program
    {

        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Seleccione el ejercicio que desea ejecutar.");
                Console.WriteLine("1. Operaciones matematicas.");
                Console.WriteLine("2. Comparacion de numeros");
                Console.WriteLine("3. Comparacion de numeros avanzado");
                Console.WriteLine("4. porcentajes");
                Console.WriteLine("5. descuento e importe");
                Console.WriteLine("6. cuadrado de los numeros naturales");
                Console.WriteLine("7. algoritmo que nos calcule el cuadrado de los 9 primeros números naturales ");
                Console.WriteLine("8. Dada una secuencia de números leídos por teclado, que acabe con un –1, por ejemplo: 5,3,0,2,4,4,0,0,2,3,6,0,……,-1; Realizar el algoritmo que calcule la media aritmética.");
                Console.WriteLine("9. Algoritmo que lea un número entero (lado) y a partir de él cree un cuadrado de asteriscos con ese tamaño.");
                Console.WriteLine("10. Algoritmo que nos calcule las raíces de una ecuación de segundo grado (ax^2 + bx +c).");
                Console.WriteLine("0. salir");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Ejercicio1();
                        break;

                    case 2:
                        Ejercicio2();
                        break;

                    case 3:
                        Ejercicio3();
                        break;

                    case 4:
                        Ejercicio4();
                        break;

                    case 5:
                        Ejercicio5();
                        break;

                    case 6:
                        Ejercicio6();
                        break;

                    case 7:
                        Ejercicio7();
                        break;

                    case 8:
                        Ejercicio8();
                        break;

                    case 9:
                        Ejercicio9();
                        break;

                    case 10:
                        Ejercicio10();
                        break;

                }

            } while (opcion != 0);
        }
        private static void Ejercicio1()
        {
            Console.WriteLine("ingrese el primer numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            int suma = numero1 + numero2;
            Console.WriteLine("La suma de los numeros es: " + suma);

            int resta = numero1 - numero2;
            Console.WriteLine("La resta de los numeros es: " + resta);

            int producto = numero1 * numero2;
            Console.WriteLine("El producto de los numeros es: " + producto);

            double division = (double)numero1 / numero2;
            Console.WriteLine("La division de los numeros es: " + division);

            Console.ReadKey();
        }

        private static void Ejercicio2()
        {
            Console.WriteLine("ingrese el primer numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("El numero mayor es: " + numero1);
            }
            else if (numero1 == numero2)
            {
                Console.WriteLine("Los numeros son iguales");
            }
            else
            {
                Console.WriteLine("El numero mayor es: " + numero2);
            }

            Console.ReadKey();


        }

        private static void Ejercicio3()
        {
            Console.WriteLine("ingrese el primer numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el tercer numero: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2 && numero1 > numero3)
            {
                Console.WriteLine("el mayor es: " + numero1);
            }
            else if (numero2 > numero3)
            {
                Console.WriteLine("El mayor es: " + numero2);
            }
            else
            {
                Console.WriteLine("El mayor es: " + numero3);
            }

            Console.ReadKey();
        }

        private static void Ejercicio4()
        {
            Console.WriteLine("ingrese la cantidad de ninos");
            int cantidad1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese la cantidad de ninas");
            int cantidad2 = Convert.ToInt32(Console.ReadLine());

            var total = cantidad1 + cantidad2;
            var porcentaje1 = cantidad1 * 100 / total;
            var porcentaje2 = cantidad2 * 100 / total;

            Console.WriteLine("El porcentaje de ninos es: " + porcentaje1);
            Console.WriteLine("El porcentaje de ninas es: " + porcentaje2);

            Console.ReadKey();

        }

        private static void Ejercicio5()
        {
            double pagar;
            double descuento;

            Console.WriteLine("ingrese el importe");
            double importe = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el mes");
            int mes = Convert.ToInt32(Console.ReadLine());

            if (mes == 10)
            {
                descuento = importe * 0.15;
                pagar = importe - descuento;
            }
            else
            {
                pagar = importe;
            }

            Console.WriteLine("usted debe pagar: " + pagar);

            Console.ReadLine();
        }


        private static void Ejercicio6()
        {
            Console.WriteLine("introduzca un numero");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero == 0)
            {
                Console.WriteLine("El numero es 0");
            }
            else if (numero % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El nummero es impar");
            }

            Console.ReadKey();
        }

        private static void Ejercicio7()
        {
            int resultado;

            for (int i = 1; i < 10; i++)
            {
                resultado = i*i;
                Console.WriteLine("es : {0}", resultado);
            }
            Console.ReadKey();
        }

        private static void Ejercicio8()
        {
            int contar = 0;
            int suma = 0;
            int resultado = 0;
            int n= 0;

            while (n != -1)
            {
                Console.WriteLine("ingrese los numeros");
                 n = Convert.ToInt32(Console.ReadLine());
                
                suma += n;
                contar += 1;
            }
            resultado = suma / contar;
            Console.WriteLine("la media aritmetica es: {0}", resultado);
            Console.ReadKey();
        }

        private static void Ejercicio9()
        {
            Console.WriteLine("ingrese el tamaño del cuadro");
            int c = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= c; i++)
            {
                for (int j = 0; j <= c; j++)
                {
                    if (i == 0 || j == 0 || i == c || j == c)
                    {
                        Console.Write("*");

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }

        private static void Ejercicio10()
        {
            Console.WriteLine("ingrese el coeficiente A");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el coeficiente B");
            double b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el coeficiente C");
            double c = Convert.ToInt32(Console.ReadLine());

            double x1;
            double x2;

            x1 = (-b + (b * b - 4 * a * c)) / 2 * a;
            x2 = (-b - (b * b - 4 * a * c)) / 2 * a;

            Console.WriteLine("las soluciones son : {0} y {1}", x1, x2);
            Console.ReadKey();
        }

    }
}
    

 
