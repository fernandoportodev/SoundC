using System.Text.Json;
using SoundC.Modelos;
using SoundC.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(response)!;
        //LinqFiltro.FiltrarGeneros(musicas);
        LinqOrdenacao.ExibirListaArtistasOrdenada(musicas);

    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}