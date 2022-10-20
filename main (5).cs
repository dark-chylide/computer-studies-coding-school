using System;

class Program {
  public static void Main (string[] args) {
    int a,b; 
   Console.WriteLine("Enter 2 numbers...");
    a= Convert.ToInt32(Console.ReadLine());
    b= Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Enter the option...");
    string exp =(Console.ReadLine());


    switch (exp)
    {
      case "+": Console.WriteLine("Addition is {0}",(a+b)); 
    break; 
      case "-": Console.WriteLine("Substraction is {0}",(a-b));
        break; 
      case "*": Console.WriteLine("Multiplication is {0}",(a*b));
    break; 
     case "/": Console.WriteLine("Division is {0}",(a/b));
    break; 
     case "%": Console.WriteLine("Modulo is {0}",(a%b));
    break; 
      
    }

    }
  } 