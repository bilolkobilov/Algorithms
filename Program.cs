using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkk
{
    internal class Program
    {


        // task 1

        //     static void Main(string[] args)
        //     {
        //         Console.Write("Enter first number ");
        //         int num1 = Convert.ToInt32(Console.ReadLine());
        //         Console.Write("Enter second number ");
        //         int num2 = Convert.ToInt32(Console.ReadLine());
        //   
        //         Console.WriteLine(result(num1, num2));
        //   
        //         Console.ReadLine(); 
        //     }
        //     static int result(int num1, int num2)
        //     {
        //         return (num1 % 2 == 0 && num2 % 2 == 0 || num1 % 3 == 0 && num2 % 3 == 0) ? num1 * num2 : num1 + num2;
        //     }



        // task 2

        //  static void Main(string[] args)
        //  {
        //      Console.Write("Enter word ");
        //      string str = Convert.ToString(Console.ReadLine());
        //      Console.WriteLine(result(str ));
        //      
        //      Console.ReadLine();
        //  }
        //  static bool result(string str ) 
        //  {
        //      return (str[0]  == 65 && str[1] == 65 && str[2] == 65) && (str[0] == 90 && str[1] == 90 && str[2] == 90);
        //     
        //  }


        //task 3
        //     static void Main(string[] args)
        //     {
        //         Console.Write("Enter first number ");
        //         int num = Convert.ToInt32(Console.ReadLine());
        //         Console.Write("Enter second number ");
        //         int num1 = Convert.ToInt32(Console.ReadLine());
        //         Console.Write("Enter third number ");
        //         int num2 = Convert.ToInt32(Console.ReadLine());
        //   
        //         Console.WriteLine(Result(num, num1, num2));
        //         Console.ReadLine();
        //     }
        //     static bool Result(int num, int num1, int num2)
        //     {
        //         return num + num1 > num2 || num * num1 > num2;
        //     }


        // task 4
        //        static void Main(string[] args)
        //     {
        //        Console.WriteLine(sort(new int[] { 5, 10, 15}));
        //        Console.ReadLine();
        //     }
        //    static bool sort(int[] num)
        //    {
        //        return  (num[0] <= num[1] && num[1] <= num[2]);
        //        
        //    }


        //   // task 6
        //   static void Main(string[] args)
        //   {
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
        //   }       


        // task 7

        //    static void Main(string[] args)
        //    {
        //        Console.Write("Enter a year ");
        //        int num = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine(Result(num));
        //        Console.ReadLine();
        //    }
        //    static bool Result(int num)
        //    {
        //        return num % 4 == 0;
        //    }
        //


        // task 8
        //
        //      static void Main(string[] args)
        //   {
        //       Console.Write("Enter a number ");
        //       int num = Convert.ToInt32(Console.ReadLine());
        //
        //       if (num % 10 == 3 || num % 100 == 3 || num % 1000 == 3 )
        //       {
        //           Console.WriteLine("True ");
        //       }
        //     
        //       else
        //       {
        //           Console.WriteLine("False ");
        //       }
        //          
        //       
        //     
        //       Console.ReadLine();
        //   }


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










        //task 11
      
        //      int number = Convert.ToInt32(Console.ReadLine());
        //      Console.Write("Enter numbers ");
        //      int[] arr = new int[number];
        //      for (int i = 0; i < number; i++)
        //      {
        //          arr[i] = Convert.ToInt32(Console.ReadLine()S);
        //      }
        //    




 // static void Main(string[] args)
 //      {
 //
 //     Console.Write("Enter numbers ");
 //     int[] arr = Console.ReadLine().Replace(" ", " ").Split(',').Select(str => int.Parse(str)).ToArray();       
 //     //      Console.Write("Enter Array Size? ");
 //     for (int i = 0; i < arr.Length; i++)
 //     {
 //         int Value = arr[i];
 //         int j = i - 1;
 //         while (j >= 0 && arr[j] > Value)
 //         {
 //             arr[j + 1] = arr[j];
 //             j = j - 1;
 //         }
 //         arr[j + 1] = Value;
 //     }
 //     for (int i = 0; i < arr.Length; i++)
 //     {
 //         Console.Write(arr[i] + " ");
 //     }
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
        //      Console.WriteLine("Enetr numbers " );
        //      int[] arr = Console.ReadLine().Replace(" ", " ").Split(',').Select(str => int.Parse(str)).ToArray();
        //
        //     
        //                                                                                                                        //   Console.WriteLine();
        //                                                                                                                        //   foreach (int i in array)
        //                                                                                                                        //       Console.Write(i + ",");
        //                
        //                  for (int i = 0; i < arr.Length; i++)
        //                  {
        //          Console.Write((',') + i);
        //                  }
        //                  Console.ReadLine();
        //                        }
        //                       

    }
}




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
    

