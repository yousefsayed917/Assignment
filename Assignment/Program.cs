using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            #region part 1
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
            #region Q5
            //Console.WriteLine(" Enter A Number To Check if It Is vowel Or consonant ");
            //char x = char.ToLower(char.Parse(Console.ReadLine()!));
            //if (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u')
            //    Console.WriteLine("vowel");
            //else
            //    Console.WriteLine("consonant");
            #endregion
            #endregion
            #region part 2
            #region Q6
            //bool flag;
            //int num;
            //do
            //{
            //    Console.WriteLine("enter a number to get the numbers between 1 and this number");
            //    flag = int.TryParse(Console.ReadLine()!, out num);
            //} while (!flag);
            //Console.Clear();
            //for (int i = 1; i <= num; i++)
            //{               
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Q7
            //bool flag;
            //int num;
            //do
            //{
            //    Console.WriteLine("enter a number to get multiplication table of this number");
            //    flag = int.TryParse(Console.ReadLine()!, out num);
            //} while (!flag);
            //Console.Clear();
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{num}*{i}={num * i}");
            //}
            #endregion
            #region Q8
            //bool flag;
            //int num;
            //do
            //{
            //    Console.WriteLine("enter a number to get the even numbers between 1 and this number");
            //    flag = int.TryParse(Console.ReadLine()!, out num);
            //} while (!flag);
            //Console.Clear();
            //for (int i = 1; i <= num; i++)
            //{
            //    if (i%2==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Q9
            //bool flag1,flag2;
            //int num, power, res=1;
            //do
            //{
            //    Console.WriteLine("enter a number");
            //    flag1 = int.TryParse(Console.ReadLine()!, out num);
            //} while (!flag1);
            //do
            //{
            //    Console.WriteLine("enter the power");
            //    flag2 = int.TryParse(Console.ReadLine()!, out power);
            //} while (!flag2);
            //for (int i = 1; i <= power; i++)
            //{
            //    res *= num;
            //}
            //Console.WriteLine($"{num}^{power}={res}");
            #endregion
            #region Q10
            //bool flag;
            //int num, sum = 0;
            //Console.WriteLine("enter 5 numbers to get the average and presentage");
            //for (int i = 0; i < 5; i++)
            //{
            //    do
            //    {
            //        flag = int.TryParse(Console.ReadLine()!, out num);
            //    } while (!flag);
            //    sum += num;
            //}
            //Console.Clear();
            //Console.WriteLine($"average = {sum / 5}");
            //Console.WriteLine($"percentage = {(sum*100) /500}");
            #endregion
            #region Q11
            //int num;
            //bool flag;
            //Console.WriteLine("the month number to get the number of days in that month");
            //do
            //{
            //    Console.WriteLine("enter a number");
            //    flag = int.TryParse(Console.ReadLine()!, out num);
            //} while (!flag);
            //if (num == 1 || num == 3 || num == 5 || num == 7 || num == 8 || num == 10 || num == 12)
            //    Console.WriteLine($"Days in Month{num}: 31");
            //else if (num == 2)
            //    Console.WriteLine($"Days in Month{num}: 29 or 28");
            //else if (num == 4 || num == 6 || num == 9 || num == 11)
            //    Console.WriteLine($"Days in Month{num}: 30");
            //else
            //    Console.WriteLine("this number is not month number");
            #endregion
            #region Q12
            //bool flag1,flag2, flag3=true;
            //char op;
            //int num1, num2;
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("enter the first number");
            //    flag1 = int.TryParse(Console.ReadLine()!, out num1);
            //    Console.WriteLine("enter the second number");
            //    flag2 = int.TryParse(Console.ReadLine()!, out num2);
            //} while (!flag1 && !flag2);
            //do
            //{
            //    Console.WriteLine("enter enter one operator of these operators{+ , - , * , / , %}");
            //    op = char.Parse(Console.ReadLine()!);
            //    if (op == '+' || op == '-' || op == '*' || op == '/' || op == '%')
            //        flag3 = true;
            //    else
            //        flag3 = false;
            //}while (!flag3);
            //switch (op)
            //{
            //    case '+':
            //        Console.WriteLine($"{num1}{op}{num2}={num1 + num2}");
            //        break;
            //    case '-':
            //        Console.WriteLine($"{num1}{op}{num2}={num1 - num2}");
            //        break;
            //    case '*':
            //        Console.WriteLine($"{num1}{op}{num2}={num1 * num2}");
            //        break;
            //    case '/':
            //        Console.WriteLine($"{num1}{op}{num2}={num1 / num2}");
            //        break;
            //    case '%':
            //        Console.WriteLine($"{num1}{op}{num2}={num1 % num2}");
            //        break;
            //}
            #endregion
            #region Q13
            //string s, rev = "";
            //Console.WriteLine("enter a string to reverse it");
            //s = Console.ReadLine()!;
            //for (int i = s.Length - 1; i >= 0; i--)
            //{
            //    rev += s[i];
            //}
            //Console.WriteLine(rev);
            #endregion
            #region Q14
            //bool flag;
            //int num, rev=0;
            //do
            //{
            //    Console.WriteLine("enter a number to reverse it ");
            //    flag = int.TryParse(Console.ReadLine()!, out num);
            //} while (!flag);
            //while (num > 0)
            //{
            //    int lastDigit = num % 10;
            //    rev = (rev * 10) + lastDigit;
            //    num /= 10;
            //}
            //Console.WriteLine(rev);
            #endregion
            #region Q15
            //bool flag1, flag2;
            //int StartingNumber , EndingNumber ;
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("enter the first number");
            //    flag1 = int.TryParse(Console.ReadLine()!, out StartingNumber);
            //    Console.WriteLine("enter the second number");
            //    flag2 = int.TryParse(Console.ReadLine()!, out EndingNumber);
            //} while (!flag1 && !flag2);
            //for(int i = StartingNumber; i <= EndingNumber; i++)
            //{
            //    int count = 0;
            //    for (int j = 1; j <=i ; j++)
            //    {
            //        if (i % j == 0)
            //            count++;
            //    }
            //    if (count == 2)
            //        Console.WriteLine(i);
            //}
            #endregion
            #region Q16
            //bool flag;
            //int DecimalNumber, BinaryNumber = 0, RversedNumber=0;
            //do
            //{
            //    Console.WriteLine("enter a decimal number to convert it to binary");
            //    flag = int.TryParse(Console.ReadLine()!, out DecimalNumber);
            //} while (!flag);
            //while (DecimalNumber > 0)
            //{
            //    int binary = DecimalNumber % 2;
            //    BinaryNumber = BinaryNumber * 10 + binary;
            //    DecimalNumber /= 2;
            //}
            //while (BinaryNumber > 0)
            //{
            //    int lastDigit = BinaryNumber % 10;
            //    RversedNumber = RversedNumber * 10 + lastDigit;
            //    BinaryNumber /= 10;
            //}
            //Console.WriteLine(RversedNumber);
            #endregion
            #region Q17
            //bool flag;
            //int x1,y1, x2, y2, x3, y3;
            //do
            //{
            //    Console.WriteLine("enter first point  ");
            //    flag = int.TryParse(Console.ReadLine()!, out x1);
            //    flag = int.TryParse(Console.ReadLine()!, out y1);
            //    Console.WriteLine("enter second point  ");
            //    flag = int.TryParse(Console.ReadLine()!, out x2);
            //    flag = int.TryParse(Console.ReadLine()!, out y2);
            //    Console.WriteLine("enter third point  ");
            //    flag = int.TryParse(Console.ReadLine()!, out x3);
            //    flag = int.TryParse(Console.ReadLine()!, out y3);
            //} while (!flag);
            //double area = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);
            //if (area == 0)
            //    Console.WriteLine("The points lie on a single straight line");
            //else
            //    Console.WriteLine("The points do not lie on a single straight line");
            #endregion
            #region Q19
            //bool flag;
            //int n;
            //do
            //{
            //    Console.Write("enter the size of the identity matrix ");
            //    flag = int.TryParse(Console.ReadLine()!, out n);
            //} while (!flag);
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Q20
            //int[] array = new int[5];
            //bool flag;
            //int sum = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"Enter element {i + 1}: ");
            //        flag = int.TryParse(Console.ReadLine()!, out array[i]);
            //    } while (!flag);
            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    sum += array[i];
            //}
            //Console.WriteLine(sum);
            #endregion
            #region Q22
            //int[] array = new int[5];
            //bool flag;
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < 5; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"Enter element {i + 1}: ");
            //        flag = int.TryParse(Console.ReadLine()!, out array[i]);
            //    } while (!flag);
            //}
            //int[] frequency = new int[5];
            //bool[] visited = new bool[5];]
            //for (int i = 0; i < 5; i++)
            //{
            //    if (visited[i] == true)
            //        continue;
            //    int count = 1;
            //    for (int j = i + 1; j < 5; j++)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            visited[j] = true;
            //            count++;
            //        }
            //    }
            //    frequency[i] = count;
            //}
            //Console.WriteLine("the frequency of each element in the array is");
            //for (int i = 0; i < 5; i++)
            //{
            //    if (visited[i] == false)
            //        Console.WriteLine($"Element {array[i]} => {frequency[i]} times");
            //}
            #endregion
            #region Q23
            //int[] array = new int[5];
            //bool flag;
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < 5; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"Enter element {i + 1}: ");
            //        flag = int.TryParse(Console.ReadLine()!, out array[i]);
            //    } while (!flag);
            //}
            //int MaxElement = array[0];
            //int MinElement = array[0];
            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (array[i] < MinElement)
            //        MinElement = array[i];

            //    if (array[i] > MaxElement)
            //        MaxElement = array[i];
            //}
            //Console.WriteLine($"Maximum element is {MaxElement}");
            //Console.WriteLine($"Minimum element is {MinElement}");
            #endregion
            #region Q24
            //int[] array = new int[5];
            //bool flag;
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < 5; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"Enter element {i + 1}: ");
            //        flag = int.TryParse(Console.ReadLine()!, out array[i]);
            //    } while (!flag);
            //}
            //int FirstMax = 0;
            //int SecondMax = int.MinValue;
            //for (int i = 0; i < array.Length; i++)
            //    {
            //    if (array[i] > FirstMax)
            //    {
            //        SecondMax = FirstMax;
            //        FirstMax = array[i];
            //    }
            //    else if (array[i] > SecondMax && array[i] != FirstMax)
            //    {
            //        SecondMax = array[i];
            //    }
            //}
            //Console.WriteLine($"the second largest element is {SecondMax}");
            #endregion
            #region Q27
            //bool flag;
            //int[,] array1 = new int[2, 3];
            //int[,] array2 = new int[2, 3];
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < array1.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter element in row {i + 1}: ");
            //    for (int j = 0; j < array1.GetLength(1); j++)
            //    {
            //        do
            //        {
            //            Console.WriteLine($"Enter element in column {j + 1}: ");
            //            flag = int.TryParse(Console.ReadLine()!, out array1[i, j]);
            //        } while (!flag);
            //    }
            //}
            //for (int i = 0; i < array1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array1.GetLength(1); j++)
            //    {
            //        array2[i, j] = array1[i, j];
            //    }
            //}
            //for (int i = 0; i < array2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array2.GetLength(1); j++)
            //    {
            //        Console.Write(array2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Q28
            //int[] array = new int[5];
            //bool flag;
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < 5; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"Enter element {i + 1}: ");
            //        flag = int.TryParse(Console.ReadLine()!, out array[i]);
            //    } while (!flag);
            //}
            //for (int i = array.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();
            #endregion
            #endregion
            #endregion

        }
    }
}
