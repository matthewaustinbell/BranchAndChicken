using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BranchAndChicken.Api.Commands;
using BranchAndChicken.Api.Models;

namespace BranchAndChicken.Api
{
    public class ChickenRepository
    {
        public IEnumerable<Chicken> GetAll()
        {
            throw new NotImplementedException();
        }

        public Chicken Get(int chicken)
        {
            throw new NotImplementedException();
        }

        public void Add(AddChickenCommand chicken)
        {
            throw new NotImplementedException();
        }

        public void Delete(int chickenIdToDelete)
        {
            throw new NotImplementedException();
        }
    }
}
