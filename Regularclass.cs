using System;
using Program.File.MyClasses;

namespace Program.File
{
    class Programs
    {
        static void Main()
        {
            UserClass myVariable = new UserClass();
            myVariable.PrintSomethingToTheConsole<string>(1, "Blanca");

            Console.WriteLine(myVariable.UserId);
            Console.WriteLine(myVariable.UserName);
        }
    }
}
public class UserClass
{
    public string UserId { get; set; }
     public string UserName { get; set; }
    

    public void PrintSomethingToTheConsole<T>(int parameter1, T parameter2)
    {
        this.UserId = parameter1.ToString();
        this.UserName = parameter2.ToString();
        
     }
}
