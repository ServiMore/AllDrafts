using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios4
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
                Console.WriteLine("1. programa que pregunte al usuario su edad y muestre por pantalla si es mayor de edad o no. ");
                Console.WriteLine("2. programa que almacene la cadena de caracteres contraseña en una variable, pregunte al usuario por la contraseña e imprima por pantalla si la contraseña introducida por el usuario ");
                Console.WriteLine("3. pregunte al usuario su edad y sus ingresos mensuales y muestre por pantalla si el usuario tiene que tributar o no.");
                Console.WriteLine("4. pregunte al usuario su nombre y sexo, y muestre por pantalla el grupo que le corresponde");
                Console.WriteLine("5. pregunte al usuario su renta anual y muestre por pantalla el tipo impositivo que le corresponde.");
                Console.WriteLine("6.  programa que pida al usuario una palabra y la muestre por pantalla 10 veces");
                Console.WriteLine("7.  programa que pida al usuario un número entero positivo y muestre por pantalla todos los números impares desde 1 hasta ese número separados por comas");
                Console.WriteLine("8.  programa que pida al usuario un número entero positivo y muestre por pantalla la cuenta atrás desde ese número hasta cero separados por comas.");
                Console.WriteLine("9.  programa que pida al usuario un número entero y muestre por pantalla un triángulo rectángulo como el de más abajo, de altura el número introducido.");
                Console.WriteLine("10. programa que muestre por pantalla la tabla de multiplicar del 1 al 10.");
                Console.WriteLine("11. programa que almacene la cadena de caracteres contraseña en una variable, pregunte al usuario por la contraseña hasta que introduzca la contraseña correcta.");
                Console.WriteLine("12. programa en el que se pregunte al usuario por una frase y una letra, y muestre por pantalla el número de veces que aparece la letra en la frase.");
                Console.WriteLine("13. programa que pregunte el nombre del usuario en la consola y después de que el usuario lo introduzca muestre por pantalla la cadena ¡Hola <nombre>!");
                Console.WriteLine("14. programa que pregunte el nombre del usuario en la consola y después de que el usuario lo introduzca muestre por pantalla <NOMBRE> tiene <n> letras");
                Console.WriteLine("15. programa que pregunte al usuario por el número de horas trabajadas y el coste por hora. Después debe mostrar por pantalla la paga que le corresponde.	");
                Console.WriteLine("16. programa que pida al usuario su peso (en kg) y estatura (en metros), calcule el índice de masa corporal y lo almacene en una variable, y muestre por pantalla la frase Tu índice de masa corporal es <imc> donde <imc> es el índice de masa corporal calculado redondeado con dos decimales.");
                Console.WriteLine("17. programa que comience leyendo la cantidad de dinero depositada en la cuenta de ahorros, introducida por el usuario. Después el programa debe calcular y mostrar por pantalla la cantidad de ahorros tras el primer, segundo y tercer años. Redondear cada cantidad a dos decimales.");
                Console.WriteLine("18. función que calcule el total de una factura tras aplicarle el IVA. La función debe recibir la cantidad sin IVA y el porcentaje de IVA a aplicar, y devolver el total de la factura. ");
                Console.WriteLine("19. función que reciba una muestra de números en una lista y devuelva su media.");
                Console.WriteLine("20. programa que almacene el abecedario en una lista, elimine de la lista las letras que ocupen posiciones múltiplos de 3, y muestre por pantalla la lista resultante.");
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

                    case 11:
                        Ejercicio11();
                        break;

                    case 12:
                        Ejercicio12();
                        break;

                    case 13:
                        Ejercicio13();
                        break;

                    case 14:
                        Ejercicio14();
                        break;

                    case 15:
                        Ejercicio15();
                        break;

                    case 16:
                        Ejercicio16();
                        break;

                    case 17:
                        Ejercicio17();
                        break;

                    case 18:
                        Ejercicio18();
                        break;

                    case 19:
                        Ejercicio19();
                        break;

                    case 20:
                        Ejercicio20();
                        break;

                }

            } while (opcion != 0);
        }

        private static void Ejercicio1()
        {
            Console.WriteLine("Ingrese su edad");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (edad < 18)
            {
                Console.WriteLine("usted es menor de edad");
            }
            else
            {
                Console.WriteLine("usted es mayor de edad");
            }
            Console.ReadKey();
        }

        private static void Ejercicio2()
        {
            Console.WriteLine("cual es tu contraseña?");
            string contraseña = Console.ReadLine();

            Console.WriteLine("ingrese de nuevo su contraseña?");
            string contraseña2 = Console.ReadLine();

            if (contraseña == contraseña2)
            {
                Console.WriteLine("las contraseñas coinciden");
            }
            else
            {
                Console.WriteLine("las contraseñas no coinciden");

            }
            Console.ReadKey();

        }

        private static void Ejercicio3()
        {
            Console.WriteLine("cual es tu edad?");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("De cuanto es tu ingreso mensual?");
            int ingresos = Convert.ToInt32(Console.ReadLine());

            if (edad > 16 && ingresos >= 1000)
            {
                Console.WriteLine("tienes que pagar impuestos");
            }
            else
            {
                Console.WriteLine("no tienes que pagar impuestos");
            }
            Console.ReadKey();
        }

        private static void Ejercicio4()
        {
            Console.WriteLine("ingrese el sexo del estudiante M o F");
            string sexo = Console.ReadLine();

            Console.WriteLine("ingrese el nombre");
            string nombre = Console.ReadLine();

            char letra = nombre.ToLower().ToCharArray()[0];
           
            if (sexo.ToLower() == "m")
            {
                if (letra > 'n')
                {
                    Console.WriteLine("pertenece al grupo A.");

                }
                else
                {
                    Console.WriteLine("pertenece al grupo B.");

                }
            }
            else if (sexo.ToLower() == "f")
            {
                if (letra < 'm')
                {
                    Console.WriteLine("pertenece al grupo A.");

                }
                else
                {
                    Console.WriteLine("pertenece al grupo B.");

                }
            }
            else
            {
                Console.WriteLine("el sexo ingresado no es valido");
            }
            Console.ReadKey();
        }

        private static void Ejercicio5()
        {
            int impositivo = 0;

            Console.WriteLine("cual es tu renta anual?");
            int renta = Convert.ToInt32(Console.ReadLine());

            if (renta <= 10000)
            {
                impositivo = 5;
            }
            else if (renta > 10000 && renta <= 20000)
            {
                impositivo = 15;
            }

            else if (renta > 20000 && renta <= 35000)
            {
                impositivo = 20;
            }

            else if (renta > 35000 && renta <= 60000)
            {
                impositivo = 30;
            }

            else
            {
                impositivo = 40;
            }

            Console.WriteLine("tu impositivo es: " + impositivo + "%");
            Console.ReadKey();
        }

        private static void Ejercicio6()
        {
            Console.WriteLine("ingrese la palabra");
            string palabra = Console.ReadLine();

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(palabra);
            }
            Console.ReadKey();
        }
        private static void Ejercicio7()
        {
            Console.WriteLine("ingrese el numero");
            int numero = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < numero; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + ", ");
                }

            }

            Console.ReadKey();

        }

        private static void Ejercicio8()
        {
            Console.WriteLine("ingrese el numero");
            int numero = Convert.ToInt32(Console.ReadLine());

            while (numero >= 0)
            {
                Console.Write(numero + ", ");
                numero = numero - 1;

            }
            Console.ReadKey();
        }

        private static void Ejercicio9()
        {
            Console.WriteLine("ingrese el tamaño del triangulo");
            int c = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= c; i++)
            {
                for (int j = 0; j <= c; j++)
                {
                    if (j <= i)
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
            for (int i = 1; i < 11; i++)
            {
                for (int o = 1; o < 11; o++)
                {
                    Console.WriteLine($"{i} * {o} = { i * o }");
                }
            }
            Console.ReadKey();
        }

        private static void Ejercicio11()
        {
            string clave = "contraseña";
            string clave2 = "";

            while (clave2 != clave)
            {
                Console.WriteLine("ingrese la contraseña");
                clave2 = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("la contraseña es correcta");
            Console.ReadKey();
        }

        private static void Ejercicio12()
        {
            Console.WriteLine("ingrese una frase");
            string frase = Console.ReadLine().ToLower();

            Console.WriteLine("ingrese la letra");
            var letra = Console.ReadLine().ToLower().ToCharArray()[0];
            var contador = 0;

            foreach (var i in frase.ToLower().ToCharArray())
            {
                if (letra == i)
                {
                    contador += 1;
                }
            }

            Console.WriteLine("la letra {0} aparece {1}.", letra, contador);
            Console.ReadKey();
        }

        private static void Ejercicio13()
        {
            Console.WriteLine("ingrese su nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("Hola {0}!", nombre);
            Console.ReadKey();
        }

        private static void Ejercicio14()
        {
            Console.WriteLine("ingrese su nombre");
            string nombre = Convert.ToString(Console.ReadLine());
          
            int largo = nombre.Length;
            Console.WriteLine("{0} tiene {1} letras", nombre, largo);
            Console.ReadKey();
        }


        private static void Ejercicio15()
        {
            Console.WriteLine("ingrese sus horas de trabajo");
            int horas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el coste por hora");
            int costo = Convert.ToInt32(Console.ReadLine());

            int pago = horas * costo;

            Console.WriteLine("tu paga es de: {0}$", pago);
            Console.ReadKey();
        }

        private static void Ejercicio16()
        {
            Console.WriteLine("ingrese su peso en kg");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingrese estatura en metros");
            double altura = Convert.ToDouble(Console.ReadLine());
            //utilizar math.round
            double masa = peso / altura * 2.2;

            Console.WriteLine("tu indice de masa corporal es {0}", Math.Round(masa, 2));
            Console.ReadKey();
        }

        private static void Ejercicio17()
        {
            Console.WriteLine("ingrese la inversion inicial");
            double inversion = Convert.ToDouble(Console.ReadLine());

            double interes = 0.04;

            double ahorro1 = Math.Floor(inversion) * (1 + interes);
            double ahorro2 = Math.Floor(ahorro1) * (1 + interes);
            double ahorro3 = Math.Floor(ahorro2) * (1 + interes);

            Console.WriteLine("ahorro tras primer año {0}", ahorro1);
            Console.WriteLine("ahorro tras segundo año {0}", ahorro2);
            Console.WriteLine("ahorro tras tercer año {0}", ahorro3);
            Console.ReadKey();

        }

        private static void Ejercicio18()
        {
            Console.WriteLine("ingrese el monto");
            var monto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingrese el iva");
            var ivaPorcentaje = Convert.ToDouble(Console.ReadLine());

            var calculo = monto * (ivaPorcentaje / 100 + 1);

            var iva = monto * (ivaPorcentaje/100);

            Console.WriteLine("El iva es: {0}", iva);

            Console.WriteLine("la cantidad a pagar es: {0}", calculo);
            Console.ReadKey();
        }

        private static void Ejercicio19()
        {
            var conteo = 0;
            double numeros = 0;
            double media;


            while (conteo < 10)
            {
                Console.WriteLine("ingrese los numeros");
                numeros += Convert.ToDouble(Console.ReadLine());
                conteo += 1;
            }

            media = numeros / conteo;

            Console.WriteLine("la media de los numeros es : {0}", media);
            Console.ReadKey();
        }

        private static void Ejercicio20()
        {
            //con una coleccion, recorrerlas y si la posicion es multiplo de 3 no  hay que imprimirlo 
            string[] abc = new[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            for (int i = 0; i < abc.Length; i++)
            {
                if ((i +1) % 3 !=0)
                {
                Console.WriteLine(abc[i]);
                }
            }
            Console.ReadKey();
            }
    }
}

