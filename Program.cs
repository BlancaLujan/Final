﻿using System;
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

                            Console.WriteLine("Look for a User:");
                            User user1 = new User();
                            user1.UserName = "Blanca";


                                userList.Add(user1);

                                Console.WriteLine("Blanca");
                              
                            break;





                        case "6":
                            Console.WriteLine("Look for Comment:");

                            Comment Comment1 = new Comment();
                            Comment1.Comments = "The actual comment is: How are you?";
                           
   
                                CommentList.Add(Comment1);

                                Console.WriteLine(" How are you?");
                            

                            break;
                            

                        case "7":
                            Console.WriteLine("Data file:");

                            foreach (var User in userList)
                            {
                                Console.WriteLine(User.UserId);
                                Console.WriteLine(User.UserName);
                                Console.WriteLine(User.UserRole);
                                Console.WriteLine(User.UserList);
                            }

                            foreach (var Comments in CommentList)
                            {
                                Console.WriteLine(Comments.Comments);
                                Console.WriteLine(Comments.NumberofComments);

                            }

                            break;


                          



                    }
                }
            }
        }
    }
}
