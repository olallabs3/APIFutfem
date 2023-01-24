using APIfutfem.Models;

namespace APIfutfem.Services;

public static class EquipoService
{
    static List<Equipo> Equipos { get; }
    static int nextId = 5;
    static EquipoService()
    {
        Equipos = new List<Equipo>
        {
            new Equipo {Id =1, Nombre = "Futbol Club Barcelona", Trofeos = 23, AnyoCreacion = 2002},
            new Equipo {Id =2, Nombre = "Real Madrid", Trofeos = 0, AnyoCreacion = 2020}
        };
    }

    public static List<Equipo> GetAll() => Equipos;

    //Hacer get de cada atributo

    public static Equipo? Get(int id) => Equipos.FirstOrDefault(p => p.Id == id);

    public static void Add(Equipo Equipo)
    {
        Equipo.Id = nextId++;
        Equipos.Add(Equipo);
    }

    public static void Delete(int id)
    {
        var Equipo = Get(id);
        if(Equipo is null)
            return;

        Equipos.Remove(Equipo);
    }

    public static void Update(Equipo Equipo)
    {
        var index = Equipos.FindIndex(p => p.Id == Equipo.Id);
        if(index == -1)
            return;

        Equipos[index] = Equipo;
    }
}