using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace _13DownloadClient
{
    internal class PdfDownloader
    {
        public event EventHandler<PdfDownloadEventArgs> Downloadfinished;
        public async Task DownloadAsync(Uri url)
        {
            using(WebClient client = new WebClient())       // nach dem Using BLock, werden ressourcen des WebCLient wieder freigegeben
            {
                string pdfName = url.Segments.Last() + ".pdf";
                Console.WriteLine("Download: " + pdfName);
                string fileName = @"C:\Users\jakob.jehle\OneDrive - HBLFA Francisco Josephinum\4.Klasse\SEW\12DownloadCLient\" + pdfName;

                await client.DownloadFileTaskAsync(url, fileName);  // nach diesem AUfruf wird der Code nach dem Aufruf der Methode download ausgeführt

                //Diese Codezeilen werden erst ausgeführt, wenn der Asynchrone Aufruf fertig ist
                Console.WriteLine("Download completed");
                if (this.Downloadfinished != null)
                {
                    PdfDownloadEventArgs args = new PdfDownloadEventArgs();
                    args.FileName = fileName;
                    Downloadfinished(this,args);

                }
            }
        }
    }
}
