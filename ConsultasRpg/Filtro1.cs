using static Program;

public record FichaOrden(string Nombre, int Vida, string Estado = "Preparado");
public class Filtro1
{
    public Filtro1(List<Ficha> fichaDatos)
    {
        var res = fichaDatos.Select(j => new FichaOrden(j.Nombre, j.Vida)).ToList();
        foreach (FichaOrden jugador in res)
        {
            Console.WriteLine($"Nombre: {jugador.Nombre}, Vida: {jugador.Vida}, Estado: {jugador.Estado}");
        }
    }
}