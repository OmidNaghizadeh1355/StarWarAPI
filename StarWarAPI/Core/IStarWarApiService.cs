using StarWarAPI.Entities;

namespace StarWarAPI.Core
{
    public interface IStarWarApiService
    {
        IEnumerable<People> GetAllPersons();
        IEnumerable<Starship> GetAllStarships();
    }
}