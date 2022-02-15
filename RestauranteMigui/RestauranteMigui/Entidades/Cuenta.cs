using System;
using System.Collections.Generic;

namespace RestauranteMigui.Entidades {
    internal class Cuenta {

        public List<Platillo> Platillos { get; }
        public bool Abierto { get; private set; }
        public DateTime FechaDeCreacion { get; }
        public Mesa Mesa { get; }
        public string Cliente { get; }
        public int Codigo => Mesa.Codigo;
        //public int Codigo {
        //    get {
        //        return Mesa.Codigo;
        //    }
        //}


        public Cuenta(Mesa mesa, string cliente) {
            Platillos = new List<Platillo>();
            Abierto = true;
            FechaDeCreacion = DateTime.Now;
            Mesa = mesa;
            Mesa.Ocupar();
            Cliente = cliente;
        }


        public void AgregarPlatillo(Platillo platillo) {
            if (!Abierto) {
                throw new Exception("La cuenta se encuentra cerrada.");
            }
            Platillos.Add(platillo);
        }

        public void Pagar() {
            if (!Abierto) {
                throw new Exception("La cuenta se encuentra cerrada.");
            }
            Abierto = false;
            Mesa.Liberar();
            ImprimirFactura();
        }

        public double CalcularSubTotal() {
            double subTotal = 0;
            foreach (var platillo in Platillos) {
                subTotal += platillo.Precio;
            }
            return subTotal;
        }

        public double CalcularIva() {
            return CalcularSubTotal() * 0.15;
        }

        public double CalcularTotal() {
            return CalcularSubTotal() + CalcularIva();
        }

        public void ImprimirFactura() {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("**                                           **");
            Console.WriteLine($"**          Recibo de cuenta # {Codigo}             **");
            Console.WriteLine("**                                           **");
            Console.WriteLine("***********************************************\n\n");

            Console.WriteLine(" Cliente: {0}\n\n", Cliente);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("   {0,-30} {1,7}", "Producto", "Precio");
            Console.WriteLine("----------------------------------------------");

            foreach (var platillo in Platillos) {
                Console.WriteLine("   {0,-30} {1,7:N1}", platillo.Nombre, platillo.Precio);
            }

            Console.WriteLine("----------------------------------------------\n");
            Console.WriteLine("   {0,-30} {1,7}", "SubTotal:", CalcularSubTotal());
            Console.WriteLine("   {0,-30} {1,7}", "IVA:", CalcularIva());
            Console.WriteLine("   {0,-30} {1,7}", "Total:", CalcularTotal());
            Console.WriteLine("\n***********************************************");
        }
    }
}