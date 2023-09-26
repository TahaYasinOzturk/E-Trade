using ETrade.Core;
using ETrade.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Rep.Abstract
{
    public interface IUserRepository : IBaseRepository<Users>
    {
        //BCryptnext next i kurduk heryere  shared layout da register  login leri ekledik. Rep i yaptık.  authcontroller olusturuk promgrac.cs e ekledik. simdi authcontrollere düzeltiyoruz.
        public Users Login(Users user);
        //login i yapıyoruz. rep user a
        public void Logout();
        public bool Register(Users user);
    }
}
