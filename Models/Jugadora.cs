namespace APIfutfem.Models;

public class Jugadora
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Apellidos { get; set; }
    public string? Posicion { get; set; }
    public bool Capitana { get; set; }

    //Partidos jugador se podría añadir
    public string? Equipo { get; set; }
    public int Edad { get; set; }
    public int Numero { get; set; }
    public int Goles { get; set; }
    public int Asistencias {get; set;}
    public int TarjetasA { get; set; }
    public int TarjetasR { get; set; }
}
