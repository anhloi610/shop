using System.Threading.Tasks;

namespace shop_fifa
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var app = Startup.InitializeApp(args);
            await app.RunAsync();
        }
    }
}
