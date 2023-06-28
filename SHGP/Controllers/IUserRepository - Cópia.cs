using SHGP.Model;

namespace SHGP.Controllers
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetUsers()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<User> GetUserById(int id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<User> GetUserByemail(string email)
        {
            throw new NotImplementedException();
        }
        public bool CreateUser(User user)
        {
            throw new NotImplementedException();
        }
        public bool UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
        public bool DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

    }
}
