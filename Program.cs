using System;
using System.Collections.Generic;

namespace login
{
  class Program
  {
    static void Main(string[] args)
    {
      User mark = new User("mark", "IheartCod3");
      User jake = new User("jake", "Cod3w3rkx");

      Dictionary<string, User> users = new Dictionary<string, User>();
      users.Add(mark.Username, mark);
      users.Add(jake.Username, jake);
      while (true)
      {
        Console.Write("Username: ");
        string userName = Console.ReadLine();
        Console.Write("Password: ");
        string pass = Console.ReadLine();
        if (users.ContainsKey(userName) && users[userName].ValidatePassword(pass) && users[userName].AccessLevel > 5)
        {
          System.Console.WriteLine("SUCCESSFULLY LOGGED IN");
          return;
        }
        else
        {
          System.Console.WriteLine("Invalid try again");
        }
      }
    }
  }
}
