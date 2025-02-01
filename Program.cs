using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.jso");
        Console.WriteLine(response);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);

    }
}