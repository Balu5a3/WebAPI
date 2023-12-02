using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BChatDataAccess;

namespace BchatDataRetrieve
{
    public class CheckUsers
    {
        public static bool Login(string UserName,string Password)
        {

            User UserLogin = new User();
            using (BChatEntities entity = new BChatEntities())
            {
                UserLogin = entity.Users.Where(x => x.UserId == UserName && x.FirstName == Password).FirstOrDefault();
            }
            return (UserLogin!=null)?true: false;
        }

    }
}
