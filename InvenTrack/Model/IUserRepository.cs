using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace InvenTrack.Model
{
    public interface IUserRepository
    {
        bool AuthenticateUser(UserModel userModel, SecureString contrasena);
        bool Add(UserModel userModel);
        bool Edit(UserModel userModel);
        bool Remove(UserModel userModel);
        UserModel GetById(int id);
        UserModel GetByUserUserName(string userName, string Pass);
        List<UserModel> GetByAll(UserModel userModel);
    }
}
