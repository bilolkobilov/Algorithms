using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Program
    {


        // task 1
       
       //    static void Main(string[] args)
       //    {
       //        Console.Write("Enter first number ");
       //        int num1 = Convert.ToInt32(Console.ReadLine());
       //        Console.Write("Enter second number ");
       //        int num2 = Convert.ToInt32(Console.ReadLine());           
       //        
       //        Console.WriteLine((num1 % 2 == 0 && num2 % 2 == 0 || num1 % 3 == 0 && num2 % 3 == 0) ? num1 * num2 : num1 + num2);
       //        Console.ReadLine();
       //    }

       
         
     
           // task 2
     
       //  static void Main(string[] args)
       //  {
       //      Console.Write("Enter word ");
       //      string txt = Convert.ToString(Console.ReadLine());
       //  
       //      if (txt[0] >= 'A' && txt[0] <= 'Z'  && txt[1] >= 'A' && txt[1] <= 'Z' && txt[2] >= 'A' && txt[2] <= 'Z')
       //      {
       //          Console.WriteLine("True ");
       //      }
       //      else
       //      {
       //          Console.WriteLine("False ");
       //      }
       //      Console.ReadLine();
       //  }
       
     
        
       
        //task 3
         
       //    static void Main(string[] args)
       //    {
       //      Console.Write("Enter numbers ");
       //      int[] arr = Console.ReadLine().Replace(" "," ").Split(',').Select(str => int.Parse(str)).ToArray();          
       //          if (arr[0] + arr[1] > arr[2] || arr[0] * arr[1] > arr[2])
       //          {
       //              Console.WriteLine("True ");
       //          }
       //          else
       //          {
       //              Console.WriteLine("False ");
       //          }           
       //          Console.ReadLine();
       //    }
          
          
          

         // task 4
       
       //   static void Main(string[] args)
       //   {
       //       Console.Write("Enter numbers ");
       //       int[] num = Console.ReadLine().Replace(" "," ").Split(',').Select(str => int.Parse(str)).ToArray();
       //
       //       if (num[0] <= num[1] && num[1] <= num[2])
       //       {
       //           Console.WriteLine("True ");
       //       }
       //       else
       //       {
       //           Console.WriteLine("False ");
       //       }
       //       Console.ReadLine();
       //   }
          
        


        // task 5

        //      static void Main(string[] args)
        //      {
        //          Console.Write("Enter a word ");
        //          string str1 = Convert.ToString(Console.ReadLine());
        //              
        //          if (str1[0] == str1[1] - 1 || str1[0] == str1[1] + 1 || str1[2] == str1[1] - 1 || str1[2] == str1[1] + 1)
        //          {
        //              Console.Write("True ");
        //          }
        //          else
        //          {
        //              Console.WriteLine("False ");
        //          }
        //          Console.ReadLine();
        //      }



           // task 6
        //     static void Main(string[] args)
        //     {
        //       Console.Write("Enter a number ");
        //       double num = Convert.ToDouble(Console.ReadLine());
        //           
        //       if (num > 0.0)
        //       {
        //           Console.WriteLine("Number is positive");
        //       }
        //       else if (num < 0.0)
        //       {
        //           Console.WriteLine("Number is negative");
        //       }
        //       else
        //       {
        //           Console.WriteLine("Number is zero");
        //       }
        //       Console.ReadLine();
        //    }       




            // task 7
      
        //   static void Main(string[] args)
        //   {
        //      Console.Write("Enter a year = ");
        //      int num = Convert.ToInt32(Console.ReadLine());
        //      if (num % 4 == 0)
        //      {
        //          Console.WriteLine("True ");
        //      }
        //      else
        //      {
        //          Console.WriteLine("False ");
        //      }                
        //          Console.ReadLine();
        //   }
            
        
        
        
             // task 8
        
        //     static void Main(string[] args)
        //     {
        //        Console.Write("Enter a number ");
        //        int num = int.Parse(Console.ReadLine());
        //
        //       if (num % 10 == 3 || num % 100 == 3 || num % 1000 == 3 )
        //       {
        //         Console.WriteLine("True ");
        //       }     
        //       else
        //       {
        //         Console.WriteLine("False ");
        //       }         
        //         Console.ReadLine();
        //     }




        // task 9

        //  static void Main(string[] args)
        //  {
        //      for (int i = 1; i <= 10; i++)
        //      {
        //          for (int b = 1; b <= 10; b++)
        //          {
        //              Console.Write((b == 1 ? "{0,2}" : "{0,4}"), i * b);
        //          }
        //
        //          Console.WriteLine();
        //      }
        //      Console.ReadLine();
        //  }         



        //task 10

        //   static void Main(string[] args)
        //   {
        //       Console.Write("Enter number ");
        //       double num1 = Convert.ToDouble(Console.ReadLine());
        //
        //       double sum = 0.0;
        //       for (double i = 1; i <= num1; i++)
        //       {
        //           sum = sum + (1 / (double)(i * i));
        //       }
        //       Console.Write(sum);
        //       Console.ReadLine();
        //   }




        //task 11

        //  static void Main(string[] args)
        // {  
        //     Console.Write("Enter numbers ");
        //     int[] arr = Console.ReadLine().Replace(" "," ").Split(',').Select(str => int.Parse(str)).ToArray();
        //     Console.WriteLine("");
        //          for (int i = 0; i < arr.Length; i++)
        //          {
        //              int Value = arr[i];
        //              int j = i - 1;
        //              while (j >= 0 && arr[j] > Value)
        //              {
        //                  arr[j + 1] = arr[j];
        //                  j = j - 1;
        //              }
        //              arr[j + 1] = Value;
        //          }
        //          for (int i = 0; i < arr.Length; i++)
        //          {                
        //              Console.Write(arr[i] + " ");
        //          }
        //     Console.ReadLine();
        // }                                                                                                         




        // task 12


        //  static void Main(string[] args)
        //  {
        //      Console.WriteLine(larg(new int[] { 190, 291, 145, 209, 280, 300 }));
        //      Console.WriteLine(larg(new int[] { -9, -2, -7, -8, -4 }));
        //      Console.ReadLine();
        //  }
        //  static int larg(int[] numArr)
        //  {
        //      int theBiggest = numArr[0];
        //
        //      for (int i = 1; i < numArr.Length; i++)
        //      {
        //          if (numArr[i] > theBiggest)
        //          {
        //              theBiggest = numArr[i];
        //          }
        //      }
        //
        //      return theBiggest;
        //  }




        // task 13

        //  static void Main(string[] args)
        //  {
        //      Console.WriteLine(num(new int[] { 8, 2, 5, 7, 9, 0, 7, 7, 3, 1 }));
        //      Console.WriteLine(num(new int[] { 9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7 }));
        //      Console.ReadLine();
        //
        //
        //  }
        //  static int num(int[] arr)
        //  {
        //      int adj = 0;
        //      for (int i = 0; i < arr.Length - 1; i++)
        //      {
        //          if (arr[i] == 7 && arr[i + 1] == 7)
        //          {
        //              adj++;
        //          }
        //      }
        //
        //      return  adj;
        //  }                             
        //



        //task 14

        //  static void Main(string[] args)
        //  {
        //      Console.WriteLine("Enter numbers ");
        //      int[] arr = Console.ReadLine().Replace(" ", " ").Split(',').Select(str => int.Parse(str)).ToArray();                 
        //     
        //      for (int i = 1; i <= arr.Length - 2; i++)
        //        {
        //          if (arr[i - 1] + 1 == arr[i] && arr[i + 1] - 1 == arr[i])
        //          {
        //              Console.WriteLine("True");
        //          }
        //          else
        //          {
        //              Console.WriteLine("False");
        //          }
        //        }      
        //      Console.ReadLine();
        //  }                              
        //




        //task 15

        //  static void Main(string[] args)
        //  {
        //      int i = 0;
        //
        //      Console.WriteLine("Even Numbers ");
        //      for (i = 1; i < 100; i++)
        //      {
        //          if (i % 2 == 0)
        //          {
        //              Console.Write(i + " ");
        //          }
        //      }
        //      Console.Read();
        //  }
    }
}

