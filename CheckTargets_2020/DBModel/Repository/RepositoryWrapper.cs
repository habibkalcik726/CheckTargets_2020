using CheckTargets_2020.DBModel.Context;
using CheckTargets_2020.DBModel.DBObjects.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckTargets_2020.DBModel.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private DatabaseContext _repoContext;
        private ITargets _targets;
        private INotifications _notifications;
        private IUsers _users;

        public ITargets Targets
        {
            get
            {
                if (_targets == null)
                {
                    _targets = new TargetRepo(_repoContext);
                }
                return _targets;
            }
        }

        public IUsers Users
        {
            get
            {
                if (_users == null)
                {
                    _users = new UserRepo(_repoContext);
                }
                return _users;
            }
        }
        public INotifications Notifications
        {
            get
            {
                if (_notifications == null)
                {
                    _notifications = new NotificationsRepo(_repoContext);
                }
                return _notifications;
            }
        }
        public RepositoryWrapper(DatabaseContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
