using System.Threading.Tasks;

namespace Web_API.Models.Interfases
{
    public interface ITablesTasks
    {
        Task AddInformation();

        Task DeleteInformation();

        Task UpdateInformation();

        Task ShowInformation();

    }
}