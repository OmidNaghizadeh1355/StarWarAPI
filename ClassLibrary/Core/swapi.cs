using SharpTrooper.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Swapi.Core
{
    public class SwapiTools
    {
        private readonly ISharpTrooperCore _sharpTrooperCore;
        public SwapiTools()
        {
            _sharpTrooperCore = new Swapi.Core.SharpTrooperCore();
        }

        public IEnumerable<People> GetAllPeople()
        {
            List<SharpTrooper.Entities.People> list = new List<SharpTrooper.Entities.People>();
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
