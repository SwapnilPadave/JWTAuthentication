using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtApp.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() { Username = "Swapnil", EmailAddress = "swapnil@gmail.com", Password = "Password", GivenName = "Swapi", Surname = "Padave", Role = "Administrator" },
            new UserModel() { Username = "admin", EmailAddress = "Swapi@email.com", Password = "admin", GivenName = "add", Surname = "Admin", Role = "Seller" },
        };
    }
}
