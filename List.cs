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
            List<User> myList = new User<User>();

            User myFirstUser = new User();
            myFirstUser.UserId = 1;
            myFirstUser.UserName = ("abc");
            myFirstUser.UserRole = "write";

            User mySecondUser = new User();
            mySecondUser.UserId = 2;
            mySecondUser.UserName = ("def");
            mySecondUser.UserRole = "Count";

            User myThirdUser = new User();
            myThirdUser.UserId = 3;
            myThirdUser.UserName = ("ghi");
            myThirdUser.UserRole = "Read";

            User myForthUser = new User();
            myForthUser.UserId = 4;
            myForthUser.UserName = ("jkl");
            myForthUser.UserRole = "Talk";

            User myFifthUser = new User();
            myFifthUser.UserId = 5;
            myFifthUser.UserName = ("mno");
            myFifthUser.UserRole = "Sum";

            User mySixthUser = new User();
            mySixthUser.UserId = 6;
            mySixthUser.UserName = ("pqr");
            mySixthUser.UserRole = "Subtract";

            User mySeventhUser = new User();
            mySeventhUser.UserId = 7;
            mySeventhUser.UserName = ("stu");
            mySeventhUser.UserRole = "Multipy";

            User myEighthUser = new User();
            myEighthUser.UserId = 8;
            myEighthUser.UserName = ("wxy");
            myEighthUser.UserRole = "Divide";

            User myNinthUser = new User();
            myNinthUser.UserId = 9;
            myNinthUser.UserName = ("z");
            myNinthUser.UserRole = "Draw";

            User myTenthUser = new User();
            myTenthUser.UserId = 10;
            myTenthUser.UserName = ("Aa");
            myTenthUser.UserRole = "Paint";

            myList.Add(myFirstUser);
            myList.Add(mySecondUser);
            myList.Add(myThirdUser);
            myList.Add(myForthUser);
            myList.Add(myFifthUser);
            myList.Add(mySixthUser);
            myList.Add(mySeventhUser);
            myList.Add(myEighthUser);
            myList.Add(myNinthUser);
            myList.Add(myTenthUser);

            int result = myList.Select(list => list.UserId).First();
            Console.WriteLine(result);
            string result1 = myList.Select(list => list.UserName).First();
            Console.WriteLine(result1);
            string result2 = myList.Select(list => list.UserRole).First();
            Console.WriteLine(result2);

            Console.WriteLine();

            int result4 = myList.Select(list => list.UserId).Last();
            Console.WriteLine(result4);
            string result5 = myList.Select(list => list.UserName).Last();
            Console.WriteLine(result5);
            string result6 = myList.Select(list => list.UserRole).Last();
            Console.WriteLine(result6);



            //  ConcatenationOfStrings("my first sting", "my second string");
            //  }

            // static void ConcatenationOfStrings(string parameter1, string parameter2)

            // {

            //  string result = parameter1 + " " + parameter2;


            // Console.WriteLine(result);


            // Comment comment = new Comment();

            //comment.Comments = "This is a comment";

            //Console.WriteLine("The value of my first property is:" + comment.Comments);




            //ImageDTOS Image = new ImageDTOS();
            //Image.ImageNumber = ("This is image number 1");
            //  Console.WriteLine("The value of my first property is;" + Image.ImageNumber);
        }
    }
}

class User<T> : List<User>
{
}