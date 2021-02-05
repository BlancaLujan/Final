using System;
using Program.File.MyClasses;



namespace Program.File
{
    class Programs
    {
        static void Main()
        {
            UserClass myNewClass = new UserClass();

            myNewClass.PrintSomethingToTheConsole<string, string>(1, "User1" , "Administrator");

        }
    }
}
public class UserClass
{
    public void PrintSomethingToTheConsole<T, Key>(int UserId, Key UserName, T UserRole)
    {
        Console.WriteLine("The value of the parameters are the following:");
        Console.WriteLine(UserId);
        Console.WriteLine(UserName);
        Console.WriteLine(UserRole);
    }
}


