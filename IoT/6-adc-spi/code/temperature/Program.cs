using Microsoft.Extensions.Configuration;
using System;
using System.Device.Spi;
using System.IO;
using System.Threading.Tasks;

namespace temperature
{
    class Program
    {
        static async Task Main(string[] args)
        {   
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) 
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var spiSettings = new SpiConnectionSettings(0, 0)
            {
                ClockFrequency = 1000000,
                Mode = SpiMode.Mode0
            };

            using (SpiDevice spi = SpiDevice.Create(spiSettings))
            using (RtdProbe rtd = new RtdProbe(spi, configuration))
            {
                while (true)
                {
                    await Task.Delay(TimeSpan.FromSeconds(1));
                    Console.Clear();
                    Console.WriteLine($"RTD Temperature: {rtd.ProbeTemp}°F");
                }
            }
        }
    }
}
