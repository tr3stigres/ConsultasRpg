class Program
{

    public record FichaOrden(string Nombre, int Vida, string Estado = "Preparado");
    public static void Main()
    {

        try
        {
 
            var jugadores = new List<Ficha>
            {
                new ("Ada", 80, "Mago"),
                new ("Bruno", 0, "Guerrero"),
                new ("Carla", 50, "Mago"),
                new ("Diego", 100, "Guerrero"),
                new ("Eva", 0, "Mago")
            };

            foreach (Ficha jugador in jugadores)
            {
                Console.WriteLine($"Nombre: {jugador.Nombre}, Vida: {jugador.Vida}, Tipo: {jugador.Tipo}");
            }

            var res1 = jugadores.Where(j => j.Vida > 0).OrderByDescending(j => j.Vida).ThenBy(j => j.Nombre).ToList();
            foreach (Ficha jugador in res1)
            {
                Console.WriteLine($"Nombre: {jugador.Nombre}, Vida: {jugador.Vida}, Tipo: {jugador.Tipo}");
            }

            var res2 = jugadores.Select(j => new FichaOrden(j.Nombre, j.Vida)).ToList();
            Console.WriteLine($"\nConsulta 2:");
            foreach (FichaOrden jugador in res2)
            {
                Console.WriteLine($"Nombre: {jugador.Nombre}, Vida: {jugador.Vida}, Estado: {jugador.Estado}");
            }


            Ficha? elegido = jugadores.FirstOrDefault(j => j.Nombre.Contains("ada",StringComparison.OrdinalIgnoreCase));
            Console.WriteLine($"\nConsulta 3:");
            if(elegido != null)
                Console.WriteLine($"Nombre: {elegido.Nombre}, Vida: {elegido.Vida}, Estado: {elegido.Tipo}");
            else
                Console.WriteLine("No se ha encontrado ningún jugador con ese nombre.");
            elegido = jugadores.FirstOrDefault(j => j.Nombre.Contains("nadie", StringComparison.OrdinalIgnoreCase));
            if (elegido != null) 
                Console.WriteLine($"Nombre: {elegido.Nombre}, Vida: {elegido.Vida}, Estado: {elegido.Tipo}");
            else
                Console.WriteLine("No se ha encontrado ningún jugador con ese nombre.");


        }
        catch (Exception error)
        {
            Console.WriteLine($"Se ha producido el siguiente error: {error.Message}");
        }
    }

    public static void mostrar(string descripcion, List<Ficha> jugadores)
    {
        Console.WriteLine($"\n{descripcion}:");
        
    }

}
