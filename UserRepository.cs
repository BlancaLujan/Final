using System;
using System.Collections.Generic;
using System.Linq;
using Program.File.Expections;
using Program.File.MyClasses;

namespace Program.File.Repositories.Implementation
{
    public class UserRepository : MainRepository<User>, IUser_Repository
    {
        public UserRepository()
        {

            List<User> resultList =
                currentDataBase.Where(user => user.UserName == "Blanca").ToList();

            if (resultList.Count > 0)
            {
                foreach (var user in resultList)
                {
                    Console.WriteLine(user.UserName);
                    Console.WriteLine(user.UserId);
                    Console.WriteLine(user.UserRole);

                }

            }
            else
            {
                Console.WriteLine("No user found");
            }
        }

        public void GetAllUserNames(string name)
        {
            Console.WriteLine();


        }

        internal void Save(Comment newComment)
        {
            Console.WriteLine();
        }

        internal void Delete(Comment newComment2)
        {
            Console.WriteLine();
        }
    }
}
