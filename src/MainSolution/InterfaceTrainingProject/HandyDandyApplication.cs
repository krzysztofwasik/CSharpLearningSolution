using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using InterfaceTrainingProject.Data.SqlServer;
using InterfaceTrainingProject.Data;

namespace InterfaceTrainingProject
{
 
    public class HandyDandyApplication
    {
        private IUserRepository _users;

        public HandyDandyApplication(IUserRepository repository = null)
        {
            _users = repository ?? new UserRepository();
        }

        public void DisplayUsers(TextWriter writer)
        {
            foreach (var user in _users.All())
            {
                var userData = string.Format("{0}\t{1} {2}",
                    user.Id,
                    user.FirstName,
                    user.LastName);

                writer.WriteLineAsync(userData);
            }
        }

    }
}
