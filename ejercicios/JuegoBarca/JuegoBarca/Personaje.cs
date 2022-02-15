using System;
using System.Collections.Generic;
using System.Linq;

namespace JuegoBarca {
    internal class Personaje {

        public Personaje(int id, string nombre, Zona zonaActual, Tipo tipoPropio, Tipo tipoDeComida) {
            Id = id;
            Nombre = nombre;
            ZonaActual = zonaActual;
            TipoPropio = tipoPropio;
            TipoDeComida = tipoDeComida;
        }
        
        public int Id { get; }
        public string Nombre { get; }
        public Zona ZonaActual { get; set; }
        public Tipo TipoPropio { get; }
        public Tipo TipoDeComida { get; }

        
        public bool TratarDeComer(List<Personaje> personajes) {
            var vecinos = personajes.FindAll(i => i.ZonaActual == ZonaActual);
            var hayBarca = vecinos.Any(i => i.TipoPropio == Tipo.Barca);
            var comida = vecinos.Find(i => i.TipoPropio == TipoDeComida);
            var haComido = !hayBarca && comida != null;
            
            if (haComido)
                Console.WriteLine($"{Nombre} se ha comido a la {comida.Nombre}.");

            return haComido;
        }

    }
}
