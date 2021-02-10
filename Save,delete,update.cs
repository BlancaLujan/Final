using System;
using Program.File.MyClasses;
using Program.File.Repositories;
using Program.File.Repositories.Implementation;
using System.Collections.Generic;
using System.Linq;

namespace Program.File
{
    class Programs
    {
        static void Main()
        {
            UserRepository repository = new UserRepository();


            User newUser = new User();
            newUser.UserId = 1;
            newUser.UserName = "Blanca";
            newUser.Email = "email@.com";
            newUser.Password = "Passw0rd";

            User newUser2 = new User();
            newUser2.UserId = 2;
            newUser2.UserName = "User 2";
            newUser2.Email = "email123@.com";
            newUser2.Password = "Passw0rd123";

            User newUser3 = new User();
            newUser3.UserId = 3;
            newUser3.UserName = "User 3";
            newUser3.Email = "emailabc@.com";
            newUser3.Password = "Passw0rdabc";


            repository.Save(newUser);
            repository.Save(newUser2);
            repository.Save(newUser3);

            repository.Delete(newUser);
            repository.Delete(newUser2);
            repository.Delete(newUser3);


            CommentRepository repository2 = new CommentRepository();

            Comment newComment = new Comment();
            newComment.NumberofComments = "One";
            newComment.Comments = "This is a comment";

            Comment newComment2 = new Comment();
            newComment2.NumberofComments = "Two";
            newComment2.Comments = "This is a comment";

            Comment newComment3 = new Comment();
            newComment3.NumberofComments = "Three";
            newComment3.Comments = "This is a comment";


            repository.Save(newComment);
            repository.Save(newComment2);
            repository.Save(newComment3);

            repository.Delete(newComment);
            repository.Delete(newComment2);
            repository.Delete(newComment3);





            // repository.GetAllUserNames();
        }
    }
}
       // enum UserType
        //{
         //   UserId,
        //    UserName,
       //     UserRole,
        //    OtherUser,
       // }
      //  static void Main()
      //  {

       //     UserType type = UserType.OtherUser;

       //     if ((int)type == 3)
       //     {
        //        Console.WriteLine("The value is 3");
        //    }
        //    else
        //    {
           //     Console.WriteLine("the value is not 3");
           // }


