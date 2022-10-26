using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Please enter username and password below...");
    string password = "12345";
    string username = "Grade 10";
    string username1 =  Console.ReadLine();
    string password1 =  Console.ReadLine();
   
    if (username == username1)
    {
      Console.WriteLine ("username correct");
    }
    else
    {
      Console.WriteLine("username incorrect");
    }
  if (password == password1)
    {
      Console.WriteLine ("password correct");
    }
    
    else
    {
      Console.WriteLine("password incorrect");
    }
if (username1 == "Grade 10" && password1 == "12345")
    {
      Console.WriteLine ("Login successful");
    }
    
    else
    {
      Console.WriteLine("Login unsuccessful");
    }
    Console.ReadLine();
  }
}