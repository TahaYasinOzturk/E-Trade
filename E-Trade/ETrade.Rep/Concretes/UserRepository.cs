using BCrypt.Net;
using ETrade.Core;
using ETrade.Dal;
using ETrade.Ent;
using ETrade.Rep.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Rep.Concretes
{
    public class UserRepository : BaseRepository<Users>, IUserRepository
    {
        public UserRepository(Context context) : base(context)
        {

        }

        public Users Login(Users user)
        {
            var dummyUser = new Users();
            try
            {

                var loginUser = Set().FirstOrDefault(x => x.UserName == user.UserName);
                if (loginUser != null)
                {
                    bool verified = BCrypt.Net.BCrypt.Verify(user.Password, loginUser.Password);
                    if (verified)
                    {
                        return loginUser;
                    }
                }
                return dummyUser;
            }
            catch (Exception)
            {
                return dummyUser;
            }
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public bool Register(Users user)
        {
            try
            {
                //set de liste olustururken vs.
                //burda ise user i add ile ekleyecez okadar sete gerek yok.
                user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
                //bunu incrypt olarak saklayacak.
                //sonra authcontrollerda view olusturduk.
                user.CreatedDate = DateTime.Now;
                user.LastUpdated = DateTime.Now;
                Add(user);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
