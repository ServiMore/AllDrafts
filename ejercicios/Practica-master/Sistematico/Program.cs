using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistematico
{
    class Program
    {
        static List<string> nombres = new List<string>();

        static void Main(string[] args)
        { //1ra pedir al usuario que meta 5 salarios y calcular promedio de salario.
          //primero preguntar cuantos salarios va a querer.
          //pedir al usuario de entrada un salario y seguirle pidiendo hasta que el salario promedio sea mayor que mil.
          //and now en lugar de imprimir solo el promedio final quiero imprimir todos los salarios que el usuario ingreso mas el promedio
            double promedio = 0;
            int conteo = 0;
            double salarios = 0;
            List<double> numeros = new List<double>();
            double n = 0;
            do
            {
                Console.WriteLine("ingrese un salario");
                n = Convert.ToDouble(Console.ReadLine());
                salarios += n; 
                numeros.Add(n);
                conteo += 1;
                promedio = salarios / conteo;
            } while (promedio < 1000);

            Console.WriteLine("Estos son los salarios:");
            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("El promedio es: {0}", promedio);
            Console.ReadKey();
        }

        private static void EjercicioPersonaje()
        {
            int opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("1. crear nuevo personaje");
                Console.WriteLine("2. ver personajes creados");
                Console.WriteLine("3. cambiar nombre");
                Console.WriteLine("4. borrar un personaje");
                Console.WriteLine("0. salir");
                Console.WriteLine("\n");
                opcion = Convert.ToInt32(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        crearPersonaje();
                        break;

                    case 2:
                        verPersonajes();
                        break;

                    case 3:
                        cambiarNombre();
                        break;

                    case 4:
                        borrarPersonaje();
                        break;
                }

            } while (opcion != 0);
        }



        public static void crearPersonaje()
        {
            Console.Clear();
            if (nombres.Count >= 5)
            {
                Console.WriteLine("Solo puedes tener 5 personajes :).");
            }
            else
            {
                Console.WriteLine("ingrese el nombre del personaje");
                var respuesta = Console.ReadLine();
                nombres.Add(respuesta);
            }
            Console.ReadKey();
        }


        public static void verPersonajes()
        {
            Console.Clear();
            if (nombres.Count == 0)
            {
                Console.WriteLine("Aun no tienes personajes creados");
            }

            Console.WriteLine("\n Esta es tu lista de personajes \n");
            for (int i = 0; i < nombres.Count; i++)
            {
                Console.WriteLine(nombres[i]);
            }
            Console.ReadKey();
        }
        private static void cambiarNombre()
        {
            Console.Clear();
            verPersonajes();
            Console.WriteLine("\nseleccione el personaje");
            int opcion = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine("\ningrese el nuevo nombre");
            string nuevoNombre = Console.ReadLine();

            nombres[opcion] = nuevoNombre;

            Console.ReadKey();
        }
        private static void borrarPersonaje()
        {
            Console.Clear();
            verPersonajes();
            Console.WriteLine("\nseleccione el personaje");
            int opcion = Convert.ToInt32(Console.ReadLine());
            nombres.RemoveAt(opcion);
            Console.ReadKey();
        }














        private static void Ejercicio4()
        {
            //pedirle la cantidad de nombres que quiere.
            //hacer un programa que pida al usuario 5 nombres, y despues imprimir el nombre mas largo de todos.

            var masLargo = "";
            Console.WriteLine("cuantos nombres desea imprimir?");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese los nombres");
                var nuevoNombre = Console.ReadLine();
                if (nuevoNombre.Length > masLargo.Length)
                {
                    masLargo = nuevoNombre;
                }

            }

            Console.WriteLine("El nombres mas largo es: {0}", masLargo);
            Console.ReadKey();

            /*
            Console.WriteLine("Ingrese el primer nombre");
            string nombre1 = Console.ReadLine();
           
            Console.WriteLine("Ingrese el segundo nombre");
            string nombre2 = Console.ReadLine();

            Console.WriteLine("Ingrese el tercero nombre");
            string nombre3 = Console.ReadLine();

            Console.WriteLine("Ingrese el cuarto nombre");
            string nombre4 = Console.ReadLine();

            Console.WriteLine("Ingrese el quinto nombre");
            string nombre5 = Console.ReadLine();


            if (nombre1.Length > nombre2.Length && nombre1.Length > nombre3.Length && nombre1.Length > nombre4.Length && nombre1.Length > nombre5.Length)
            {
                Console.WriteLine("El nombre mas largo es: {0}", nombre1);
            }
            else if (nombre2.Length > nombre1.Length && nombre2.Length > nombre3.Length && nombre2.Length > nombre4.Length && nombre2.Length > nombre5.Length)
            {
                Console.WriteLine("El nombre mas largo es: {0}", nombre2);

            }
            else if (nombre3.Length > nombre1.Length && nombre3.Length > nombre2.Length && nombre3.Length > nombre4.Length && nombre3.Length > nombre5.Length)
            {
                Console.WriteLine("El nombre mas largo es: {0}", nombre3);

            }
            else if (nombre4.Length > nombre1.Length && nombre4.Length > nombre2.Length && nombre4.Length > nombre3.Length && nombre4.Length > nombre5.Length)
            {
                Console.WriteLine("El nombre mas largo es: {0}", nombre4);

            }

            else
            {
                Console.WriteLine("El nombres mas largo es: {0}", nombre5);
            }
            Console.ReadKey();
            */


        }
        private static void Ejercicio3()
        {

            //el usuario va a poner la medida xs(muy pequeno) s(pequeno) m(medio) l(largo) xl(muy largo), 10xs, 20s, 30m, 40l, 50xl. va a poner cuantas pinturas quiere, mostrar el precio final, luego preguntar si dare descuento. tiene que ingresar el descuento y volver a calcular el resultado.

            int xs = 10;
            int s = 20;
            int m = 30;
            int l = 40;
            int xl = 50;

            Console.WriteLine("Que medida de pintura quiere?: 1-XS 2-S 3-M 4-L 5-XL");
            int tipo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cuantas pinturas de ese tipo desea?");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            double precioFinal = 0;

            if (tipo == 1)
            {
                precioFinal = xs * cantidad;

            }

            else if (tipo == 2)
            {
                precioFinal = s * cantidad;
            }

            else if (tipo == 3)
            {
                precioFinal = m * cantidad;
            }

            else if (tipo == 4)
            {
                precioFinal = l * cantidad;
            }

            else if (tipo == 5)
            {
                precioFinal = xl * cantidad;
            }

            else
            {
                Console.WriteLine("ingrese un numero por favor");
            }

            Console.WriteLine("El precio de la pintura es: {0}, desea agregar descuento? 1-si, 2-no", precioFinal);
            int respuesta = Convert.ToInt32(Console.ReadLine());

            if (respuesta == 1)
            {
                Console.WriteLine("De cuanto es el descuento que desea? 1-25%  2-50%  3-75% ");
                double descuento = Convert.ToDouble(Console.ReadLine()); //total = 100*(1 + 0.18) //diviridilo entre 100 multiplicarlo por el monto original y al precio final restarselo al monto original

                descuento = Convert.ToDouble(descuento / 100 * precioFinal);
                precioFinal = precioFinal - descuento;

                Console.WriteLine("El precio de la pintura con descuento aplicado es de: {0}", precioFinal);

            }
            else
            {
                Console.WriteLine("El precio de la pintura es: {0}", precioFinal);
            }

            Console.ReadKey();
        }

        private static void Ejercicio()
        {
            //calcualr el precio usuario tiene que indicar el ancho y el largo en cm, calcular cual es el precio final asumiendo que el precio es de 8 cordobas por cm2.
            Console.WriteLine("Ingrese el largo que desea tener la pintura en centimetros");
            double largo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el ancho que desea tener la pintura  en centimetros");
            double ancho = Convert.ToDouble(Console.ReadLine());


            double precioFinal = largo * ancho * 8;

            Console.WriteLine("El precio de la pintura es: {0}", precioFinal);
            Console.ReadKey();
        }


    }
}
