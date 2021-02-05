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




























//generic class with generic properties
           // MyClass<bool> newClass = new MyClass<bool>();
          //  newClass.myProperty = "A value";
          //  newClass.myProperty2 = true;

          //  newClass.Printsomething();
          //  newClass.PrintSomethingElse(false);
     //   }
  //  }
//}
//public class MyClass<T>
//{
   // public string myProperty { get; set; }
  //  public T myProperty2 { get; set; }

  //  public void Printsomething()
   // {

    //    Console.WriteLine("this is an action");
   // }
  //  public void PrintSomethingElse(T parameter1)
  //  {
  //      Console.WriteLine("The parameter value is: " + parameter1);
 //   }
//}

        