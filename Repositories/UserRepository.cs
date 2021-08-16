using System.Collections.Generic;
using System.Linq;
using Cadastros.Models;

namespace Cadastros.Repositories {
    public static class UserRepository {
        public static User Get(string username, string password) {
            var users = new List<User>();
            users.Add(
                new User {
                    Id = 1, 
                    Username = "admin", 
                    Password = "admin", 
                    Role = "manager" 
                }
            );
            
            users.Add(
                new User { 
                    Id = 2, 
                    Username = "user", 
                    Password = "user", 
                    Role = "employee" 
                }
            );
            
            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == x.Password).FirstOrDefault();
        }
    }
}