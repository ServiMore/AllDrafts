namespace RestauranteMigui.Entidades {
    internal class Platillo {

        public int Codigo { get; }
        public string Nombre { get; }
        public double Precio { get; }


        public Platillo(int codigo, string nombre, double precio) {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
        }

    }
}