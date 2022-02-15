using System;

namespace JuegoBarca {
    internal class Program {

        public static void Main(string[] args) {
            while (true) {
                new Juego().Ejecutar();
                Console.WriteLine("\n\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }

}
