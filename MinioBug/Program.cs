using System;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Minio;

namespace MinioBug
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new MinioClient("localhost:9009", "minioadmin", "minioadmin", "ru-central1");
            var list = await client.ListObjectsAsync("bug");
           
            // never comes to this point because of exception
            Console.Write("Success");
        }
    }
}