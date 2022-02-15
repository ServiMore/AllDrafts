using System;
using RestauranteMigui.Servicios;
using System.Drawing;
using Console = Colorful.Console;

namespace RestauranteMigui {
    class Program {

        private static ManejadorDeMesas _servicioMesas;
        private static ManejadorDeCuentas _servicioCuentas;
        private static ManejadorDePlatillos _servicioPlatillos;

        static void Main() {
            InicializarServicios();
            ConfigurarConsola();
            Ejecutar();
        }

        private static void InicializarServicios() {
            _servicioMesas = new ManejadorDeMesas(5);
            _servicioCuentas = new ManejadorDeCuentas();
            _servicioPlatillos = new ManejadorDePlatillos();
        }

        private static void ConfigurarConsola() {
            Console.BackgroundColor = Color.Beige;
            Console.ForegroundColor = Color.Black;
            Console.Title = "Restaurante EL MIGUELON";
        }

        private static void Ejecutar() {
            do {
                var opcion = MostrarOpciones();
                EjecutarOpcion(opcion);
                Console.ReadKey();
            } while (true);
        }

        private static int MostrarOpciones() {
            try {
                Console.Clear();
                Console.WriteLine("***********************************************");
                Console.WriteLine("**                                           **");
                Console.WriteLine("**          Restaurante EL MIGUELON          **");
                Console.WriteLine("**                                           **");
                Console.WriteLine("***********************************************\n\n");

                Console.WriteLine("Seleccione la opción deseada");
                Console.WriteLine("   1. Ver cuentas existentes.");
                Console.WriteLine("   2. Crear nueva cuenta.");
                Console.WriteLine("   3. Cancelar una cuenta.");
                Console.WriteLine("   4. Ordenar un producto.");
                Console.WriteLine("\n");

                return Convert.ToInt32(Console.ReadLine());
            } catch (Exception e) {
                Console.Write("\n");
                Console.WriteLine("Error: " + e.Message, Color.Red);
                Console.Beep(1000, 800);
                Console.ReadKey();
                return MostrarOpciones();
            }

        }

        private static void EjecutarOpcion(int opcion) {
            try {
                switch (opcion) {
                    case 1:
                        _servicioCuentas.ImprimirCuentasAbiertas();
                        break;
                    case 2:
                        var mesa = _servicioMesas.SeleccionarMesa();
                        _servicioCuentas.AbrirCuenta(mesa);
                        break;
                    case 3:
                        _servicioCuentas.CerrarCuenta();
                        break;
                    case 4:
                        var platillo = _servicioPlatillos.SeleccionarPlatillo();
                        _servicioCuentas.AgregarPlatillo(platillo);
                        break;
                }
            } catch (Exception e) {
                Console.Write("\n");
                Console.WriteLine("Error: " + e.Message, Color.Red);
                Console.Beep(1000, 800);
            }

        }

    }
}
