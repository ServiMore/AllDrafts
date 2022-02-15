using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
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
                Console.WriteLine("1  Pedir al usuario el diametro de un circunferencia y calcular su area.");
                Console.WriteLine("2. Pedir al usuario 7 calificaciones y mostrar su promedio junto con un mensaje");
                Console.WriteLine("3. Pedir al usuario 7 calificaciones y mostrar cuantas asignaturas fueron aprobadas y cuantas reprobadas.");
                Console.WriteLine("4. Pedir al usuario el precio orignal de un producto y el precio real pagado ");
                Console.WriteLine("5. Pedir al usuario los catetos de un triangulo rectangulo y luego imprimir en pantalla el valor de la hipotenusa ");
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
                }
            } while (opcion != 0);
        }

        private static void Ejercicio1()
        {
            double radio;
            double area;

            Console.WriteLine("ingrese el diametro");
            double diametro = Convert.ToInt32(Console.ReadLine());

            radio = diametro / 2;
            double v = (Math.PI * Math.Pow(radio, 2));
            area = v;

            Console.WriteLine("El area de la circunferencia es: " + area);

            Console.ReadKey();

        }

        private static void Ejercicio2()
        {
            double suma = 0;
            double promedio;

            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine("ingrese la nota #" + i);
                suma += Convert.ToInt32(Console.ReadLine());
            }

            promedio = suma / 7;
            if (promedio < 60)
            {
                Console.WriteLine("deficiente");
            }
            else if (promedio >= 60 && promedio < 90)
            {
                Console.WriteLine("normal");
            }
            else
            {
                Console.WriteLine("sobresaliente");
            }
            Console.ReadKey();
        }

        private static void Ejercicio3()
        {
            int aprobados = 0;
            int reprobados = 0;

            for (var i = 0; i < 7; i++)
            {
                Console.WriteLine("ingrese sus notas");
                int nota = Convert.ToInt32(Console.ReadLine());
                if (nota >= 60)
                {
                    aprobados += 1;
                }
                else
                {
                    reprobados += 1;
                }
            }
            Console.WriteLine("aprobaste: " + aprobados);
            Console.WriteLine("reprobaste: " + reprobados);

            Console.ReadKey();
        }

        private static void Ejercicio4()
        {
            Console.WriteLine("ingrese el precio original");
            double precioOriginal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el precio pagado");
            double precioPagado = Convert.ToInt32(Console.ReadLine());

            double descuento = precioOriginal - precioPagado;
            double porcentaje = descuento * 100 / precioOriginal;

            Console.WriteLine("el descuento otorgado es de: " + porcentaje);

            Console.ReadKey();
        }
        private static void Ejercicio5()
        {
            double hipotenusa;

            Console.WriteLine("ingrese el primer cateto");
            double cateto1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el segundo cateto ");
            double cateto2 = Convert.ToInt32(Console.ReadLine());

            hipotenusa = (Math.Pow(cateto1, 2)) + (cateto2 * cateto2);
            hipotenusa = Math.Sqrt(hipotenusa);

            Console.WriteLine("el valor de la hipotenusa es: " + hipotenusa);
            Console.ReadKey();
        }

    }
}


