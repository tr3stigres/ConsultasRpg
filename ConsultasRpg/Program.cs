class Program
{

    
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
            Console.WriteLine("\nTest lista con datos:");
            lanzarTest(jugadores);
            
            jugadores = new List<Ficha>{};
            Console.WriteLine("\nTest lista vacía:");
            lanzarTest(jugadores);

        }
        catch (Exception error)
        {
            Console.WriteLine($"Se ha producido el siguiente error: {error.Message}");
        }
    }

    public static void lanzarTest(List<Ficha> jugadores)
    {
        Console.WriteLine("\nOriginal:");
        foreach (Ficha jugador in jugadores)
        {
            Console.WriteLine($"Nombre: {jugador.Nombre}, Vida: {jugador.Vida}, Tipo: {jugador.Tipo}");
        }

        Console.WriteLine($"\nConsulta 1:");
        ConVida j = new ConVida(jugadores);
        Console.WriteLine($"\nConsulta 2:");
        Filtro1 k = new Filtro1(jugadores);
        Console.WriteLine($"\nConsulta 3:");
        Busqueda o = new Busqueda(jugadores);

    }

}
