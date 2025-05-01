using System.Collections.Generic;
using System.Linq;
using Coaches.Models;

namespace Coaches.Services
{
    public class UserService
    {
        private readonly MyDnndatabaseContext _context;

        public UserService(MyDnndatabaseContext context)
        {
            _context = context;
        }

        public List<Users> SearchByUsername(string keyword)
        {
            return _context.Users
                .Where(x => x.Username.ToLower().Contains(keyword.ToLower()))
                .ToList();
        }
    }
}
