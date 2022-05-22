using DbExample.DB;
using DbExample.Models;
using DbExample.Services.Interfaces;

namespace DbExample.Services
{
    public class UserService : IUserService
    {
        DemoDbContext dbContext;
        public UserService(DemoDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public User Get(Guid id)
        {
            return dbContext.User.Find(id);
        }

        public List<User> GetAll()
        {

           return  dbContext.User.ToList();
        }

        public void Insert(User mewUser)
        {
         
            dbContext.User.Add(mewUser);
            dbContext.SaveChanges();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
