using System;
using System.Collections;
using System.Collections.Generic;

namespace problem_148A_InsomniaCure {
class Program {
  static void Main(string[] args) {
    var k = Convert.ToInt32(Console.ReadLine());
    var l = Convert.ToInt32(Console.ReadLine());
    var m = Convert.ToInt32(Console.ReadLine());
    var n = Convert.ToInt32(Console.ReadLine());
    var d = Convert.ToInt32(Console.ReadLine());

    var result = 0;

    // var dividersWDuplicate = new List<int>();
    // var dividers = new List<int>();

    // dividersWDuplicate.Add(k);
    // dividersWDuplicate.Add(l);

    // dividersWDuplicate.Add(m);

    // dividersWDuplicate.Add(n);

    // foreach (var i in dividersWDuplicate) {
    //   if (!dividers.Contains(i)) {
    //     dividers.Add(i);
    //   }
    // }

    // if (MinOfGivenNumbers(new int[]{k, l, m, n}) > d) {
    //   System.Console.WriteLine(0);
    //   return;
    // }

    if (k == 1 || m == 1 || l == 1 || n == 1) {
      System.Console.WriteLine(d);
      return;
    }

    for(int i = 1; i<=d;i++)
    {
        if(i%k==0)
        {
            result++;
        }
        else if(i%l==0)
        {
            result++;
        }
        else if(i%m==0)
        {
            result++;
        }
        else if(i%n==0)
        {
            result++;
        }
    }

    // if (dividers.Contains(2) && dividers.Contains(4)) {
    //   dividers.Remove(4);
    // }

    // if (dividers.Contains(2) && dividers.Contains(6)) {
    //   dividers.Remove(6);
    // }
    // if (dividers.Contains(2) && dividers.Contains(8)) {
    //   dividers.Remove(8);
    // }
    // if (dividers.Contains(2) && dividers.Contains(10)) {
    //   dividers.Remove(10);
    // }
    // if (dividers.Contains(3) && dividers.Contains(6)) {
    //   dividers.Remove(6);
    // }
    // if (dividers.Contains(3) && dividers.Contains(9)) {
    //   dividers.Remove(9);
    // }
    // if (dividers.Contains(4) && dividers.Contains(8)) {
    //   dividers.Remove(8);
    // }
    // if (dividers.Contains(5) && dividers.Contains(10)) {
    //   dividers.Remove(10);
    // }

    // //
    // int[] sorted = dividers.ToArray();
    // Array.Sort(sorted);
    // Array.Reverse(sorted);
    // //
    // var AStack = new Stack<int>();
    // foreach (var i in sorted) { AStack.Push(i); }
    // System.Console.WriteLine("length of stack:" + AStack.Count);

    // int temp4 = 0;
    // int temp3 = 0;
    // int temp2 = 0;
    // int temp1 = 0;
    // if (AStack.Count >= 1) {
    //   temp1 = AStack.Pop();
    //   // System.Console.WriteLine(temp);
    //   result += d / temp1;
    //   AStack.Push(temp1);
    //   System.Console.WriteLine("result after step1 : " + result);
    // }

    // if (AStack.Count >= 2) {
    //   temp1 = AStack.Pop();

    //   temp2 = AStack.Pop();
    //   result += d / temp2 - d / LCMOfTwoNumbers(temp1, temp2);
    //   AStack.Push(temp2);
    //   AStack.Push(temp1);
    //   System.Console.WriteLine("result after step 2 : " + result);
    // }

    // if (AStack.Count >= 3) {
    //   temp1 = AStack.Pop();
    //   temp2 = AStack.Pop();
    //   temp3 = AStack.Pop();
    //   result += d / temp3 - d / LCMOfTwoNumbers(temp3, temp1) -
    //             d / LCMOfTwoNumbers(temp3, temp2);
    //   AStack.Push(temp3);
    //   AStack.Push(temp2);
    //   AStack.Push(temp1);
    //   System.Console.WriteLine("result after step 3: " + result);
    // }

    // if (AStack.Count >= 4) {
    //   temp1 = AStack.Pop();
    //   temp2 = AStack.Pop();
    //   temp3 = AStack.Pop();
    //   temp4 = AStack.Pop();

    //   result += d / temp4 - d / LCMOfTwoNumbers(temp4, temp1) -
    //             d / LCMOfTwoNumbers(temp4, temp2) -
    //             d / LCMOfTwoNumbers(temp4, temp3);
    //   AStack.Push(temp4);
    //   AStack.Push(temp3);
    //   AStack.Push(temp2);
    //   AStack.Push(temp1);
    // }

    System.Console.WriteLine(result);
    // Array.Sort(newArr);
  }

 public
  static int GCDofTwoNumbers(int num1, int num2) {
    if (num1 == 0) return num2;
    if (num2 == 0) return num1;
    if (num1 == num2) return num1;

    if (num1 > num2)
      return GCDofTwoNumbers(num1 - num2, num2);
    else
      return GCDofTwoNumbers(num1, num2 - num1);
  }

 public
  static int MinOfGivenNumbers(int[] input) {
    int min = input[0];
    for (int i = 1; i < input.Length; i++) {
      if (min > input[i]) {
        min = input[i];
      }
    }
    return min;
  }
 public
  static int LCMOfTwoNumbers(int a, int b) {
    int result = 0;
    int multiplied = a * b;
    int GcmOfThoseNumbers = GCDofTwoNumbers(a, b);
    result = multiplied / GcmOfThoseNumbers;

    return result;
  }
}
}  // namespace problem_148A_InsomniaCure
