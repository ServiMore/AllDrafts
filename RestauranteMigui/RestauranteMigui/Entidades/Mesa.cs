using System;

namespace RestauranteMigui.Entidades {
  
    internal class Mesa {

        public int Codigo { get; }
        public int Capacidad { get; }
        public bool Disponible { get; private set; }


        public Mesa(int codigo, int capacidad) {
            Codigo = codigo;
            Capacidad = capacidad;
            Disponible = true;
        }


        public void Ocupar() {
            if (!Disponible) { 
                throw new Exception("La mesa ya esta ocupada.");
            }

            Disponible = false;
        }

        public void Liberar() {
            Disponible = true;
        }

    }
}