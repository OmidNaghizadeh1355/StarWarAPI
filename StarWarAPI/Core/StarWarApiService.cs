using StarWarAPI.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarWarAPI.Core
{
    public class StarWarApiService : IStarWarApiService
    {
        private readonly ISharpTrooperCore _sharpTrooperCore;
        public StarWarApiService()
        {
            _sharpTrooperCore = new StarWarAPI.Core.SharpTrooperCore();
        }

        private IEnumerable<People> GetAllPeople()
        {
            List<People> list = new List<People>();
            var people = _sharpTrooperCore.GetAllPeople();

            list.AddRange(people.results);

            while (people.nextPageNo != null)
            {
                people = _sharpTrooperCore.GetAllPeople(people.nextPageNo);
                list.AddRange(people.results);
            }

            return list;
        }

        public IQueryable<Starship> GetAllStarships()
        {
            List<Starship> list = new List<Starship>();
            var Starship = _sharpTrooperCore.GetAllStarships();

            list.AddRange(Starship.results);

            while (Starship.nextPageNo != null)
            {
                Starship = _sharpTrooperCore.GetAllStarships(Starship.nextPageNo);
                list.AddRange(Starship.results);
            }

            return (IQueryable<Starship>)list;
        }

        public IQueryable<People> GetAllPersons()
        {
            var persons = GetAllPeople().Where(p => p.gender == "male" || p.gender == "female");

            return (IQueryable<People>)persons;
        }

        public Starship GetStarshipById(string id)
        {
            var Starship = _sharpTrooperCore.GetStarship(id);
            return Starship;
        }

    }
}
