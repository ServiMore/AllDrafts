using System;
using System.Collections.Generic;
using System.Drawing;
using RestauranteMigui.Entidades;
using Console = Colorful.Console;

namespace RestauranteMigui.Servicios {
    class ManejadorDePlatillos {

        private readonly List<Platillo> _platillos;

        public ManejadorDePlatillos() {
            _platillos = new List<Platillo> {
                new Platillo(1, "Arroz con pollo", 20),
                new Platillo(2, "Pescado frito", 60),
                new Platillo(3, "Carne asada", 40),
                new Platillo(4, "Tajadas con queso", 15),
                new Platillo(5, "Ensalada de fruta", 25)
            };
        }

        public void ImprimirPlatillos() {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("**                                           **");
            Console.WriteLine("**         Platillos disponibles             **");
            Console.WriteLine("**                                           **");
            Console.WriteLine("***********************************************\n\n");

            foreach (var platillo in _platillos) {
                Console.WriteLine("   - Codigo: " + platillo.Codigo);
                Console.WriteLine("   - Nombre: " + platillo.Nombre);
                Console.WriteLine("   - Precio: " + platillo.Precio);
                Console.WriteLine("\n");
            }
        }

        public Platillo SeleccionarPlatillo() {
            ImprimirPlatillos();
            Console.Write("\nIngrese el # de platillo: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            foreach (var plato in _platillos) {
                if (plato.Codigo == codigo) {
                    return plato;
                }
            }

            Console.Write("\nNo se encontró el platillo solicitado.", Color.OrangeRed);
            Console.ReadKey();
            return SeleccionarPlatillo();
        }

    }
}
