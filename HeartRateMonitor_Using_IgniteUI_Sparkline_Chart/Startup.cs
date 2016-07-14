using Owin;

namespace HeartRateMonitor_Using_IgniteUI_Sparkline_Chart
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            appBuilder.MapSignalR();
        }
    }
}