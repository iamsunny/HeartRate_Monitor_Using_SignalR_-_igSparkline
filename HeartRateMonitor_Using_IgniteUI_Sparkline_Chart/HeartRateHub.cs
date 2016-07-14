using System;
using System.Threading;
using Microsoft.AspNet.SignalR;
using Newtonsoft.Json;

namespace HeartRateMonitor_Using_IgniteUI_Sparkline_Chart
{

    public class HeartRateHub : Hub
    {
        private static Timer _timer;       
        private readonly Random _rnd = new Random();
        public void PulseSimulator()
        {
            if (_timer == null)
            {
                _timer = new Timer(GeneratePulse, null, 3000, 1000);
            }
        }

        public void GeneratePulse(object state)
        {
            var pulseRate = new { pulseRate =  _rnd.Next(60, 100) };

            Clients.All.updatePulse(JsonConvert.SerializeObject(pulseRate));
        }
    }
}