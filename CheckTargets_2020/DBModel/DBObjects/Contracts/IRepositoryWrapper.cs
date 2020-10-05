using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckTargets_2020.DBModel.DBObjects.Contracts
{
    public interface IRepositoryWrapper
    {
        INotifications Notifications { get; }
        ITargets Targets { get; }
        IUsers Users { get; }
        void Save();
    }
}
