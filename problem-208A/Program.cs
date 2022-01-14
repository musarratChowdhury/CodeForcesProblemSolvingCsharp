using System;
using System.Text;

namespace problem_208A {
class Program {
  static void Main(string[] args) {
    var inputL = Console.ReadLine();

    var sb = new StringBuilder();

    var word = new StringBuilder();

    for (int i = 0; i < inputL.Length; i++) {
      char presentChar = inputL[i];

      if (i != inputL.Length - 1 && i != inputL.Length - 2 &&
          presentChar == 'W' && inputL[i + 1] == 'U' && inputL[i + 2] == 'B') {
        word.Append(" ");

        i += 2;

      } else {
        word.Append(inputL[i]);
      }
    }

    var arrwords = new StringBuilder();
    var stringWord = word.ToString().Trim().Split(' ');
    for (int w = 0; w < stringWord.Length; w++) {
      arrwords.Append(stringWord[w]);
      arrwords.Append(" ");
    }

    System.Console.WriteLine(arrwords.ToString().Trim());
  }
 }
}  // namespace problem_208A
