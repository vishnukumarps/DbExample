using DbExample.Models;

namespace DbExample.Services.Interfaces
{
    public interface IUserService
    {

        public void Insert(User mewUser);
        public void Update();
        public void Delete();
        public User Get(Guid id);
        public List<User> GetAll();
    }
}
