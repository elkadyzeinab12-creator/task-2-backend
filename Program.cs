#region problem#1
//using System;
//class Program
//{
//    static void Main()
//    {
//      int  n = Convert.ToInt32(Console.ReadLine());
//        for (int i = 1; i <= n; i++)
//        {
//            if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
//            else if (i % 3 == 0) Console.WriteLine("Fizz");
//            else if (i % 5 == 0) Console.WriteLine("Buzz"); 
//            else Console.WriteLine(i);
//        }

//        }
//}
#endregion
#region problem#2
//using System;
//using System.ComponentModel;
//using System.Diagnostics;
//using System.Linq.Expressions;
//class Program
//{
//    static void Main()
//    {
//        Char grade = Convert.ToChar(Console.ReadLine());

//        switch (grade)
//        {
//             case 'A': Console.WriteLine("Excellent");
//                break;
//            case 'B': Console.WriteLine("Very Good");
//                break;
//            case 'C': Console.WriteLine("Good");
//                break;
//            case 'D': Console.WriteLine("Fair"); break;
//            case 'F': Console.WriteLine("Fail"); break;
//            default: Console.WriteLine("Invalid Grade"); break;

//            }
//        } }
#endregion
#region problem#3
//using System;
//using System.ComponentModel;
//using System.Diagnostics;
//using System.Linq.Expressions;
//class Program
//{
//    static void Main()
//    {
//       string password;
//        int t = 0;
//        do
//        {
//         if (t!=0) Console.WriteLine("Wrong password, try again.");
//            t++;
//           password = (Console.ReadLine());
//        }
//        while (password != "1234");

//        Console.Write("Login Successful!");
//    }
//}

#endregion
#region problem#4
//using System;
//using System.ComponentModel;
//using System.Diagnostics;
//using System.Linq.Expressions;
//class Program
//{
//    static void Main()
//    {
//        int n = Convert.ToInt32(Console.ReadLine());
//        int res = 0, sum = (n * (n + 1)) / 2;

//        int[] arr = Console.ReadLine()
//                 .Split()
//                 .Select(int.Parse)
//                 .ToArray();

//        for (int i = 0; i < n; i++){
//            if (arr[i] == n + 1) continue;
//            res += arr[i];
//          }
//        Console.WriteLine(sum - res);

//    }
//}

#endregion
#region problem#5
//using System;
//using System.ComponentModel;
//using System.Diagnostics;
//using System.Linq.Expressions;
//class Program
//{
//    static void Main()
//    {
//        int[] arr = Console.ReadLine()
//                  .Split()
//                  .Select(int.Parse)
//                  .ToArray();
//        Array.Reverse(arr);
//        foreach (var item in arr)
//        {
//            Console.Write(item + " ");
//        }

//    }
//}
#endregion
#region problem#6
//using System;
//using System.ComponentModel;
//using System.Diagnostics;
//using System.Linq.Expressions;
//class Program
//{
//    static void Main()
//    {
//        int[] arr = Console.ReadLine()
//                  .Split()
//                  .Select(int.Parse)
//                  .ToArray();

//        int res = 0, tar = Convert.ToInt32(Console.ReadLine());

//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] == tar) res++;
//        }
//        Console.WriteLine(res);
//    }
//}
#endregion
#region problem#7
//using System;
//using System.ComponentModel;
//using System.Diagnostics;
//using System.Linq.Expressions;
//class Program
//{
//    static void Main()
//    {
//        int[] arr = Console.ReadLine()
//                  .Split()
//                  .Select(int.Parse)
//                  .ToArray();

//        int idx = 0;

//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] == 0)
//            {
//                (arr[i], arr[idx]) = (arr[idx], arr[i]);
//                idx++;
//            }
//        }
//        foreach (var item in arr)
//        {
//            Console.Write(item + " ");
//        }
//    }
//}
#endregion
#region problem#8
//using System;
//using System.ComponentModel;
//using System.Diagnostics;
//using System.Linq.Expressions;
//class Program
//{
//    static void Main()
//    {
//        int[] arr = Console.ReadLine()
//                  .Split()
//                  .Select(int.Parse)
//                  .ToArray();

//        Array.Sort(arr);
//        Console.Write(arr[(arr.Length)-2]);

//    }
//}
#endregion
#region problem#9
//using System;
//using System.ComponentModel;
//using System.Diagnostics;
//using System.Linq.Expressions;
//class Program
//{
//    static void Main()
//    {
//        int[] arr = Console.ReadLine()
//                  .Split()
//                  .Select(int.Parse)
//                  .ToArray();
//        int j = (arr.Length)-1;
//        bool ok = true;
//        for (int i = 0; i < ((arr.Length)+1)/2; i++)
//        {
//            if (arr[i] != arr[j--]) { ok = false; break; }
//        }

//        Console.Write(ok?"YES" : "NO");

//    }
//}
#endregion
#region problem#10
//using System;
//using System.ComponentModel;
//using System.Diagnostics;
//using System.Linq.Expressions;
//using static System.Runtime.InteropServices.JavaScript.JSType;
//class Program
//{
//    static void Main()
//    {
//        int n = Convert.ToInt16(Console.ReadLine());

//      int[,] matrix = new int[n,n ];

//     int low = 0, up = 0;


//                for (int i = 0; i < n; i++){

//            string[] row = Console.ReadLine().Split();
//                for (int j = 0; j < n; j++){
//                 matrix[i, j] = int.Parse(row[j]);

//                          if (i == j) up += matrix[i,j];
//                 if (i+j == n-1) low += matrix[i, j];
//            }
//                }

//                var res = Math.Abs(up-low);
//        Console.Write(res);

//    }
//}
#endregion
#region problem#11
//using System;
//class Program
//{
//    static void Main()
//    {
//        int n = Convert.ToInt16(Console.ReadLine());
//        int m = Convert.ToInt16(Console.ReadLine());
//        int[,] matrix = new int[n, m];

//        for (int i = 0; i < n; i++) {

//            for (int j = 0; j < m; j++)
//            {
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        for (int i = 0; i < m; i++)
//        {
//            Console.WriteLine();
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write(matrix[j, i] + " ");
//            }
//        }

//    }
//}
#endregion
#region Matrix Multiplication 
using System;
class Program
{
    static void Main()
    {
        int[,] arr = new int[2, 3], matrix = new int[3, 2];

        for (int i = 0; i < 2; i++){
            for (int j = 0; j < 3; j++)
              arr[i, j] = int.Parse(Console.ReadLine());
       }

        for (int i = 0; i < 3; i++){
            for (int j = 0; j < 2; j++)
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
       
        for (int i = 0; i < 2; i++){
            Console.WriteLine();
            for (int j = 0; j < 2; j++){
                int ele = 0;
                for (int k = 0; k < 3; k++) ele += arr[i, k] * matrix[k, j];
                    
                Console.Write(ele + " ");
            }
        }
    }
}
#endregion