using System;
using System.Threading.Tasks;
using Web_API.Models.Interfases;

namespace Web_API.Models.Servises
{
    public class DateTimeNow:ITimeService
    {
        public string DateTime
        {
            get;
            set;
        }
        public async void GetTime()
        {
            await Task.Run(()=>DateTime=System.DateTime.Now.ToString("hh:mm:ss"));
        }
    }
}