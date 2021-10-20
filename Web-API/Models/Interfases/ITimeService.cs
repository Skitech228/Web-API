namespace Web_API.Models.Interfases
{
    public interface ITimeService
    {
        string DateTime { get; set; }
        void GetTime();
    }
}