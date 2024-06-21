namespace Assignment
{
    //class Point
    //{
    //    public int x;
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment 2
            #region Q1
            //Console.WriteLine("Enter a Number To Print It");
            //int x = int.Parse(Console.ReadLine()!);
            //Console.WriteLine($"the number is : {x}");
            #endregion
            #region Q2
            //Console.WriteLine("Enter a String Contains Non-Numeric Characters");
            //string x = Console.ReadLine()!;
            //int y = Convert.ToInt32(x);
            //Console.WriteLine(y);
            ////if the input = 1234 the output will be 1234
            ////if the input = 123wee (non-numeric) the output will be Unhandled Exception
            #endregion
            #region Q3
            //Console.WriteLine("Enter 2 Numbers To Get The Summation ");
            //float x = Convert.ToSingle (Console.ReadLine()!);
            //float y = float.Parse(Console.ReadLine()!);
            //Console.WriteLine(x + y);
            #endregion
            #region Q4
            //Console.WriteLine("Enter a String ");
            //string s = Console.ReadLine()!;
            //Console.WriteLine(s.Substring(2, 4));
            #endregion
            #region Q5
            //int x = 10;
            //int y = x;
            //Console.WriteLine(x); // x=10
            //Console.WriteLine(y); // y=10 
            //y = 20;
            ////after modifying
            //Console.WriteLine(x);// x=10
            //Console.WriteLine(y);// y=20
            #endregion
            #region Q6
            //Point p1 = new Point();
            //p1.x = 5;
            //Point p2 = p1;
            //Console.WriteLine(p1.x); 
            //Console.WriteLine(p2.x);
            //// p1 = p2 = 5
            //// p1 and p2 are references to the same object
            //p2.x = 10;
            //////after modifying
            //Console.WriteLine(p1.x);
            //Console.WriteLine(p2.x);
            //// p1 = p2 = 10
            //// p1 and p2 are references to the same object
            #endregion
            #region Q7
            //Console.WriteLine("Enter 2 Strings ");
            //string s1 = Console.ReadLine()!;
            //string s2 = Console.ReadLine()!;
            //string s = s1 + " " + s2;
            //Console.WriteLine(s);
            #endregion
            #region Q8
            // b) A value 1 will be assigned to d.
            #endregion
            #region Q9
            // d) 6 1
            #endregion
            #region 10
            // d) 7 7
            #endregion
            #endregion
            #region Assignment 3
            #region Q1
            //Console.WriteLine(" Enter A Number To Check if that number can be divided by 3 and 4 otherwise");
            //int x = int.Parse(Console.ReadLine()!);
            //if (x % 3 == 0 && x % 4 == 0)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");
            #endregion
            #region Q2
            //Console.WriteLine(" Enter A Number To Check if It Is Negative Or Positive ");
            //int x = int.Parse(Console.ReadLine()!);
            //if (x>0)
            //    Console.WriteLine("Positive");
            //else if (x<0)
            //    Console.WriteLine("Negative");
            //else 
            //    Console.WriteLine("Zero");
            #endregion
            #region Q3
            //Console.WriteLine(" Enter 3 Numbers To Get Max and Min ");
            //int x = int.Parse(Console.ReadLine()!);
            //int y = int.Parse(Console.ReadLine()!);
            //int z = int.Parse(Console.ReadLine()!);
            //int max = x;
            //int min = x;
            //if (y > x)
            //    max = y;
            //else if (y < x)
            //    min = y;
            //if (z>x)
            //    max = z;
            //else if (y < z)
            //    min = z;
            //Console.WriteLine(max);
            //Console.WriteLine(min);
            #endregion
            #region Q4
            //Console.WriteLine(" Enter A Number To Check if It Is Odd Or Even ");
            //int x = int.Parse(Console.ReadLine()!);
            //if (x % 2 == 1)
            //    Console.WriteLine("Odd");
            //else
            //    Console.WriteLine("Even");
            #endregion
            #region 5
            Console.WriteLine(" Enter A Number To Check if It Is vowel Or consonant ");
            char x = char.ToLower(char.Parse(Console.ReadLine()!));
            if (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u')
                Console.WriteLine("vowel");
            else
                Console.WriteLine("consonant");
            #endregion

                #endregion

        }
    }
}
