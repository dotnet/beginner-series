using Iot.Device.Adc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Concurrent;
using System.Device.Spi;
using System.Linq;
using System.Threading.Tasks;

namespace temperature
{
    public class RtdProbe : IDisposable
    {
        Mcp3008 _adc;
        ConcurrentQueue<double> _probeResistances;
        Task _adcReadTask;
        int _offset;

        public RtdProbe(SpiDevice spi, IConfiguration config)
        {
            _adc = new Mcp3008(spi);
            _probeResistances = new ConcurrentQueue<double>();
            _offset = int.Parse(config["offset"]);
            _adcReadTask = ReadAdc();

        }

        public double ProbeTemp => TempWithOffset();

        private async Task ReadAdc()
        {
            while (true)
            {
                int probeValue = _adc.Read(0);

                _probeResistances.Enqueue(CalculateResistanceFromAdc(probeValue));
                while (_probeResistances.Count > 100)
                {
                    _probeResistances.TryDequeue(out double resistance);
                }

                await Task.Delay(TimeSpan.FromMilliseconds(10));
            }
        }

        static double CalculateResistanceFromAdc(double adcValue)
        {
            double rtdV = (adcValue / 1023) * 3.3;
            return ((3.3 * 1000) - (rtdV * 1000)) / rtdV;
        }

        static double RtdTempFahrenheitFromResistance(double Resistance)
        {
            double A = 3.90830e-3; // Coefficient A
            double B = -5.775e-7; // Coefficient B
            double RefResistance = 1000;

            double TempCelsius = (-A + Math.Sqrt(A * A - 4 * B * (1 - Resistance / RefResistance))) / (2 * B);
            return TempCelsius * 9 / 5 + 32;
        }

        private double TempWithOffset()
        {
            double temp = (_probeResistances.Count > 0) ? RtdTempFahrenheitFromResistance(_probeResistances.Average()) : 0;
            return Math.Round(temp + _offset);
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _adc.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~RtdArray()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion


    }
}