using MyPatientManager.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPatientManager.Services
{
    public class ServiceLogin
    {
        private MyPatientManagerDbContext _dbContext;

        public ServiceLogin(MyPatientManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool Login(string username, string password)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Username == username);
            if (user != null && BCrypt.Net.BCrypt.Verify(password, user.Pw))
            {
                return true;
            }
            return false;
        }

        public void GetUsername(string username)
        {
            // get the username of the currently logged in user
            var user = _dbContext.Users.FirstOrDefault(u => u.Username == username);
        }
    }
}
