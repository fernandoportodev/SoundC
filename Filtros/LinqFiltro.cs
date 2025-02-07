using SoundC.Modelos;

namespace SoundC.Filtros;

internal class LinqFiltro
{
    public static void FiltrarGeneros(List<Musica> musicas)
    {
        var todosGeneros = musicas
            .Select(g => g.Genero)
            .Distinct()
            .ToList();
        foreach (var genero in todosGeneros)
        {
            Console.WriteLine($"- {genero}");
        }
    }
}
