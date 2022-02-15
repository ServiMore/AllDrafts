using System;
using System.Linq;
using System.Collections.Generic;

namespace JuegoBarca {
    internal class Juego {

        private List<Personaje> _personajes;
        private Personaje _barca;
        private bool _haFinalizado;


        public Juego() {
            _barca = new Personaje(0, "Barca", Zona.Izquierda, Tipo.Barca, Tipo.NA);
            _personajes = new List<Personaje> {
                _barca,
                new Personaje(1, "Tigre", Zona.Izquierda, Tipo.Carnivoro, Tipo.Herbivoro),
                new Personaje(2, "Vaca", Zona.Izquierda, Tipo.Herbivoro, Tipo.Vegetal),
                new Personaje(3, "Repollo", Zona.Izquierda, Tipo.Vegetal, Tipo.NA)
            };
        }

        public void Ejecutar() {
            do {
                Console.Clear();
                MostrarPosiciones();
                var id = SolicitarAccion();
                Mover(id);
                _haFinalizado = !PuedeContinuar();
            } while (!_haFinalizado);
        }

        private void MostrarPosiciones() {
            Console.WriteLine($"A la izquierda se encuentran:");
            MostrarPosiciones(Zona.Izquierda);

            Console.WriteLine($"A la derecha se encuentran:");
            MostrarPosiciones(Zona.Derecha);
        }

        private void MostrarPosiciones(Zona zona) {
            _personajes
                .FindAll(i => i.ZonaActual == zona)
                .ForEach(i => Console.WriteLine($"{i.Id}. {i.Nombre}"));
            Console.WriteLine("");
        }


        private int SolicitarAccion() {
            Console.WriteLine("Seleccione el personaje que desea trasladar:");
            MostrarPosiciones(_barca.ZonaActual);
            return Convert.ToInt32(Console.ReadLine());
        }

        private void Mover(int id) {
            var personaje = _personajes.Find(i => i.Id == id);
            var destino = ObtenerZonaOpuesta(personaje.ZonaActual);
            personaje.ZonaActual = destino;
            _barca.ZonaActual = destino;
        }

        private static Zona ObtenerZonaOpuesta(Zona zona) {
            return zona == Zona.Izquierda ? Zona.Derecha : Zona.Izquierda;
        }


        private bool PuedeContinuar() {
            return !HaGanado() && !HaPerdido();
        }

        private bool HaGanado() {
            var resultado = _personajes.TrueForAll(i => i.ZonaActual == Zona.Derecha);
            if (resultado)
                Console.WriteLine("Has ganado!!");

            return resultado;
        }

        private bool HaPerdido() {
            var resultado = _personajes.Any(i => i.TratarDeComer(_personajes));
            if (resultado)
                Console.WriteLine("Has perdido!!");

            return resultado;
        }

    }
}
