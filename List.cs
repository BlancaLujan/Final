using System;
using Program.File.MyClasses;
using Program.File.DTOS;
using System.Collections.Generic;
using System.Linq;

namespace Program.File
{
    class Program
    {
        static void Main()
        {
               try
            { 
            List<User> myList = new User<User>();

            User myFirstUser = new User();
            myFirstUser.UserId = 1;
            myFirstUser.UserName = ("abc");
            myFirstUser.UserRole = "write";
            myList.Add(myFirstUser);

            User mySecondUser = new User();
            mySecondUser.UserId = 2;
            mySecondUser.UserName = ("def");
            mySecondUser.UserRole = "Count";
            myList.Add(mySecondUser);

            User myThirdUser = new User();
            myThirdUser.UserId = 3;
            myThirdUser.UserName = ("ghi");
            myThirdUser.UserRole = "Read";
            myList.Add(myThirdUser);

            User myForthUser = new User();
            myForthUser.UserId = 4;
            myForthUser.UserName = ("jkl");
            myForthUser.UserRole = "Talk";
            myList.Add(myForthUser);

            User myFifthUser = new User();
            myFifthUser.UserId = 5;
            myFifthUser.UserName = ("mno");
            myFifthUser.UserRole = "Sum";
            myList.Add(myFifthUser);

            User mySixthUser = new User();
            mySixthUser.UserId = 6;
            mySixthUser.UserName = ("pqr");
            mySixthUser.UserRole = "Subtract";
            myList.Add(mySixthUser);

            User mySeventhUser = new User();
            mySeventhUser.UserId = 7;
            mySeventhUser.UserName = ("stu");
            mySeventhUser.UserRole = "Multipy";
            myList.Add(mySeventhUser);

            User myEighthUser = new User();
            myEighthUser.UserId = 8;
            myEighthUser.UserName = ("wxy");
            myEighthUser.UserRole = "Divide";
            myList.Add(myEighthUser);

            User myNinthUser = new User();
            myNinthUser.UserId = 9;
            myNinthUser.UserName = ("z");
            myNinthUser.UserRole = "Draw";
            myList.Add(myNinthUser);


            User myTenthUser = new User();
            myTenthUser.UserId = 10;
            myTenthUser.UserName = ("Aa");
            myTenthUser.UserRole = "Paint";
            myList.Add(myTenthUser);




            List<User> result = myList.Where(User => myFirstUser.UserId == 1).ToList();

            List<User> result1 = myList.Where(User => myFirstUser.UserName == "").ToList();

            List<User> result2 = myList.Where(User => myFirstUser.UserRole == "").ToList();

            if (myList.Count > 0)
            {

                Console.WriteLine("Users found");
                string format = "User has these properties:" +
                             "UserId: {0}, UserName: {1}, UserRole: {2}";

                foreach (var User in result)
                {
                    Console.WriteLine(format, User.UserId, User.UserName, User.UserRole);

                }
            }
            else
            {
                throw new UserNotFound("No user found");
            }
        }
            catch(UserNotFound exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("Program has ended");
            }
        }
    }
}

public class UserNotFound : Exception
{
    public UserNotFound(string errorMessage) : base(errorMessage)
    {

    }
}
