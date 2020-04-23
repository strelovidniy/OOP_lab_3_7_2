using System;
using System.IO;

namespace OOP_lab_3_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fileInput = new StreamReader("input.txt");

            string word = fileInput.ReadLine();

            fileInput.Close();

            char[] newWord = word.ToCharArray();

            newWord[0] = word[3];
            newWord[3] = word[0];

            StreamWriter fileOutput = new StreamWriter("output.txt", false);

            fileOutput.WriteLine(newWord);

            fileOutput.Close();
        }
    }
}
