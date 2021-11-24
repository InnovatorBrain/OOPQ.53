using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
        // (a)
      int  x = 20, y = 35;
      x = y++ + x++;
      y = ++y + ++x;
      Console.WriteLine(x);
      Console.ReadLine();

      {
          // (b)
        int a = 10, b= 15;
        x = a++;
        y = ++b;
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.ReadLine();
      }
       {
          // (c)
        int c =10;
        c++;
        Console. WriteLine(c);
        Console. ReadLine();
       }
       {
          //(d)
        int c = 10;
        Console. WriteLine(c++);
        Console. ReadLine();
       }
       {
           // (e)
        int n =10;
        int d = n--;
        Console. WriteLine(d);
        Console. ReadLine ();
       }
       {
           //(f)
        int i = 5, j= 6, k = 7, n = 3;
        Console.WriteLine(i+j*k-k%n);
        Console.WriteLine(i/n);
        Console.ReadLine();
        }
        {
            // (g)
            int g;
            float f = 3;
            g = (f);
            Console.WriteLine (g);
        }
        { 
            //(h)
        int a = 6 ;
        Console.WriteLine(a);
        Console.ReadLine();
        a = a+3;
        Console. WriteLine(a);
        Console.ReadLine();
        a++;
        Console.WriteLine(a);
        Console. ReadLine();
        
        }

   
     }
  }
}
