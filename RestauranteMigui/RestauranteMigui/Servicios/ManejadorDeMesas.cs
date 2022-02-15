using System;
using System.Collections.Generic;
using System.Drawing;
using RestauranteMigui.Entidades;
using Console = Colorful.Console;

namespace RestauranteMigui.Servicios {
    internal class ManejadorDeMesas {

        private readonly List<Mesa> _mesas;

        public ManejadorDeMesas(int cantidad) {
            _mesas = new List<Mesa>();
            var aleatorio = new Random();

            for (var i = 0; i < cantidad; i++) {
                var capacidad = aleatorio.Next(3, 10);
                var mesa = new Mesa(i + 1, capacidad);
                _mesas.Add(mesa);
            }
        }

        public void ImprimirMesasDisponibles() {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("**                                           **");
            Console.WriteLine("**          Mesas disponibles                **");
            Console.WriteLine("**                                           **");
            Console.WriteLine("***********************************************\n\n");

            foreach (var mesa in _mesas) {
                if (mesa.Disponible) {
                    Console.WriteLine("   - Código: " + mesa.Codigo);
                    Console.WriteLine("   - Capacidad: " + mesa.Capacidad);
                    Console.WriteLine("\n");
                }
            }
        }

        public Mesa SeleccionarMesa() {
            ImprimirMesasDisponibles();
         
            Console.Write("\nIngrese el # de mesa deseado: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            foreach (var mesa in _mesas) {
                if (mesa.Codigo == codigo) {
                    return mesa;
                }
            }

            Console.Write("\nNo se encontró la mesa solicitada.", Color.OrangeRed);
            Console.ReadKey();
            return SeleccionarMesa();
        }

    }
}