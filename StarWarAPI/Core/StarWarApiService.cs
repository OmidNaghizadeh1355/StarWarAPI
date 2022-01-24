using StarWarAPI.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarWarAPI.Core
{
    public class StarWarApiService
    {
        private readonly ISharpTrooperCore _sharpTrooperCore;
        public StarWarApiService()
        {
            _sharpTrooperCore = new StarWarAPI.Core.SharpTrooperCore();
        }

        public IEnumerable<People> GetAllPeople()
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

        public IEnumerable<People> GetAllPersons()
        {
            var persons = GetAllPeople().Where(p => p.gender != "n/a");

            return persons;
        }

    }
}
