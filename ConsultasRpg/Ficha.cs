using static System.Runtime.InteropServices.JavaScript.JSType;

public class Ficha
{
    public string Nombre { get; }
    public int Vida { get; }
    public string Tipo { get; }

    public Ficha(string nombre, int vida, string tipo)
    {
        Nombre = nombre;
        Vida = vida;
        Tipo = tipo;
    }
}