using StarWarAPI.Entities;

namespace StarWarAPI.Core
{
    public interface IStarWarApiService
    {
        IEnumerable<People> GetAllPersons();
        IQueryable<Starship> GetAllStarships();
        Starship GetStarshipById(string id);
    }
}