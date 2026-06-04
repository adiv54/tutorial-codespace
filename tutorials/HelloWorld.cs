using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace HelloWorld;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int x = int.MaxValue;
        Console.WriteLine($"I have {x} tickets");
        // SolarWindsTicketAsync();
        Console.WriteLine("Hello");
    }

    // public async static Task<string> SolarWindsTicketAsync()
    // {
    //     await Task.Delay();
    //     return "J";
    // }
}