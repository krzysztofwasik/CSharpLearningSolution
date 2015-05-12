using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTrainingProject.Data.Test
{
    /// <summary>
    /// This isn't a real SqlServer repository, but only a mistification
    /// </summary>
    public class TestUserRepository : IUserRepository
    {
        private readonly List<User> _store;
        public TestUserRepository()
        {
            _store = new List<User>();

            _store.Add(new User { Id = "1", FirstName = "Tadeusz", LastName = "Nowak" });
            _store.Add(new User { Id = "2", FirstName = "Michal", LastName = "Kowalski" });
            _store.Add(new User { Id = "3", FirstName = "Rafal", LastName = "Wolski" });
        }

        public IEnumerable<User> All()
        {
            return _store.ToArray();
        }
    }
}
