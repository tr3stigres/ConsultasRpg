public class Busqueda
{
    public Busqueda(List<Ficha> fichaDatos)
    {
        Ficha? elegido = fichaDatos.FirstOrDefault(j => j.Nombre.Contains("ada", StringComparison.OrdinalIgnoreCase));
        if (elegido != null)
            Console.WriteLine($"Nombre: {elegido.Nombre}, Vida: {elegido.Vida}, Estado: {elegido.Tipo}");
        else
            Console.WriteLine("No se ha encontrado ningún jugador con ese nombre.");
        elegido = fichaDatos.FirstOrDefault(j => j.Nombre.Contains("nadie", StringComparison.OrdinalIgnoreCase));
        if (elegido != null)
            Console.WriteLine($"Nombre: {elegido.Nombre}, Vida: {elegido.Vida}, Estado: {elegido.Tipo}");
        else
            Console.WriteLine("No se ha encontrado ningún jugador con ese nombre.");
    }
}