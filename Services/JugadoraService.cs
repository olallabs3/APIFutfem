using APIfutfem.Models;

namespace APIfutfem.Services;

public static class JugadoraService
{
    static List<Jugadora> Jugadoras { get; }
    static int nextId = 3;
    static JugadoraService()
    {
        Jugadoras = new List<Jugadora>
        {
            new Jugadora { Id = 1, Nombre = "Sandra", Apellidos = "Paños", Edad = 30, Equipo = "Futbol Club Barcelona", Numero= 1, Posicion = "Portera", Capitana = true, Goles = 0, Asistencias = 0 , TarjetasA = 0 ,TarjetasR = 0},
            new Jugadora { Id = 2, Nombre = "Irene", Apellidos = "Paredes", Edad = 31, Equipo = "Futbol Club Barcelona", Numero= 2, Posicion = "Defensa", Capitana = true, Goles = 1, Asistencias = 1 , TarjetasA = 1 ,TarjetasR = 0 }
        };
    }

    public static List<Jugadora> GetAll() => Jugadoras;

    public static Jugadora? Get(int id) => Jugadoras.FirstOrDefault(p => p.Id == id);

    public static void Add(Jugadora Jugadora)
    {
        Jugadora.Id = nextId++;
        Jugadoras.Add(Jugadora);
    }

    public static void Delete(int id)
    {
        var Jugadora = Get(id);
        if(Jugadora is null)
            return;

        Jugadoras.Remove(Jugadora);
    }

    public static void Update(Jugadora Jugadora)
    {
        var index = Jugadoras.FindIndex(p => p.Id == Jugadora.Id);
        if(index == -1)
            return;

        Jugadoras[index] = Jugadora;
    }
}