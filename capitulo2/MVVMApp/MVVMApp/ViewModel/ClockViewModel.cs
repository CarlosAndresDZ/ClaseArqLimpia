

using System.Timers;

namespace MVVMApp.ViewModel
{
    public class ClockViewModel
    {
        public System.Timers.Timer timmer {  get; set; }
        public string CurrenTime { get; set; }= DateTime.Now.ToString("HH:mm:ss");
        public string Name { get; set; }

        public ClockViewModel() {
            timmer = new System.Timers.Timer(1000);
            timmer.Elapsed += UpdateTime;
            timmer.Start();
            CurrenTime = DateTime.Now.ToString("HH:mm:ss");
        }

        public void UpdateTime(object sender, ElapsedEventArgs args)
        {
            this.CurrenTime = DateTime.Now.ToString("HH:mm:ss");
        }

        public void Dispose() { 
            timmer.Dispose();
        }
    }
}
