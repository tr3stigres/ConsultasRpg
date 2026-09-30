using static System.Runtime.InteropServices.JavaScript.JSType;

public class ConVida
{
    public ConVida(List<Ficha> fichaDatos) 
    {
        var res = fichaDatos.Where(j => j.Vida > 0).OrderByDescending(j => j.Vida).ThenBy(j => j.Nombre).ToList();
        
        foreach (Ficha jugador in res)
        {
            Console.WriteLine($"Nombre: {jugador.Nombre}, Vida: {jugador.Vida}, Tipo: {jugador.Tipo}");
        }
    }
}