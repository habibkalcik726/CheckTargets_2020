using CheckTargets_2020.DBModel.Context;
using CheckTargets_2020.DBModel.DBObjects;
using CheckTargets_2020.DBModel.DBObjects.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckTargets_2020.DBModel.Repository
{
    public class UserRepo : EFRepository<Users>, IUsers
    {
        public UserRepo(DatabaseContext repositoryContext)
          : base(repositoryContext)
        {
        }
    }
}
