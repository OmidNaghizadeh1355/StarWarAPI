using StarWarAPI.Entities;

namespace StarWarAPI.Core
{
    public interface IStarWarApiService
    {
        IQueryable<People> GetAllPersons();
        IQueryable<Starship> GetAllStarships();
        Starship GetStarshipById(string id);
    }
}