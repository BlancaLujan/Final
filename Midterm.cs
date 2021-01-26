using System;
using Program.File.MyClasses;
using Program.File.DTOS;
using System.Collections.Generic;

namespace Program.File
{
    class Program
    {
        static void Main()
        {

            string response = "";
            while (response != "5")
            {
                Console.WriteLine("1. Create a User");
                Console.WriteLine("2. Create a Comment");
                Console.WriteLine("3. Print a List of Users");
                Console.WriteLine("4. print a List of Comments");
                Console.WriteLine("5. Exit the program");

                Console.WriteLine("");
                Console.WriteLine("Please select a value");

                response = Console.ReadLine();


                Console.WriteLine("your response is: " + response);

                List<string> myList = new List<string>();
              
                myList.Add("user.UserList, User 1, User 2, User 3, User 4");

                myList.Add("Comments.NumberofComments, Comment 1, Comment 2, Comment 3, Comment 4 ");

                

                foreach (var item in myList)
                {
                    Console.WriteLine(item);
                }

                switch (response)
                {

                    case "1":
                        User user = new User();
                        user.UserId = (1);
                        user.UserName = "Blanca";
                        user.UserRole = "Administrator";
                        user.UserList = "";

                        Console.WriteLine("The user I created is:"+
                                         user.UserName);

                        break;

                    case "2":
                        Comment Comment = new Comment();
                        Comment.Comments = "myList";
                        Comment.NumberofComments = "Comment 1, Comment 2, Comment 3, Comment 4";

                        Console.WriteLine("The comment I created is:" +
                                        Comment.Comments);
                        break;

                    case "3":
                        user = new User();
                        user.UserList = "User 1, User 2, User 3, User 4";
                        user.UserName = "Blanca";

                        Console.WriteLine("The  new user I created is:" +
                                        user.UserList);
                        break;

                    case "4":
                        Comment Comments = new Comment();
                        Comments.ListofComments = "myList";
                        Comments.NumberofComments = "Comment 1, Comment 2, Comment 3, Comment 4";

                        Console.WriteLine("The new comment I created is:" +
                                          Comments.NumberofComments );
                        break;








                        

                }
            }
        }
    }
}
