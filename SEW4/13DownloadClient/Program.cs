
using _13DownloadClient;

List<Uri> urls = new List<Uri>();
urls.Add(new Uri("http://bit.ly/leseprobe_schroedinger_cplusplus"));
urls.Add(new Uri("http://bit.ly/leseprobe_schroedinger_abap"));
urls.Add(new Uri("http://bit.ly/leseprobe_schroedinger_html5"));
urls.Add(new Uri("http://bit.ly/leseprobe_programmieren_lernen"));
urls.Add(new Uri("https://www.thecodingguys.net/resources/cs-cheat-sheet.pdf"));

List<Task> tasks = new List<Task>();
foreach (Uri url in urls)   
{
    //url Downloaden
    PdfDownloader downloader = new PdfDownloader();
    downloader.Downloadfinished += Downloaderfinished;
    Task t = downloader.DownloadAsync(url);
    tasks.Add(t);        //hängt ein Element an die Liste an
    //t.Wait();       //warten bi download fertig ist       --> wollen wir aber nicht --> sonst keine Parallele ausführung

    //durch den Asynchronen Aufruf wird der Code an dieser Stelle weiter ausgeführt.
}
Task.WaitAll(tasks.ToArray());        //warten bis alle Tasks fertig ist


void Downloaderfinished(object? sender, PdfDownloadEventArgs e)
{
    Console.WriteLine("Downloader has finished file: " + e.FileName);

}