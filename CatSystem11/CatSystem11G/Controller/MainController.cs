using CatSystem11G.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatSystem11G.Controller
{
    internal class MainController
    {
        public List<User> GetAllUsers()
        {
            using (CatsDBEntities db = new CatsDBEntities())
            {
                return db.User.ToList();
            }


        }
        public bool CheckIfRegistered(string username, string password)
        {
            using (CatsDBEntities db = new CatsDBEntities())
            {
                return db.User.ToList().Where(u => u.UserName == username &&
                u.Password == password).Any();
            }
        }
        public void RegisterUser(string username, string password)

            {
            using (CatsDBEntities db = new CatsDBEntities())
            {
                User u = new User();
                if (!db.User.ToList().Any())
                {
                    u.Id = 1;
                }
                else
                {
                    u.Id = db.User.ToList().LastOrDefault().Id + 1;
                }

                //return db.User.ToList().Where(u => u.UserName == username &&
               
                u.UserName = username;
                u.Password = password;
                db.User.Add(u);
                db.SaveChanges();
            }
            }
        }
    }

