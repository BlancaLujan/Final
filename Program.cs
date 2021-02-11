using System;
using Program.File.MyClasses;
using Program.File.DTOS;
using Program.File.Expections;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Programs
    {
        private static bool UserName;

        static void Main()
        {

            List<User> userList = new List<User>();
            List<Comment> CommentList = new List<Comment>();
            try
            {
                List<User> myList = new User<User>();


                string response = "";
                while (response != "8")
                {
                    Console.WriteLine("1. Create a User");
                    Console.WriteLine("2. Create a Comment");
                    Console.WriteLine("3. Print a List of Users");
                    Console.WriteLine("4. print a List of Comments");
                    Console.WriteLine("5. Look for a User");
                    Console.WriteLine("6. Look for Comment");
                    Console.WriteLine("7. Data file");
                    Console.WriteLine("8. Exit the program");


                    Console.WriteLine("");
                    Console.WriteLine("Please select a value");

                    response = Console.ReadLine();


                    Console.WriteLine("your response is: " + response);



                    switch (response)
                    {



                        case "1":
                            User user = new User();
                            user.UserId = (1);
                            user.UserName = "Blanca";
                            user.UserRole = "Administrator";
                            user.UserList = "User 1, User 2, User 3, User 4";

                            userList.Add(user);

                            Console.WriteLine("I created a user");
                            break;



                        case "2":
                            Comment Comment = new Comment();
                            Comment.Comments = "The actual comment is: How are you?";
                            Comment.NumberofComments = "Comment 1, Comment 2, Comment 3, Comment 4";

                            CommentList.Add(Comment);

                            Console.WriteLine("I created a comment");
                            break;



                        case "3":
                            Console.WriteLine("This is the list of users:");


                            foreach (var User in userList)
                            {
                                Console.WriteLine(User.UserId);
                                Console.WriteLine(User.UserName);
                                Console.WriteLine(User.UserRole);
                                Console.WriteLine(User.UserList);
                            }

                            break;



                        case "4":
                            Console.WriteLine("This is the list of Comments:");


                            foreach (var Comments in CommentList)
                            {
                                Console.WriteLine(Comments.Comments);
                                Console.WriteLine(Comments.NumberofComments);

                            }

                            break;

                        case "5":
                            Console.WriteLine("Look for a User");


                            foreach (var User in userList)
                            {
                                Console.WriteLine(User.UserName);
                                Console.WriteLine();
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



                                List<User> result1 = myList.Where(User => myFirstUser.UserName == "").ToList();



                                if (myList.Count > 0)
                                {

                                    Console.WriteLine("Users found");
                                    string format = "User has these properties:" +
                                                 "UserId: {0}, UserName: {1}, UserRole: {2}";

                                    foreach (var User in result)
                                    {
                                        Console.WriteLine(format, User.UserName);

                                    }
                                }
                                else
                                {
                                    throw new UserNotFound("No user found");
                                }
                            }
                    }
                }

            }
                            catch (UserNotFound exception)
                            {
                                Console.WriteLine(exception.Message);
                            }
                            finally
                            {
                                Console.WriteLine("Program has ended");
                            }
                        }
                }
    

    public class UserNotFound : Exception
        {
            public UserNotFound(string errorMessage) : base(errorMessage)
            {


            }
        break;

                    case "6":
                        Console.WriteLine("Look for Comment:");


                        foreach (var Comments in CommentList)
                        {
                            Console.WriteLine();
                            Console.WriteLine();

                        }

                        break;

                    case "7":
                        Console.WriteLine("Data file:");


                        foreach (var Comments in CommentList)
                        {
                            Console.WriteLine();
                            Console.WriteLine();

                        }

                        break;


                }
            }
        }
    }
}
