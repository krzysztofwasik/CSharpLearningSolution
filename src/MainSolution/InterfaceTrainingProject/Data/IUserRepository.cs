using System;
using System.Collections.Generic;

namespace InterfaceTrainingProject.Data
{
    public interface IUserRepository
    {
        IEnumerable<User> All();
    }
}
