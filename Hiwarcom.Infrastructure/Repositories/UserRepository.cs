using Hiwarcom.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiwarcom.Infrastructure.Repositories
{
    public class UserRepository : Repository<User>
    {
        public List<User> GetUsers()
        {
            return DbSet.ToList();
        }
    }
}
