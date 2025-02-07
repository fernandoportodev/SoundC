using SoundC.Modelos;

namespace SoundC.Filtros;

internal class LinqOrdenacao
{
    public static void ExibirListaArtistasOrdenada(List<Musica> musicas) 
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista)
            .Select(musica => musica.Artista)
            .Distinct()
            .ToList();
        Console.WriteLine("Lista de artistas ordenados");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
