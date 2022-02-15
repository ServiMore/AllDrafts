using System;
using System.Collections.Generic;
using System.Drawing;
using RestauranteMigui.Entidades;
using Console = Colorful.Console;

namespace RestauranteMigui.Servicios {
    internal class ManejadorDeCuentas {

        private readonly List<Cuenta> _cuentas;

        public ManejadorDeCuentas() {
            _cuentas = new List<Cuenta>();
        }


        public void ImprimirCuentasAbiertas() {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("**                                           **");
            Console.WriteLine("**            Cuentas abiertas               **");
            Console.WriteLine("**                                           **");
            Console.WriteLine("***********************************************\n\n");

            if (_cuentas.Count == 0) {
                Console.WriteLine("No hay cuentas abiertas.", Color.OrangeRed);
            }

            foreach (var cuenta in _cuentas)
                if (cuenta.Abierto) {
                    Console.WriteLine("   - Codigo: " + cuenta.Codigo);
                    Console.WriteLine("   - Cliente: " + cuenta.Cliente);
                    Console.WriteLine("   - Total: " + cuenta.CalcularTotal());
                    Console.WriteLine("\n");
                }
        }

        public Cuenta SeleccionarCuenta() {
            ImprimirCuentasAbiertas();
            if (_cuentas.Count == 0) {
                return null;
            }

            Console.Write("\nIngrese el # de cuenta: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            foreach (var cuenta in _cuentas) {
                if (cuenta.Codigo == codigo) {
                    return cuenta;
                }
            }

            Console.Write("\nNo se encontró la cuenta solicitada.", Color.OrangeRed);
            Console.ReadKey();
            return SeleccionarCuenta();
        }

        public Cuenta AbrirCuenta(Mesa mesa) {
            Console.Write("Ingrese el nombre del cliente: ");
            var cliente = Console.ReadLine();
            var cuenta = new Cuenta(mesa, cliente);

            _cuentas.Add(cuenta);
            Console.WriteLine("\nCuenta creada exitosamente!!!", Color.Green);
            Console.Beep(500, 500);
            return cuenta;
        }

        public void CerrarCuenta() {
            var cuenta = SeleccionarCuenta();
            if (cuenta == null) {
                return;
            }

            cuenta.Pagar();
            _cuentas.Remove(cuenta);
            Console.WriteLine("\nCuenta cerrada exitosamente!!!", Color.Green);
            Console.Beep(500, 500);
        }

        public void AgregarPlatillo(Platillo platillo) {
            var cuenta = SeleccionarCuenta();
            if (cuenta == null) {
                return;
            }

            cuenta.AgregarPlatillo(platillo);
            Console.WriteLine("\nPlatillo agregado exitosamente!!!", Color.Green);
            Console.Beep(500, 500);
        }
    }
}